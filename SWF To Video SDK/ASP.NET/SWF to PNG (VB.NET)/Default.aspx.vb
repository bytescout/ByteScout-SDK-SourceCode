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


' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode. 
Imports System.IO

Imports BytescoutSWFToVideo

Public Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs)
        Dim inputSwfFile As String = Server.MapPath("Shapes.swf")

        ' Create an instance of SWFToVideo ActiveX object
        Dim converter As New SWFToVideo()

        ' Set debug log
        'converter.SetLogFile("log.txt");

        ' Register SWFToVideo
        converter.RegistrationName = "demo"
        converter.RegistrationKey = "demo"

        ' Enable trasparency - set BEFORE calling input SWF filename
        converter.RGBAMode = True

        ' Set input SWF file
        converter.InputSWFFileName = inputSwfFile

        ' you may calculate output video duration using information about the the source swf movie
        ' WARNING #1: this method to calculate the output video duration is not working for movies with dynamic scenes 
        ' and interactive scripts as in these movies it is not possible to calculate the precise duration of the movie 
        ' WARNING #2: you should set the input swf or flv filename (or url) before this calculation

        ' So the movie duration is calculated as the following:
        ' as swf frame count (number of frames in the swf) / movieFPS (frames per second defined in swf)
        ' and then multiplied by 1000 (as we are setting the .ConverstionTimeout in milliseconds)
        ' as the following (uncomment if you want to set the length of the output video to the same as the original swf)
        ' or as the following source code (uncomment to enable):

        ' converter.ConversionTimeout = 1000 * (converter.FrameCount / converter.MovieFPS)


    
        ' Select the frame to extract (20th)
        converter.StartFrame = 20
        converter.StopFrame = 20

        ' Run conversion.
        ' Empty parameter means conversion to binary stream instead of file.
        converter.ConvertToPNG("")

        ' release resources
        System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
        converter = Nothing


        ' Display the extracted image:

        Response.Clear()
        ' Add content type header 
        Response.ContentType = "image/png"
        ' Set the content disposition 
        Response.AddHeader("Content-Disposition", "inline;filename=result.png")

        ' Write the image bytes into the Response output stream 
        Response.BinaryWrite(DirectCast(converter.BinaryImage, Byte()))

        Response.End()
    End Sub
End Class
