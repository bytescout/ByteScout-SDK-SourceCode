## How to capture webcam full screen only in VBScript and VB6 and ByteScout Screen Capturing SDK

### How to capture webcam full screen only in VBScript and VB6

This sample source code below will demonstrate you how to capture webcam full screen only in VBScript and VB6. What is ByteScout Screen Capturing SDK? It is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video. It can help you to capture webcam full screen only in your VBScript and VB6 application.

Fast application programming interfaces of ByteScout Screen Capturing SDK for VBScript and VB6 plus the instruction and the code below will help you quickly learn how to capture webcam full screen only. In order to implement the functionality, you should copy and paste this code for VBScript and VB6 below into your code editor with your app, compile and run your application. You can use these VBScript and VB6 sample examples in one or many applications.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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

##### ****CaptureWebCamOnlyFullScreen.vbs:**
    
```
' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' set output video file name to .WMV or .AVI file
capturer.OutputFileName = "CaptureWebCamOnlyFullScreen.wmv" 

' set capturing type to the catWebcamFullScreen =5 to capture the entire screen
capturer.CapturingType = 5

' output video width
capturer.OutputWidth = 640

' output video height
capturer.OutputHeight = 480

' set to use hardware web cam
capturer.CurrentWebCamName = "USB"

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

MsgBox "This script will record 640x480 video from web camera with 'USB' name for 15 seconds. Output video will go to EntireScreenCaptured.avi"

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

```

<!-- code block end -->