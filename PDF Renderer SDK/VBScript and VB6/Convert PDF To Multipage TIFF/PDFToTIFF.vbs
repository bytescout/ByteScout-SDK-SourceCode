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

' Render PDF document at 96 DPI - default PC display resolution
' To get higher quality output, set 200, 300 or more
Dim renderingResolution
renderingResolution = 96

Set renderingOptions = CreateObject("Bytescout.PDFRenderer.RenderingOptions")
' Set TIFF compression to CCITT4 
renderingOptions.TIFFCompression = 3  ' 1 - LZW; 2 - CCIT3; 3 - CCIT4; 4 - JPEG; 5 - RLE

' save to multi-page TIFF
renderer.SaveMultipageTiff_2 "multipage.tiff", 0, -1, renderingResolution, (renderingOptions)

