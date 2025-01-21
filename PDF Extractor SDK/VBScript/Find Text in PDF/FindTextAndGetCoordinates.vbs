'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("sample1.pdf")

' Set the matching mode:
' 0 = WordMatchingMode.None - treats the search string as substring;
' 1 = WordMatchingMode.SmartMatch - will find the word in various forms (like Adobe Reader);
' 2 = WordMatchingMode.ExactMatch - treats the search string as separate word.
extractor.WordMatchingMode = 2

' Get page count

pageCount = extractor.GetPageCount()

For i = 0 To PageCount - 1 
 
    If extractor.Find(i, "ipsum", false) Then ' parameters are: page index, string to find, case sensitivity.
        Do
            foundMessage = "Found word 'ipsum' on page #" & CStr(i) & " at { " & _
                "x = " & CStr(extractor.FoundText.Left) & "; " & _
                "y = " & CStr(extractor.FoundText.Top) & "; " & _
                "width = " & CStr(extractor.FoundText.Width) & "; " & _
                "height = " & CStr(extractor.FoundText.Height) & " }"

            elementInfo = ""

            ' Iterate through elements of the found text object
            For j = 0 to extractor.FoundText.ElementCount - 1
                Set element = extractor.FoundText.GetElement(j)	
                elementInfo = elementInfo & "Element #" & CStr(j) & " at { x = " & CStr(element.Left) & "; y = " & CStr(element.Top) & "; width = " & CStr(element.Width) & "; height = " & CStr(element.Height) & vbCRLF
                elementInfo = elementInfo & "Text: " & CStr(element.Text) & vbCRLF
                elementInfo = elementInfo & "Font is bold: " & CStr(element.FontIsBold) & vbCRLF
                elementInfo = elementInfo & "Font is italic: " & CStr(element.FontIsItalic) & vbCRLF
                elementInfo = elementInfo & "Font name: " & CStr(element.FontName) & vbCRLF
                elementInfo = elementInfo & "Font size: " & CStr(element.FontSize) & vbCRLF
                elementInfo = elementInfo & "Font color (as OLE_COLOR): " & CStr(element.FontColorAsOleColor) & vbCRLF & vbCRLF
            Next 

            WScript.Echo foundMessage & vbCRLF & vbCRLF & elementInfo

        Loop While extractor.FindNext
        
    End If

Next

WScript.Echo "Done"

Set extractor = Nothing

