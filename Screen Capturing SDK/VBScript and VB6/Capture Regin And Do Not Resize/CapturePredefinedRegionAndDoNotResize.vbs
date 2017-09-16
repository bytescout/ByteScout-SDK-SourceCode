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
capturer.OutputFileName = "CaptureScreenVbs.wmv" 

' set capturing type to the caRegion =0 to capture the given region
capturer.CapturingType = 0


' set left coordinate of the rectangle to capture from
capturer.CaptureRectLeft = 10
' set top coordinate of the rectangle to capture from
capturer.CaptureRectTop = 100

' set width of the rectangle to capture from
capturer.CaptureRectWidth = 720
' set height of the rectangle to capture from
capturer.CaptureRectHeight = 200

' the code below is commented as output width and height will be set automatically by MatchOutputSizeToTheSourceSize = true from the source region's width and height
' set width of the output video
' capturer.OutputWidth = 640
' set height of the output video
' capturer.OutputHeight = 480

' sets the output width and height of the video to the source region size
' IMPORTANT: some width and height combinations may fail with the video due to video codecs limitations on supporting different width and height 
' so in our case output video will be 720x200 (the same size as the capture region)
' this option is turned OFF by default (captured video is resied to .OutputWidth and .OutputHeight size)
capturer.MatchOutputSizeToTheSourceSize = true

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

' set border type to show around captured area
capturer.CaptureAreaBorderType = 2 ' CaptureAreaBorderType.cabtDashed;


' uncomment to set Bytescout Lossless Video format output video compression method
' do not forget to set file to .avi format if you use Video Codec Name
' capturer.CurrentVideoCodecName = "Bytescout Lossless"


MsgBox "This script will record video from the screen from region (100,100, 420, 350) for 15 seconds. Output video will go to PredefinedRegionCaptured.avi"

' run video capturing 
capturer.Run()


' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked

' wait for 15 seconds (15000 msec)
WScript.Sleep(3000)

' stop capturing
capturer.Stop()

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing
