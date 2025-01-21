'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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

