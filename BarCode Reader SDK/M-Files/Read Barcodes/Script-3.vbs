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


'Script to read barcode from document, and update object if it exists

'Download file
'================
Dim objFiles : Set objFiles = Vault.ObjectFileOperations.GetFiles(objVer)
Dim sFilePath : sFilePath = "C:\M-FilesTemp\" & objFiles(1).GetNameForFileSystem() & "-" & ObjVer.ObjId.ID & "-" & ObjVer.Version & ".PDF"
Call Vault.ObjectFileOperations.DownloadFile(objFiles(1).ID, objFiles(1).Version, sFilePath)

'Read barcode
'================
Dim barcode: Set barcode = CreateObject("Bytescout.BarCodeReader.Reader")
barcode.BarcodeTypesToFind.DataMatrix = True
barcode.ReadFromFile sFilePath

'Iterate through all found barcodes.  Ignore barcodes less than 10 characters, and that don't start with JTB
For i = 0 To barcode.FoundCount - 1
    Dim sValue : sValue = barcode.GetFoundBarcodeValue(i)
    If Len(sValue) >= 14 And Left(sValue,3) = "JTB" Then
        'Create ObjID (Barcode Format: JTBZZZZXXXXXXX)
        ' Z = Type (4 Digits)
        ' X = ID (7 Digits)
        Dim oObjID : set oObjID = CreateObject("MFilesAPI.ObjID")
        oObjID.Type = CInt(Mid(sValue, 4, 4))
        oObjID.ID = CInt(Mid(sValue, 8, 7))

        'Err.Raise MFScriptCancel, "Found JTB Barcode. Type: " & oObjID.Type & " ID: " & oObjID.ID

        'Checkout object
        'TODO: Add error handling
        Dim oObjVer : set oObjVer = Vault.ObjectOperations.CheckOut(oObjID)
        
        'Upload file
        Dim objFileNew : Set objFileNew = Vault.ObjectFileOperations.GetFilesForModificationInEventHandler(oObjVer.ObjVer)
        Call Vault.ObjectFileOperations.UploadFile(objFileNew(1).ID, objFileNew(1).Version, sFilePath)

        'CheckIn file
        Vault.ObjectOperations.CheckIn(oObjVer.ObjVer)

        'Delete temporary files
        Dim fs: Set fs = CreateObject("Scripting.FileSystemObject") 'Calls the File System Object
        fs.DeleteFile(sFilePath)

        'Set Name to "DELETEME" to trigger next state
        Dim oName : Set oName = CreateObject("MFilesAPI.PropertyValue")
        oName.PropertyDef = 26 'Keywords property
        oName.TypedValue.SetValue MFDatatypeText, "DELETEME"
        Vault.ObjectPropertyOperations.SetProperty ObjVer, oName

    End If
Next

