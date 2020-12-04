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


Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to all PDF form fields programmatically.
''' </summary>
Class Program

    Shared Sub Main()

        ' Load PDF form
        Dim document = New Document("sample.pdf")
        document.RegistrationName = "demo"
        document.RegistrationKey = "demo"

        Dim formFields As New List(Of FormFieldInfo)

        ' Loop through all pages
        For i = 0 To document.Pages.Count - 1

            Dim page = document.Pages(i)

            ' Loop through all annotations
            For Each annotation In page.Annotations

                If TypeOf annotation Is EditBox Or TypeOf annotation Is ComboBox Or TypeOf annotation Is CheckBox Or TypeOf annotation Is RadioButton Then

                    ' Get form field info
                    Dim fieldInfo As New FormFieldInfo()
                    fieldInfo.Type = annotation.Type.ToString()
                    fieldInfo.FieldName = CType(annotation, Field).Name
                    fieldInfo.PageIndex = i
                    fieldInfo.Left = CType(annotation, Field).Left
                    fieldInfo.Top = CType(annotation, Field).Top
                    fieldInfo.Width = CType(annotation, Field).Width
                    fieldInfo.Height = CType(annotation, Field).Height

                    ' Get form field value
                    Select Case annotation.Type
                        Case AnnotationType.EditBox
                            fieldInfo.Value = CType(annotation, EditBox).Text
                        Case AnnotationType.ComboBox
                            fieldInfo.Value = CType(annotation, ComboBox).Text
                        Case AnnotationType.CheckBox
                            fieldInfo.Value = CType(annotation, CheckBox).Checked.ToString()
                        Case AnnotationType.RadioButton
                            fieldInfo.Value = CType(annotation, RadioButton).Checked.ToString()
                    End Select

                    formFields.Add(fieldInfo)

                End If

            Next

        Next

        ' Cleanup 
        document.Dispose()

        ' Display Form Data
        DisplayData(formFields)

        Console.ReadLine()

    End Sub

    ''' <summary>
    ''' Display data to console
    ''' </summary>
    Shared Sub DisplayData(ByVal formFieldInfos As List(Of FormFieldInfo))
        If Not formFieldInfos Is Nothing And formFieldInfos.Count > 0 Then
            For Each item In formFieldInfos
                Console.WriteLine($"Type: {item.Type}{Environment.NewLine}FieldName: {item.FieldName}{Environment.NewLine}Value: {item.Value}{Environment.NewLine}Page Index: {item.PageIndex}{Environment.NewLine}Left: {item.Left}, Top: {item.Top}, Width: {item.Width}, Height: {item.Height}")
                Console.WriteLine()
            Next
        End If
    End Sub

End Class

Class FormFieldInfo

    Public Property Type As String
    Public Property FieldName As String
    Public Property Value As String

    Public Property PageIndex As Int32

    Public Property Left As Single
    Public Property Top As Single
    Public Property Width As Single
    Public Property Height As Single

End Class
