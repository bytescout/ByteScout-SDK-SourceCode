'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.DocumentSplitter object
Set splitter = CreateObject("Bytescout.PDFExtractor.DocumentSplitter")
splitter.RegistrationName = "demo"
splitter.RegistrationKey = "demo"

inputFile = "sample.pdf"

' enable optimization for documents
' splitter.OptimizeSplittedDocuments = true

splitter.ExtractPage inputFile, "page3.pdf", 3 ' (!) Note: page number is 1-based.
                
MsgBox "Extracted page 3 to file page3.pdf"

' Split in two parts:
' ===================

splitter.Split inputFile, "part1.pdf", "part2.pdf", 3 ' (!) Note: page number is 1-based.

MsgBox "Splitted at page 3 to files part1.pdf and part2.pdf"

' Split by ranges:
' ================

' array to store output file names
Dim OutFiles

' SplitCOM() returns array with a list of filenames
OutFiles = splitter.SplitCOM(inputFile, "1-3,4-6,7,8-") ' (!) Note: page numbers are 1-based; ending "-" means "to the end".
 
 MsgBox "Splitted by ranges sucessfully! Click OK to see filenames generated"

  ' display list of generated outputfiles              
  For each of in outFiles
	MsgBox of
  Next

