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

' set output video file name to .WMV 
capturer.OutputFileName = "EntireScreenCapturedHD.wmv" 

' set capturing type to the caScreen =3 to capture the entire screen
capturer.CapturingType = 3

' set bitrate to 10 mb/sec - high bitrate is required for HD video
capturer.WMVVideoBitrate  = 1024*1024*10

' output video width and height to HD video size 1920x1080
capturer.OutputWidth = 1920
capturer.OutputHeight = 1080

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

MsgBox "This script will record 1920x1080 video from entire screen for 15 seconds. Output video will go to EntireScreenCapturedHD.wmv"

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

MsgBox "Ready! Check EntireScreenCapturedHD.wmv"
