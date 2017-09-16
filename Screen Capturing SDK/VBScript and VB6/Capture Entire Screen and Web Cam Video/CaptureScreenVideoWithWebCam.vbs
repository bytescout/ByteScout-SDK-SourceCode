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
capturer.OutputFileName = "ScreenWithWebCamera.wmv"

' set web camera device to add overlaying video to the source

' set webcamera device name or you can set the device by index using .CurrentWebCam property
capturer.CurrentWebCamName = "USB Video Device"

' set rectangle to show overlaying video from webcam into the rectangle 160x120 (starting with left point at 10, 10)
capturer.SetWebCamVideoRectangle 10, 10, 160, 120

' enable webcam overlaying capture device
capturer.AddWebCamVideo = true

' set capturing type to the caScreen =3 to capture the entire screen
capturer.CapturingType = 3

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

' uncomment to set Bytescout Lossless Video format output video compression method
' do not forget to set file to .avi format if you use Video Codec Name
' capturer.CurrentVideoCodecName = "Bytescout Lossless"

MsgBox "This script will record 160x120 video from web camera for 15 seconds. Output video will go to ScreenWithWebCamera.wmv."

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
