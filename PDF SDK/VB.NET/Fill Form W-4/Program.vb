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

        fieldMap.Add("f1_01[0]", "John J") ' FirstName And middle initial
        fieldMap.Add("f1_02[0]", "Smith") ' LastName
        fieldMap.Add("f1_03[0]", "111-111-3333") ' Security number
        fieldMap.Add("f1_04[0]", "12 Palm st., Hill Valley") ' Home address
        fieldMap.Add("f1_05[0]", "CA 12345") ' City, Town, State And ZIP
        fieldMap.Add("c1_1[1]", "True") ' Married
        fieldMap.Add("f1_06[0]", "123") ' Total number of allowance
        fieldMap.Add("f1_07[0]", "443.44") ' Additional amount
        fieldMap.Add("f1_09[0]", "Google, Somewhere in CA") ' Employer's name and address
        fieldMap.Add("f1_10[0]", "12-3-2012") ' First date of employment
        fieldMap.Add("f1_11[0]", "EMP223344") ' Employer identification number

        ' Load PDF form
        Dim pdfDocument = New Document("W-4.pdf")
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
