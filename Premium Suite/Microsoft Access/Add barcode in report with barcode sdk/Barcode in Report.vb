'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' 1. Add reference to "Bytescout Barcode SDK" ActiveX object to your database project (in menu Tools->References).
' 2. Put Picture object on the Details section of the report.
' 3. Handle the Format event of the Details section and set barcode image to the Picture control.

Option Compare Database

Dim BarCodeGenerator

Private Sub Report_Open(Cancel As Integer)

    ' Setup the barcode generator
    Set BarCodeGenerator = CreateObject("Bytescout.BarCode.Barcode")
    BarCodeGenerator.RegistrationName = "demo"
    BarCodeGenerator.RegistrationKey = "demo"
    BarCodeGenerator.Symbology = 16 ' QRCode
    
End Sub

Private Sub Detail_Format(Cancel As Integer, FormatCount As Integer)

    ' Set barcode value
    BarCodeGenerator.Value = Me.Field1
    ' Set generated barcode image to Picture object
    Me.BarcodeImage.PictureData = BarCodeGenerator.GetImageBytesPNG()
           
End Sub

Private Sub Report_Close()

    ' Cleanup
    Set BarCodeGenerator = Nothing

End Sub
