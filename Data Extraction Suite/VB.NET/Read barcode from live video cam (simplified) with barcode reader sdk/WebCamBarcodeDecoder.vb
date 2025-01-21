'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Threading
Imports Bytescout.BarCodeReader
Imports TouchlessLib


Partial Public Class WebCamBarcodeDecoder
    Inherits Form

    ' Touchless API library manager (to use it you should have TouchlessLib.dll referenced and WebCamLib.dll copied to the output directory).
    Private _touchlessLibManager As TouchlessMgr

    ' Background barcode decoding thread.
    Private ReadOnly _backgroundWorker As New BackgroundWorker()

    ' Array with all latest barcodes from the last scanning session.
    Public FoundBarcode As String = Nothing

    ' Form initialization.
    Public Sub New()

        InitializeComponent()

        ' Setup background working thread 
        _backgroundWorker.WorkerSupportsCancellation = True
        AddHandler _backgroundWorker.DoWork, New DoWorkEventHandler(AddressOf BackgroundWorker_DoWork)
        AddHandler _backgroundWorker.RunWorkerCompleted, New RunWorkerCompletedEventHandler(AddressOf BackgroundWorker_RunWorkerCompleted)

    End Sub

    ' On form loading.
    Private Sub VideoScanForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Initialize camera and cancel if no camera avalaible
        If InitCamera() = False Then
            DialogResult = New DialogResult()
            Close()
        End If

        StartDecoding()

    End Sub

    ' Camera initialization.
    Private Function InitCamera() As Boolean

        ' Create Touchless API library manager to work with web camera
        _touchlessLibManager = New TouchlessMgr()

        If _touchlessLibManager.Cameras.Count = 0 Then
            MessageBox.Show("No camera devices available.")
            Return False
        End If

        ' Get first available web camera 
        Dim camera As Camera = _touchlessLibManager.Cameras(0)
        ' ... and set it as the current device
        _touchlessLibManager.CurrentCamera = camera

        ' Set camera image dimensions acquired from camera
        camera.CaptureWidth = 640
        camera.CaptureHeight = 480

        ' Handle camera's OnImageCaptured event
        AddHandler camera.OnImageCaptured, New EventHandler(Of CameraEventArgs)(AddressOf CurrentCamera_OnImageCaptured)

        Return True

    End Function

    Public Sub StartDecoding()

        ' Start the background decoding thread
        _backgroundWorker.RunWorkerAsync()

    End Sub

    Private Sub StopDecoding()

        ' Signal the background thread to stop
        _backgroundWorker.CancelAsync()

    End Sub

    Private Sub DeinitCamera()

        If _touchlessLibManager IsNot Nothing Then
            If _touchlessLibManager.CurrentCamera IsNot Nothing Then
                RemoveHandler _touchlessLibManager.CurrentCamera.OnImageCaptured, AddressOf CurrentCamera_OnImageCaptured
                _touchlessLibManager.CurrentCamera = Nothing
            End If
        End If
        _touchlessLibManager.Dispose()
        _touchlessLibManager = Nothing

    End Sub

    ' Barcode decoding procedure executing in the background thread.
    Private Sub BackgroundWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)

        Dim worker As BackgroundWorker = TryCast(sender, BackgroundWorker)

        ' Create barcode reader instance
        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Enable QR Code decoding
        reader.BarcodeTypesToFind.QRCode = True

        Try

            ' Get image from camera every 1.5s and try to find a barcode on it
            While True

                ' If the decoding is canceled then exit
                If (worker.CancellationPending = True) Then
                    e.Cancel = True
                    Return
                Else
                    ' get current frame bitmap from camera using Touchless lib
                    Dim bitmap As Bitmap = _touchlessLibManager.CurrentCamera.GetCurrentImage()
                    If bitmap IsNot Nothing Then

                        ' -----------------------------------------------------------------------
                        ' NOTE: We can read barcodes from specific page to increase performance .
                        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
                        ' ----------------------------------------------------------------------- 

                        ' Search barcodes
                        Dim result As FoundBarcode() = reader.ReadFrom(bitmap)
                        If result IsNot Nothing And result.Length > 0 Then
                            ' return value of the first found barcode
                            e.Result = result(0).Value
                            Return
                        End If
                    End If

                    ' Pause the loop for 1.5s
                    Thread.Sleep(1500)
                End If

            End While

        Finally
            reader.Dispose()
        End Try

    End Sub

    ' Background thread procedure is finished
    Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)

        ' If decoding is not canceled then get the decoding result from background thread and close the form
        If Not e.Cancelled Then

            ' Get barcode value for background thread result
            FoundBarcode = DirectCast(e.Result, String)

            ' Close form with OK result
            DialogResult = DialogResult.OK
            Close()

        End If

    End Sub

    ' Update picture box with the last captured frame from web camera.
    Private Sub CurrentCamera_OnImageCaptured(ByVal sender As Object, ByVal e As CameraEventArgs)

        pictureVideoPreview.Image = _touchlessLibManager.CurrentCamera.GetCurrentImage()

    End Sub

    ' Cancel button click.
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click

        DialogResult = DialogResult.Cancel
        Close()

    End Sub

    ' On form closing.
    Private Sub VideoScanForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        StopDecoding()

        DeinitCamera()

    End Sub

    ' Shared (static) function for convenient use. 
    ' It creates the form and returns the decoded barcode value as string.
    ' Returns Nothing if the decoding is canceled.
    Public Shared Function DecodeBarcode() As String

        Dim form As New WebCamBarcodeDecoder()

        If form.ShowDialog() = DialogResult.OK Then

            Return form.FoundBarcode

        End If

        Return Nothing

    End Function

End Class
