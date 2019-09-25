## How to capture given window and stop video on window closed in VBScript and VB6 with ByteScout Screen Capturing SDK

### Tutorial on how to capture given window and stop video on window closed in VBScript and VB6

Capture given window and stop video on window closed is easy to implement in VBScript and VB6 if you use these source codes below. Want to capture given window and stop video on window closed in your VBScript and VB6 app? ByteScout Screen Capturing SDK is designed for it. ByteScout Screen Capturing SDK is the SDK for developers for quick implementation of screen video recording. The SDK records screen into video or into a series of screenshots. Can also record audio. Saves video into AVI,WMV and Google's WebM. Output video quality, size, resolution or framerate can be adjusted easily. Provides additional tools for privacy features like blacking out on scren areas with sensitive information on screen right during recording. Supports web camera as input and can add instant text and images into video output.

VBScript and VB6 code samples for VBScript and VB6 developers help to speed up coding of your application when using ByteScout Screen Capturing SDK. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Test VBScript and VB6 sample code examples whether they respond your needs and requirements for the project.

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

##### ****CaptureGivenWindowAndStopIfWindowClosed.vbs:**
    
```
' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' set output video file name (WMV), you can also set to AVI 
capturer.OutputFileName = "WindowCaptured.wmv"

' set capturing type to the caVisibleWindow=4 (captures from the window) or caWindow=1 (may flicker but captures from non-visible windows as well) 
capturer.CapturingType = 4

MsgBox "This script will record video from Internet Explorer for 60 seconds OR will stop if Window was closed." & vbCRLF  & vbCRLF  & "Please run Internet Explorer and click OK"

capturer.WindowToCapture = "Internet Explorer"

' set width of the output video
capturer.OutputWidth = 640
' set height of the output video
capturer.OutputHeight = 480

' set border type to show around captured area
capturer.CaptureAreaBorderType = 2 ' CaptureAreaBorderType.cabtDashed;

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

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


' count number of seconds actually recorded
SecondsActuallyCaptured = 0

' wait for 60 seconds, checking if window is still available every 1 second
for i=0 to 60 
 WScript.Sleep(1000) ' wait for 1 second
 SecondsActuallyCaptured = SecondsActuallyCaptured + 1
 if Not capturer.WindowToCaptureIsAvailable Then ' check if window to capture is still available
  Exit For ' break if the window to capture from is not available anymore
 End If
Next 

' stop capturing
capturer.Stop()

MsgBox "Recorded " & CStr(SecondsActuallyCaptured) & " second(s)"

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing

```

<!-- code block end -->