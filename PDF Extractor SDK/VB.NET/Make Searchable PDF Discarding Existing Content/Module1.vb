'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDFExtractor

Module Module1

    Sub Main()

        ' By default, "SearchablePDFMaker" uses one of the standard PDF fonts to apply 
        ' recognized text over the scanned document. Such fonts contain only basic characters 
        ' from ISO-8859-1 charset. 
        ' If you run OCR for one of the languages with characters that are not present in the default
        ' encoding, you should explicitly specify the font that contains the required characters
        ' using ".LabelingFont" property.
        ' If you run the application in Windows with a selected locale that matches OCR language, 
        ' it will be enough to specify the usual font "Arial". But if your app will run in an unknown
        ' environment (for example, in some virtual machine) you will need to install some full Unicode 
        ' font (e.g. "Arial Unicode MS") and then use it with SearchablePDFMaker:
        ' 
        ' searchablePDFMaker.LabelingFont = "Arial Unicode MS"

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim searchablePdfMaker As SearchablePDFMaker = New SearchablePDFMaker()
        searchablePdfMaker.RegistrationName = "demo"
        searchablePdfMaker.RegistrationKey = "demo"

        ' Load sample PDF document
        searchablePdfMaker.LoadDocumentFromFile("sample_ocr_withText.pdf")

        ' Set the location of OCR language data files
        searchablePdfMaker.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"

        ' Set OCR language
        searchablePdfMaker.OCRLanguage = "eng" ' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder

        ' Set PDF document rendering resolution
        searchablePdfMaker.OCRResolution = 300

        ' Discard Existing Text in document
        searchablePdfMaker.DiscardExistingDocumentText = True

        ' Process document
        searchablePdfMaker.MakePDFSearchable("output.pdf")

        ' Cleanup
        searchablePDFMaker.Dispose()

        ' Open output file in default associated application
        System.Diagnostics.Process.Start("output.pdf")

    End Sub

End Module
