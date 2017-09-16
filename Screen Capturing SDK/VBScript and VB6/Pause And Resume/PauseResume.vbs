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
capturer.OutputFileName = "PauseAndResume.wmv" 

' set capturing type to the caScreen =3 to capture the entire screen
capturer.CapturingType = 3

' set width of the output video
' capturer.OutputWidth = 1280
' set height of the output video
' capturer.OutputHeight = 720

' uncomment to set Bytescout Lossless Video format output video compression method
' do not forget to set file to .avi format if you use Video Codec Name
' capturer.CurrentVideoCodecName = "Bytescout Lossless"

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

MsgBox "This script will record 2 parts video and will merge it automaticaly. Now recording of the first part 3 seconds will start"

' run video capturing 
capturer.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked

' wait for 3 seconds (3000 msec)
WScript.Sleep(3000)

' pause video capturing 
capturer.Pause()

MsgBox "The recording was paused. Click OK to resume the recording for another 3 seconds"

' run recording for another 3 seconds
capturer.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked

' wait for 3 seconds (3000 msec)
WScript.Sleep(3000)

' finally stop capturing, we should get 6 seconds of the video
capturer.Stop()

MsgBox "The recording is done! Final video will be created now"


' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing
