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
        Dim pdfDocument = New Document("I130.pdf")
        pdfDocument.RegistrationName = "demo"
        pdfDocument.RegistrationKey = "demo"

        ' Iterate through all pages
        For i As Int32 = 0 To pdfDocument.Pages.Count - 1
            ' Get current page
            Dim page As Page = pdfDocument.Pages(i)

            ' Get FieldMap if exists
            Dim fieldMap = GetPageAnnotationValues(i)

            ' Get widget by its name and change value
            For Each keyValuePair In fieldMap

                Dim annotation As Annotation = page.Annotations(keyValuePair.Key)

                If TypeOf (annotation) Is CheckBox Then
                    CType(annotation, CheckBox).Checked = CType(keyValuePair.Value, Boolean)
                ElseIf TypeOf (annotation) Is EditBox Then
                    CType(annotation, EditBox).Text = CType(keyValuePair.Value, String)
                ElseIf TypeOf (annotation) Is ComboBox Then
                    CType(annotation, ComboBox).Text = CType(keyValuePair.Value, String)
                End If

            Next

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

    ''' <summary>
    ''' Get page annotation values
    ''' </summary>
    Shared Function GetPageAnnotationValues(ByVal pageIndex As Int32) As Dictionary(Of String, Object)

        Dim lstAnnotationValues As New List(Of Dictionary(Of String, Object))

        ' Map of form fields and sample values to set

        ' Set values for page-1
        Dim fieldMap_page1 As New Dictionary(Of String, Object)
        With fieldMap_page1
            .Add("Pt2Line11_SSN[0]", "987654321")
            .Add("CheckBox1[0]", "True")
            .Add("VolagNumber[0]", "V1234567")
            .Add("AttorneyStateBarNumber[0]", "A2345678")
            .Add("USCISOnlineAcctNumber[0]", "U45897231")
            .Add("Pt1Line1_Spouse[0]", "True")
            .Add("Pt1Line1_Siblings[0]", "False")
            .Add("Pt1Line1_Parent[0]", "False")
            .Add("Pt1Line1_Child[0]", "False")
            .Add("Pt1Line2_InWedlock[0]", "True")
            .Add("Pt1Line2_AdoptedChild[0]", "False")
            .Add("Pt1Line2_Stepchild[0]", "False")
            .Add("Pt1Line2_OutOfWedlock[0]", "False")
            .Add("Pt1Line3_Yes[0]", "True")
            .Add("Pt1Line4_No[0]", "False")
            .Add("Pt1Line4_Yes[0]", "True")
            .Add("Pt1Line3_No[0]", "False")
            .Add("Pt2Line4a_FamilyName[0]", "Zawodny")
            .Add("Pt2Line4b_GivenName[0]", "John")
            .Add("Pt2Line4c_MiddleName[0]", "C")
            .Add("Pt2Line1_AlienNumber[0]", "3948JDC")
            .Add("Pt2Line2_USCISOnlineActNumber[0]", "D395083105")
        End With
        lstAnnotationValues.Add(fieldMap_page1)

        ' Set values for page-2
        Dim fieldMap_page2 As New Dictionary(Of String, Object)
        With fieldMap_page2
            .Add("Pt2Line8_DateofBirth[0]", "02/22/1985")
            .Add("Pt2Line9_Male[0]", "True")
            .Add("Pt2Line9_Female[0]", "False")
            .Add("Pt2Line7_CountryofBirth[0]", "Bolivia")
            .Add("Pt2Line11_Yes[0]", "False")
            .Add("Pt2Line11_No[0]", "True")
            .Add("Pt2Line10_StreetNumberName[0]", "Happy Street")
            .Add("Pt2Line10_Unit[0]", "True")
            .Add("Pt2Line10_Unit[1]", "False")
            .Add("Pt2Line10_Unit[2]", "False")
            .Add("Pt2Line10_AptSteFlrNumber[0]", "12")
            .Add("Pt2Line10_CityOrTown[0]", "NJ")
            .Add("Pt2Line10_Province[0]", "Province")
            .Add("Pt2Line10_PostalCode[0]", "39392")
            .Add("Pt2Line10_ZipCode[0]", "39392")
            .Add("Pt2Line10_State[0]", "NJ")
            .Add("Pt2Line10_Country[0]", "USA")
            .Add("Pt2Line10_InCareofName[0]", "Mrs Maizel")
            .Add("Pt2Line14_StreetNumberName[0]", "Happy Street")
            .Add("Pt2Line14_Unit[0]", "False")
            .Add("Pt2Line14_Unit[1]", "True")
            .Add("Pt2Line14_Unit[2]", "False")
            .Add("Pt2Line14_AptSteFlrNumber[0]", "14")
            .Add("Pt2Line14_CityOrTown[0]", "NY")
            .Add("Pt2Line14_State[0]", "NY")
            .Add("Pt2Line14_ZipCode[0]", "10001")
            .Add("Pt2Line14_Province[0]", "Province")
            .Add("Pt2Line14_Country[0]", "USA")
            .Add("Pt2Line14_PostalCode[0]", "10001")
            .Add("Pt2Line13a_DateFrom[0]", "12/30/2010")
            .Add("Pt2Line15a_DateFrom[0]", "11/23/2010")
            .Add("Pt2Line15b_DateTo[0]", "11/28/2010")
            .Add("Pt2Line12_StreetNumberName[0]", "Happy Street")
            .Add("Pt2Line12_Unit[0]", "False")
            .Add("Pt2Line12_Unit[1]", "False")
            .Add("Pt2Line12_Unit[2]", "True")
            .Add("Pt2Line12_AptSteFlrNumber[0]", "14")
            .Add("Pt2Line12_CityOrTown[0]", "NY")
            .Add("Pt2Line12_State[0]", "NY")
            .Add("Pt2Line12_ZipCode[0]", "10001")
            .Add("Pt2Line12_Province[0]", "")
            .Add("Pt2Line12_Country[0]", "USA")
            .Add("Pt2Line12_PostalCode[0]", "12332")
            .Add("Pt2Line6_CityTownOfBirth[0]", "Bolivia")
            .Add("Pt2Line5a_FamilyName[0]", "Zawodny")
            .Add("Pt2Line5b_GivenName[0]", "John")
            .Add("Pt2Line5c_MiddleName[0]", "C")
            .Add("Pt2Line16_NumberofMarriages[0]", "1")
            .Add("Pt2Line17_Widowed[0]", "False")
            .Add("Pt2Line17_Annulled[0]", "False")
            .Add("Pt2Line17_Separated[0]", "False")
            .Add("Pt2Line17_Single[0]", "False")
            .Add("Pt2Line17_Married[0]", "True")
            .Add("Pt2Line17_Divorced[0]", "False")
            .Add("Pt2Line13b_DateTo[0]", "12/20/2011")
        End With
        lstAnnotationValues.Add(fieldMap_page2)

        If pageIndex < lstAnnotationValues.Count Then
            Return lstAnnotationValues(index:=pageIndex)
        Else
            Return New Dictionary(Of String, Object)
        End If

    End Function

End Class
