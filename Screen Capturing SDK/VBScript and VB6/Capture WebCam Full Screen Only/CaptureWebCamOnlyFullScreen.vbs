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
capturer.OutputFileName = "CaptureWebCamOnlyFullScreen.wmv" 

' set capturing type to the catWebcamFullScreen =5 to capture the entire screen
capturer.CapturingType = 5

' output video width
capturer.OutputWidth = 640

' output video height
capturer.OutputHeight = 480

' set to use hardware web cam
capturer.CurrentWebCamName = "USB"

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

MsgBox "This script will record 640x480 video from web camera with 'USB' name for 15 seconds. Output video will go to EntireScreenCaptured.avi"

' run video capturing 
capturer.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked

' wait for 15 seconds (15000 msec)
WScript.Sleep(15000)

' stop capturing
capturer.Stop()

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing
