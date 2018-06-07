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

''' <summary>
''' This example demonstrates how to create a button with GoTo action.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

        ' Add pages
        Dim page1 = New Page(PaperFormat.A4)
        pdfDocument.Pages.Add(page1)
        Dim page2 = New Page(PaperFormat.A4)
        pdfDocument.Pages.Add(page2)

        Dim font = New Font(StandardFonts.Times, 18)
        Dim brush = New SolidBrush()

        ' Mark action target with text
        page2.Canvas.DrawString("Action target", font, brush, 20, 200)

        ' Create button
        Dim button = New PushButton(20, 20, 100, 25, "button1")
        button.Caption = "Go To Page 2"
        ' Create action to go to page 2 at 200 points from the top
        button.OnActivated = New GoToAction(New Destination(page2, 200))

        page1.Annotations.Add(button)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
