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
Imports System.Windows.Forms
Imports Bytescout.PDFExtractor

' This example requires 'PDF Viewer SDK' and 'PDF Extractor SDK' installed.
' Download link: http://cdn.bytescout.com/ByteScoutInstaller.exe

Public Partial Class Form1
    Inherits Form

	Public Sub New()
		InitializeComponent()
	End Sub

	Protected Overrides Sub OnLoad(e As EventArgs)

	    ' Preload document into viewer
	    pdfViewerControl1.InputFile = ".\sample_ocr.pdf"

	    MyBase.OnLoad(e)
	End Sub

	Private Sub tsbOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbOpen.Click

        Using openFileDialog As New OpenFileDialog()

            openFileDialog.Title = "Open PDF Document"
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files|*.*"

            If openFileDialog.ShowDialog() = DialogResult.OK Then

                Me.Text = openFileDialog.FileName

                Cursor = Cursors.WaitCursor

                Try
                    pdfViewerControl1.InputFile = openFileDialog.FileName
                Catch exception As Exception
                    MessageBox.Show(exception.Message)
                Finally
                    Cursor = Cursors.[Default]
                End Try

            End If

        End Using

    End Sub

    Private Sub tsbExportToCSV_Click(sender As Object, e As EventArgs) Handles tsbExportToCSV.Click

        ' Get selections from viewer
        Dim selections As RectangleF() = pdfViewerControl1.SelectionInPoints

        Dim outputFile As String = ".\result.csv"

        Using csvExtractor As CSVExtractor = New CSVExtractor()

            ' Load document into extractor
            csvExtractor.LoadDocumentFromFile(pdfViewerControl1.InputFile)

            ' Enable OCR to recongize text from images
            csvExtractor.OCRMode = OCRMode.Auto
            csvExtractor.OCRResolution = 300
            csvExtractor.OCRLanguage = "eng"
            csvExtractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"

            
            ' FYI, removing horizontal lines may increase the text recognition quality in some cases
            'csvExtractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover()
            ' Another filter able to improve the recognition 
            'csvExtractor.OCRImagePreprocessingFilters.AddGammaCorrection()

            ' If selection exists set the extraction area.
            ' Overwise it will extract the whole page.
            If selections.Length > 0 Then
                csvExtractor.SetExtractionArea(selections(0))
            End If

            ' Save extraction results to CSV files
            csvExtractor.SavePageCSVToFile(pdfViewerControl1.CurrentPageIndex, outputFile)

        End Using

        Process.Start(outputFile)

    End Sub

    Private Sub tsbExportToXLSX_Click(sender As Object, e As EventArgs) Handles tsbExportToXLSX.Click

        ' Get selections from viewer
        Dim selections As RectangleF() = pdfViewerControl1.SelectionInPoints

        Dim outputFile As String = ".\result.xlsx"

        Using xlsExtractor As XLSExtractor = New XLSExtractor()

            ' Load document into extractor
            xlsExtractor.LoadDocumentFromFile(pdfViewerControl1.InputFile)

            ' Enable OCR to recongize text from images
            xlsExtractor.OCRMode = OCRMode.Auto
            xlsExtractor.OCRResolution = 300
            xlsExtractor.OCRLanguage = "eng"
            xlsExtractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"

            xlsExtractor.OutputFormat = SpreadseetOutputFormat.XLSX
            xlsExtractor.RichTextFormatting = false

            ' FYI, removing horizontal lines may increase the text recognition quality in some cases
            'xlsExtractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover()
            ' Another filter able to improve the recognition 
            'xlsExtractor.OCRImagePreprocessingFilters.AddGammaCorrection()

            ' If selection exists set the extraction area.
            ' Overwise it will extract the whole page.
            If selections.Length > 0 Then
                xlsExtractor.SetExtractionArea(selections(0))
            End If

            ' Save extraction results to CSV files
            xlsExtractor.SavePageToXLSFile(pdfViewerControl1.CurrentPageIndex, outputFile)

        End Using

        Process.Start(outputFile)

    End Sub
End Class
