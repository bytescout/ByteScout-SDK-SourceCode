'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports Bytescout.Spreadsheet

Class Program
    
    Friend Shared Sub Main(args As String())

        ' Create new spreadsheet (or open existing)
        Dim doc As New Spreadsheet()
        doc.RegistrationName = "demo"
        doc.RegistrationKey = "demo"

        ' Add worksheet
        Dim worksheet As Worksheet = doc.Worksheets.Add()

        ' Put background image on the worksheet
        worksheet.BackgroundPicture = Image.FromFile("image1.jpg")

        ' Save document
        doc.SaveAs("output.xls")

        ' Close spreadsheet
        doc.Close()

        ' Open generated XLS document in default application
        Process.Start("output.xls")

        doc.Dispose()

    End Sub
    
End Class
