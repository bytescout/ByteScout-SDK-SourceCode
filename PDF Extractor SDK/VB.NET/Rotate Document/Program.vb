'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


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
