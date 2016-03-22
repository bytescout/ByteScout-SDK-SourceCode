'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.StructuredExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.StructuredExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3.pdf"
           

For ipage = 0 to extractor.GetPageCount()-1 

	' starting extraction from page #"
	extractor.PrepareStructure ipage

	rowCount = extractor.GetRowCount(ipage)
	CellsAlreadyScanned = 0

	FOR row = 0 to rowCount-1 
		columnCount = extractor.GetColumnCount(ipage, row)

		For col = 0 To columnCount-1
                    MsgBox "Cell at page #" +CStr(ipage) + ", row=" & CStr(row) & ", column=" & CStr(col) & vbCRLF & extractor.GetCellValue(ipage, row, col)
                Next
	CellsAlreadyScanned = CellsAlreadyScanned + columnCount
        Next
Next

