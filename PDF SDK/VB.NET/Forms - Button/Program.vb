'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to create a button and decorate it.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
        ' Add page
        Dim page = New Page(PaperFormat.A4)
        pdfDocument.Pages.Add(page)

        ' Create a button
        Dim button = New PushButton(50, 50, 100, 30, "button1")
        button.Caption = "Button"
        ' Decorate the button with various styles
        button.BackgroundColor = New ColorRGB(192, 192, 255)
        button.BorderWidth = 2
        button.BorderStyle = BorderStyle.Beveled
        button.BorderColor = New ColorRGB(0, 0, 128)
        button.Font = New Font(StandardFonts.Times, 16)
        button.FontColor = New ColorRGB(0, 0, 0)
        button.HighlightingMode = PushButtonHighlightingMode.Outline

        ' Add button to the page
        page.Annotations.Add(button)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
