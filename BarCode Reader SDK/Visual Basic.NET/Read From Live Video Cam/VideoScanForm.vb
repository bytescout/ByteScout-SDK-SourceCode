'*******************************************************************
'       ByteScout BarCode Reader SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Threading
Imports Bytescout.BarCodeReader
Imports TouchlessLib


Partial Public Class VideoScanForm
    Inherits Form
    ''' <summary>
    ''' Touchless lib manager object (to use it you should have TouchlessLib.dll and WebCamLib.dll)
    ''' </summary>
    Private MANAGER As TouchlessMgr

    ''' <summary>
    ''' USED IN POPUP MODE ONLY (see ShowScanPopup() method)
    ''' Close or not on the first barcode found
    ''' (results are saved in m_foundBarcodes
    ''' </summary>
    Public CloseOnFirstBarcodeFound As Boolean = False

    ''' <summary>
    ''' Background worker
    ''' </summary>
    Private bw As New BackgroundWorker()

    ''' <summary>
    ''' Delay to scan every (mseconds), default to scan every 1500 mseconds
    ''' </summary>
    Const SCAN_DELAY As Integer = 1500 ' 1.5 sec

    ''' <summary>
    ''' Default barcode type to scan.
    ''' </summary>
    Private m_barcodeTypeToScan As New BarcodeTypeSelector()

    ''' <summary>
    ''' Array with all latest barcodes from the last scanning session.
    ''' </summary>
    Public m_foundBarcodes As FoundBarcode() = Nothing

    ''' <summary>
    ''' Internal varaible to indicate working status.
    ''' </summary>
    Public Shared STATUS As Boolean = True

    ''' <summary>
    ''' Creates the form.
    ''' </summary>
    Public Sub New()
        InitializeComponent()

        ' enable calling UI element 'ListBox' inside a thread
        ListBox.CheckForIllegalCrossThreadCalls = False
        lblScanning.Visible = False

        bw.WorkerSupportsCancellation = True
    End Sub

    ''' <summary>
    ''' Finds barcodes from bitmap object
    ''' </summary>
    ''' <param name="img">input bitmap</param>
    Private Function findBarcodes(ByVal img As Bitmap) As FoundBarcode()
        Dim reader As New Reader()

        Try
            reader.RegistrationName = "demo"
            reader.RegistrationKey = "demo"

            reader.BarcodeTypesToFind = GetBarcodeTypeToFindFromCombobox()

            'reader.MaxNumberOfBarcodesPerPage = 1;
            Dim result As FoundBarcode() = reader.ReadFrom(img)

            Dim timeNow As String = String.Format("{0:HH:mm:ss:tt}", DateTime.Now)

            If result IsNot Nothing AndAlso result.Length > 0 Then
                textAreaBarcodes.SelectionStart = 0
                textAreaBarcodes.SelectionLength = 0
                textAreaBarcodes.SelectedText = "" & Chr(10) & "Time: " & timeNow & "" & Chr(10) & ""

                ' insert barcodes into the text area output
                For Each barcode As FoundBarcode In result
                    ' make a sound that we found the barcode (not working on x64 due to Microsoft changed it)
                    Console.Beep()
                    ' form the string with barcode value
                    Dim barcodeValue As String = [String].Format("Found: {0} {1}" & "" & Chr(13) & "" & Chr(10) & "", barcode.Type, barcode.Value)
                    ' add barcode to the text area output
                    textAreaBarcodes.SelectedText = barcodeValue & "" & Chr(10) & ""
                    ' update status text with number of barcodes
                    lblFoundBarcodes.Text = [String].Format("Found {0} barcodes:", result.Length)
                Next
            End If
            ' make flickering for "Scanning..." label
            lblScanning.Visible = Not lblScanning.Visible
            lblScanning.Update()

            ' return result with barcodes
            Return result
        Finally
            reader.Dispose()
        End Try
    End Function

    Private Sub InitCamera()
        Try
            ' create touchless lib manager to work with video camera
            MANAGER = New TouchlessMgr()

            ' iterate through available video camera devices
            For Each item As Camera In MANAGER.Cameras
                ' add to the list of available camera devices
                cbCamera.Items.Add(item)
            Next

            ' select first available camera
            cbCamera.SelectedItem = MANAGER.Cameras(0)

            ' setting default image dimensions, see also camera selection event
            MANAGER.Cameras(0).CaptureWidth = Integer.Parse(tbCameraWidth.Text)
            MANAGER.Cameras(0).CaptureHeight = Integer.Parse(tbCameraHeight.Text)

        Catch ex As Exception
            MessageBox.Show("No video camera available. Please connect the camera" & "" & Chr(10) & "" & ex.Message)
        End Try


    End Sub

    Public Sub StartDecoding()

        'UpdateCameraSelection();

        ' clear the rich text box output
        textAreaBarcodes.Clear()
        ' clean list of barcodes
        m_foundBarcodes = Nothing

        ' check if we have camera selected
        If cbCamera.SelectedIndex <> -1 Then

            ' set working status
            STATUS = True

            ' create new thread with image processing function
            AddHandler bw.DoWork, New DoWorkEventHandler(AddressOf doBarcodeDecoding)
            AddHandler bw.RunWorkerCompleted, New RunWorkerCompletedEventHandler(AddressOf bw_RunWorkerCompleted)


            ' update ui buttons
            btnStart.Enabled = False
            btnStop.Enabled = True
            cbBarCodeType.Enabled = False
            cbCamera.Enabled = False
            lblScanning.Visible = True
            tbCameraHeight.Enabled = False
            tbCameraWidth.Enabled = False

            lblScanning.Text = "Scanning..."

            ' finally start the decoding thread
            bw.RunWorkerAsync(CloseOnFirstBarcodeFound)
        Else
            MessageBox.Show("Please select the camera first !")
        End If
    End Sub


    ''' <summary>
    ''' Update picture box with the latest frame from video camera
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CurrentCamera_OnImageCaptured(ByVal sender As Object, ByVal e As CameraEventArgs)
        ' you can change image dimensions if needed
        'MANAGER.CurrentCamera.CaptureWidth = 320;
        'MANAGER.CurrentCamera.CaptureHeight = 240;

        If MANAGER IsNot Nothing Then
            pictureVideoPreview.Image = MANAGER.CurrentCamera.GetCurrentImage()
        End If
    End Sub


    ' http://stackoverflow.com/questions/1195064/fastest-image-resizing-in-net
    Private Function ResizeImage(ByVal img As Image, ByVal Width As Integer, ByVal Height As Integer) As Image

        ResizeImage = New Bitmap(Width, Height)

        Using g As Graphics = Graphics.FromImage(ResizeImage)
            g.DrawImage(img, 0, 0, Width, Height)
        End Using

        Return ResizeImage
    End Function

    ''' <summary>
    ''' Start the scanning process
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStart.Click
        StartDecoding()
    End Sub

    ''' <summary>
    ''' Stops scanning process
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStop.Click
        StopDecoding()
    End Sub

    Private Sub StopDecoding()
        bw.CancelAsync()

        ' update ui elements
        'lblScanning.Visible = false;

        ' change working status
        STATUS = False

        btnStart.Enabled = True
        btnStop.Enabled = False

        cbBarCodeType.Enabled = True
        cbCamera.Enabled = True

        tbCameraHeight.Enabled = True
        tbCameraWidth.Enabled = True

        If CloseOnFirstBarcodeFound AndAlso m_foundBarcodes IsNot Nothing AndAlso m_foundBarcodes.Length > 0 Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    ''' <summary>
    ''' Function to read barcodes from image (used by new created Thread object)
    ''' </summary>
    Public Sub doBarcodeDecoding(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = TryCast(sender, BackgroundWorker)
        Dim closeOnFirstBarcode As Boolean = CBool(e.Argument)

        While True
            If (worker.CancellationPending = True) Then
                e.Cancel = True
                Return
            Else
                ' work while user has not changed the status to false (i.e. false meanse user canceled the scan)
                ' get current frame bitmap from camera using Touchless lib
                Dim bitmap As Bitmap = MANAGER.CurrentCamera.GetCurrentImage

                ' search for bar codes
                Dim result As FoundBarcode() = Nothing

                If bitmap IsNot Nothing Then
                    result = findBarcodes(bitmap)
                End If

                ' check if we need to stop on first barcode found
                If closeOnFirstBarcode AndAlso result IsNot Nothing AndAlso result.Length > 0 Then
                    e.Result = result
                    ' end processing
                    Return
                End If

                ' wait for a little to lower the CPU load
                Thread.Sleep(SCAN_DELAY)
            End If
        End While
    End Sub

    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        ' clear last results
        m_foundBarcodes = Nothing

        ' if cancaled
        If (e.Cancelled = True) Then
            lblScanning.Visible = True
            Me.lblScanning.Text = "Canceled"
            ' if some error
        ElseIf Not (e.[Error] Is Nothing) Then
            lblScanning.Visible = True
            Me.lblScanning.Text = "Error: " + e.[Error].Message
        Else

            lblScanning.Visible = True
            Me.lblScanning.Text = "Done!"
            m_foundBarcodes = DirectCast(e.Result, FoundBarcode())
        End If

        StopDecoding()
    End Sub


    ''' <summary>
    ''' Update camera according to use selection of camera from list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbCamera_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbCamera.SelectedIndexChanged
        UpdateCameraSelection()
    End Sub

    Private Sub UpdateCameraSelection()
        If cbCamera.Items.Count > 0 AndAlso cbCamera.SelectedIndex > -1 Then
            If MANAGER.CurrentCamera IsNot Nothing Then
                RemoveHandler MANAGER.CurrentCamera.OnImageCaptured, AddressOf CurrentCamera_OnImageCaptured
            End If

            Dim CurrentCamera As Camera = MANAGER.Cameras(cbCamera.SelectedIndex)

            If CurrentCamera IsNot Nothing Then
                ' setting camera output image dimensions

                CurrentCamera.CaptureWidth = Integer.Parse(tbCameraWidth.Text)
                CurrentCamera.CaptureHeight = Integer.Parse(tbCameraHeight.Text)

                AddHandler CurrentCamera.OnImageCaptured, New EventHandler(Of CameraEventArgs)(AddressOf CurrentCamera_OnImageCaptured)

                MANAGER.CurrentCamera = CurrentCamera
            End If
        End If

    End Sub

    ''' <summary>
    ''' Updates current symbology filter selection to scan according to the selection in the combobox
    ''' </summary>
    ''' <returns></returns>
    Private Function GetBarcodeTypeToFindFromCombobox() As BarcodeTypeSelector
        Dim selectedItemText As String = cbBarCodeType.Text

        If String.IsNullOrEmpty(selectedItemText) Then
            Throw New Exception("empty barcode type selection!")
        End If

        ' iterate through properties of barcode selector 
        ' and enable the selected property

        ' reset all barcodes selections
        m_barcodeTypeToScan.Reset()

        ' iterate through m_barcodeTypeToScan bool properties 
        ' checking if we should check this barcode type value
        For Each propinfo As System.Reflection.PropertyInfo In m_barcodeTypeToScan.[GetType]().GetProperties()
            ' continue if can not write to propery
            If Not propinfo.CanWrite Then
                Continue For
            End If

            Dim name As String = propinfo.Name
            If name = selectedItemText Then
                propinfo.SetValue(m_barcodeTypeToScan, True, Nothing)
            End If
        Next

        Return m_barcodeTypeToScan
    End Function

    Protected Sub PopulateBarcodeTypesCombobox()
        cbBarCodeType.Items.Clear()
        For Each propinfo As System.Reflection.PropertyInfo In m_barcodeTypeToScan.[GetType]().GetProperties()
            ' continue if can not write to propery
            If Not propinfo.CanWrite Then
                Continue For
            End If

            Dim name As String = propinfo.Name
            cbBarCodeType.Items.Add(name)
        Next

        cbBarCodeType.Sorted = True

        ' select first item in barcode types combobox (first is FindAll )
        cbBarCodeType.SelectedItem = cbBarCodeType.Items(0)


    End Sub

    Private Sub Deinitialize()
        ' cancel decoding thread
        bw.CancelAsync()
        ' deinit camera
        DeinitCamera()
        ' mark as closed
        IsClosed = True

    End Sub

    Private Sub DeinitCamera()
        If MANAGER IsNot Nothing Then
            If MANAGER.CurrentCamera IsNot Nothing Then
                RemoveHandler MANAGER.CurrentCamera.OnImageCaptured, AddressOf CurrentCamera_OnImageCaptured
                MANAGER.CurrentCamera = Nothing
            End If
        End If
        If cbCamera.SelectedItem IsNot Nothing Then
            cbCamera.SelectedItem = Nothing
        End If
        cbCamera.Items.Clear()
        MANAGER = Nothing
        Thread.Sleep(500)
    End Sub

    Private Sub btnPopup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTryPopup.Click
        ' click on stop button to stop any scan if any
        btnStop_Click(Nothing, Nothing)

        ' deinit the current camera
        DeinitCamera()

        ShowScanPopup()

        ' reiniit current camera
        InitCamera()
    End Sub

    Private Sub ShowScanPopup()

        Me.Hide()

        Try

            ' this block to create another instance to scan barcodes
            Dim popup As New VideoScanForm()
            ' set new popup position shifted by 20 pixels
            popup.Left = Me.Left + 20
            popup.Top = Me.Top + 20
            ' set the new popup window to close on first found barcpde
            popup.CloseOnFirstBarcodeFound = True
            ' hide the btnTry button on new dialog window
            popup.btnTryPopup.Visible = False
            popup.btnStop.Visible = False
            popup.btnStart.Visible = False

            ' set the popup title
            popup.Text = "POPUP DIALOG - ONE TIME SCAN"

            ' show the dialog
            If popup.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                ' checking if one time scan dialog found barcodes 
                If popup.m_foundBarcodes IsNot Nothing AndAlso popup.m_foundBarcodes.Length > 0 Then
                    MessageBox.Show("Popup scan found the barcode:" + popup.m_foundBarcodes(0).Value, "POPUP RESULT")
                End If
            Else
                MessageBox.Show("Popup canceled! Returning to the main window")
            End If

            ' close the popup dialog
            popup.Close()
            ' set to null
            popup = Nothing
        Finally
            Me.Visible = True
        End Try
    End Sub

    ''' <summary>
    ''' indicates if the form is closed
    ''' </summary>
    Public IsClosed As Boolean = False

    Private Sub VideoScanForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' populate barcode types into the combobox
        PopulateBarcodeTypesCombobox()

        InitCamera()

        StartDecoding()

    End Sub

    Private Sub VideoScanForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Deinitialize()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
