'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Option Explicit

'Script to download file, add barcode, and upload
'BARCODE LAYOUT:
'JTBZZZZXXXXXXX
'Z - Type (4 Digits)
'X - ID (7 Digits)
'To debug: Err.Raise MFScriptCancel,

'Err.Raise MFScriptCancel, "GUID: " & ObjVer.ObjId.ToJSON()

'Download file
'===============
Dim objFiles : Set objFiles = Vault.ObjectFileOperations.GetFiles(objVer)
Dim sFilePath : sFilePath = "C:\M-FilesTemp\" & objFiles(1).GetNameForFileSystem() & "-" & ObjVer.ObjId.ID & "-" & ObjVer.Version & ".PDF"
Call Vault.ObjectFileOperations.DownloadFile(objFiles(1).ID, objFiles(1).Version, sFilePath)

'Add barcode
'===============
Dim barcode : Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"
barcode.Symbology = 15 ' DataMatrix
barcode.Value = "JTB" & Right("0000" & ObjVer.ObjId.Type, 4) & Right("0000000" & ObjVer.ObjId.ID, 7)
barcode.ResolutionX = 150
barcode.ResolutionY = 150
Dim sNewPath : sNewPath = "C:\M-FilesTemp\" & objFiles(1).GetNameForFileSystem() & "-" & ObjVer.ObjId.ID & "-" & ObjVer.Version & "-BARCODE.PDF"
barcode.DrawToPDF sFilePath, 0, 15, 15, sNewPath

'Upload file
'================
Dim objFileNew : Set objFileNew = Vault.ObjectFileOperations.GetFilesForModificationInEventHandler(objVer)
Call Vault.ObjectFileOperations.UploadFile(objFileNew(1).ID, objFileNew(1).Version, sNewPath)
'Call Vault.ObjectOperations.CheckIn(objVer)

'Delete Files
'================
Dim fs: Set fs = CreateObject("Scripting.FileSystemObject") 'Calls the File System Object
fs.DeleteFile(sFilePath)
fs.DeleteFile(sNewPath)
