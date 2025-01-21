'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.IO
Imports Bytescout.PDFExtractor
Imports System.Diagnostics

Class Program

    Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.XLSExtractor instance

        Dim extractor As New XLSExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        File.Delete("output.xls")

        ''' Document Password Can be set in two ways
        ''' 1. Using Property
        ''' 2. Using Events

        ' 1. Handle document password using Property
        ' extractor.Password = "password"

        ' 2. Handle document password using Event
        AddHandler extractor.PasswordRequired, New System.EventHandler(AddressOf extractor_PasswordRequired)

        ' Load sample PDF document
        extractor.LoadDocumentFromFile("encrypted (password is 'password').pdf")

        ' Uncomment this line if you need all pages converted into a single worksheet:
        'extractor.PageToWorksheet = False

        ' Set the output format to XLS
        extractor.OutputFormat = SpreadseetOutputFormat.XLS

        ' Save the spreadsheet to file
        extractor.SaveToXLSFile("output.xls")

        ' Cleanup
        extractor.Dispose()

        ' Open result file in default associated application (for demo purposes)
        Process.Start("output.xls")

    End Sub

    Private Shared Sub extractor_PasswordRequired(sender As Object, e As EventArgs)

        ' Ask user for password and put it to `Password` property.
        CType(sender, XLSExtractor).Password = "password"

    End Sub
End Class
