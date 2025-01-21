'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "multipage.pdf"

' Image format: 0 - BMP; 1 - JPEG; 2 - PNG; 3 - TIFF; 4 - GIF
Dim outputImageFormat
outputImageFormat = 1

' Output extension
Dim outputExtension
Select Case outputImageFormat
Case 0
outputExtension =".bmp"
Case 1
outputExtension =".jpg"
Case 2
outputExtension =".png"
Case 3
outputExtension =".tiff"
Case Else
outputExtension =".gif"
End Select

' Specify Image output's Width and Height
Dim Width
Dim Height

Width = 600
Height = 800

' Iterate through pages
For pageIndex = 0 To renderer.GetPageCount() - 1
	' Render document page to image file
	renderer.Save_3 "page" & CStr(pageIndex) & outputExtension, outputImageFormat, pageIndex, Width, Height
Next


