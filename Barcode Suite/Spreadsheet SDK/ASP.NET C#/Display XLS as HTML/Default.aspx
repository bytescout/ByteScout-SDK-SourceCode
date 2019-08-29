<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DisplayXlsAsHtml._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Width="311px"></asp:Label><br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Select worksheet to display: "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server"
            Width="233px">
        </asp:DropDownList>
        <asp:Button ID="ButtonGo" runat="server" Text="Go" Width="45px" OnClick="ButtonGo_Click" /></div>
    </form>
</body>
</html>
