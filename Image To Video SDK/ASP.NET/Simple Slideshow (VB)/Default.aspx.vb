'*******************************************************************
'       ByteScout Image To Video SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.IO
Imports BytescoutImageToVideo

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' These test files will be copied to the project directory on the pre-build event (see the project properties).
        Dim file1 As String = Server.MapPath("slide1.jpg")
        Dim file2 As String = Server.MapPath("slide2.jpg")
        Dim file3 As String = Server.MapPath("slide3.jpg")

        Dim outputVideoFile As String = Path.GetTempPath() + "result.wmv"

        ' Create BytescoutImageToVideoLib.ImageToVideo object instance
        Dim converter As New ImageToVideo()

        ' Activate the component
        converter.RegistrationName = "demo"
        converter.RegistrationKey = "demo"

        ' Add images and set the duration for every slide
        Dim slide As Slide
        slide = converter.AddImageFromFileName(file1)
        slide.Duration = 3000 ' 3000ms = 3s
        slide = converter.AddImageFromFileName(file2)
        slide.Duration = 3000
        slide = converter.AddImageFromFileName(file3)
        slide.Duration = 3000

        ' Set output video size
        converter.OutputWidth = 400
        converter.OutputHeight = 300

        ' Set output video file name
        converter.OutputVideoFileName = outputVideoFile

        ' Run the conversion
        converter.RunAndWait()

	' Release resources
	System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
	converter = null


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
