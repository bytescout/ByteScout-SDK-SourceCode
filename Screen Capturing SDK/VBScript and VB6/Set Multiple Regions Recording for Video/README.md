## How to set multiple regions recording for video in VBScript and VB6 using ByteScout Screen Capturing SDK

### This code in VBScript and VB6 shows how to set multiple regions recording for video with this how to tutorial

With this source code sample you may quickly learn how to set multiple regions recording for video in VBScript and VB6. ByteScout Screen Capturing SDK is the SDK for developers for quick implementation of screen video recording. The SDK records screen into video or into a series of screenshots. Can also record audio. Saves video into AVI,WMV and Google's WebM. Output video quality, size, resolution or framerate can be adjusted easily. Provides additional tools for privacy features like blacking out on scren areas with sensitive information on screen right during recording. Supports web camera as input and can add instant text and images into video output. It can be used to set multiple regions recording for video using VBScript and VB6.

The SDK samples like this one below explain how to quickly make your application do set multiple regions recording for video in VBScript and VB6 with the help of ByteScout Screen Capturing SDK. In order to implement the functionality, you should copy and paste this code for VBScript and VB6 below into your code editor with your app, compile and run your application. Implementing VBScript and VB6 application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

ByteScout Screen Capturing SDK free trial version is available on our website. VBScript and VB6 and other programming languages are supported.

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

##### ****CaptureMultipleRegions.vbs:**
    
```
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

```

<!-- code block end -->