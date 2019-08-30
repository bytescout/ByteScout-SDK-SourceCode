<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PDFSDKSamples.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PDF SDK Samples</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;">
            <div style="font-size: 20px; text-decoration: underline;">
                <br /> This page demostrates Byscout PDF SDK, by perfomring following PDF related operations.<br /> <br /><br />
            </div>

            <div>
                <asp:Button ID="btnPDFConversionFromHtml" runat="server" Text="1. Html to PDF conversion" Width="360px" OnClick="btnPDFConversionFromHtml_Click" />
                &nbsp;&nbsp;<asp:Label ID="lblPDFConversationFromHTML" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnTableCreation" runat="server" Text="2. Table Creation" Width="360px" OnClick="btnTableCreation_Click" />
                &nbsp;&nbsp;<asp:Label ID="lblTableCreation" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnSplitPDF" runat="server" Text="3. Splitting PDF" Width="360px" OnClick="btnSplitPDF_Click" />
                &nbsp;&nbsp;<asp:Label ID="lblSplitPDF" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnMergePDF" runat="server" Text="4. Merging PDF" Width="360px" OnClick="btnMergePDF_Click" />
                &nbsp;&nbsp;<asp:Label ID="lblMergePDF" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnProtectingPDF" runat="server" Text="5. Protecting PDF (password=password1)" Width="360px" OnClick="btnProtectingPDF_Click" />
                &nbsp;&nbsp;<asp:Label ID="lblProtectingPDF" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
