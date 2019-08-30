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


Imports System.Text
Imports System.Windows.Forms
Imports Bytescout.BarCodeReader

' This example demonstrates camera image acquiring using Windows Image Acquisition (WIA) interface.
' BarCode Reader SDK has builtin WIAImageScanner class for WIA.
' If you experienced issues with this example, please try another example located in /Visual Basic.NET/Read From Live Video Cam/ 

NotInheritable Class Program
	Private Sub New()
	End Sub
    Friend Shared Sub Main()

        ' Use WIAImageScanner image acquisition module
        Dim wiaScanner As WIAImageScanner = New WIAImageScanner

        wiaScanner.OutputFileNameTemplate = "BarCodeReader-scanned"
        wiaScanner.OutputImageFormat = WiaImageFormatType.PNG
        wiaScanner.ImageQuality = WiaImageBias.MaximizeQuality
        wiaScanner.ImageIntent = WiaImageIntent.UnspecifiedIntent
        wiaScanner.ShowDeviceSelectionDialog = True

        Try
            ' Run Acquire and exit if canceled or zero images
            If Not wiaScanner.Acquire() Then
                Return
            End If

        Catch Ex As Exception
            Dim message As String = Ex.Message
            If Ex.InnerException IsNot Nothing Then
                message = message & Environment.NewLine & Ex.InnerException.Message
            End If
            MessageBox.Show("Failed acquiring images:" & Environment.NewLine & Environment.NewLine & message)
            Return
        End Try

        ' Read barcode:
        Dim barcodeReader As New Reader()
        barcodeReader.RegistrationName = "demo"
		barcodeReader.RegistrationKey = "demo"
        
        ' Enable decoding of ALL known barcode types.
        barcodeReader.BarcodeTypesToFind.All = True
        ' To speed up the processing and avoid false positives select specific barcodes type, 
        ' e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True

        ' -----------------------------------------------------------------------
        ' NOTE: We can read barcodes from specific page to increase performance .
        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
        ' ----------------------------------------------------------------------- 

        Dim barcodes As FoundBarcode() = barcodeReader.ReadFrom(wiaScanner.OutputFiles(0))

        If barcodes.Length > 0 Then
            Dim builder As New StringBuilder()
            For Each barcode As FoundBarcode In barcodes
                builder.AppendLine(String.Format("Found barcode of type '{0}' with value '{1}'", barcode.Type, barcode.Value))
            Next
            MessageBox.Show(builder.ToString())
        Else
            MessageBox.Show(wiaScanner.OutputFiles(0) & Environment.NewLine & "Could not find any barcode.")
        End If

        ' Cleanup
        barcodeReader.Dispose()

    End Sub
End Class
