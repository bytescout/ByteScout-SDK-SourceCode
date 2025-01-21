'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

capturer.AudioEnabled = true


' set output video file name to .WEBM 
capturer.OutputFileName = "EntireScreenCaptured.webm" 

' set WEBM/WMV bitrate
capturer.WMVVideoBitrate = 1024*1024*1024

' set capturing type to the caScreen =3 to capture the entire screen
capturer.CapturingType = 3

' output video width
capturer.OutputWidth = 1920

' output video height
capturer.OutputHeight = 1080

' uncomment to set Bytescout Lossless Video format output video compression method
' do not forget to set file to .avi format if you use Video Codec Name
' capturer.CurrentVideoCodecName = "Bytescout Lossless";             

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true


MsgBox "This script will record 640x480 video from entire screen for 15 seconds. Output video will go to EntireScreenCaptured.avi"

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
