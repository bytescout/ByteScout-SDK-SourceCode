<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebTestSharp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Barcode Reader Tester (C#)</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Click browse button to upload a PDF/TIFF document<br />
            <asp:FileUpload ID="FileUpload1" runat="server" /><br />
            <br />
            Page No. to read barcode from:
        <asp:TextBox ID="txtPageNo" Text="1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="UploadButton"
                Text="Upload file and read barcodes"
                OnClick="UploadButton_Click"
                runat="server"></asp:Button>
            <br />
            <br />
            <asp:Label ID="UploadStatusLabel" Text="" runat="server"></asp:Label>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Visible="False"></asp:ListBox><br />
            <br />
        </div>
    </form>
</body>
</html>
