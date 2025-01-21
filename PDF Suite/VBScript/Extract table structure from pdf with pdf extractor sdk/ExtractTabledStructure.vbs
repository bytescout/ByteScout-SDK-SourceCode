'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.StructuredExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.StructuredExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "sample3.pdf"
           
For ipage = 0 To extractor.GetPageCount() - 1 

    ' starting extraction from page #"
    extractor.PrepareStructure ipage

    rowCount = extractor.GetRowCount(ipage)
    
    For row = 0 To rowCount - 1 
        columnCount = extractor.GetColumnCount(ipage, row)

        For col = 0 To columnCount-1
            WScript.Echo "Cell at page #" +CStr(ipage) + ", row=" & CStr(row) & ", column=" & _
                CStr(col) & vbCRLF & extractor.GetCellValue(ipage, row, col)
        Next
    Next
Next

