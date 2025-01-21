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

' Set resolution of rendered images to 300DPI
Set renderingOptions = CreateObject("Bytescout.PDFRenderer.RenderingOptions")
renderingOptions.ResolutionOverride= 300

' Generate 800x600 px multipage TIFF
renderer.SaveMultipageTiff_4 "result.tif", 0, -1, 600, 800, (renderingOptions)

