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
capturer.OutputFileName = "RegionAroundMouseCaptured.wmv" 

' set capturing type to the caMouse =2 to capture the region around the mouse curosr. You can also set to caRegion = 0 (to record from the given rectangle on screen) or to caScreen = 3 (to capture entire screen)
capturer.CapturingType = 2

' set width of the rectangle to capture from
capturer.CaptureRectWidth = 640
' set height of the rectangle to capture from
capturer.CaptureRectHeight = 480

' set width of the output video
capturer.OutputWidth = 640
' set height of the output video
capturer.OutputHeight = 480

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

' set border type to show around captured area
capturer.CaptureAreaBorderType = 2 ' CaptureAreaBorderType.cabtDashed;

' uncomment to set Bytescout Lossless Video format output video compression method
' do not forget to set file to .avi format if you use Video Codec Name
' capturer.CurrentVideoCodecName = "Bytescout Lossless"

MsgBox "Script will record 640x480 region around the mouse cursor for 10 seconds. Output video will go to CaptureScreenVbs.avi"

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
