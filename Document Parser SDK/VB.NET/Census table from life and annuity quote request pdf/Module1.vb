'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System.IO
Imports System.Text
Imports ByteScout.DocumentParser
Imports Newtonsoft.Json.Linq

Module Module1

    Sub Main()

        ' Sample document containing life and annuity quote request form
        Dim sampleDocument As String = ".\SampleGroupDisabilityForm.pdf"

        ' Sample template
        Dim sampleTemplate As String = ".\SampleGroupDisabilityForm.yml"

        ' Create DocumentParser instance
        Using documentParser As New DocumentParser("demo", "demo")

            ' Add sample template
            documentParser.AddTemplate(sampleTemplate)

            ' Parse document data in JSON format
            Dim jsonString As String = documentParser.ParseDocument(sampleDocument, OutputFormat.JSON)

            ' Parse to Json Fields
            Dim oRet = ParseJsonFields(jsonString)

            ' Display some of data to console
            Console.WriteLine($"Parsing Details:{Environment.NewLine}------------------------")

            Console.WriteLine($"Contact Person: {oRet.ContactPerson}")
            Console.WriteLine($"Business Name: {oRet.BusinessName}")
            Console.WriteLine($"Business Address: {oRet.BusinessAddress}")
            Console.WriteLine($"Business Type: {oRet.BusinessType}")
            Console.WriteLine($"Phone: {oRet.Phone}")
            Console.WriteLine($"Email: {oRet.Email}")

            ' Export list of census to csv format
            Dim csvOutputFile As String = "result.csv"

            Dim csvString = ConvertToCsv(oRet.lstCensusTable)
            File.WriteAllText(csvOutputFile, csvString)

            Console.WriteLine($"{Environment.NewLine}{csvOutputFile} generated successfully!")

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

    ''' <summary>
    ''' Parse Json Fields
    ''' </summary>
    Function ParseJsonFields(ByVal jsonInput As String) As FormVM

        Dim jsonObj As JObject = JObject.Parse(jsonInput)

        Dim oRet As New FormVM()
        oRet.ContactPerson = CStr(jsonObj("fields")("contactPerson")("value"))
        oRet.BusinessName = CStr(jsonObj("fields")("businessName")("value"))
        oRet.BusinessAddress = CStr(jsonObj("fields")("businessAddress")("value"))
        oRet.BusinessType = CStr(jsonObj("fields")("businessType")("value"))
        oRet.Phone = CStr(jsonObj("fields")("phone")("value"))
        oRet.Email = CStr(jsonObj("fields")("email")("value"))

        Dim censusTable = jsonObj("tables").Where(Function(p) p.Value(Of String)("name") = "CencusTable")

        If Not censusTable Is Nothing Then

            Dim rows = censusTable.Values("rows").First()

            If Not rows Is Nothing And rows.Count() > 0 Then

                For i As Int32 = 1 To rows.Count() - 1
                    Dim oCensus As New CensusTableVm()

                    ' Parse individual data
                    oCensus.SrNo = rows.ElementAt(i).ElementAt(0).ElementAt(0).Value(Of String)("value")
                    oCensus.DOB = rows.ElementAt(i).ElementAt(1).ElementAt(0).Value(Of String)("value")
                    oCensus.Gender = rows.ElementAt(i).ElementAt(2).ElementAt(0).Value(Of String)("value")
                    oCensus.Occupation = rows.ElementAt(i).ElementAt(3).ElementAt(0).Value(Of String)("value")
                    oCensus.Salary = rows.ElementAt(i).ElementAt(4).ElementAt(0).Value(Of String)("value")
                    oCensus.IsShortTermDisability = rows.ElementAt(i).ElementAt(5).ElementAt(0).Value(Of String)("value")
                    oCensus.IsLongTernDisability = rows.ElementAt(i).ElementAt(6).ElementAt(0).Value(Of String)("value")
                    oCensus.LifeInsuCoverAmt = rows.ElementAt(i).ElementAt(7).ElementAt(0).Value(Of String)("value")

                    oRet.lstCensusTable.Add(oCensus)
                Next

            End If

        End If

        Return oRet

    End Function

    ''' <summary>
    ''' Convert to Csv Format
    ''' </summary>
    Function ConvertToCsv(ByVal lstCensusTable As List(Of CensusTableVm)) As String

        Dim oRet As New StringBuilder(String.Empty)

        ' Get Header Row
        oRet.AppendLine(getCsvTitleRow())

        ' Put Child Rows
        For Each item In lstCensusTable
            oRet.AppendLine(item.ToString())
        Next

        Return oRet.ToString()

    End Function


    Class FormVM

        Public Property ContactPerson As String
        Public Property BusinessName As String
        Public Property BusinessAddress As String
        Public Property BusinessType As String
        Public Property Phone As String
        Public Property Email As String

        Public Property lstCensusTable As List(Of CensusTableVm) = New List(Of CensusTableVm)()

    End Class

    Class CensusTableVm

        Public Property SrNo As String
        Public Property DOB As String
        Public Property Gender As String
        Public Property Occupation As String
        Public Property Salary As String
        Public Property IsShortTermDisability As String
        Public Property IsLongTernDisability As String
        Public Property LifeInsuCoverAmt As String

        Public Overrides Function ToString() As String
            Return $"{SrNo},{DOB},{Gender},{Occupation},{Salary},{IsShortTermDisability},{IsLongTernDisability},{LifeInsuCoverAmt}"
        End Function

    End Class

    Public Function getCsvTitleRow() As String
        Return "SrNo,DOB,Gender,Occupation,Salary,IsShortTermDisability,IsLongTermDisability,LifeInsuCoverAmt"
    End Function

End Module
