'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "../../multipage.pdf"

' Render PDF document at 96 DPI - default PC display resolution
' To get higher quality output, set 200, 300 or more
Dim renderingResolution
renderingResolution = 96

Set renderingOptions = CreateObject("Bytescout.PDFRenderer.RenderingOptions")
' Set TIFF compression to CCITT4 
renderingOptions.TIFFCompression = 3  ' 1 - LZW; 2 - CCIT3; 3 - CCIT4; 4 - JPEG; 5 - RLE

' save to multi-page TIFF
renderer.SaveMultipageTiff_2 "multipage.tiff", 0, -1, renderingResolution, (renderingOptions)

