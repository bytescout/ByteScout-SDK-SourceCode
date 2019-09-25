## How to capture video from flashplayer control in browser in VBScript and VB6 with ByteScout Screen Capturing SDK

### Write code in VBScript and VB6 to capture video from flashplayer control in browser with this step-by-step tutorial

Learn how to capture video from flashplayer control in browser in VBScript and VB6 with this source code sample. ByteScout Screen Capturing SDK is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video. It can be used to capture video from flashplayer control in browser using VBScript and VB6.

You will save a lot of time on writing and testing code as you may just take the VBScript and VB6 code from ByteScout Screen Capturing SDK for capture video from flashplayer control in browser below and use it in your application. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. This basic programming language sample code for VBScript and VB6 will do the whole work for you to capture video from flashplayer control in browser.

You can download free trial version of ByteScout Screen Capturing SDK from our website to see and try many others source code samples for VBScript and VB6.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Screen%20Capturing%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Screen%20Capturing%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=fujkvtWUVCw](https://www.youtube.com/watch?v=fujkvtWUVCw)




<!-- code block begin -->

##### ****CaptureGivenWindow-FlashPlayerControl.vbs:**
    
```
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

```

<!-- code block end -->