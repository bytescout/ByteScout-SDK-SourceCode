'*******************************************************************
'       ByteScout SWF To Video SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

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

		' Set a value for the variable
		' (!) You should call SetVariable() before SetMovie()
		converter.SetVariable("Variable1", "hi this is passed variable")

		' Enable trasparency - set BEFORE setting input SWF filename
		converter.RGBAMode = True

       	' Set input SWF file
       	converter.InputSWFFileName = "MovieDisplayPassedVar.swf"
	
		' Select first frame
		converter.StartFrame = 0
		converter.StopFrame = 0

		' Run conversion
		converter.ConvertToPNG("result.png")

		' release resources
		System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
		converter = null


		' Open the result in default application
		Process.Start("result.png")
	End Sub
End Class
