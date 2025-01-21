'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDF

Module Program

    Sub Main()

        Dim PDFSDK_RegName As String = "demo"
        Dim PDFSDK_RegKey As String = "demo"

        Dim templateDoc As New Document With {.RegistrationName = PDFSDK_RegName, .RegistrationKey = PDFSDK_RegKey}
        Dim mainDoc As New Document With {.RegistrationName = PDFSDK_RegName, .RegistrationKey = PDFSDK_RegKey}
        Dim resultDoc As New Document With {.RegistrationName = PDFSDK_RegName, .RegistrationKey = PDFSDK_RegKey}

        templateDoc.Load("./background.pdf")
        mainDoc.Load("./sample.pdf")

        ' Create GraphicsTemplate object from the first page of the template document
        Dim template As GraphicsTemplate
        template = templateDoc.Pages(0).SaveAsTemplate()

        For i = 0 To mainDoc.Pages.Count - 1
            ' Create empty page 
            Dim resultPage As New Page(mainDoc.Pages(i).Width, mainDoc.Pages(i).Height)


            ' Draw the template page as a background before the main content
            resultPage.Canvas.DrawTemplate(template, 0, 0)

            ' Draw main content
            Dim mainContentAsTemplate As GraphicsTemplate = mainDoc.Pages(i).SaveAsTemplate()
            resultPage.Canvas.DrawTemplate(mainContentAsTemplate, 0, 0)

            ' Add the created page to the result document
            resultDoc.Pages.Add(resultPage)
        Next

        ' Save result document
        resultDoc.Save("./result.pdf")

        resultDoc.Dispose()
        templateDoc.Dispose()
        mainDoc.Dispose()

        Console.WriteLine("Result file 'result.pdf' generated!")
        Process.Start("result.pdf")
        Console.ReadLine()

    End Sub

End Module
