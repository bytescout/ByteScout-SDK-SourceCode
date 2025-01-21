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

Module Program

    Sub Main()

        Dim inputDocument = ".\samplePDF_SSNNo.pdf"
        Dim outputDocument = ".\samplePDF_SSNNo_edited.pdf"

        Try
            ' Create Bytescout.PDFExtractor.TextExtractor instance
            Using extractor As TextExtractor = New TextExtractor("demo", "demo")
                ' Create Bytescout.PDFExtractor.Remover2 instance
                Using remover As Remover2 = New Remover2("demo", "demo")
                
                    ' Load sample PDF document
                    extractor.LoadDocumentFromFile(inputDocument)
                    remover.LoadDocumentFromFile(inputDocument)
                    
                    ' Enable the regular expression 
                    extractor.RegexSearch = True

                    Dim pageCount As Integer = extractor.GetPageCount()

                    ' Search through pages
                    For pageIndex As Integer = 0 To pageCount - 1

                        ' Search SSN in format 202-55-0130 using regular expression.
                        ' See the complete regular expressions reference at https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx
                        Dim regexPattern As String = "[0-9]{3}-[0-9]{2}-[0-9]{4}"
                        
                        ' Search each page for the pattern
                        Dim searchResults As ISearchResult() = extractor.FindAll(pageIndex, regexPattern, False)
                        
                        ' Iterate through each element in the found text
                        For Each element As ISearchResult In searchResults
                            Console.WriteLine("Found SSN No: " & element.Text)
                            ' Add rectangle of the found SSN to Remover
                            remover.AddTextToRemove(pageIndex, element.Bounds)
                        Next
                    Next

                    ' Mask replaced text with black rectangle
                    remover.MaskRemovedText = True
                    ' Change the color of the mask rectangle, if necessary
                    'remover.MaskColor = Color.Red

                    remover.PerformRemoval(outputDocument)

                    Console.WriteLine("Found SSNs removed, result saved to file """ & outputDocument & """")

                End Using
            End Using

            ' Open result file in default associated application (for the demonstration purpose)
            Dim processStartInfo As New ProcessStartInfo(outputDocument) With { .UseShellExecute = true }
            Process.Start(processStartInfo)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key...")
        Console.ReadKey()

    End Sub

End Module
