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
capturer.OutputFileName = "output.wmv" 

' set capturing type to the caScreen =3 to capture the entire screen
capturer.CapturingType = 3

' output video width
capturer.OutputWidth = 640

' output video height
capturer.OutputHeight = 480

' set border type to show around captured area
capturer.CaptureAreaBorderType = 2 ' CaptureAreaBorderType.cabtDashed;

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

MsgBox "This script will record entire screen for 5 seconds. From 1st to 5 seconds some areas will be blackouted"

' run video capturing 
capturer.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked


' wait for 1 second (1000 msec)
WScript.Sleep(1000)

capturer.BlackoutAddArea 20,100,500,80
capturer.BlackoutAddArea 10,200,550,80
capturer.BlackoutAddArea 20,400,550,120

' record for 5 seconds more
WScript.Sleep(5000)

' reset all blackouts
capturer.BlackoutReset

' record 1 second more
WScript.Sleep(1000)

' stop capturing
capturer.Stop()

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing
