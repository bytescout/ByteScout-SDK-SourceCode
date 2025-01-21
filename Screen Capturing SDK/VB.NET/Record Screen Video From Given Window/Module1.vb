'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Threading
Imports System.Diagnostics

Imports BytescoutScreenCapturingLib ' import bytescout screen capturer activex object

' NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
' try to do the following:
' 1) remove the reference to the SDK by View - Solution Explorer
' then click on References, select Bytescout... reference name and right-click it and select Remove
' 2) To re-add click on the menu: Project - Add Reference
' 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
' 4) Select it and click "Add" 
' 5) Recompile the application 
' Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference

Module Module1

    Sub Main()
	' create capturer class
        Dim capturer As New Capturer()
	' set capturing area to the region type (to capture from given region on the screen)
        capturer.CapturingType = CaptureAreaType.catWindow

        ' output video filename
        capturer.OutputFileName = "CaptureGivenWindow.wmv" ' set output video filename to .WMV or .AVI file


        ' set the window to capture from
        MsgBox("Please run Internet Explorer (this sample will capture video from IE) and click OK")

        ' set the title (or name) of the window to capture from
        capturer.WindowToCapture = "Internet Explorer"

        ' set width and height of output video
        capturer.OutputWidth = 640
        capturer.OutputHeight = 480

	' // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
   	' // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
	' capturer.WMVVideoBitrate = capturer.WMVVideoBitrate * 2

        
	' set border style
        capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed

  	' uncomment to set Bytescout Lossless Video format output video compression method
	' do not forget to set file to .avi format if you use Video Codec Name
        ' capturer.CurrentVideoCodecName = "Bytescout Lossless" 
     
	' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
	' capturer.CaptureTransparentControls = true

	' start capturing
        capturer.Run()

	'// IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	'// using Thread.Sleep(1) inside the checking loop, so you have the loop like
	'// Do {
	'// Thread.Sleep(1) 
	'// }
	'// While(StopButtonNotClicked);


        Console.WriteLine("Capturing entire screen for 20 seconds...")

        ' wait for 20 seconds
        Thread.Sleep(20000)

	' stop capturing and flush WMV or AVI video file into the disk
        capturer.Stop()

        ' Release(Resources)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(capturer)
        capturer = Nothing


        Console.WriteLine("Done")

        ' open the output video 
        Process.Start("CaptureGivenWindow.wmv")

    End Sub

End Module
