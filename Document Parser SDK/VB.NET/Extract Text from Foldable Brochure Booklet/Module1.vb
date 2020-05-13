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

        ' Sample document containing foldable PDF
        Dim sampleDocument As String = ".\SampleFoldable.pdf"

        ' Sample template
        Dim sampleTemplate As String = ".\SampleFoldable.yml"

        ' Output 
        Dim resFile As String = "result.txt"
        Dim sOutput As New StringBuilder(String.Empty)

        ' Create DocumentParser instance
        Using documentParser As New DocumentParser("demo", "demo")

            ' Add sample template
            documentParser.AddTemplate(sampleTemplate)

            ' Parse document data in JSON format
            Dim jsonString As String = documentParser.ParseDocument(sampleDocument, OutputFormat.JSON)

            ' Parse json to foldable structure
            Dim parsedRes = ParseJsonToFoldableStructure(jsonString)

            ' Append all parts to return output
            sOutput.AppendLine(parsedRes.Part1)
            sOutput.AppendLine(parsedRes.Part2)
            sOutput.AppendLine(parsedRes.Part3)

            ' Write output file
            File.WriteAllText(resFile, sOutput.ToString())

            Console.WriteLine($"Extracted text saved to {resFile}")

            ' Open result file with default application
            Process.Start(resFile)

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

    ''' <summary>
    ''' Parse Json to Foldable Structure
    ''' </summary>
    Function ParseJsonToFoldableStructure(ByVal jsonData As String) As FoldableStructure

        ' Get Object data from input file
        Dim jsonObj As JObject = JObject.Parse(jsonData)

        Dim oRet = New FoldableStructure()
        oRet.Part1 = Convert.ToString(jsonObj("fields")("part1")("value"))
        oRet.Part2 = Convert.ToString(jsonObj("fields")("part2")("value"))
        oRet.Part3 = Convert.ToString(jsonObj("fields")("part3")("value"))

        Return oRet

    End Function

    Class FoldableStructure
        Public Property Part1 As String
        Public Property Part2 As String
        Public Property Part3 As String
    End Class

End Module
