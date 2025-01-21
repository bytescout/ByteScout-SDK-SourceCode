'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.ImageExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.ImageExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("sample1.pdf")

i = 0

' Initialize image enumeration
If extractor.GetFirstImage() Then
    Do
        outputFileName = "image" & i & ".png"
        ' Save image to file
        extractor.SaveCurrentImageToFile outputFileName
        i = i + 1
    Loop While extractor.GetNextImage() ' Advance image enumeration
End If

' Open first output image in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "image0.png", 1, false
Set shell = Nothing

Set extractor = Nothing

