'*******************************************************************
'       ByteScout SWF To Video SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode. WHY? Because flash is not supported on x64 platform currently at all

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
        converter.InputSWFFileName = "circles.swf"

		' Select 20th frame
		converter.StartFrame = 20
		converter.StopFrame = 20

		' Run conversion
		converter.ConvertToPNG("result.png")

		' Open the result in default application
		Process.Start("result.png")
	End Sub
End Class
