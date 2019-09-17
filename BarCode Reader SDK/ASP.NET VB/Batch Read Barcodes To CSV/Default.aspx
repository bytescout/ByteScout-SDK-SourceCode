<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="SimpleWebTestVB._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Scan Image/PDF files for barcode and generate CSV (VB)</title>
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
            <asp:Button ID="btnImagePDFBarcodeToCSV" Text="Scan for Barcode and Generate CSV" runat="server" />
            <br />
            <br />
            <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
