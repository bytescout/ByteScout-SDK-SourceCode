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
Imports System.Xml

Module Module1

    Sub Main()

        ' Create XMLExtractor instance
        Dim extractor As XMLExtractor = New XMLExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile(".\filled_form.pdf")

        ' Get PDF document text as XML
        Dim xmlText As String = extractor.GetXML()

        ' Load XML
        Dim xmlDocument As XmlDocument = New XmlDocument()
        XmlDocument.LoadXml(XmlText)

        ' Select all "control" nodes
        Dim formControls As XmlNodeList = xmlDocument.SelectNodes("//control")
        If (formControls IsNot Nothing) Then

            For Each formControl As XmlNode In formControls

                Dim typeAttribute = formControl.Attributes("type")

                If (typeAttribute.Value = "editbox") Then
                    ' Show filled textboxes
                    If (Not String.IsNullOrEmpty(formControl.InnerText)) Then
                        Console.WriteLine("EDITBOX " + formControl.Attributes("id").Value + ": " + formControl.InnerText)
                    End If
                ElseIf (typeAttribute.Value = "checkbox") Then
                    ' Show checked checkboxes
                    If (formControl.Attributes("state").Value = "1") Then
                        Console.WriteLine("CHECKBOX " + formControl.Attributes("id").Value + ": " + formControl.Attributes("state").Value)
                    End If
                End If

            Next formControl

        End If

        ' Cleanup
        extractor.Dispose()


        Console.WriteLine()
        Console.WriteLine("Press any key...")
        Console.ReadKey()

    End Sub

End Module
