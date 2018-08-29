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


Imports Bytescout.PDF

Module Program

    Sub Main()

        Try
            'Files
            Dim fileName As String = "ProtectedPDFFile.pdf"
            Dim fileName_UnProtected As String = "UnProtectedPDFFile.pdf"

            'Protected file password
            Dim filePassword As String = "admin@123"
            'Process file to remove password

            Dim document As Document = New Document()
            document.RegistrationName = "demo"
            document.RegistrationKey = "demo"
            document.Load(fileName, filePassword)

            ' Remove password protection and encryption
            document.Security.OwnerPassword = String.Empty
            document.Security.UserPassword = String.Empty
            document.Security.EncryptionAlgorithm = EncryptionAlgorithm.None

            ' Remove restrictions
            document.Security.AllowAccessibilitySupport = True
            document.Security.AllowAssemlyDocument = True
            document.Security.AllowContentExtraction = True
            document.Security.AllowFillForms = True
            document.Security.AllowModifyAnnotations = True
            document.Security.AllowModifyDocument = True
            document.Security.AllowPrintDocument = True
            document.Security.PrintQuality = PrintQuality.HightResolution

            'Save Unprotected file
            document.Save(fileName_UnProtected)
            Console.WriteLine("PDF restrictions removed successfully!")

            Process.Start(fileName_UnProtected)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()


    End Sub

End Module
