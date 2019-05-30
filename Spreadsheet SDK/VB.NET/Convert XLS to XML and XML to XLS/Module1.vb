'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.IO

Module Module1
    Sub Main()
        ' sample XLS to XML conversion
        SampleXLStoXMLConversion()
        ' sample XML to XLS conversion
        SampleXMLtoXLSConversion()
    End Sub

    ''' <summary>
    ''' shows how to convert existing XLS (Excel) _document into XML using Bytescout.Spreadsheet and Bytescout.Spreadsheet.Utils.SimpleXMLConverter
    ''' </summary>
    Sub SampleXLStoXMLConversion()
        Dim document As New Spreadsheet()
document.LoadFromFile("AdvancedReport.xls")

        ' read XLS and save as XML
        Dim tools As New SimpleXMLConverter(document)
        tools.SaveXML("AdvancedReport.xml")

        document.Close()
    End Sub

    ''' <summary>
    ''' shows how to convert XML data into XLS excel using Bytescout.Spreadsheet and Bytescout.Spreadsheet.Utils.SimpleXMLConverter
    ''' </summary>
    Sub SampleXMLtoXLSConversion()
        ' read XML and convert into XLS (Excel) and save

        Dim document As New Spreadsheet()

        Dim tools As New SimpleXMLConverter(document)

        tools.LoadXML("AdvancedReport.xml")

        ' remove output file if already exists
        If File.Exists("AdvancedReportFromXML.xls") Then
            File.Delete("AdvancedReportFromXML.xls")
        End If

        document.SaveAs("AdvancedReportFromXML.xls")

        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("AdvancedReportFromXML.xls")
    End Sub

End Module
