'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.Globalization
Imports System.IO
Imports System.Threading

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()
        document.LoadFromFile("sampleDates.xlsx")

        ' Get worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets.ByName("Sheet1")

        ' List of cell-addresses
        Dim valuesToRead As New List(Of KeyValuePair(Of Int32, Int32))
        valuesToRead.Add(New KeyValuePair(Of Integer, Integer)(1, 0))
        valuesToRead.Add(New KeyValuePair(Of Integer, Integer)(2, 0))
        valuesToRead.Add(New KeyValuePair(Of Integer, Integer)(3, 0))

        ' Set culture as en-us
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US")

        ' Iterate through list of cell addresses
        For Each itmAddress As KeyValuePair(Of Int32, Int32) In valuesToRead

            Dim itmValue = worksheet.Cell(itmAddress.Key, itmAddress.Value).ValueAsDateTime

            ' Read cell value
            Console.WriteLine($"Cell ({itmAddress.Key},{itmAddress.Value}) value: {itmValue.ToShortDateString()}")
        Next

        ' Write message
        Console.Write("Press any key to continue...")

        ' Wait user input
        Console.ReadKey()
    End Sub

End Module
