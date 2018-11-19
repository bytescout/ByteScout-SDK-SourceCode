'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports System.Linq
Imports Bytescout.PDF

Imports Font = Bytescout.PDF.Font
Imports SolidBrush = Bytescout.PDF.SolidBrush

Module Program

    Sub Main()

        Try

            Console.WriteLine("Please wait while PDF is being created...")

            ' Parse MessageContents using MsgReader Library
            ' MsgReader library can be obtained from: https://github.com/Sicos1977/MSGReader
            Using msg = New MsgReader.Outlook.Storage.Message("TxtSampleEmail.msg")

                ' Get Sender information
                Dim from = msg.GetEmailSender(False, False)

                ' Message sent datetime
                Dim sentOn = msg.SentOn

                ' Recipient To information
                Dim recipientsTo = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.[To], False, False)

                ' Recipient CC information
                Dim recipientsCc = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.Cc, False, False)

                ' Recipient BCC information
                Dim recipientBcc = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.Bcc, False, False)

                ' Message subject
                Dim subject = msg.Subject

                ' Get Message Body
                Dim msgBody = msg.BodyText

                ' Prepare PDF docuemnt
                Using outputDocument As Document = New Document()

                    ' Add registration keys
                    outputDocument.RegistrationName = "demo"
                    outputDocument.RegistrationKey = "demo"

                    ' Add page
                    Dim page As Page = New Page(PaperFormat.A4)
                    outputDocument.Pages.Add(page)

                    ' Default font and brush
                    Dim font As Font = New Font(StandardFonts.Times, 12)
                    Dim brush As Brush = New SolidBrush()

                    ' Add Email contents
                    Dim topMargin As Integer = 0
                    topMargin += 20
                    page.Canvas.DrawString($"File Name: {msg.FileName}", font, brush, 20, topMargin)

                    topMargin += 20
                    page.Canvas.DrawString($"From: {from}", font, brush, 20, topMargin)

                    topMargin += 20
                    page.Canvas.DrawString($"Sent On: {(If(sentOn.HasValue, sentOn.Value.ToString("MM/dd/yyyy HH:mm"), ""))}", font, brush, 20, topMargin)

                    topMargin += 20
                    page.Canvas.DrawString($"To: {recipientsTo}", font, brush, 20, topMargin)

                    If Not String.IsNullOrEmpty(recipientsCc) Then
                        topMargin += 20
                        page.Canvas.DrawString($"CC: {recipientsCc}", font, brush, 20, topMargin)
                    End If

                    If Not String.IsNullOrEmpty(recipientBcc) Then
                        topMargin += 20
                        page.Canvas.DrawString($"BCC: {recipientBcc}", font, brush, 20, topMargin)
                    End If

                    topMargin += 20
                    page.Canvas.DrawString($"Subject: {subject}", font, brush, 20, topMargin)

                    topMargin += 20
                    page.Canvas.DrawString("Message body in next page.", font, brush, 20, topMargin)

                    ' Get string splitted so that it can be fit properly into page canvas.
                    Dim splittedStringList = _GetStringMeasuredAndSplitted(msgBody, font)
                    For Each itmString As String In splittedStringList

                        Dim pageBody As New Page(PaperFormat.A4)
                        pageBody.Canvas.DrawString(itmString, font, brush, 20, 20)

                        ' Add new page
                        outputDocument.Pages.Add(pageBody)
                    Next

                    ' Save output file
                    outputDocument.Save("result.pdf")

                    ' Open output file
                    Process.Start("result.pdf")

                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine("Press enter key to exit...")
            Console.ReadLine()
        End Try

    End Sub

    ''' <summary>
    ''' Gets string measured and splitted properly
    ''' </summary>
    Private Function _GetStringMeasuredAndSplitted(ByVal msgBody As String, ByVal font As Font) As List(Of String)

        Dim lstStringRet As List(Of String) = New List(Of String)()

        Dim oMeasuredString As KeyValuePair(Of String, String) = New KeyValuePair(Of String, String)()

        While Not String.IsNullOrEmpty(msgBody)

            oMeasuredString = _MeasuredString(msgBody, font)

            lstStringRet.Add(oMeasuredString.Key)

            msgBody = oMeasuredString.Value

        End While

        Return lstStringRet

    End Function

    ''' <summary>
    ''' Measure string
    ''' </summary>
    ''' <param name="msgBody"></param>
    ''' <param name="font"></param>
    ''' <returns></returns>
    Private Function _MeasuredString(ByVal msgBody As String, ByVal font As Font) As KeyValuePair(Of String, String)
        Dim pageBody As Page = New Page(PaperFormat.A4)
        Dim msgBodySplitted = msgBody.Split(vbLf.ToCharArray())
        Dim strTemp As String = ""

        For i As Integer = 0 To msgBodySplitted.Length - 1
            Dim sizeF = pageBody.Canvas.MeasureString(strTemp & "" & msgBodySplitted(i), font)

            If sizeF.Height > 800 Then
                Dim lstRetString_Value = String.Join(vbLf, msgBodySplitted.Skip(i))
                Return New KeyValuePair(Of String, String)(strTemp, lstRetString_Value)
            End If

            strTemp += msgBodySplitted(i)
        Next

        Return New KeyValuePair(Of String, String)(msgBody, "")
    End Function


End Module
