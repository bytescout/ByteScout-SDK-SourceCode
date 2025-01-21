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

Module Module1

    Sub Main()

        ' Create TextExtractor instance
        Dim textExtractor = New TextExtractor("demo", "demo")
        textExtractor.WordMatchingMode = WordMatchingMode.ExactMatch ' Set exact search (default is SmartSearch that works like in Adobe Reader)

        ' Create XMLExtractor instance
        Dim xmlExtractor = New XMLExtractor("demo", "demo")

        ' Load document
        textExtractor.LoadDocumentFromFile("Invoice.pdf")
        xmlExtractor.LoadDocumentFromFile("Invoice.pdf")

        ' Results
        Dim invoiceNo = String.Empty
        Dim invoiceDate = String.Empty
        Dim total = String.Empty
        Dim tableData = String.Empty

        ' Iterate pages
        For i As Integer = 0 To textExtractor.GetPageCount() - 1

            Dim pageRectangle = textExtractor.GetPageRectangle(i)
            Dim tableRect = New RectangleF(0, 0, pageRectangle.Width, 0)

            ' Search for "Invoice No."
            If textExtractor.Find(i, "Invoice No.", False) Then
                ' Get the found text rectangle
                Dim textRect = textExtractor.FoundText.Bounds
                ' Assume the text at right is the invoice number.
                ' Shift the rectangle to the right:
                textRect.X = textRect.Right
                textRect.Width = pageRectangle.Right - textRect.Left
                ' Set the extraction region and extract the text
                textExtractor.SetExtractionArea(textRect)
                invoiceNo = textExtractor.GetTextFromPage(i).Trim()
            End If

            ' Search for "Invoice Date" and extract text at right
            If textExtractor.Find(i, "Invoice Date", False) Then
                Dim textRect = textExtractor.FoundText.Bounds
                textRect.X = textRect.Right
                textRect.Width = pageRectangle.Right - textRect.Left
                textExtractor.SetExtractionArea(textRect)
                invoiceDate = textExtractor.GetTextFromPage(i).Trim()
            End If

            ' Search for "Quantity" keyword to detect the top of the tabular data rectangle
            If textExtractor.Find(i, "Quantity", False) Then
                ' Keep the top table coordinate
                tableRect.Y = textExtractor.FoundText.Bounds.Top ' use textRect.Bottom if you want to skip column headers
            End If

            ' Search and extract "TOTAL" (it will be also the bottom of tabular data rectangle)
            If textExtractor.Find(i, "TOTAL", True) Then ' case sensitive! 

                Dim textRect = textExtractor.FoundText.Bounds
                textRect.X = textRect.Right
                textRect.Width = pageRectangle.Right - textRect.Left
                textExtractor.SetExtractionArea(textRect)
                total = textExtractor.GetTextFromPage(i).Trim()

                ' Calculate the table height
                tableRect.Height = textRect.Top - tableRect.Top
            End If

            ' Extract tabular data using XMLExtractor
            If tableRect.Height > 0 Then
                xmlExtractor.SetExtractionArea(tableRect)
                tableData = xmlExtractor.GetXMLFromPage(i)
            End If
        Next

        ' Display extracted data
        Console.WriteLine("Invoice No.: " + invoiceNo)
        Console.WriteLine("Invoice Date: " + invoiceDate)
        Console.WriteLine("TOTAL: " + total)
        Console.WriteLine("Table Data: ")
        Console.WriteLine(tableData)

        Console.WriteLine("Press any key...")
        Console.ReadKey()

    End Sub

End Module
