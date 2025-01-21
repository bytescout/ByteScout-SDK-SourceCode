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
''' This example demonstrates how to fill PDF form programmatically.
''' </summary>
Class Program

    Shared Sub Main()

        ' Load PDF form
        Dim pdfDocument = New Document("form.pdf")
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

        Dim page = pdfDocument.Pages(0)

        ' Get widget by its name and change value
        DirectCast(page.Annotations("editBox1"), EditBox).Text = "Test 123"
        DirectCast(page.Annotations("editBox2"), EditBox).Text = "Test 456"
        DirectCast(page.Annotations("checkBox1"), CheckBox).Checked = True

        ' Save modified document
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
