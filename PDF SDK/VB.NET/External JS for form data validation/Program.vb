'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDF

''' <summary>
''' This example demonstrates validation of form with JavaScript
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

        ' If you wish to load an existing document uncomment the line below And comment the Add page section instead
        ' pdfDocument.Load(".\existing_document.pdf")

        ' Add page
        Dim page As New Page(PaperFormat.A4)
        pdfDocument.Pages.Add(page)

        ' Get page canvas
        Dim canvas As Canvas = page.Canvas

        ' Prepare font and brush
        Dim font As Font = New Font(StandardFonts.Helvetica, 15)
        Dim blackBrush As New SolidBrush()

        ' Draw First Name Label
        canvas.DrawString("First Name: ", font, blackBrush, 50, 50)

        ' Create FirstName EditBox
        Dim firstName As EditBox = New EditBox(130, 50, 100, 30, "FirstName")

        ' Add javascript validation on focus lose
        firstName.OnLoseFocus = New JavaScriptAction("
if(event.value == ''){
    app.alert('First Name is required!');
}
")

        ' Add First Name EditBox to page
        page.Annotations.Add(firstName)


        ' Draw Last Name Label
        canvas.DrawString("Last Name: ", font, blackBrush, 50, 100)

        ' Create Last Name EditBox
        Dim lastName As EditBox = New EditBox(130, 100, 100, 30, "LastName")

        ' Add javascript validation on focus lose
        lastName.OnLoseFocus = New JavaScriptAction("
if(event.value == ''){
    app.alert('Last Name is required!');
}
")

        page.Annotations.Add(lastName)

        ' Create a button
        Dim btnSubmit As PushButton = New PushButton(50, 150, 150, 30, "SayHello")
        btnSubmit.Caption = "Say Hello!"

        ' Javascript action to validate as well as displaying message
        btnSubmit.OnMouseDown = New JavaScriptAction("

var valFirstName = this.getField('FirstName').value;
var valLastName = this.getField('LastName').value;

if(valFirstName == '' || valLastName == ''){
    app.alert('Please complete incompete values in form!');
}
else{
    var messageToDisplay = 'Hello, ' + valLastName + ' ' + valFirstName + '!';
    app.alert(messageToDisplay, 4);
}

")

        page.Annotations.Add(btnSubmit)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
