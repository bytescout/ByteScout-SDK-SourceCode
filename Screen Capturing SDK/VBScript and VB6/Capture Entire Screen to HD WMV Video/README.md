## How to capture entire screen to HD WMV video in VBScript and VB6 using ByteScout Screen Capturing SDK

### The tutorial below will demonstrate how to capture entire screen to HD WMV video in VBScript and VB6

Capture entire screen to HD WMV video is easy to implement in VBScript and VB6 if you use these source codes below. What is ByteScout Screen Capturing SDK? It is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video. It can help you to capture entire screen to HD WMV video in your VBScript and VB6 application.

You will save a lot of time on writing and testing code as you may just take the VBScript and VB6 code from ByteScout Screen Capturing SDK for capture entire screen to HD WMV video below and use it in your application. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Use of ByteScout Screen Capturing SDK in VBScript and VB6 is also explained in the documentation included along with the product.

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

##### ****CaptureScreenToHDWMV.vbs:**
    
```
' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' set output video file name to .WMV 
capturer.OutputFileName = "EntireScreenCapturedHD.wmv" 

' set capturing type to the caScreen =3 to capture the entire screen
capturer.CapturingType = 3

' set bitrate to 10 mb/sec - high bitrate is required for HD video
capturer.WMVVideoBitrate  = 1024*1024*10

' output video width and height to HD video size 1920x1080
capturer.OutputWidth = 1920
capturer.OutputHeight = 1080

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

MsgBox "This script will record 1920x1080 video from entire screen for 15 seconds. Output video will go to EntireScreenCapturedHD.wmv"

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

MsgBox "Ready! Check EntireScreenCapturedHD.wmv"

```

<!-- code block end -->