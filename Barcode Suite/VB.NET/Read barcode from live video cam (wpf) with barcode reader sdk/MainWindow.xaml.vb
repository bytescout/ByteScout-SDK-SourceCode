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
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Reflection
Imports System.Threading
Imports System.Windows.Threading
Imports Bytescout.BarCodeReader
Imports TouchlessLib

Public Class MainWindow

    ' Touchless lib manager object (to use it you should have TouchlessLib.dll and WebCamLib.dll)
    Private _touchlessMgr As TouchlessMgr

    ' USED IN POPUP MODE ONLY (see ShowScanPopup() method)
    ' Close or not on the first barcode found
    ' (results are saved in m_foundBarcodes)
    Public Property CloseOnFirstBarcodeFound As Boolean = False

    ' Indicates if the form is closed
    Public Property IsClosed As Boolean = False

    ' Background processing object
    Private _backgroundWorker As New BackgroundWorker()

    ' Barcode type to scan
    Private _barcodeTypeToFind As New BarcodeTypeSelector()

    ' Array with decoded barcodes from the last scanning session.
    Public Property FoundBarcodes As FoundBarcode() = Nothing

    ' Scanning delay (ms); default is to scan every 800 ms.
    Const ScanDelay As Integer = 800

    ' Internal varaible to indicate the status.
    Public Shared Status As Boolean = True

    Public Sub New()

        InitializeComponent()

        lblScanning.Visibility = Visibility.Collapsed

        _backgroundWorker.WorkerSupportsCancellation = True
        AddHandler _backgroundWorker.DoWork, AddressOf BackgroundWorker_DoWork
        AddHandler _backgroundWorker.RunWorkerCompleted, AddressOf BackgroundWorker_RunWorkerCompleted

    End Sub

    Delegate Sub MyDelegate()

    ' Searches for barcodes in bitmap object
    Private Function FindBarcodes(bitmap As Bitmap) As FoundBarcode()

        Dim reader As New Bytescout.BarCodeReader.Reader()

        Try
            reader.RegistrationName = "demo"
            reader.RegistrationKey = "demo"

            Me.Dispatcher.Invoke(DispatcherPriority.Normal, Sub() UpdateBarcodeTypeToFindFromCombobox())

            reader.BarcodeTypesToFind = _barcodeTypeToFind

            ' -----------------------------------------------------------------------
            ' NOTE: We can read barcodes from specific page to increase performance .
            ' For sample please refer to "Decoding barcodes from PDF by pages" program.
            ' ----------------------------------------------------------------------- 

            Dim result As FoundBarcode() = reader.ReadFrom(bitmap)
            Dim timeNow As String = String.Format("{0:HH:mm:ss:tt}", DateTime.Now)

            Dispatcher.Invoke(DispatcherPriority.Normal,
                              Sub()
                                  If result IsNot Nothing And result.Length > 0 Then
                                      textAreaBarcodes.SelectAll()
                                      textAreaBarcodes.Selection.Text = Environment.NewLine & "Time: " & timeNow & Environment.NewLine

                                      ' insert barcodes into text box
                                      For Each barcode As FoundBarcode In result
                                          ' make a sound that we found the barcode
                                          Console.Beep()
                                          'form the string with barcode value
                                          Dim barcodeValue As String = String.Format("Found: {0} {1}" & Environment.NewLine, barcode.Type, barcode.Value)
                                          ' add barcode to the text area output
                                          textAreaBarcodes.AppendText(barcodeValue & Environment.NewLine)
                                          ' add barcode to the list of saved barcodes
                                          lblFoundBarcodes.Content = String.Format("Found {0} barcodes:", result.Length)
                                      Next
                                  End If

                                  ' make "Scanning..." label flicker
                                  If lblScanning.Visibility = Visibility.Collapsed Then
                                      lblScanning.Visibility = Visibility.Visible
                                  Else
                                      lblScanning.Visibility = Visibility.Collapsed
                                  End If
                              End Sub)
            ' return found barcodes
            Return result

        Finally
            reader.Dispose()
        End Try

    End Function

    ' Updates barcode type filter according with combobox selection
    Private Sub UpdateBarcodeTypeToFindFromCombobox()

        Dim selectedItemText As String = cbBarCodeType.Text

        If String.IsNullOrEmpty(selectedItemText) Then Throw New Exception("Empty barcode type selection.")

        _barcodeTypeToFind.Reset()

        ' Iterate through BarcodeTypeSelector bool properties 
        ' and enable property by barcode name selected in the combobox
        For Each propertyInfo As PropertyInfo In GetType(BarcodeTypeSelector).GetProperties()

            ' Skip readonly properties
            If Not propertyInfo.CanWrite Then
                Continue For
            End If

            If propertyInfo.Name = selectedItemText Then
                propertyInfo.SetValue(_barcodeTypeToFind, True, Nothing)
            End If
        Next

    End Sub

    Private Sub Window_Loaded(sender As System.Object, e As RoutedEventArgs) Handles MyBase.Loaded

        'Populate barcode types into the combobox
        PopulateBarcodeTypesCombobox()

        InitCamera()

        StartDecoding()

    End Sub

    Private Sub InitCamera()

        Try
            ' Create Touchless lib manager to work with video camera
            _touchlessMgr = New TouchlessMgr()

            ' Iterate through available video camera devices
            For Each camera As Camera In _touchlessMgr.Cameras
                ' Add to list of available camera devices
                cbCamera.Items.Add(camera)
            Next

            ' Select first available camera
            cbCamera.SelectedItem = _touchlessMgr.Cameras(0)

            ' Setting default image dimensions; see also camera selection event.
            _touchlessMgr.Cameras(0).CaptureWidth = Integer.Parse(tbCameraWidth.Text)
            _touchlessMgr.Cameras(0).CaptureHeight = Integer.Parse(tbCameraHeight.Text)

        Catch exception As Exception
            MessageBox.Show("No video camera available. Please connect camera." + Environment.NewLine + exception.Message)
        End Try

    End Sub

    Sub StartDecoding()

        UpdateCameraSelection()

        ' Clear the text box output
        Dim txt As New TextRange(textAreaBarcodes.Document.ContentStart, textAreaBarcodes.Document.ContentEnd)
        txt.Text = ""

        ' Clean list of found barcodes
        FoundBarcodes = Nothing

        ' Check camera selected
        If cbCamera.SelectedIndex <> -1 Then

            ' Set status
            Status = True

            ' Update UI buttons
            btnStart.IsEnabled = False
            btnStop.IsEnabled = True
            cbBarCodeType.IsEnabled = False
            cbCamera.IsEnabled = False
            tbCameraHeight.IsEnabled = False
            tbCameraWidth.IsEnabled = False
            lblScanning.Content = "Scanning..."

            ' Start the decoding thread
            _backgroundWorker.RunWorkerAsync(CloseOnFirstBarcodeFound)

        Else
            MessageBox.Show("Please select camera")
        End If

    End Sub


    Private Sub Window_Closing(sender As System.Object, e As CancelEventArgs) Handles MyBase.Closing
        Deinitialize()
    End Sub

    Private Sub cbCamera_SelectionChanged(sender As System.Object, e As SelectionChangedEventArgs) Handles cbCamera.SelectionChanged
        UpdateCameraSelection()
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As RoutedEventArgs) Handles btnStart.Click
        StartDecoding()
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As RoutedEventArgs) Handles btnStop.Click
        StopDecoding()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As RoutedEventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnTryPopup_Click(sender As System.Object, e As RoutedEventArgs) Handles btnTryPopup.Click

        ' Stop scan if any
        StopDecoding()

        ' Deinit the current camera
        DeinitCamera()

        ShowScanPopup()

        ' Reinit current camera
        InitCamera()

    End Sub

    Sub BackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs)

        Dim worker As BackgroundWorker = sender
        Dim closeOnFirstBarcode As Boolean = e.Argument

        While True

            ' Work till user canceled the scan
            If worker.CancellationPending Then
                e.Cancel = True
                Return
            End If

            ' Get current frame bitmap from camera using Touchless lib
            Dim bitmap As Bitmap = _touchlessMgr.CurrentCamera.GetCurrentImage()

            ' Search barcodes
            Dim result As FoundBarcode() = Nothing

            If bitmap IsNot Nothing Then result = FindBarcodes(bitmap)

            ' Check if we need to stop on first barcode found
            If closeOnFirstBarcode AndAlso result IsNot Nothing AndAlso result.Length > 0 Then
                e.Result = result
                Return
            End If

            ' Wait a little to lower CPU load
            Thread.Sleep(ScanDelay)

        End While


    End Sub

    Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)

        ' Clear last results
        FoundBarcodes = Nothing

        If e.Cancelled Then
            lblScanning.Content = "Canceled"
        ElseIf e.Error IsNot Nothing Then
            lblScanning.Content = "Error: " & e.Error.Message
        Else
            lblScanning.Content = "Done."
            FoundBarcodes = e.Result
        End If

        StopDecoding()

    End Sub

    ' Update picture box with the latest frame from video camera
    Sub CurrentCamera_OnImageCaptured(sender As Object, e As CameraEventArgs)
        ' You can change image dimensions if needed
        '_touchlessMgr.CurrentCamera.CaptureWidth = 320
        '_touchlessMgr.CurrentCamera.CaptureHeight = 240
        Dispatcher.Invoke(DispatcherPriority.Normal, Sub()
                                                         If _touchlessMgr IsNot Nothing Then

                                                             pictureVideoPreview.BeginInit()
                                                             Dim imageSource As BitmapImage = BitmapToImageSource(_touchlessMgr.CurrentCamera.GetCurrentImage(), ImageFormat.Png)

                                                             Dim st = New ScaleTransform()
                                                             st.ScaleX = 320.0F / imageSource.PixelWidth
                                                             st.ScaleY = 240.0F / imageSource.PixelHeight

                                                             pictureVideoPreview.Source = New TransformedBitmap(imageSource, st)
                                                             pictureVideoPreview.EndInit()
                                                             pictureVideoPreview.UpdateLayout()

                                                         End If
                                                     End Sub)
    End Sub

    Function BitmapToImageSource(bitmap As Bitmap, imageFormat As ImageFormat) As BitmapImage

        Using memoryStream As New MemoryStream

            bitmap.Save(memoryStream, imageFormat)
            memoryStream.Position = 0

            Dim bitmapImage As New BitmapImage()
            bitmapImage.BeginInit()
            bitmapImage.StreamSource = memoryStream
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad
            bitmapImage.EndInit()

            Return bitmapImage
        End Using

    End Function

    Sub StopDecoding()

        _backgroundWorker.CancelAsync()

        ' Update UI elements
        lblScanning.Visibility = Visibility.Collapsed

        ' Change working status
        Status = False

        btnStart.IsEnabled = True
        btnStop.IsEnabled = False

        cbBarCodeType.IsEnabled = True
        cbCamera.IsEnabled = True

        tbCameraHeight.IsEnabled = True
        tbCameraWidth.IsEnabled = True

        If CloseOnFirstBarcodeFound Then
            If FoundBarcodes IsNot Nothing AndAlso FoundBarcodes.Length > 0 Then
                Close()
            End If
        End If

    End Sub

    Sub UpdateCameraSelection()

        If cbCamera.Items.Count > 0 And cbCamera.SelectedIndex > -1 Then

            If _touchlessMgr.CurrentCamera IsNot Nothing Then
                RemoveHandler _touchlessMgr.CurrentCamera.OnImageCaptured, AddressOf CurrentCamera_OnImageCaptured
            End If

            _touchlessMgr.CurrentCamera = Nothing

            Dim currentCamera As Camera = _touchlessMgr.Cameras(cbCamera.SelectedIndex)

            ' Setting camera output image dimensions
            currentCamera.CaptureWidth = Integer.Parse(tbCameraWidth.Text)
            currentCamera.CaptureHeight = Integer.Parse(tbCameraHeight.Text)

            _touchlessMgr.CurrentCamera = currentCamera
            AddHandler _touchlessMgr.CurrentCamera.OnImageCaptured, AddressOf CurrentCamera_OnImageCaptured

        End If
    End Sub

    Sub PopulateBarcodeTypesCombobox()

        cbBarCodeType.Items.Clear()
        Dim items As New List(Of String)()

        For Each propertyInfo As PropertyInfo In GetType(BarcodeTypeSelector).GetProperties()
            ' Skip readonly properties
            If Not propertyInfo.CanWrite Then
                Continue For
            End If

            items.Add(propertyInfo.Name)
        Next

        items.Sort()
        cbBarCodeType.ItemsSource = items

        ' Select first item in combobox (first is "Find All")
        cbBarCodeType.SelectedItem = cbBarCodeType.Items(0)

    End Sub

    Sub Deinitialize()

        ' Cancel decoding thread
        _backgroundWorker.CancelAsync()

        ' Deinit camera
        DeinitCamera()

        ' Mark as closed
        _isClosed = True

    End Sub

    Sub DeinitCamera()

        If _touchlessMgr IsNot Nothing Then
            RemoveHandler _touchlessMgr.CurrentCamera.OnImageCaptured, AddressOf CurrentCamera_OnImageCaptured
            _touchlessMgr.CurrentCamera = Nothing
        End If

        If cbCamera.SelectedItem IsNot Nothing Then
            cbCamera.SelectedItem = Nothing
        End If

        cbCamera.Items.Clear()
        _touchlessMgr = Nothing

        Thread.Sleep(500)

    End Sub

    Sub ShowScanPopup()

        ' Create another MainWindow instance to scan barcodes
        Dim popup As New MainWindow()
        ' Set new popup position shifted by 20 pixels
        popup.Left = Left + 20
        popup.Top = Top + 20

        ' Set the new popup window to close on first found barcode
        popup.CloseOnFirstBarcodeFound = True

        ' Hide btnTryPopup button 
        popup.btnTryPopup.Visibility = Visibility.Hidden
        popup.btnStop.Visibility = Visibility.Hidden
        popup.btnStart.Visibility = Visibility.Hidden

        ' Set the popup title
        popup.Title = "POPUP DIALOG - ONE-TIME SCAN"

        ' Show the dialog
        popup.Show()

        ' Now wait while the popup is closed (it will be closed on barcode found or canceled)
        While Not popup.IsClosed
            ' HACK: Simulate "DoEvents"
            Dispatcher.Invoke(DispatcherPriority.Background, Sub() Thread.Sleep(20))
            Thread.Sleep(20)
        End While

        ' Checking if one-time scan dialog found barcodes 
        If popup.FoundBarcodes IsNot Nothing AndAlso popup.FoundBarcodes.Length > 0 Then
            MessageBox.Show("Popup scan found the barcode: " & Environment.NewLine & popup.FoundBarcodes(0).Value, "POPUP RESULT")
        Else
            MessageBox.Show("Popup canceled. Returning to the main window")
        End If

        ' Close the dialog
        popup.Close()

    End Sub

End Class
