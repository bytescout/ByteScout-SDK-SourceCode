'*******************************************************************
'       ByteScout SWF To Video SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode

Imports BytescoutSWFToVideo

Module Module1

    Sub Main()

        ' Create an instance of SWFToVideo ActiveX object
        Dim converter As New SWFToVideo()

        ' Set debug log
        'converter.SetLogFile("log.txt")

        ' Register SWFToVideo
        converter.RegistrationName = "demo"
        converter.RegistrationKey = "demo"

        ' Set input SWF file
        converter.InputSWFFileName = "SlideShowWithEffects.swf"
	
		' Set output video file
		converter.OutputVideoFileName = "result.avi"

        ' Set background music
        converter.ExternalAudioTrackFromFileName = "bgmusic.mp3"
        ' Set output audio codec
        converter.CurrentAudioCodecName = "ADPCM"

        ' Set output movie dimensions
        converter.OutputWidth = 640
        converter.OutputHeight = 480

        ' Run conversion
        converter.RunAndWait()

	' release resources
	System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
	converter = null


        ' Open the result movie in default media player
        Process.Start("result.avi")

    End Sub

End Module
