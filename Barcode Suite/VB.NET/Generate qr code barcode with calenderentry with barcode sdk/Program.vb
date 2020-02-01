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


Imports Bytescout.BarCode

Module Program

    Sub Main()

        Try
            ' Create new barcode
            Dim barcode As Barcode = New Barcode

            ' Set symbology
            barcode.Symbology = SymbologyType.QRCode

            ' Get QRCode value in CalenderEntry format
            barcode.Value = GetCalenderEntryFormatText()

            ' Save barcode to image
            barcode.SaveImage("result.png")

            ' Show image in default image viewer
            Process.Start("result.png")

        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)

            Console.WriteLine("Press enter key to exit...")
            Console.ReadLine()
        End Try

    End Sub

    ''' <summary>
    ''' Return Calender Entry Format
    ''' </summary>
    ''' <returns></returns>
    Private Function GetCalenderEntryFormatText() As String
        Return "BEGIN:VCALENDAR
BEGIN:VEVENT
DTSTART:20181113T100000Z
DTEND:20181113T150000Z
SUMMARY:New Calendar Entry
DESCRIPTION:Description Text
LOCATION:Chicago
RRULE:FREQ=YEARLY;BYDAY=-1SU;BYMONTH=3
END:VEVENT
END:VCALENDAR"
    End Function

End Module
