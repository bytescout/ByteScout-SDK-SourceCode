'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


Imports Bytescout.PDFExtractor
Imports System.Diagnostics

Class Program

	Friend Shared Sub Main(args As String())

        Dim inputFiles As String() = New String() {"sample1.pdf", "sample2.pdf", "sample3.pdf"}

        Using merger As New DocumentMerger("demo", "demo")
            merger.Merge(inputFiles, "result.pdf")
        End Using

        Process.Start("result.pdf")

    End Sub
    
End Class
