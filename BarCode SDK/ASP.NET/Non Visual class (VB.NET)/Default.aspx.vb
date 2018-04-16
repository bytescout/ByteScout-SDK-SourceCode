'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports System.Drawing.Imaging

Imports Bytescout.BarCode

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        barcode.Symbology = SymbologyType.Code39
        ' Set value
        barcode.Value = "Sample"

        ' Clear http output
        Response.Clear()
        ' Set the content type to PNG
        Response.ContentType = "image/png"
        ' Add content type header
        Response.AddHeader("Content-Type", "image/png")
        ' Set the content disposition
        Response.AddHeader("Content-Disposition", "inline;filename=result.png")

        ' Save image to output stream
        barcode.SaveImage(Response.OutputStream, ImageFormat.Png)

        ' End response
        Response.End()
    End Sub
End Class
