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

        ' Map of form fields and sample values to set
        Dim fieldMap As New Dictionary(Of String, Object)()

        fieldMap.Add("f1_1[0]", "John J Smith") ' Name
        fieldMap.Add("f1_2[0]", "12 Palm st., Hill Valley, CA 12345") ' Business address

        ' Load PDF form
        Dim pdfDocument = New Document("W-9.pdf")
        pdfDocument.RegistrationName = "demo"
        pdfDocument.RegistrationKey = "demo"

        ' Get first page
        Dim page = pdfDocument.Pages(0)

        ' Get widget by its name and change value
        For Each keyValuePair In fieldMap

            Dim annotation As Annotation = page.Annotations(keyValuePair.Key)

            If TypeOf (annotation) Is CheckBox Then
                CType(annotation, CheckBox).Checked = CType(keyValuePair.Value, Boolean)
            ElseIf TypeOf (annotation) Is EditBox Then
                CType(annotation, EditBox).Text = CType(keyValuePair.Value, String)
            End If

        Next

        ' Save modified document
        pdfDocument.Save("result.pdf")

        ' Cleanup 
        pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Dim processStartInfo As New ProcessStartInfo("result.pdf")
        processStartInfo.UseShellExecute = True
        Process.Start(processStartInfo)

    End Sub

End Class
