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
            ' Create Bytescout.PDFExtractor.XFDFExtractor instance
            Dim extractor As New XFDFExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            ' Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf")

            extractor.SaveXFDFToFile("output.xml")

            Console.WriteLine()
            Console.WriteLine("Data has been extracted to 'output.xml' file.")
            Console.WriteLine()
            Console.WriteLine("Press any key to continue and open file in default associated application...")
            Console.ReadKey()

            Process.Start("output.xml")
        End Sub
    End Class
End Namespace

