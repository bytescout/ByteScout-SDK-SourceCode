'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
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
