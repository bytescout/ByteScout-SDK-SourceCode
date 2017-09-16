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
Set capturer1 = CreateObject("BytescoutScreenCapturing.Capturer")
Set capturer2 = CreateObject("BytescoutScreenCapturing.Capturer")

' set output video file name (WMV), you can also set to AVI 
capturer1.OutputFileName = "Region1.wmv" 
capturer2.OutputFileName = "Region2.wmv" 

' set capturing type to the caRegion =0 to capture the given region
capturer1.CapturingType = 0
capturer2.CapturingType = 0

' set left coordinate of the rectangle to capture from
capturer1.CaptureRectLeft = 100
' set top coordinate of the rectangle to capture from
capturer1.CaptureRectTop = 100
' set width of the rectangle to capture from
capturer1.CaptureRectWidth = 320
' set height of the rectangle to capture from
capturer1.CaptureRectHeight = 240


' set left coordinate of the rectangle to capture from
capturer2.CaptureRectLeft = 300
' set top coordinate of the rectangle to capture from
capturer2.CaptureRectTop = 200
' set width of the rectangle to capture from
capturer2.CaptureRectWidth = 320
' set height of the rectangle to capture from
capturer2.CaptureRectHeight = 240


' set width of the output video
capturer1.OutputWidth = 640
' set height of the output video
capturer1.OutputHeight = 480

' set width of the output video
capturer2.OutputWidth = 640
' set height of the output video
capturer2.OutputHeight = 480


' set border type to show around captured area
capturer1.CaptureAreaBorderType = 2 ' CaptureAreaBorderType.cabtDashed

' set border type to show around captured area
capturer2.CaptureAreaBorderType = 1 '  CaptureAreaBorderType.cabtSolid


' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer1.CaptureTransparentControls = true
' capturer2.CaptureTransparentControls = true

MsgBox "This script will record video from 2 regions for 5 seconds. Output video will go to Region1.wmv and Region2.wmv"

' run video capturing 
capturer1.Run()
capturer2.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked


' wait for 5 seconds (5000 msec)
WScript.Sleep(5000)

' stop capturing
capturer1.Stop()
capturer2.Stop()

' destroy Capturer object so the video will be saved into the disk
Set capturer1 = Nothing
Set capturer2 = Nothing
