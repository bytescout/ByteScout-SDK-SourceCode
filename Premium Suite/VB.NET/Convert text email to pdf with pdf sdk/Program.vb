'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing.Printing
Imports System.Linq
Imports System.Text
Imports Bytescout.PDF
Imports Bytescout.PDF.Converters

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


                Dim oHtmlGenerator As HtmlGenerator = New HtmlGenerator()

                oHtmlGenerator.Title = $"Subject: {msg.Subject}"
                oHtmlGenerator.AddParagraphBodyItem($"File Name: {msg.FileName}")
                oHtmlGenerator.AddParagraphBodyItem($"From: {from}")
                oHtmlGenerator.AddParagraphBodyItem($"Sent On: {(If(sentOn.HasValue, sentOn.Value.ToString("MM/dd/yyyy HH:mm"), ""))}")
                oHtmlGenerator.AddParagraphBodyItem($"To: {recipientsTo}")
                oHtmlGenerator.AddParagraphBodyItem($"Subject: {msg.Subject}")

                If Not String.IsNullOrEmpty(recipientsCc) Then
                    oHtmlGenerator.AddParagraphBodyItem($"CC: {recipientsCc}")
                End If

                If Not String.IsNullOrEmpty(recipientBcc) Then
                    oHtmlGenerator.AddParagraphBodyItem($"BCC: {recipientBcc}")
                End If

                oHtmlGenerator.AddRawBodyItem("<hr/>")
                Dim msgBodySplitted = msg.BodyText.Split(vbLf.ToCharArray())

                For Each itmBody In msgBodySplitted
                    oHtmlGenerator.AddParagraphBodyItem(itmBody)
                Next

                oHtmlGenerator.SaveHtml("result.html")

                Using converter As HtmlToPdfConverter = New HtmlToPdfConverter()
                    converter.PageSize = PaperKind.A4
                    converter.Orientation = Bytescout.PDF.Converters.PaperOrientation.Portrait
                    converter.ConvertHtmlToPdf("result.html", "result.pdf")

                    Dim processStartInfo As ProcessStartInfo = New ProcessStartInfo("result.pdf")
                    processStartInfo.UseShellExecute = True

                    Process.Start(processStartInfo)

                End Using

            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine("Press enter key to exit...")
            Console.ReadLine()
        End Try

    End Sub

    ''' <summary>
    ''' Html Generator class
    ''' </summary>
    Class HtmlGenerator

#Region "Constructors and variable declarations"

        Public Sub New()
            Me.StrBodyItems = New List(Of String)()
        End Sub

        Public Property Title As String
        Private Property StrBodyItems As List(Of String)

#End Region

#Region "Methods"

        ''' <summary>
        ''' Add Body Item
        ''' </summary>
        Public Sub AddRawBodyItem(ByVal strBodyItem As String)
            StrBodyItems.Add(strBodyItem)
        End Sub

        ''' <summary>
        ''' Add Paragraph body item
        ''' </summary>
        Public Sub AddParagraphBodyItem(ByVal strText As String)
            StrBodyItems.Add(String.Format("<p style=''>{0}</p>", strText))
        End Sub

        ''' <summary>
        ''' Gets generated HTML
        ''' </summary>
        Public Function GetHtml() As String
            Dim oRetHtml As StringBuilder = New StringBuilder(String.Empty)
            oRetHtml.Append("<html>")
            oRetHtml.Append("<head>")
            oRetHtml.AppendFormat("<title>{0}</title>", Title)
            oRetHtml.Append("<style>p {
                                    line-height: 107.9 %;
                                    margin-bottom: 13pt;
                                    font-family: 'Arial', 'sans-serif';
                                    font-size: 15pt;
                                    margin-top: 0;
                                    margin-left: 0;
                                    margin-right: 0;
                            }</style>")
            oRetHtml.Append("</head>")
            oRetHtml.Append("<body>")

            For Each itemBody In StrBodyItems
                oRetHtml.Append(itemBody)
            Next

            oRetHtml.Append("</body>")
            oRetHtml.Append("</html>")
            Return oRetHtml.ToString()
        End Function

        ''' <summary>
        ''' Save all HTML
        ''' </summary>
        Public Sub SaveHtml(ByVal fileName As String)
            Dim allHtml = GetHtml()
            System.IO.File.WriteAllText(fileName, allHtml)
        End Sub

#End Region

    End Class

End Module
