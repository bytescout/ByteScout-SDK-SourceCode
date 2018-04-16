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


' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode

Imports System.Diagnostics
Imports BytescoutSWFToVideo

Class Program
	Friend Shared Sub Main(args As String())
		' Create an instance of SWFToVideo ActiveX object
		Dim converter As New SWFToVideo()

		' Set debug log
		'converter.SetLogFile("log.txt");

		' Register SWFToVideo
		converter.RegistrationName = "demo"
		converter.RegistrationKey = "demo"

		' Set the converter to the live data conversion mode
		' (it will fully load the embedded video stream before the conversion)
		converter.SWFConversionMode = SWFConversionModeType.SWFWithLiveData

		' Set input SWF file
		converter.InputSWFFileName = "http://bytescout.com/demo/swfscout_VideoSample.swf"

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

	
		' Set output video file
		converter.OutputVideoFileName = "output.avi"

		' Don't let it run infinitely
		converter.ConversionTimeOut = 3000 ' 3000ms = 3 seconds 

		' set FPS 
		converter.FPS = 29.97F

		' Set output movie dimensions 
		converter.OutputWidth = 320
		converter.OutputHeight = 240

		' Run conversion 
		converter.RunAndWait()

		' release resources
		System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
		converter = Nothing


		' Open the result in default media player
		Process.Start("output.avi")
	End Sub
End Class
