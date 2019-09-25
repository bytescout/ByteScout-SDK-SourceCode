## How to capture region into video in VBScript and VB6 using ByteScout Screen Capturing SDK

### Write code in VBScript and VB6 to capture region into video with this step-by-step tutorial

On this page you will learn from code samples for programming in VBScript and VB6.Writing of the code to capture region into video in VBScript and VB6 can be done by developers of any level using ByteScout Screen Capturing SDK. ByteScout Screen Capturing SDK can capture region into video. It can be used from VBScript and VB6. ByteScout Screen Capturing SDK is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video.

VBScript and VB6 code samples for VBScript and VB6 developers help to speed up coding of your application when using ByteScout Screen Capturing SDK. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Enjoy writing a code with ready-to-use sample VBScript and VB6 codes.

Trial version of ByteScout Screen Capturing SDK is available for free. Source code samples are included to help you with your VBScript and VB6 app.

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

##### ****CapturePredefinedRegion.vbs:**
    
```
' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' set output video file name (WMV), you can also set to AVI 
capturer.OutputFileName = "CaptureScreenVbs.wmv" 

' set capturing type to the caRegion =0 to capture the given region
capturer.CapturingType = 0

' set left coordinate of the rectangle to capture from
capturer.CaptureRectLeft = 100
' set top coordinate of the rectangle to capture from
capturer.CaptureRectTop = 100

' set width of the rectangle to capture from
capturer.CaptureRectWidth = 320
' set height of the rectangle to capture from
capturer.CaptureRectHeight = 240

' set width of the output video
capturer.OutputWidth = 640
' set height of the output video
capturer.OutputHeight = 480

' set border type to show around captured area
capturer.CaptureAreaBorderType = 2 ' CaptureAreaBorderType.cabtDashed;


' uncomment to set Bytescout Lossless Video format output video compression method
' do not forget to set file to .avi format if you use Video Codec Name
' capturer.CurrentVideoCodecName = "Bytescout Lossless"

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

MsgBox "This script will record video from the screen from region (100,100, 420, 350) for 15 seconds. Output video will go to PredefinedRegionCaptured.avi"

' run video capturing 
capturer.Run()


' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked

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