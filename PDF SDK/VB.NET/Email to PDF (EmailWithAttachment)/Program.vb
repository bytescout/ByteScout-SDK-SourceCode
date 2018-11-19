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


Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports Bytescout.PDF
Imports Bytescout.PDF.Converters

Imports Font = Bytescout.PDF.Font
Imports SolidBrush = Bytescout.PDF.SolidBrush

Module Program

    Sub Main()

        Try
            ' Parse MessageContents using MsgReader Library
            ' MsgReader library can be obtained from: https://github.com/Sicos1977/MSGReader
            Using msg = New MsgReader.Outlook.Storage.Message("EmailWithAttachments.msg")

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
                Dim msgBody = msg.BodyHtml

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

                    Using converter As HtmlToPdfConverter = New HtmlToPdfConverter()
                        converter.PageSize = PaperKind.A4
                        converter.Orientation = Bytescout.PDF.Converters.PaperOrientation.Portrait

                        ' Get all inline attachment, and replace them
                        For Each itmAttachment As MsgReader.Outlook.Storage.Attachment In msg.Attachments

                            If itmAttachment.IsInline Then
                                Dim oData = itmAttachment.Data
                                Dim dataBase64 = Convert.ToBase64String(oData)

                                ' Replace within email
                                msgBody = msgBody.Replace($"src=""{itmAttachment.FileName}""", $"src=""data:image/jpeg;base64,{dataBase64}""")
                            End If
                        Next

                        ' Convert input HTML to stream
                        Dim byteArrayBody As Byte() = Encoding.UTF8.GetBytes(msgBody)
                        Dim inputStream As MemoryStream = New MemoryStream(byteArrayBody)

                        ' Create output stream to store generated PDF file
                        Using outputStream = New MemoryStream()

                            ' Convert HTML to PDF
                            converter.ConvertHtmlToPdf(inputStream, outputStream)

                            ' Create new document from generated output stream
                            Dim docContent As Document = New Document(outputStream)

                            ' Append all pages to main PDF
                            For Each item As Page In docContent.Pages
                                outputDocument.Pages.Add(item)
                            Next

                            ' Apped all other attachments
                            For Each itmAttachment As MsgReader.Outlook.Storage.Attachment In msg.Attachments

                                If Not itmAttachment.IsInline Then
                                    ' Attachment is image, so adding accordingly
                                    Dim pageAttachment = New Page(PaperFormat.A4)
                                    Dim canvas As Canvas = pageAttachment.Canvas

                                    Dim oAttachmentStream = New MemoryStream(itmAttachment.Data)
                                    Dim imageAttachment As Image = New Image(oAttachmentStream)

                                    canvas.DrawImage(imageAttachment, 20, 20)

                                    ' Add attachment
                                    outputDocument.Pages.Add(pageAttachment)
                                End If
                            Next
                            ' Save output file
                            outputDocument.Save("result.pdf")
                        End Using
                    End Using

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

End Module
