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


Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to lock the document with a password. 
''' PDF format supports two kinds of passwords: owner and user password.
''' User password allows to view document and perform allowed actions.
''' Owner password allows everything, including changing passwords and permissions.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
        ' Add page
        pdfDocument.Pages.Add(New Page(PaperFormat.A4))


        ' Set document encryption algorythm
        pdfDocument.Security.EncryptionAlgorithm = EncryptionAlgorithm.RC4_40bit
        ' Set various user permissions
        pdfDocument.Security.AllowPrintDocument = False
        pdfDocument.Security.AllowContentExtraction = False
        pdfDocument.Security.AllowModifyAnnotations = False
        pdfDocument.Security.PrintQuality = PrintQuality.LowResolution

        ' Set owner password
        pdfDocument.Security.OwnerPassword = "ownerpassword"

        ' Set user password
        pdfDocument.Security.UserPassword = "userpassword"


        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
