//Creating the Instance of the OLE object as barcodeReader
OLEObject barcodeReader
barcodeReader = Create OLEObject

//Connecting to the Barcode Reader object
If barcodeReader.ConnectToNewObject("Bytescout.BarCodeReader.Reader") < 0 Then  
    Destroy barcodeReader
    MessageBox("Error", "Can't create Bytescout.BarCodeReader.Reader ActiveX/COM object")
    Return
End If

// Enable barcode types to find:
barcodeReader.BarcodeTypesToFind.Code39 = True
barcodeReader.BarcodeTypesToFind.Code128 = True

// Read barcode from image file
barcodeReader.ReadFromFile("barcode.png")

For i = 0 To barcodeReader.FoundCount - 1
    // Use barcodeReader.GetFoundBarcodePage(i), barcodeReader.GetFoundBarcodeType(i) and barcodeReader.GetFoundBarcodeValue(i)
    // to get the found barcode information
Next

Destroy barcodeReader