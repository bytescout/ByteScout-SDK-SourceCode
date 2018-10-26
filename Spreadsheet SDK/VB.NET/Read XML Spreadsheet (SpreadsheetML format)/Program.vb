'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet

Module Program

    Sub Main()

        Try

            ' Convert SpreadhseetML (xml spreadsheet) to XLSX format
            Using spreadsheet As New Spreadsheet

                spreadsheet.RegistrationName = "demo"
                spreadsheet.RegistrationKey = "demo"

                ' Load input file
                spreadsheet.LoadFromFile("sample.xml")

                ' Generate XLSX format
                spreadsheet.SaveAsXLSX("sample.xlsx")
            End Using

            ' Read spreadsheet and display data to console
            Using spreadsheet As New Spreadsheet

                spreadsheet.RegistrationName = "demo"
                spreadsheet.RegistrationKey = "demo"

                ' Load input file
                spreadsheet.LoadFromFile("sample.xlsx")

                ' Reference Worksheet
                Dim Worksheet As Worksheet = spreadsheet.Worksheet(0)

                Console.WriteLine("=====================================================")
                Console.WriteLine("================ Spreadsheet data ===================")
                Console.WriteLine("=====================================================")

                ' Read And output cells to console.
                For row = Worksheet.UsedRangeRowMin To Worksheet.UsedRangeRowMax

                    For column = Worksheet.UsedRangeColumnMin To Worksheet.UsedRangeColumnMax

                        Console.Write("{0}" + vbTab, Worksheet.Cell(row, column).ValueAsString)

                    Next

                    Console.WriteLine()

                Next

            End Using


        Catch ex As Exception
            Console.WriteLine(("ERROR:" + ex.Message))
        End Try

        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()

    End Sub

End Module
