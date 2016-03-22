<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="SimpleSlideshow._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Click browse button to upload an image:<br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" Width="255px" />
        <br />
        <br />
        <asp:Button ID="ButtonUpload" runat="server" Text="Upload" Width="90px" />
        <br />
        <br />
        Uploaded images:<br />
        <asp:ListBox ID="ListBoxUploadedImages" runat="server" Height="137px" 
            Width="258px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="ButtonMakeVideo" runat="server" Text="MakeVideo" 
            Width="257px" />
    
    </div>
    </form>
</body>
</html>
