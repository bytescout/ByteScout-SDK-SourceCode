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


Public Class QrCodeMessageTemplate

#Region "Constructors"

    Public Sub New()
    End Sub

    Public Sub New(ByVal Message As String)
        Me.Message = Message
    End Sub

#End Region


#Region "Properties"

    Public Property Message As String

#End Region

#Region "Overloaded Methods"

    Public Overrides Function ToString() As String

        If String.IsNullOrEmpty(Message) Then Return MyBase.ToString()

        Return Message

    End Function

#End Region


End Class
