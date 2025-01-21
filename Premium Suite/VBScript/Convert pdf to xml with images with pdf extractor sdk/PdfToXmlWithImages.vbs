'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.XMLExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XMLExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "sample1.pdf"

' Uncomment this line to get rid of empty nodes in XML
'extractor.PreserveFormattingOnTextExtraction = False

' Set output image format
extractor.ImageFormat = 0 ' 0 = PNG; 1 = JPEG; 2 = GIF; 3 = BMP

' Save images to external files
extractor.SaveImages = 1 ' 1 = ImageHandling.OuterFile
extractor.ImageFolder = "images" ' Folder for external images
extractor.SaveXMLToFile "result_with_external_images.xml"

' Embed images into XML as Base64 encoded string
extractor.SaveImages = 2 ' 2 = ImageHandling.Embed
extractor.SaveXMLToFile "result_with_embedded_images.xml"

WScript.Echo "Done."
