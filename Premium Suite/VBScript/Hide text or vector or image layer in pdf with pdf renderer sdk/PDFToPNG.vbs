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

Set renderingOptions = CreateObject("Bytescout.PDFRenderer.RenderingOptions")

' Enable text objects rendering
renderingOptions.RenderTextObjects = True
' DISABLE vector objects rendering
renderingOptions.RenderVectorObjects = False
' DISABLE image objects rendering
renderingOptions.RenderImageObjects = False
        
' Render PDF document at 96 DPI - default PC display resolution
' To get higher quality output, set 200, 300 or more
Dim renderingResolution
renderingResolution = 96

' iterate through pages
For i=0 To renderer.GetPageCount()-1
	' Render document page to PNG image file
    renderer.Save_2 "image" & i & ".png", 2, i, renderingResolution, (renderingOptions)
Next

