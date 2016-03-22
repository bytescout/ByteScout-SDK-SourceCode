'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Bytescout.PDFExtractor
Imports System.Diagnostics

Namespace ConsoleApplication1
    Class Program
        Shared Sub Main(ByVal args As String())
            ' Create Bytescout.PDFExtractor.CSVExtractor instance
            Dim extractor As New CSVExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            ' Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf")

            'extractor.CSVSeparatorSymbol = "," // you can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales

            extractor.SaveCSVToFile("output.csv")

            Console.WriteLine()
            Console.WriteLine("Data has been extracted to 'output.csv' file.")
            Console.WriteLine()
            Console.WriteLine("Press any key to continue and open CSV in default CSV viewer (or Excel)...")
            Console.ReadKey()

            Process.Start("output.csv")
        End Sub
    End Class
End Namespace

