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


' HOW TO USE: save this file as "GenerateMultipleBarcodes.vbs'
' change parameters below to your parameters required
' the script wlil generate barcodes into the same folder
' output images are named using encoded value, for example: 100.png represents barcode with encoded value "100"
' TO RUN: install BarCode SDK and in Windows Explorer double-click on "MultipleBarcodes.vbs"


' BEGIN OF BARCODE BATCH GENERATION PARAMETERS
BarCodeType = 16 ' 16 = qr code, for full list of available barcode types see this link: http://bytescout.com/files/help/BytescoutBarCodeSDK/source/html/T_Bytescout_BarCode_SymbologyType.htm
StartValue = 1 ' starting value
StepValue = 2 ' incrementing step for each new barcode
NumberOfBarcodes = 100 ' number of barcodes to generate

BarCodeSDKLicenseName = "demo"
BarCodeSDKLicenseSerial = "demo"

' END OF BARCODE BATCH GENERATION PARAMETERS
' do not change below this line

' initialize barcode library
Set bc = CreateObject("Bytescout.BarCode.Barcode")
bc.RegistrationName = BarCodeSDKLicenseName
bc.RegistrationKey = BarCodeSDKLicenseSerial

' set barcode type to generate
bc.Symbology = BarCodeType

' now make list of barcodes 
For i = StartValue to (StartValue + NumberOfBarcodes)*StepValue Step StepValue 

 bc.Value = CStr(i)
 bc.SaveImage CStr(i) & ".png"

Next

j = (StartValue + NumberOfBarcodes)*StepValue

Msgbox "Done: saved " & NumberOfBarcodes & " barcodes in PNG format with values starting from " & CStr(StartValue) & " to " &  CStr(j) & " (including) with step by " & CStr(StepValue)

' deinitialize barcode sdk
Set bc = Nothing

