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


Imports System.IO
Imports BytescoutImageToVideo

Partial Public Class _Default
    Inherits Page

    Dim uploadPath As String = "\uploads\"
    Dim outputPath As String = "\output\"

    Protected Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click

        If FileUpload1.HasFile Then
            Dim fileName As String = FileUpload1.FileName
            uploadPath += fileName
            FileUpload1.SaveAs(Server.MapPath(uploadPath))
            ListBoxUploadedImages.Items.Add(FileUpload1.FileName)
        End If

    End Sub

    Protected Sub ButtonMakeVideo_Click(sender As Object, e As EventArgs) Handles ButtonMakeVideo.Click
               
        ' Create BytescoutImageToVideoLib.ImageToVideo object instance
        Dim converter As New ImageToVideo()

        ' Activate the component
        converter.RegistrationName = "demo"
        converter.RegistrationKey = "demo"

        Dim outputVideoFile As String = Server.MapPath(outputPath + "result.wmv")

        ' Add images to converter and set the duration for every slide
        For Each item As ListItem In ListBoxUploadedImages.Items
            Dim fileName As String = item.Value
            Dim slide As Slide
            slide = converter.AddImageFromFileName(Server.MapPath(uploadPath + fileName))
            slide.Duration = 2000 ' 2000ms = 2s
        Next

        ' Set output video size
        converter.OutputWidth = 640
        converter.OutputHeight = 480

        ' Set output video file name
        converter.OutputVideoFileName = outputVideoFile

        ' Run the conversion
        converter.RunAndWait()

        ' Release resources
        System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
        converter = Nothing

        ' Show filename of result file
        Response.Clear()
        Response.ContentType = "text/html"

        If File.Exists(outputVideoFile) Then
            Response.Write("Result video file:  <b>" + outputVideoFile + "</b>")
        Else
            Response.Write("Conversion failed. Error information: " + converter.LastError)
        End If

        Response.End()

    End Sub

End Class
