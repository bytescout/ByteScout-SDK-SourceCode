'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing
Imports Bytescout.PDFExtractor

Class Program
    Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.SensitiveDataDetector instance
        Dim sensitiveDataDetector As New Bytescout.PDFExtractor.SensitiveDataDetector()
        sensitiveDataDetector.RegistrationName = "demo"
        sensitiveDataDetector.RegistrationKey = "demo"

        ' Load sample PDF document
        sensitiveDataDetector.LoadDocumentFromFile(".\samplePDF_EmailSSN.pdf")

        ' Set the location of OCR language data files
        sensitiveDataDetector.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"

        ' Perform detecting sensitive data
        Dim detectionResults = sensitiveDataDetector.PerformDetection()

        ' Generate Report
        Dim report As String = sensitiveDataDetector.GenerateReport(detectionResults, SensitiveDataReportFormat.TXT)

        Console.WriteLine(report)

        ' Cleanup
        sensitiveDataDetector.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub
End Class
