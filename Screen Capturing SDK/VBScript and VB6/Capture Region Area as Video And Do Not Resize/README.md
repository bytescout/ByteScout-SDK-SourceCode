## How to capture region area as video and do not resize in VBScript and VB6 and ByteScout Screen Capturing SDK

### This code in VBScript and VB6 shows how to capture region area as video and do not resize with this how to tutorial

On this page you will learn from code samples for programming in VBScript and VB6.Writing of the code to capture region area as video and do not resize in VBScript and VB6 can be done by developers of any level using ByteScout Screen Capturing SDK. Want to capture region area as video and do not resize in your VBScript and VB6 app? ByteScout Screen Capturing SDK is designed for it. ByteScout Screen Capturing SDK is the tool for developers who want to add screen capturing in their application. Can record screen into video and into single screenshots. Output formats are WMV, AVI, WebM for video and PNG for screenshots. You can adjust output video size, quality, resolution, framerate, video and audio codecs. Includes special privacy features for blacking out sensitive information on screen. Can also capture video from web camera, can add overlays with text or images.

The SDK samples like this one below explain how to quickly make your application do capture region area as video and do not resize in VBScript and VB6 with the help of ByteScout Screen Capturing SDK. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Use of ByteScout Screen Capturing SDK in VBScript and VB6 is also explained in the documentation included along with the product.

Free trial version of ByteScout Screen Capturing SDK is available on our website. Documentation and source code samples are included.

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

##### ****CapturePredefinedRegionAndDoNotResize.vbs:**
    
```
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

```

<!-- code block end -->