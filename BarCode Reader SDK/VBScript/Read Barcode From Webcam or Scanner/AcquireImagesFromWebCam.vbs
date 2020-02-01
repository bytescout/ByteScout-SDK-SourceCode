'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Set wia = CreateObject("Bytescout.BarCodeReader.WIAImageScanner")

wia.OutputFileNameTemplate = "BarCodeReader-scanned"
wia.OutputFolder = "." ' set output folder to current folder
wia.OutputImageFormat = 1 ' = WiaImageFormatType.PNG
wia.ImageQuality = 131072 ' = 0x00020000 = WiaImageBias.MaximizeQuality
wia.ImageIntent = 0 ' = WiaImageIntent.UnspecifiedIntent
wia.ShowDeviceSelectionDialog = True

If wia.Acquire() Then ' acquire images from device
	
	outputFiles = wia.OutputFilesCOM ' get names of acquire image files
	Msgbox outputFiles(0) ' display first file name 
	
End If

Set wia = Nothing

