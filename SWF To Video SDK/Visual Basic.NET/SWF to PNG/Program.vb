'*******************************************************************
'       ByteScout SWF To Video SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode. 

Imports System.Diagnostics
Imports BytescoutSWFToVideo

Class Program
	Friend Shared Sub Main(args As String())
		' Create an instance of SWFToVideo ActiveX object
		Dim z As New SWFToVideo()
		Dim converter As New SWFToVideo()

		' Set debug log
		'converter.SetLogFile("log.txt");

		' Register SWFToVideo
		converter.RegistrationName = "demo"
		converter.RegistrationKey = "demo"


		' Enable trasparency - set BEFORE setting input SWF filename
		converter.RGBAMode = True

	       	' Set input SWF file
       		converter.InputSWFFileName = "Shapes.swf"

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



		' Select 20th frame
		converter.StartFrame = 20
		converter.StopFrame = 20

		' Run conversion
		converter.ConvertToPNG("result.png")

		' release resources
		System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
		converter = null


		' Open the result in default application
		Process.Start("result.png")
	End Sub
End Class
