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
            ' Create Bytescout.PDFExtractor.XMLExtractor instance
            Dim extractor As New XMLExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            ' Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf")

            extractor.SaveXMLToFile("output.XML")

            Console.WriteLine()
            Console.WriteLine("Data has been extracted to 'output.XML' file.")
            Console.WriteLine()
            Console.WriteLine("Press any key to continue and open XML in default XML viewer...")
            Console.ReadKey()

            Process.Start("output.XML")
        End Sub
    End Class
End Namespace

