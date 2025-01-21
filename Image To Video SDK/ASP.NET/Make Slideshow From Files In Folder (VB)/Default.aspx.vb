'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.IO
Imports BytescoutImageToVideo

Partial Public Class _Default
    Inherits System.Web.UI.Page

    ' IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

    ' Temporary folder access is required for web application when you use ByteScout SDK in it.
    ' If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

    ' SOLUTION:

    ' If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

    ' If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

    ' In this case
    ' - check the User or User Group your web application is running under
    ' - then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
    ' - restart your web application and try again


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub ButtonPerformSlideShow_Click(sender As Object, e As EventArgs) Handles ButtonPerformSlideShow.Click

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
