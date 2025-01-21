'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' set output video file name to .WMV or .AVI file
capturer.OutputFileName = "EntireScreenCaptured.wmv" 

' set capturing type to the caScreen =3 to capture the entire screen
capturer.CapturingType = 3

' output video width
capturer.OutputWidth = 640

' output video height
capturer.OutputHeight = 480

' uncomment to set Bytescout Lossless Video format output video compression method
' do not forget to set file to .avi format if you use Video Codec Name
' capturer.CurrentVideoCodecName = "Bytescout Lossless";             

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true


' set the screenshot saving mode type: 0=none (default), 1=onmouseclick, 2=ontimer, 3=manual (using TakeScreenshot() method only)
capturer.ScreenshotSavingType = 2
' set output folder for the screenshots

set fso = CreateObject("Scripting.FileSystemObject")
' directory in which this script is currently running
CurrentDirectory = fso.GetAbsolutePathName(".")

capturer.ScreenshotOutputFolder = CurrentDirectory ' set output folder to the current one
' set image format for the screenshots (png = 0, bmp = 1)
capturer.ScreenshotImageFormat = 0
' set timer period for taking screenshots, in ms
capturer.ScreenshotTimerPeriod = 1000 ' set the timer for 1 second


MsgBox "This script will record 640x480 video from entire screen for 15 seconds. Output video will go to EntireScreenCaptured.avi"

' run video capturing 
capturer.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked


' wait for 15 seconds (15000 msec)
WScript.Sleep(15000)

' you may also make manual screenshots
capturer.TakeScreenshot "screenshot1.png"


' stop capturing
capturer.Stop()

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing
