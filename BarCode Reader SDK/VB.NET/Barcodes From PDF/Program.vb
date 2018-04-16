'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports Bytescout.BarCodeReader

Class Program
	Friend Shared Sub Main(args As String())
        
        Dim barcodeReader As New Reader()
        barcodeReader.RegistrationName = "demo"
		barcodeReader.RegistrationKey = "demo"
	
        ' Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
        ' Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
		' or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
		barcodeReader.BarcodeTypesToFind.All1D = True

        Console.WriteLine("Reading barcodes from PDF document...")

        Dim barcodes As FoundBarcode() = barcodeReader.ReadFrom("example.pdf")

        For Each barcode As FoundBarcode In barcodes
            Console.WriteLine("Found barcode with type '{0}' and value '{1}' at page {2} at {3}", barcode.Type, barcode.Value, barcode.Page, barcode.Rect.ToString())
        Next

        Console.WriteLine()
        Console.WriteLine("Press any key to continue.")
        Console.ReadKey()
	End Sub
End Class
