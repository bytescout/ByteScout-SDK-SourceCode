'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System.ComponentModel
Imports System.Drawing
Imports System.Media
Imports System.Reflection
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Bytescout.BarCodeReader
Imports TouchlessLib

Public Class MainForm

	' Scan delay, ms.
	Const SCAN_DELAY As Integer = 1500 ' scan barcodes every 1.5 sec

	' Touchless SDK library manager (to use it you should have TouchlessLib.dll referenced and WebCamLib.dll in the build output directory)
	Dim ReadOnly _touchlessLibManager As TouchlessMgr

	' Background thread for barcode scanning
	Dim ReadOnly _backgroundWorker As New BackgroundWorker
	' Synchronization event
	Dim ReadOnly _synchronizationEvent As New AutoResetEvent(False)

	' Form constructor
	Public Sub New()

		InitializeComponent()

		' Create Touchless library manager
		_touchlessLibManager = New TouchlessMgr()

		' Setup background worker
		_backgroundWorker.WorkerSupportsCancellation = True
		AddHandler _backgroundWorker.DoWork, AddressOf BackgroundWorker_DoWork
		AddHandler _backgroundWorker.RunWorkerCompleted, AddressOf BackgroundWorker_RunWorkerCompleted

	End Sub

	' On form loading 
	Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		' Fill devices combobox with available video cameras
		For Each camera As Camera In _touchlessLibManager.Cameras
			cmbCamera.Items.Add(camera)
		Next

		' Select the first available camera. See also cmbCamera_SelectedIndexChanged event handler.
		If _touchlessLibManager.Cameras.Count > 0 Then
			cmbCamera.SelectedItem = _touchlessLibManager.Cameras(0)
		Else
			MessageBox.Show("No video camera available. Please connect the camera.")
		End If

		' Populate barcode types combobox
		PopulateBarcodeTypesCombobox()
		' Select some default barcode type
		cmbBarcodeType.SelectedItem = "QRCode"

	End Sub

	Private Sub PopulateBarcodeTypesCombobox()

		cmbBarcodeType.Items.Clear()

		For Each propertyInfo As PropertyInfo In GetType(BarcodeTypeSelector).GetProperties()
			cmbBarcodeType.Items.Add(propertyInfo.Name)
		Next

	End Sub

	' On camera selected
	Private Sub cmbCamera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCamera.SelectedIndexChanged

		If _touchlessLibManager.CurrentCamera IsNot Nothing Then
			RemoveHandler _touchlessLibManager.CurrentCamera.OnImageCaptured, AddressOf CurrentCamera_OnImageCaptured
		End If

		If cmbCamera.SelectedIndex <> -1 Then

			Dim camera As Camera = _touchlessLibManager.Cameras(cmbCamera.SelectedIndex)

			If camera IsNot Nothing Then
				' Set camera output image dimensions
				camera.CaptureWidth = Integer.Parse(tbCameraWidth.Text)
				camera.CaptureHeight = Integer.Parse(tbCameraHeight.Text)

				AddHandler camera.OnImageCaptured, AddressOf CurrentCamera_OnImageCaptured

				' Select the camera
				_touchlessLibManager.CurrentCamera = camera

			End If

		End If

	End Sub

	Private Sub btnUpdateCameraImageDimensions_Click(sender As Object, e As EventArgs) Handles btnUpdateCameraImageDimensions.Click

		If _touchlessLibManager.CurrentCamera IsNot Nothing Then

			' Update camera's output image dimensions
			_touchlessLibManager.CurrentCamera.CaptureWidth = Integer.Parse(tbCameraWidth.Text)
			_touchlessLibManager.CurrentCamera.CaptureHeight = Integer.Parse(tbCameraHeight.Text)

		End If

	End Sub

	Private Sub StartDecoding()

		If cmbCamera.SelectedIndex = -1 Then
			Return
		End If

		' Clear the output text box
		rtbFoundBarcodes.Clear()

		' Check if we have camera selected
		If cmbCamera.SelectedIndex <> -1 Then

			' Start the decoding in the background thread
			Dim barcodeTypesToFind As BarcodeTypeSelector = GetBarcodeTypeFromCombobox()
			_backgroundWorker.RunWorkerAsync(barcodeTypesToFind)

			UpdateControls(True)
		Else
			MessageBox.Show("Please select the camera first!")
		End If

	End Sub

	Private Sub StopDecoding()

		_backgroundWorker.CancelAsync()

		' Wait until BackgroundWorker finished
		If _backgroundWorker.IsBusy Then
			_synchronizationEvent.WaitOne()
		End If

		UpdateControls(False)

	End Sub

	Private Sub UpdateControls(started As Boolean)

		If started Then
			btnStart.Enabled = False
			btnStop.Enabled = True
			cmbBarcodeType.Enabled = False
			cmbCamera.Enabled = False
			tbCameraHeight.Enabled = False
			tbCameraWidth.Enabled = False
			btnUpdateCameraImageDimensions.Enabled = False
			cbStopOnFirstBarcode.Enabled = False
			lblScanning.Visible = True
			lblScanning.Text = "Scanning..."
		Else
			btnStart.Enabled = True
			btnStop.Enabled = False
			cmbBarcodeType.Enabled = True
			cmbCamera.Enabled = True
			cbStopOnFirstBarcode.Enabled = True
			tbCameraHeight.Enabled = True
			tbCameraWidth.Enabled = True
			btnUpdateCameraImageDimensions.Enabled = True
			lblScanning.Visible = True
		End If

	End Sub

	Private Sub CurrentCamera_OnImageCaptured(sender As Object, e As CameraEventArgs)

		pictureBoxPreview.Image = e.Image

	End Sub

	Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

		StartDecoding()

	End Sub

	Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

		StopDecoding()

	End Sub

	' Background thread procedure used by BackgroundWorker
	Private Sub BackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs)

		Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
		Dim barcodeTypesToFind As BarcodeTypeSelector = CType(e.Argument, BarcodeTypeSelector)

		' Create and setup barcode reader instance
		Using reader As New Reader

			reader.RegistrationName = "demo"
			reader.RegistrationKey = "demo"

			reader.BarcodeTypesToFind = barcodeTypesToFind

			' Work while not canceled
			While True

				' Check cancellation
				If worker.CancellationPending Then
					e.Cancel = True
					_synchronizationEvent.Set()
					Return
				End If

				' Get image from camera by invoking method from UI thread
				Dim bitmap As Bitmap = CType(Invoke(New GetCameraImageDelegate(AddressOf GetCameraImage)), Bitmap)
				If bitmap Is Nothing Then
					e.Result = nothing
					return
				End If

				' -----------------------------------------------------------------------
				' NOTE: We can read barcodes from specific page to increase performance .
				' For sample please refer to "Decoding barcodes from PDF by pages" program.
				' ----------------------------------------------------------------------- 

				' Search the image for barcodes
				Dim result As FoundBarcode() = reader.ReadFrom(bitmap)

				' Update UI asynchronously
				BeginInvoke(New Action(Of FoundBarcode())(AddressOf UpdateStatus), New Object() { result })

				' Pause
				Thread.Sleep(SCAN_DELAY)

			End While

		End Using

	End Sub

	Delegate Function GetCameraImageDelegate() As Bitmap

	Private Function GetCameraImage() As Bitmap

		If Not IsDisposed and Not Disposing and _touchlessLibManager.CurrentCamera IsNot Nothing Then
			return _touchlessLibManager.CurrentCamera.GetCurrentImage()	
		End If

		Return Nothing

	End Function

	' Update UI with found barcodes information
	Private Sub UpdateStatus(foundBarcodes As FoundBarcode())

		If foundBarcodes IsNot Nothing And foundBarcodes.Length > 0 Then

			' Play sound if we found any barcode
			SystemSounds.Beep.Play()

			Dim stringBuilder As StringBuilder = New StringBuilder()

			stringBuilder.AppendFormat("Time: {0:HH:mm:ss:tt}", DateTime.Now)
			stringBuilder.AppendLine()

			' Display found barcodes in the output text box
			For Each barcode As FoundBarcode In foundBarcodes
				stringBuilder.AppendFormat("Found barcode: {0} {1}", barcode.Type, barcode.Value)
				stringBuilder.AppendLine()
			Next

			rtbFoundBarcodes.Text = stringBuilder.ToString()

			' Update status text with number of found barcodes
			lblFoundBarcodes.Text = String.Format("Found {0} barcodes:", foundBarcodes.Length)

		End If

		' Make "Scanning..." label flicker.
		lblScanning.Visible = Not lblScanning.Visible
		lblScanning.Refresh()

		' Check if we need to stop on first barcode found
		If cbStopOnFirstBarcode.Checked And foundBarcodes IsNot Nothing And foundBarcodes.Length > 0 Then
			StopDecoding()
		End If

	End Sub

	' Background thread is finished
	Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)

		' Update UI asynchronously
		BeginInvoke(New Action(Of RunWorkerCompletedEventArgs)(AddressOf OnBackgroundWorkerFinished), New Object() {e})

	End Sub

	Private Sub OnBackgroundWorkerFinished(completedEventArgs As RunWorkerCompletedEventArgs)

		If completedEventArgs.Cancelled Then
			lblScanning.Text = "Stopped"
		ElseIf completedEventArgs.Error IsNot Nothing Then
			lblScanning.Text = "Error: " + completedEventArgs.Error.Message
		Else
			lblScanning.Text = "Done!"
		End If

		UpdateControls(False)

	End Sub

	Private Function GetBarcodeTypeFromCombobox() As BarcodeTypeSelector

		Dim result As BarcodeTypeSelector = New BarcodeTypeSelector()

		Dim selectedBarcodeTypeName As String = CType(cmbBarcodeType.SelectedItem, String)

		Dim propertyInfo As PropertyInfo = GetType(BarcodeTypeSelector).GetProperty(selectedBarcodeTypeName)
		propertyInfo.SetValue(result, True, Nothing)

		Return result

	End Function

	Protected Overrides Sub OnClosing(e As CancelEventArgs)
		
		StopDecoding()
		
		_touchlessLibManager.Dispose()
		
		MyBase.OnClosing(e)

	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

		DialogResult = DialogResult.OK
		Close()

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Try
			if _touchlessLibManager.CurrentCamera IsNot Nothing
				_touchlessLibManager.CurrentCamera.ShowPropertiesDialog(Handle)
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		
	End Sub
End Class
