'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


if WScript.Arguments.Count < 2 Then
 MsgBox "Run with the folder path as the argument" & vbCRLF & vbCRLF & "BatchReadFromFiles.vbs <InputFolder> <OutputFolder>"
 WScript.Quit 0
End If

Set objFSO = CreateObject("Scripting.FileSystemObject")

' define allowed input images extensions
inputImagesExtensions = "JPG,JPEG,PNG,BMP,PDF,TIF"

Set reader = CreateObject("Bytescout.BarCodeReader.Reader")

' Set barcode types for searching
reader.BarcodeTypesToFind.Code39 = True
reader.BarcodeTypesToFind.QRCode = True
reader.BarcodeTypesToFind.PDF417 = True
reader.BarcodeTypesToFind.EAN13 = True

Set objInputFolder = objFSO.GetFolder(WScript.Arguments(0))
Set objResultsFile = objFSO.CreateTextFile(WScript.Arguments(1), True)

Call ProcessFolder(objInputFolder)

WScript.Quit 0

Sub ProcessFolder(folder)

    Set objFolder = objFSO.GetFolder(folder.Path)
    Set colFiles = objFolder.Files
    
    For Each objFile in colFiles

        ' Check the file type
        If inStr(inputImagesExtensions, UCase(objFSO.GetExtensionName(objFile.Name))) > 0 Then

        ' Read barcode from file
        WScript.Echo "Reading from: " & objFile.Path
        reader.ReadFromFile objFile.Path 

        Dim csv 
        csv = reader.ExportFoundBarcodesToCSV_4
        objResultsFile.Write csv
        
        End If
    Next

    For Each subFolder in folder.SubFolders
        ProcessFolder subFolder
    Next
End Sub

