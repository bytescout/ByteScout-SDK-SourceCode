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
capturer.OutputFileName = "RecordScreenWithLowestFPSAndMinVideoSizeOutput.wmv"

' set WMV video codec to Windows Media Video 9 Screen that gives best quality/size ratio when recording from screen
capturer.CurrentWMVVideoCodecName = "Windows Media Video 9 Screen"
' disable audio so we will have a video only (and the lowest wmv file size as possible: about 20 kb per 1 second, about 70 mb per 1 hour
capturer.AudioEnabled = false 
' set FPS to 0.5 fps (1 frame per every 2 seconds)
' you may also want to set to 1 fps (1 frame per 1 second or higher)
capturer.FPS = 0.50
' set capturing type to the caScreen =3 to capture the entire screen
capturer.CapturingType = 3

' output video width
capturer.OutputWidth = 640
' output video height
capturer.OutputHeight = 480

' add time stamp
capturer.OverlayingRedTextCaption = "Recording: {RUNNINGMIN}:{RUNNINGSEC}:{RUNNINGMSEC} on {CURRENTYEAR}-{CURRENTMONTH}-{CURRENTDAY} at {CURRENTHOUR}:{CURRENTMIN}:{CURRENTSEC}:{CURRENTMSEC}"

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

' run video capturing 
capturer.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked

' wait for 5 sec
WScript.Sleep(5000)

' stop capturing
capturer.Stop()

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing


MsgBox "Done Recording!"
