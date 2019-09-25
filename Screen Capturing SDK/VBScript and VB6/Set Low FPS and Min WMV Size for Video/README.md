## How to set low FPS and min WMV size for video in VBScript and VB6 using ByteScout Screen Capturing SDK

### Write code in VBScript and VB6 to set low FPS and min WMV size for video with this step-by-step tutorial

The documentation is designed to help you to implement the features on your side. What is ByteScout Screen Capturing SDK? It is the tool for developers who want to add screen capturing in their application. Can record screen into video and into single screenshots. Output formats are WMV, AVI, WebM for video and PNG for screenshots. You can adjust output video size, quality, resolution, framerate, video and audio codecs. Includes special privacy features for blacking out sensitive information on screen. Can also capture video from web camera, can add overlays with text or images. It can help you to set low FPS and min WMV size for video in your VBScript and VB6 application.

This rich sample source code in VBScript and VB6 for ByteScout Screen Capturing SDK includes the number of functions and options you should do calling the API to set low FPS and min WMV size for video. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Further enhancement of the code will make it more vigorous.

Our website provides trial version of ByteScout Screen Capturing SDK for free. It also includes documentation and source code samples.

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

##### ****RecordScreenWithLowestFPSAndMinVideoSizeOutput.vbs:**
    
```
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

```

<!-- code block end -->