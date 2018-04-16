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
''' This example demonstrates how to submit or reset form.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
        ' Add page
        Dim page = New Page(PaperFormat.A4)
        pdfDocument.Pages.Add(page)

        ' Create sample form
        Dim font = New Font(StandardFonts.Times, 14)
        Dim brush = New SolidBrush()
        ' EditBox
        Dim editBox = New EditBox(20, 20, 100, 25, "editBox1")
        editBox.Text = "editBox1"
        page.Annotations.Add(editBox)
        ' CheckBox
        Dim checkBox = New CheckBox(20, 60, 15, 15, "checkBox1")
        page.Annotations.Add(checkBox)
        page.Canvas.DrawString("CheckBox", font, brush, 45, 60)

        ' Add Submit button
        Dim submitButton = New PushButton(20, 120, 80, 25, "buttonSubmit")
        submitButton.Caption = "Submit"
        page.Annotations.Add(submitButton)
        ' Add action
        Dim submitAction = New SubmitFormAction(New Uri("http://login.live.com"))
        submitAction.SubmitFormat = SubmitDataFormat.HTML
        submitAction.SubmitMethod = SubmitMethod.Get
        submitAction.Fields.Add(editBox)
        submitAction.Fields.Add(checkBox)
        submitButton.OnActivated = submitAction

        ' Add Reset button
        Dim resetButton = New PushButton(120, 120, 80, 25, "butonReset")
        resetButton.Caption = "Reset"
        page.Annotations.Add(resetButton)
        ' Add action
        Dim resetAction = New ResetFormAction()
        resetAction.Fields.Add(editBox)
        resetAction.Fields.Add(checkBox)
        resetButton.OnActivated = resetAction

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
