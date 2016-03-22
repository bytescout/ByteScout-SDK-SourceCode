<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="VBWebImageTester._Default" %>

<%@ Register Assembly="Bytescout.BarCode" Namespace="Bytescout.BarCode" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:BarcodeWebImage id="BarcodeWebImage1" runat="server" RenderingHint="SystemDefault" SmoothingMode="Default" Value="DATA" ForeColor="Black" HorizontalAlignment="Right" Angle="Degrees0" CaptionPosition="Below" NarrowBarWidth="3" VerticalAlignment="Top" AddChecksum="False" AddChecksumToCaption="False" AdditionalCaptionPosition="Above" AdditionalCaptionFont="Arial, 13pt" BackColor="White" BarHeight="50" CaptionFont="Arial, 13pt" DrawCaption="True" WideToNarrowRatio="3" Symbology="Code128" AdditionalCaption=" "></cc1:BarcodeWebImage><br />
    
        <br />
        If you are using web control in new application you do need to modify the <strong>Web.config
        </strong>file in your application's virtual directory (or C:\Inetpub\wwwroot\ if
        you don't have a separate application), by adding:<br />
        <p>
        </p>
        <div class="code">
            <span codelanguage="other"><em>&lt;httpHandlers&gt;<br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &lt;add verb="*" path="BarcodeHandler.aspx"
                type="Bytescout.BarCode.BarcodeHandler, Bytescout.BarCode"/&gt;<br />
                &lt;/httpHandlers&gt;</em><br />
                <br />
                inside <strong>&lt;system.web&gt;</strong> section in Web.config</span></div>
    

    </div>
    </form>
</body>
</html>
