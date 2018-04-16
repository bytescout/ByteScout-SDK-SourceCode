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
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Create BytescoutImageToVideoLib.ImageToVideo object instance
        Dim converter As New ImageToVideo()

        ' Activate the component
        converter.RegistrationName = "demo"
        converter.RegistrationKey = "demo"

        Dim outputVideoFile As String = Path.GetTempPath() + "result.wmv"

        Dim fileEntries As String() = Directory.GetFiles(Server.MapPath("~/App_Data/images/"))

        Dim fileName As String
        For Each fileName In fileEntries

            ' Add images and set the duration for every slide
            Dim slide As Slide
            slide = converter.AddImageFromFileName(fileName)
            slide.Duration = 1000 ' 1000ms = 1s
            slide.InEffect = TransitionEffectType.teZoomIn
            slide.InEffectDuration = 500 ' 0.5 ms

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
        
        ' Show filename of generated file

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
