'*******************************************************************
'       ByteScout BarCode Reader SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

if WScript.Arguments.Count < 2 Then
 MsgBox "Run with the folder path as the argument" & vbCRLF & vbCRLF & "RenameFiles.vbs InputFolder\ OutputFolder\"
 WScript.Quit 0
End If

Set objFSO = CreateObject("Scripting.FileSystemObject")

' define allowed input images extensions
inputImagesExtensions = "JPG,JPEG,PNG,BMP,PDF,TIF"

' make sure they all are upper cases
inputImagesExtensions = UCASE(inputImagesExtensions)


Set bc = CreateObject("Bytescout.BarCodeReader.Reader")

' Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
' Change to bc.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
' or select specific type, e.g. bc.BarcodeTypesToFind.PDF417 = True
' bc.BarcodeTypesToFind.SetAll1D()

bc.BarcodeTypesToFind.SetAll1D()
bc.BarcodeTypesToFind.QRCode = true
bc.BarcodeTypesToFind.PDF417 = true

Set objinputFolder = objFSO.GetFolder(WScript.Arguments(0))

' output folder
set objOutputFolder = objFSO.GetFolder(WScript.Arguments(1))

Call ShowSubfolders (objinputFolder)

WScript.Quit 0

Sub ShowSubFolders(fFolder)
    Set objFolder = objFSO.GetFolder(fFolder.Path)
    Set colFiles = objFolder.Files
    For Each objFile in colFiles
	' check if allowed extension
        If inStr(inputImagesExtensions, UCase(objFSO.GetExtensionName(objFile.name)))>0 Then

	    ' read barcode from filename
	    WScript.Echo "Reading from: " & objFile.Path 
            bc.ReadFromFile objFile.Path 

	    ' getting the sub folder path
	    outputSubFolder = Replace(objFile.Path, objinputFolder.Path, "")
	    outputSubFolder = Replace(outputSubFolder, objFile.Name, "")
		
            ' rename the file to the value of the very first barcode found on this image or pdf
	    newFileName = bc.GetFoundBarcodeValue(0) & "." & objFSO.GetExtensionName(objFile.name)

	    ' replace some special characters as they may not be allowed for use in filename
            newFileName = Replace(newFileName, "<", "_")
            newFileName = Replace(newFileName, ">", "_")

	    ' first check if output subfolder exists
 	    if Not objFSO.FolderExists (objOutputFolder.Path & outputSubFolder) Then
		objFSO.CreateFolder objOutputFolder.Path & outputSubFolder
	    End If

	    WScript.Echo "Copying and renaming " & objFile.path & " into " & objOutputFolder.Path & outputSubFolder & newFileName

	    ' copying the source file into output folder with new filename based on the barcode value
	    objFSO.CopyFile objFile.path, objOutputFolder.Path & outputSubFolder & newFileName



        End If
    Next

    For Each Subfolder in fFolder.SubFolders
        ShowSubFolders(Subfolder)
    Next
End Sub

