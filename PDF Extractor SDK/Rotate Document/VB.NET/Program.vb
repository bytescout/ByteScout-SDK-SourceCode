'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.PDFExtractor
Imports System.Diagnostics

Class Program
	Friend Shared Sub Main(args As String())
		Dim inputFile As String = "sample1.pdf"

		Using rotator As New DocumentRotator("demo", "demo")
			rotator.Rotate(inputFile, "result.pdf", RotationAngle.Deg90)
		End Using

        Process.Start("result.pdf")
    End Sub
End Class
