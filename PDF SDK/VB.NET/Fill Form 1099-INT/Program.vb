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
        fieldMap.Add("c2_1[0]", True) ' Void
        fieldMap.Add("c2_1[1]", True) ' CORRECTED
        fieldMap.Add("f2_1[0]", "John Smith, 12 Palm st., Hill Valley, CA 12345") ' PAYER'S name, street address, city or town, ...
        fieldMap.Add("f2_2[0]", "123456") ' PAYER'S TIN
        fieldMap.Add("f2_3[0]", "234567") ' RECIPIENT'S TIN 
        fieldMap.Add("f2_4[0]", "John Doe") ' RECIPIENT'S name
        fieldMap.Add("f2_5[0]", "23 Elm st., 345") ' Street address (including apt. no.)
        fieldMap.Add("f2_6[0]", "Hill Valley, CA 12345") ' City Or town, state Or province, country, And ZIP Or foreign postal code
        fieldMap.Add("c2_2[0]", True) ' FATCA filing requirement
        fieldMap.Add("f2_7[0]", "345678") ' Account number (see instructions)
        fieldMap.Add("f2_8[0]", "456789") ' Payer's RTN (optional)
        fieldMap.Add("f2_9[0]", "1000.00") ' 1 Interest income
        fieldMap.Add("f2_10[0]", "11.00") '  2 Early withdrawal penalty
        fieldMap.Add("f2_11[0]", "12.00") ' 3 Interest on U.S. Savings Bonds And Treas. obligations
        fieldMap.Add("f2_12[0]", "13.00") ' 4 Federal income tax withheld
        fieldMap.Add("f2_13[0]", "14.00") ' 5 Investment expenses
        fieldMap.Add("f2_14[0]", "15.00") ' 6 Foreign tax paid
        fieldMap.Add("f2_15[0]", "16.00") ' 7 Foreign country Or U.S. possession
        fieldMap.Add("f2_16[0]", "17.00") ' 8 Tax-exempt interest
        fieldMap.Add("f2_17[0]", "18.00") ' 9  Specified private activity bond interest
        fieldMap.Add("f2_18[0]", "19.00") ' 10 Market discount
        fieldMap.Add("f2_19[0]", "20.00") ' 11 Bond premium
        fieldMap.Add("f2_20[0]", "21.00") ' 12 Bond premium on Treasury obligations
        fieldMap.Add("f2_21[0]", "22.00") ' 13 Bond premium on tax-exempt bond 
        fieldMap.Add("f2_22[0]", "567890") ' 14 Tax-exempt And tax credit bond CUSIP no.
        fieldMap.Add("f2_23[0]", "AA") ' 15 State [field 1] 
        fieldMap.Add("f2_24[0]", "BB") ' 15 State [field 2]
        fieldMap.Add("f2_25[0]", "33") ' 16 State identification no. [field 1]
        fieldMap.Add("f2_26[0]", "44") ' 16 State identification no. [field 2]
        fieldMap.Add("f2_27[0]", "30.00") ' 17 State tax withheld [field 1]
        fieldMap.Add("f2_28[0]", "40.00") ' 17 State tax withheld [field 2]

        ' Load PDF form
        Dim pdfDocument = New Document("f1099int.pdf")
        pdfDocument.RegistrationName = "demo"
        pdfDocument.RegistrationKey = "demo"

        ' Get second page ("Copy 1")
        Dim page = pdfDocument.Pages(1)

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
