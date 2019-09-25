## How to read barcode from live video cam with barcode reader sdk in VB.NET with ByteScout Barcode Suite

### Learn to read barcode from live video cam with barcode reader sdk in VB.NET

This sample source code below will display you how to read barcode from live video cam with barcode reader sdk in VB.NET. What is ByteScout Barcode Suite? It is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK). It can help you to read barcode from live video cam with barcode reader sdk in your VB.NET application.

 These VB.NET code samples for VB.NET guide developers to speed up coding of the application when using ByteScout Barcode Suite. IF you want to implement the functionality, just copy and paste this code for VB.NET below into your code editor with your app, compile and run your application. Use of ByteScout Barcode Suite in VB.NET is also described in the documentation included along with the product.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****MainForm.Designer.vb:**
    
```
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.btnUpdateCameraImageDimensions = New System.Windows.Forms.Button()
		Me.cbStopOnFirstBarcode = New System.Windows.Forms.CheckBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.tbCameraHeight = New System.Windows.Forms.TextBox()
		Me.tbCameraWidth = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.lblScanning = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.cmbBarcodeType = New System.Windows.Forms.ComboBox()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.cmbCamera = New System.Windows.Forms.ComboBox()
		Me.rtbFoundBarcodes = New System.Windows.Forms.RichTextBox()
		Me.btnStop = New System.Windows.Forms.Button()
		Me.btnStart = New System.Windows.Forms.Button()
		Me.pictureBoxPreview = New System.Windows.Forms.PictureBox()
		Me.lblFoundBarcodes = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.pictureBoxPreview,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'btnUpdateCameraImageDimensions
		'
		Me.btnUpdateCameraImageDimensions.Location = New System.Drawing.Point(265, 64)
		Me.btnUpdateCameraImageDimensions.Name = "btnUpdateCameraImageDimensions"
		Me.btnUpdateCameraImageDimensions.Size = New System.Drawing.Size(71, 24)
		Me.btnUpdateCameraImageDimensions.TabIndex = 4
		Me.btnUpdateCameraImageDimensions.Text = "Update"
		Me.btnUpdateCameraImageDimensions.UseVisualStyleBackColor = true
		'
		'cbStopOnFirstBarcode
		'
		Me.cbStopOnFirstBarcode.AutoSize = true
		Me.cbStopOnFirstBarcode.Location = New System.Drawing.Point(14, 94)
		Me.cbStopOnFirstBarcode.Name = "cbStopOnFirstBarcode"
		Me.cbStopOnFirstBarcode.Size = New System.Drawing.Size(154, 17)
		Me.cbStopOnFirstBarcode.TabIndex = 5
		Me.cbStopOnFirstBarcode.Text = "Stop on first barcode found"
		Me.cbStopOnFirstBarcode.UseVisualStyleBackColor = true
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Location = New System.Drawing.Point(206, 69)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(12, 13)
		Me.label4.TabIndex = 46
		Me.label4.Text = "x"
		'
		'tbCameraHeight
		'
		Me.tbCameraHeight.Location = New System.Drawing.Point(224, 66)
		Me.tbCameraHeight.Name = "tbCameraHeight"
		Me.tbCameraHeight.Size = New System.Drawing.Size(35, 20)
		Me.tbCameraHeight.TabIndex = 3
		Me.tbCameraHeight.Text = "480"
		'
		'tbCameraWidth
		'
		Me.tbCameraWidth.Location = New System.Drawing.Point(165, 66)
		Me.tbCameraWidth.Name = "tbCameraWidth"
		Me.tbCameraWidth.Size = New System.Drawing.Size(35, 20)
		Me.tbCameraWidth.TabIndex = 2
		Me.tbCameraWidth.Text = "640"
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(11, 69)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(132, 13)
		Me.label2.TabIndex = 45
		Me.label2.Text = "Camera Image Dimensions"
		'
		'lblScanning
		'
		Me.lblScanning.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.lblScanning.AutoSize = true
		Me.lblScanning.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.lblScanning.Location = New System.Drawing.Point(582, 600)
		Me.lblScanning.Name = "lblScanning"
		Me.lblScanning.Size = New System.Drawing.Size(67, 13)
		Me.lblScanning.TabIndex = 44
		Me.lblScanning.Text = "Scanning..."
		Me.lblScanning.Visible = false
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label3.Location = New System.Drawing.Point(11, 15)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(131, 13)
		Me.label3.TabIndex = 43
		Me.label3.Text = "Barcode Type To Scan"
		'
		'cmbBarcodeType
		'
		Me.cmbBarcodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbBarcodeType.FormattingEnabled = true
		Me.cmbBarcodeType.Location = New System.Drawing.Point(165, 12)
		Me.cmbBarcodeType.Name = "cmbBarcodeType"
		Me.cmbBarcodeType.Size = New System.Drawing.Size(245, 21)
		Me.cmbBarcodeType.Sorted = true
		Me.cmbBarcodeType.TabIndex = 0
		'
		'btnExit
		'
		Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.btnExit.Location = New System.Drawing.Point(564, 690)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(90, 26)
		Me.btnExit.TabIndex = 9
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = true
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Location = New System.Drawing.Point(11, 42)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(80, 13)
		Me.label1.TabIndex = 42
		Me.label1.Text = "Camera Device"
		'
		'cmbCamera
		'
		Me.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbCamera.FormattingEnabled = true
		Me.cmbCamera.Location = New System.Drawing.Point(165, 39)
		Me.cmbCamera.Name = "cmbCamera"
		Me.cmbCamera.Size = New System.Drawing.Size(245, 21)
		Me.cmbCamera.TabIndex = 1
		'
		'rtbFoundBarcodes
		'
		Me.rtbFoundBarcodes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.rtbFoundBarcodes.Location = New System.Drawing.Point(14, 616)
		Me.rtbFoundBarcodes.Name = "rtbFoundBarcodes"
		Me.rtbFoundBarcodes.Size = New System.Drawing.Size(640, 68)
		Me.rtbFoundBarcodes.TabIndex = 6
		Me.rtbFoundBarcodes.Text = ""
		'
		'btnStop
		'
		Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.btnStop.Enabled = false
		Me.btnStop.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.btnStop.Location = New System.Drawing.Point(100, 690)
		Me.btnStop.Name = "btnStop"
		Me.btnStop.Size = New System.Drawing.Size(80, 26)
		Me.btnStop.TabIndex = 8
		Me.btnStop.Text = "Stop"
		Me.btnStop.UseVisualStyleBackColor = true
		'
		'btnStart
		'
		Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.btnStart.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.btnStart.Location = New System.Drawing.Point(14, 690)
		Me.btnStart.Name = "btnStart"
		Me.btnStart.Size = New System.Drawing.Size(80, 26)
		Me.btnStart.TabIndex = 7
		Me.btnStart.Text = "Start"
		Me.btnStart.UseVisualStyleBackColor = true
		'
		'pictureBoxPreview
		'
		Me.pictureBoxPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.pictureBoxPreview.BackColor = System.Drawing.Color.White
		Me.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pictureBoxPreview.Location = New System.Drawing.Point(14, 117)
		Me.pictureBoxPreview.Name = "pictureBoxPreview"
		Me.pictureBoxPreview.Size = New System.Drawing.Size(640, 480)
		Me.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.pictureBoxPreview.TabIndex = 40
		Me.pictureBoxPreview.TabStop = false
		'
		'lblFoundBarcodes
		'
		Me.lblFoundBarcodes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.lblFoundBarcodes.AutoSize = true
		Me.lblFoundBarcodes.Location = New System.Drawing.Point(14, 600)
		Me.lblFoundBarcodes.Name = "lblFoundBarcodes"
		Me.lblFoundBarcodes.Size = New System.Drawing.Size(93, 13)
		Me.lblFoundBarcodes.TabIndex = 38
		Me.lblFoundBarcodes.Text = "Found 0 barcodes"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(416, 38)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(129, 23)
		Me.Button1.TabIndex = 47
		Me.Button1.Text = "Camera Properties"
		Me.Button1.UseVisualStyleBackColor = true
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(664, 728)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.btnUpdateCameraImageDimensions)
		Me.Controls.Add(Me.cbStopOnFirstBarcode)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.tbCameraHeight)
		Me.Controls.Add(Me.tbCameraWidth)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.lblScanning)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.cmbBarcodeType)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.cmbCamera)
		Me.Controls.Add(Me.rtbFoundBarcodes)
		Me.Controls.Add(Me.btnStop)
		Me.Controls.Add(Me.btnStart)
		Me.Controls.Add(Me.pictureBoxPreview)
		Me.Controls.Add(Me.lblFoundBarcodes)
		Me.Name = "MainForm"
		Me.ShowIcon = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Barcode Scanner"
		CType(Me.pictureBoxPreview,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Private WithEvents btnUpdateCameraImageDimensions As Windows.Forms.Button
	Private WithEvents cbStopOnFirstBarcode As Windows.Forms.CheckBox
	Private WithEvents label4 As Windows.Forms.Label
	Private WithEvents tbCameraHeight As Windows.Forms.TextBox
	Private WithEvents tbCameraWidth As Windows.Forms.TextBox
	Private WithEvents label2 As Windows.Forms.Label
	Private WithEvents lblScanning As Windows.Forms.Label
	Private WithEvents label3 As Windows.Forms.Label
	Private WithEvents cmbBarcodeType As Windows.Forms.ComboBox
	Private WithEvents btnExit As Windows.Forms.Button
	Private WithEvents label1 As Windows.Forms.Label
	Private WithEvents cmbCamera As Windows.Forms.ComboBox
	Private WithEvents rtbFoundBarcodes As Windows.Forms.RichTextBox
	Private WithEvents btnStop As Windows.Forms.Button
	Private WithEvents btnStart As Windows.Forms.Button
	Private WithEvents pictureBoxPreview As Windows.Forms.PictureBox
	Private WithEvents lblFoundBarcodes As Windows.Forms.Label
	Friend WithEvents Button1 As Windows.Forms.Button
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****MainForm.vb:**
    
```
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
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports System.Collections.Generic
Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	<MTAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)

		Dim dlg As New MainForm()
		dlg.ShowDialog()
	End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadFromVideoCamera.VS2005.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{2709B33C-231F-4007-9FCA-A5F1A93F5F8A}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>ReadFromVideoCamera</RootNamespace>
    <AssemblyName>ReadFromVideoCamera</AssemblyName>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <OldToolsVersion>3.5</OldToolsVersion>
    <PublishUrl>publish\</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Disk</InstallFrom>
    <UpdateEnabled>false</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <ApplicationRevision>0</ApplicationRevision>
    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|x86'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|x86'">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup>
    <StartupObject>ReadFromVideoCamera.Program</StartupObject>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net2.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="TouchlessLib, Version=1.0.0.0, Culture=neutral, processorArchitecture=x86">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Compile Include="MainForm.Designer.vb">
      <DependentUpon>MainForm.vb</DependentUpon>
    </Compile>
    <Compile Include="MainForm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Content Include="TouchlessLib.dll">
    </Content>
    <Content Include="WebCamLib.dll">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows Installer 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="MainForm.resx">
      <DependentUpon>MainForm.vb</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadFromVideoCamera.VS2008.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>9.0.30729</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{2709B33C-231F-4007-9FCA-A5F1A93F5F8A}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>ReadFromVideoCamera</RootNamespace>
    <AssemblyName>ReadFromVideoCamera</AssemblyName>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
    <OldToolsVersion>3.5</OldToolsVersion>
    <PublishUrl>publish\</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Disk</InstallFrom>
    <UpdateEnabled>false</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <ApplicationRevision>0</ApplicationRevision>
    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|x86'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|x86'">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup>
    <StartupObject>ReadFromVideoCamera.Program</StartupObject>
  </PropertyGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net2.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="TouchlessLib, Version=1.0.0.0, Culture=neutral, processorArchitecture=x86">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Compile Include="MainForm.Designer.vb">
      <DependentUpon>MainForm.vb</DependentUpon>
    </Compile>
    <Compile Include="MainForm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Content Include="TouchlessLib.dll">
    </Content>
    <Content Include="WebCamLib.dll">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows Installer 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="MainForm.resx">
      <DependentUpon>MainForm.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadFromVideoCamera.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{2709B33C-231F-4007-9FCA-A5F1A93F5F8A}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>ReadFromVideoCamera</RootNamespace>
    <AssemblyName>ReadFromVideoCamera</AssemblyName>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <OldToolsVersion>3.5</OldToolsVersion>
    <PublishUrl>publish\</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Disk</InstallFrom>
    <UpdateEnabled>false</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <ApplicationRevision>0</ApplicationRevision>
    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|x86'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|x86'">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup>
    <StartupObject>ReadFromVideoCamera.Program</StartupObject>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="TouchlessLib, Version=1.0.0.0, Culture=neutral, processorArchitecture=x86">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Compile Include="MainForm.Designer.vb">
      <DependentUpon>MainForm.vb</DependentUpon>
    </Compile>
    <Compile Include="MainForm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Content Include="TouchlessLib.dll">
    </Content>
    <Content Include="WebCamLib.dll">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows Installer 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="MainForm.resx">
      <DependentUpon>MainForm.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadFromVideoCamera.VS2012.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{2709B33C-231F-4007-9FCA-A5F1A93F5F8A}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>ReadFromVideoCamera</RootNamespace>
    <AssemblyName>ReadFromVideoCamera</AssemblyName>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <OldToolsVersion>3.5</OldToolsVersion>
    <PublishUrl>publish\</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Disk</InstallFrom>
    <UpdateEnabled>false</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <ApplicationRevision>0</ApplicationRevision>
    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|x86'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|x86'">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup>
    <StartupObject>ReadFromVideoCamera.Program</StartupObject>
  </PropertyGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="TouchlessLib, Version=1.0.0.0, Culture=neutral, processorArchitecture=x86">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Compile Include="MainForm.Designer.vb">
      <DependentUpon>MainForm.vb</DependentUpon>
    </Compile>
    <Compile Include="MainForm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Content Include="TouchlessLib.dll">
    </Content>
    <Content Include="WebCamLib.dll">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows Installer 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="MainForm.resx">
      <DependentUpon>MainForm.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadFromVideoCamera.VS2013.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{2709B33C-231F-4007-9FCA-A5F1A93F5F8A}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>ReadFromVideoCamera</RootNamespace>
    <AssemblyName>ReadFromVideoCamera</AssemblyName>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <OldToolsVersion>3.5</OldToolsVersion>
    <PublishUrl>publish\</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Disk</InstallFrom>
    <UpdateEnabled>false</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <ApplicationRevision>0</ApplicationRevision>
    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|x86'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|x86'">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup>
    <StartupObject>ReadFromVideoCamera.Program</StartupObject>
  </PropertyGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="TouchlessLib, Version=1.0.0.0, Culture=neutral, processorArchitecture=x86">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Compile Include="MainForm.Designer.vb">
      <DependentUpon>MainForm.vb</DependentUpon>
    </Compile>
    <Compile Include="MainForm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Content Include="TouchlessLib.dll">
    </Content>
    <Content Include="WebCamLib.dll">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows Installer 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="MainForm.resx">
      <DependentUpon>MainForm.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadFromVideoCamera.VS2015.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="14.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{2709B33C-231F-4007-9FCA-A5F1A93F5F8A}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>ReadFromVideoCamera</RootNamespace>
    <AssemblyName>ReadFromVideoCamera</AssemblyName>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <OldToolsVersion>3.5</OldToolsVersion>
    <PublishUrl>publish\</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Disk</InstallFrom>
    <UpdateEnabled>false</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <ApplicationRevision>0</ApplicationRevision>
    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|x86'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
    <NoWarn>42353,42354,42355</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|x86'">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
    <NoWarn>42353,42354,42355</NoWarn>
  </PropertyGroup>
  <PropertyGroup>
    <StartupObject>ReadFromVideoCamera.Program</StartupObject>
  </PropertyGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="TouchlessLib, Version=1.0.0.0, Culture=neutral, processorArchitecture=x86">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Compile Include="MainForm.Designer.vb">
      <DependentUpon>MainForm.vb</DependentUpon>
    </Compile>
    <Compile Include="MainForm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Content Include="TouchlessLib.dll">
    </Content>
    <Content Include="WebCamLib.dll">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows Installer 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="MainForm.resx">
      <DependentUpon>MainForm.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
</Project>
```

<!-- code block end -->