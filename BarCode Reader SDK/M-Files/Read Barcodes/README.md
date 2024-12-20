## How to read barcodes in M-Files and ByteScout BarCode Reader SDK

### This tutorial will show how to read barcodes in M-Files

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. What is ByteScout BarCode Reader SDK? It is the SDK for reading of barcodes from PDF, images and live camera or video. Almost every common type like Code 39, Code 128, GS1, UPC, QR Code, Datamatrix, PDF417 and many others are supported. Supports noisy and defective images and docs. Includes optional documents splitter and merger for pdf and tiff based on found barcodess. Batch mode is supported for superior performance using multiple threads. Decoded values are easily exported to JSON, CSV, XML and to custom format. It can help you to read barcodes in your M-Files application.

The SDK samples like this one below explain how to quickly make your application do read barcodes in M-Files with the help of ByteScout BarCode Reader SDK. In your M-Files project or application you may simply copy & paste the code and then run your app! Detailed tutorials and documentation are available along with installed ByteScout BarCode Reader SDK if you'd like to dive deeper into the topic and the details of the API.

Free trial version of ByteScout BarCode Reader SDK is available on our website. Documentation and source code samples are included.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20BarCode%20Reader%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20BarCode%20Reader%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=EARSPJFIJMU](https://www.youtube.com/watch?v=EARSPJFIJMU)




<!-- code block begin -->

##### ****Script-1.vbs:**
    
```
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

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Script-2.vbs:**
    
```
'M-Files Workflow Action Script to remove state and workflow property from object.
'Place action code in the last 'end' state of the workflow.
'updated 2015-03-12, mika, pschokker

' Option Explicit

Dim oPropVals : Set oPropVals = CreateObject ("MFilesAPI.PropertyValues")
Dim oPropVal : Set oPropVal = CreateObject ("MFilesAPI.PropertyValue")

' Clear workflow
oPropVal.PropertyDef = 38
oPropval.TypedValue.SetValue MFDataTypeLookup, "" 
oPropVals.Add -1, oPropVal

' Clear state
oPropVal.PropertyDef = 39
oPropval.TypedValue.SetValue MFDataTypeLookup, ""
oPropVals.Add -1, oPropVal

Call Vault.ObjectPropertyOperations.SetProperties( ObjVer, oPropVals )


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Script-3.vbs:**
    
```
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


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Script-4.vbs:**
    
```
'M-Files Workflow Action Script to remove state and workflow property from object.
'Place action code in the last 'end' state of the workflow.
'updated 2015-03-12, mika, pschokker

' Option Explicit

Dim oPropVals : Set oPropVals = CreateObject ("MFilesAPI.PropertyValues")
Dim oPropVal : Set oPropVal = CreateObject ("MFilesAPI.PropertyValue")

' Clear workflow
oPropVal.PropertyDef = 38
oPropval.TypedValue.SetValue MFDataTypeLookup, "" 
oPropVals.Add -1, oPropVal

' Clear state
oPropVal.PropertyDef = 39
oPropval.TypedValue.SetValue MFDataTypeLookup, ""
oPropVals.Add -1, oPropVal

Call Vault.ObjectPropertyOperations.SetProperties( ObjVer, oPropVals )


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Tutorial.txt:**
    
```
Using ByteScout Barcode tools to automatically recognize documents in M-Files

Adding a barcode to a document

	
•  In M-Files Admin, create a new workflow that will add a barcode to the document. Provide a name and other information
•  In the new workflow, create a new state.  Provide a name, such as "Add Barcode" 	
•  Under "Actions" tab, select "Run script" and provide VBScript:


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

	
		

• Create a new state.  Provide a name, such as "Remove Workflow" 	
•  Under "Actions" tab, select "Run script" and provide VBScript:

	

		'M-Files Workflow Action Script to remove state and workflow property from object.
		'Place action code in the last 'end' state of the workflow.
		'updated 2015-03-12, mika, pschokker

		' Option Explicit

		Dim oPropVals : Set oPropVals = CreateObject ("MFilesAPI.PropertyValues")
		Dim oPropVal : Set oPropVal = CreateObject ("MFilesAPI.PropertyValue")

		' Clear workflow
		oPropVal.PropertyDef = 38
		oPropval.TypedValue.SetValue MFDataTypeLookup, "" 
		oPropVals.Add -1, oPropVal

		' Clear state
		oPropVal.PropertyDef = 39
		oPropval.TypedValue.SetValue MFDataTypeLookup, ""
		oPropVals.Add -1, oPropVal

		Call Vault.ObjectPropertyOperations.SetProperties( ObjVer, oPropVals )

	

•  Link "Add Barcode" and "Remove Workflow" states.  
	Right click state transition, "Transition" tab, select "Trigger the state transition once the object fulfills the specified criteria".  
	Under "Specify", "Files" tab, click "Contains Files", Yes 	

	

	
•  Your workflow should now be setup as shown in step 1.  
•   To Use,  select a document in M-Files.   Assign the new workflow and state.  A barcode will be added to the document.

	
Detecting a barcode to a document

	
•  In M-Files Admin, create a new workflow that will detect a barcode to the document. Provide a name and other information
•  In the new workflow, create a new state.  Provide a name, such as "Detect Barcode" 	
•  Under "Actions" tab, select "Run script" and provide VBScript:

	

	

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

	
		

• Create a new state.  Provide a name, such as "Remove Workflow" 	
•  Under "Actions" tab, select "Run script" and provide VBScript:

	

		'M-Files Workflow Action Script to remove state and workflow property from object.
		'Place action code in the last 'end' state of the workflow.
		'updated 2015-03-12, mika, pschokker

		' Option Explicit

		Dim oPropVals : Set oPropVals = CreateObject ("MFilesAPI.PropertyValues")
		Dim oPropVal : Set oPropVal = CreateObject ("MFilesAPI.PropertyValue")

		' Clear workflow
		oPropVal.PropertyDef = 38
		oPropval.TypedValue.SetValue MFDataTypeLookup, "" 
		oPropVals.Add -1, oPropVal

		' Clear state
		oPropVal.PropertyDef = 39
		oPropval.TypedValue.SetValue MFDataTypeLookup, ""
		oPropVals.Add -1, oPropVal

		Call Vault.ObjectPropertyOperations.SetProperties( ObjVer, oPropVals )

	

•  Link "Detect Barcode" and "Remove Workflow" states.  
	Right click state transition, "Transition" tab, select "Trigger the state transition once the object fulfills the specified criteria".  
	Under "Specify", "Files" tab, click "Contains Files", Yes 	
•  Your workflow should now be setup as shown in step 1.  

•   To Use,  assign the new workflow to an external source.  The new documents will be assigned the new workflow, which will replace the existing document.
```

<!-- code block end -->