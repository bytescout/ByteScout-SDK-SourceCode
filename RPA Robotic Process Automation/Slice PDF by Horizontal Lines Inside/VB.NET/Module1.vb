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


Imports System.Drawing
Imports System.IO
Imports Bytescout.PDFExtractor
Imports Bytescout.PDFRenderer
Imports Bytescout.PDF

''' <summary>
''' The example demonstrates slicing of PDF document pages by horizontal lines.
''' The example uses three products:
''' - PDF Extractor SDK (https://bytescout.com/products/developer/pdfextractorsdk/index.html) -
'''     to detect lines;
''' - PDF Renderer SDK (https://bytescout.com/products/developer/pdfrenderersdk/index.html) -
'''     to render PDF documents to raster images;
''' - PDF SDK (https://bytescout.com/products/developer/pdfsdk/index.html) -
'''     to create new PDF documentsd from sliced images.
''' </summary>
Module Module1

    Dim InputFile = ".\sample.pdf"
    Dim OutputFolder = ".\output"

    Sub Main()

        if Not Directory.Exists(OutputFolder)
            Directory.CreateDirectory(OutputFolder)
        End If

        ' Create LineDetector instance and load document
        Dim lineDetector = new LineDetector("demo", "demo")
        lineDetector.LoadDocumentFromFile(InputFile)

        ' Create RasterRenderer instance and load document
        Dim rasterRenderer = new RasterRenderer("demo", "demo")
        rasterRenderer.LoadDocumentFromFile(InputFile)

        Try
            Dim pageCount = lineDetector.GetPageCount()

            For pageIndex As Integer = 0 To pageCount - 1
                
                Console.WriteLine("Processing page #{0}", pageIndex)

                ' Find horizontal lines on the page
                Dim horzLines = lineDetector.FindLines(pageIndex, LineOrientationsToFind.OnlyHorizontal)
                ' Slice page by separating lines and create new PDF documents
                Slice(pageIndex, horzLines, rasterRenderer)

            Next
        Catch exception As Exception
            Console.WriteLine(exception)
        Finally
            ' Cleanup
            rasterRenderer.Dispose()
            lineDetector.Dispose()
        End Try


        Console.WriteLine()
        Console.WriteLine("Press any key...")
        Console.ReadKey()
        
    End Sub


    Private Sub Slice(pageIndex As Integer, lines As FoundLinesCollection, rasterRenderer As RasterRenderer)
        
        Const pdfRenderingResolution As Single = 300
        Dim lastLineY As Single = Single.NaN
        Dim sliceNum as Integer = 0

        Dim pageRect = rasterRenderer.GetPageRectangle(pageIndex)

        For Each line As FoundLine In lines
            
            If Single.IsNaN(lastLineY)
                lastLineY = line.From.Y
            Else 
                ' Compute slice rectangle
                Dim sliceRect = new RectangleF(0, lastLineY, pageRect.Width, line.From.Y - lastLineY)
                ' Set extraction rectangle for RasterRenderer
                rasterRenderer.SetExtractionArea(sliceRect)
                ' Render the page region to Image object
                Dim slice = rasterRenderer.GetImage(pageIndex, pdfRenderingResolution)

                ' Create PDF document
                Dim document = new Document With {
                    .RegistrationName = "demo",
                    .RegistrationKey = "demo"
                }

                ' Create page of A4 size
                Dim page = new Page(PaperFormat.A4)
                document.Pages.Add(page)

                ' Create PDF Image object from System.Drawing.Image
                Dim pdfImage = new Bytescout.PDF.Image(slice)
                ' Draw image on the page keeping the aspect ratio
                Dim r = new RectangleF(0, 20, page.Width, page.Width / slice.Width * slice.Height)
                page.Canvas.DrawImage(pdfImage, r.Left, r.Top, r.Width, r.Height)

                ' Save PDF document
                sliceNum = sliceNum + 1
                Dim fileName = string.Format("{0}\{1}-page{2}-slice{3}.pdf", OutputFolder, IO.Path.GetFileName(InputFile), pageIndex, sliceNum)
                document.Save(fileName)

                Console.WriteLine("Saved slice '{0}'", fileName)

                ' Cleanup
                document.Dispose()
                slice.Dispose()

                lastLineY = line.From.Y

            End If
        Next

    End Sub
End Module
