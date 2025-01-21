'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.UnsearchablePDFMaker object
Set unsearchablePDFMaker = CreateObject("Bytescout.PDFExtractor.UnsearchablePDFMaker")
unsearchablePDFMaker.RegistrationName = "demo"
unsearchablePDFMaker.RegistrationKey = "demo"

' Load sample PDF document
unsearchablePDFMaker.LoadDocumentFromFile("sample1.pdf")

' Larger resolution - longer processing and larger PDF file size
unsearchablePDFMaker.RenderingResolution = 300

' Enable Black and White mode
unsearchablePDFMaker.Grayscale = true

' Enable skipping black and white conversation of pages in range
unsearchablePDFMaker.KeepSkippedPages = true

' Second parameter to metohd prepresents "ranges" parameter
' "ranges" param is comma-separated list of page ranges in form "1-4,5,7,8-15,16-". 
' Pages covered by it will be converted to Black and White.
' Page numbers are 1-based. Ending "-" means "to the last page".
' You can also use inverted page numbers adding '!' before the number. E.g. "!1" means "the last page", 
' "2-!2" means "from the second to the penultimate page", "!2-" - last two pages
unsearchablePDFMaker.MakePDFUnsearchable_2 "result.pdf", "1"

WScript.Echo "Unsearchable document saved as 'result.pdf'."
