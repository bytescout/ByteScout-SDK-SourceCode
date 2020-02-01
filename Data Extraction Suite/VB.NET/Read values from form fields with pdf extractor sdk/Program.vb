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


Imports System.Xml
Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Try
            ' Create XMLExtractor interface
            Using extractor As New XMLExtractor("demo", "demo")

                ' Load Sample PDF document
                extractor.LoadDocumentFromFile("filled_form.pdf")

                ' Get PDF document text as XML
                Dim xmlText As String = extractor.GetXML

                ' Load XML
                Dim xmlDocument As XmlDocument = New XmlDocument
                xmlDocument.LoadXml(xmlText)

                ' Select all "control" nodes
                Dim formControls As XmlNodeList = xmlDocument.SelectNodes("//control")
                If (Not (formControls) Is Nothing) Then
                    For Each formControl As XmlNode In formControls

                        Dim typeAttribute As XmlAttribute = formControl.Attributes("type")

                        ' Get filled textboxes
                        If (typeAttribute.Value = "editbox") Then
                            If Not String.IsNullOrEmpty(formControl.InnerText) Then
                                Console.WriteLine(("EDITBOX " + (formControl.Attributes("id").Value + (": " + formControl.InnerText))))
                            End If

                        End If

                        ' Get checked checkboxes
                        If (typeAttribute.Value = "checkbox") Then
                            If (formControl.Attributes("state").Value = "1") Then
                                Console.WriteLine(("CHECKBOX " _
                                    + (formControl.Attributes("id").Value + (": " + formControl.Attributes("state").Value))))
                            End If
                        End If

                    Next
                End If
            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()

    End Sub

End Module
