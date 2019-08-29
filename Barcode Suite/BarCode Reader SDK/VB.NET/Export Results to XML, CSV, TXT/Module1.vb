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

        ' -----------------------------------------------------------------------
        ' NOTE: We can read barcodes from specific page to increase performance .
        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
        ' ----------------------------------------------------------------------- 

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

        ' 3b. Export only values of found barcodes to plain text file in custom character encoding
        reader.ExportFoundBarcodesToTXT("barcodes2.txt", True, Encoding.ASCII)


        ' Get formatted result to a variable for further processing
        ' =========================================================

        ' 1a. Get found barcodes as XmlDocument
        Dim xmlDocument As XmlDocument = reader.ExportFoundBarcodesToXMLDocument()

        ' 1b. Get found barcodes as XML string
        Dim xmlString = reader.ExportFoundBarcodesToXML()

        ' 2a. Get found barcodes as string in CSV format with default delimiter and quotation
        Dim csv As String = reader.ExportFoundBarcodesToCSV()

        ' 2b. Get found barcodes as string in CSV format with custom delimiter and quotation
        Dim csv2 As String = reader.ExportFoundBarcodesToCSV("|", "'")

        ' 3. Get found barcodes as string in plain text format
        Dim txt As String = reader.ExportFoundBarcodesToTXT()

        ' 4. Get found barcodes as string in JSON format
        Dim jsonString = reader.ExportFoundBarcodesToJSON()


        'Cleanup
        reader.Dispose()

    End Sub

End Module
