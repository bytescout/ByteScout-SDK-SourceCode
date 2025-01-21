'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.DocumentRotator object
Set rotator = CreateObject("Bytescout.PDFExtractor.DocumentRotator")
rotator.RegistrationName = "demo"
rotator.RegistrationKey = "demo"

rotator.Rotate "sample1.pdf", "result.pdf", 0 ' 0 - rotate 90 deg, 1 - rotate 180 deg, 2 - rotate 270 deg
                
Set rotator = Nothing

WScript.Echo "Rotated document saved as 'result.pdf' file."
