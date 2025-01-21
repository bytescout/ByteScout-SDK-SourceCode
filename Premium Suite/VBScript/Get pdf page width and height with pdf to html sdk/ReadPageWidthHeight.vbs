'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDF2HTML.HTMLExtractor object
Set extractor = CreateObject("Bytescout.PDF2HTML.HTMLExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Set HTML with CSS extraction mode
extractor.ExtractionMode = 1

' Load sample PDF document
extractor.LoadDocumentFromFile("sample2.pdf")

' read width and height of page #0 from PDF 
' and show default output width and calculated page height
MsgBox "Page #0" & vbCRLF & "Page height = " & CStr(extractor.GetPageHeight(0)) & vbCRLF & "Page width = " & CStr(extractor.GetPageWidth(0)) & vbCRLF & "Output width =" & CStr(extractor.OutputPageWidth) & vbCRLF & "Output Page Height = " & CStr(extractor.GetOutputHTMLPageHeight(0))

' uncomment to Convert pdf to HTML to file 
' extractor.SaveHtmlToFile_2 "output.html"

Set extractor = Nothing

