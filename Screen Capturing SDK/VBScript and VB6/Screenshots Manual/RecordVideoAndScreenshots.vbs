'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


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
capturer.ScreenshotSavingType = 3 ' take screenshots on mouse click

' set output folder for the screenshots
set fso = CreateObject("Scripting.FileSystemObject")
' directory in which this script is currently running
CurrentDirectory = fso.GetAbsolutePathName(".")
capturer.ScreenshotOutputFolder = CurrentDirectory ' set output folder to the current one

' set image format for the screenshots (png = 0, bmp = 1)
capturer.ScreenshotImageFormat = 0


MsgBox "This script will record 640x480 video from entire screen for 10 seconds. Output video will go to EntireScreenCaptured.wmv"

' run video capturing 
capturer.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked


capturer.TakeScreenshot "screenshot1.png"

' sleep 2 seconds
WScript.sleep (2000)

capturer.TakeScreenshot "screenshot2.png"

' sleep 8 seconds
WScript.sleep (8000)

capturer.TakeScreenshot "screenshot3.png"


' stop capturing
capturer.Stop()

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing
