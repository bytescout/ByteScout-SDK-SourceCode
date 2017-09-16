'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


' Create BarCodeReader object
Set bc = CreateObject("Bytescout.BarCodeReader.Reader")

' Limit barcode search to PDF417 barcodes only
bc.BarcodeTypesToFind.PDF417 = True

' Create File System object
Set FSO = CreateObject("Scripting.FileSystemObject")

' Get folder object (current folder)
Set objFolder = FSO.GetFolder(".")

' Get file list
Set files = objFolder.Files

' Create output file
Set TS = FSO.CreateTextFile("output.txt")

' Run barcode search for PDF and TIFF files
For Each file in files

	ext = UCase(FSO.GetExtensionName(file))	
	If ext = "PDF" Or ext = "TIF" Then
		bc.ReadFromFile file.Name
		For i = 0 To bc.FoundCount - 1
			' Write found barcode information to output file
			TS.Write("File: """ & file.Name & """ Page " & CStr(bc.GetFoundBarcodePage(i)) & ": Barcode: " & bc.GetFoundBarcodeValue(i)) & vbCRLF
		Next
    End If 
    
Next

TS.Close

Set bc = Nothing
Set TS = Nothing
Set FSO = Nothing

MsgBox "Done! See output.txt with found results"

