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
capturer.OutputFileName = "GivenWindowCaptured.wmv"

' set capturing type to the caVisibleWindow=4 (captures from the window) or caWindow=1 (may flicker but captures from non-visible windows as well) 
capturer.CapturingType = 4

MsgBox "This script will record video from Internet Explorer for 10 seconds. Please run Internet Explorer and click OK"

capturer.WindowToCapture = "Internet Explorer"

' set width of the output video
capturer.OutputWidth = 640
' set height of the output video
capturer.OutputHeight = 480

' set border type to show around captured area
capturer.CaptureAreaBorderType = 2 ' CaptureAreaBorderType.cabtDashed;

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

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
