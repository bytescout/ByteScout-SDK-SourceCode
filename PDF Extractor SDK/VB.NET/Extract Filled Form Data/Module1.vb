'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports Bytescout.PDFExtractor
Imports System.Xml

Module Module1

    Sub Main()

        ' Create XMLExtractor instance
        Dim extractor As XMLExtractor = New XMLExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile(".\interactiveform.pdf")

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
                    ' Trace filled textboxes
                    If (Not String.IsNullOrEmpty(formControl.InnerText)) Then
                        Trace.WriteLine("EDITBOX " + formControl.Attributes("id").Value + ": " + formControl.InnerText)
                    End If
                ElseIf (typeAttribute.Value = "checkbox") Then
                    ' Trace checked checkboxes
                    If (formControl.Attributes("state").Value = "1") Then
                        Trace.WriteLine("CHECKBOX " + formControl.Attributes("id").Value + ": " + formControl.Attributes("state").Value)
                    End If
                End If

            Next formControl

        End If

    End Sub

End Module
