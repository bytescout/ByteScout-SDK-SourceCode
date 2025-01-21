'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.DocumentMerger object
Set merger = CreateObject("Bytescout.PDFExtractor.DocumentMerger")
merger.RegistrationName = "demo"
merger.RegistrationKey = "demo"

merger.MergeFolder "PDFDocs", "result.pdf", True
                
Set merger = Nothing

WScript.Echo "Merged document saved as 'result.pdf'."
