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


Imports System.IO

Imports Bytescout.BarCodeReader
Imports System.Text
Imports System.Xml

Module Module1

    Sub Main()

        Dim reader As New Reader()
        reader.RegistrationName = "demo"
		reader.RegistrationKey = "demo"

        ' Set barcode type to find
        reader.BarcodeTypesToFind.All1D = True

        ' Read barcodes
        reader.ReadFromFile("barcodes.pdf")


        ' Export to files:
        ' ================

        ' 1. Export found barcodes to XML
        reader.ExportFoundBarcodesToXML("barcodes.xml")

        ' 2a. Export found barcodes to CSV with default delimiter, quotation and character encoding
        reader.ExportFoundBarcodesToCSV("barcodes.csv")

        ' 2b. Export found barcodes to CSV with custom delimiter, quotation and character encoding
        reader.ExportFoundBarcodesToCSV("barcodes2.csv", "|", "'", Encoding.UTF8)

        ' 3a. Export found barcodes to plain text file in default character encoding
        reader.ExportFoundBarcodesToTXT("barcodes.txt")

        ' 3b. Export found barcodes to plain text file in custom character encoding
        reader.ExportFoundBarcodesToTXT("barcodes2.txt", Encoding.UTF8)


        ' Get formatted result to a variable for further processing
        ' =========================================================

        ' 1. Get found barcodes as XmlDocument
        Dim xmlDocument As XmlDocument = reader.ExportFoundBarcodesToXML()

        ' 2a. Get found barcodes as string in CSV format with default delimiter and quotation
        Dim csv As String = reader.ExportFoundBarcodesToCSV()

        ' 2b. Get found barcodes as string in CSV format with custom delimiter and quotation
        Dim csv2 As String = reader.ExportFoundBarcodesToCSV("|", "'")

        ' 3. Get found barcodes as string in plain text format
        Dim txt As String = reader.ExportFoundBarcodesToTXT()

    End Sub

End Module
