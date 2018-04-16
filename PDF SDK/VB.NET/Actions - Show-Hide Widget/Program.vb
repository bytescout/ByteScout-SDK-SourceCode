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
''' This example demonstrates how to show/hide a widget in document.
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

        ' Create widget that will be shown/hidden
        Dim editBox = New EditBox(20, 20, 100, 25, "editBox1")
        editBox.Text = "editBox1"
        page.Annotations.Add(editBox)

        ' Create button that will show the widget
        Dim buttonShow = New PushButton(20, 80, 50, 25, "buttonShow")
        buttonShow.Caption = "Show"
        page.Annotations.Add(buttonShow)
        ' Add Show action
        Dim showAction = New HideAction(False)
        showAction.Fields.Add(editBox)
        buttonShow.OnActivated = showAction

        ' Create button that will hide the widget
        Dim buttonHide = New PushButton(100, 80, 50, 25, "buttonHide")
        buttonHide.Caption = "Hide"
        page.Annotations.Add(buttonHide)
        ' Add Hide action
        Dim hideAction = New HideAction(True)
        hideAction.Fields.Add(editBox)
        buttonHide.OnActivated = hideAction

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
