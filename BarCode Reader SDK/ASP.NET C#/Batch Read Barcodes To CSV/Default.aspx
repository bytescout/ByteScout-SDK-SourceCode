<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ImagePDFBarcodeToCSV.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Scan Image/PDF files for barcode and generate CSV</title>
</head>
<body>
    <form id="form1" runat="server">

        <label>
            This project demonstrates scanning of folder, and processing each image/PDF file for barcode.<br />
            It'll then generates CSV file containing barcodes and downloads it.
        </label>
        <br />
        <br />
        <div>
            <asp:Button ID="btnImagePDFBarcodeToCSV" Text="Scan for Barcode and Generate CSV" runat="server" OnClick="btnImagePDFBarcodeToCSV_Click" />
            <br />
            <br />
            <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
