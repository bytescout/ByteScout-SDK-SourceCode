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

' set output video file name (WMV), you can also set to AVI 
capturer.OutputFileName = "GivenWindowCaptured-FlashPlayerControl.avi"

' set capturing type to the caWindow =1 to capture the given window
capturer.CapturingType = 1

MsgBox "This script will record video from Flash Player control in Internet Explorer or another browser for 15 seconds. Please run Internet Explorer and open any web-site with flash player (for example, YouTube.com) and click OK"

' set log file name
capturer.SetLogFile "log-control.txt"

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

' set window class to capture from flash player activex control 
capturer.WindowClassToCapture = "MacromediaFlashPlayerActiveX "

' uncomment to capture semitransparent controls as well
'capturer.CaptureTransparentControls = true


' set width of the output video
capturer.OutputWidth = 640

' set height of the output video
capturer.OutputHeight = 480

' uncomment to set another output video compression method, Bytescout Lossless, DivX or MJPEG (if installed)
' you can use lossless video format, Bytescout Lossless Video Codec
' capturer.CurrentVideoCodecName = "Bytescout Lossless"

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

MsgBox "Done"
