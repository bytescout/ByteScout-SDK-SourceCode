## How to capture entire screen and webcam video in VBScript and VB6 and ByteScout Screen Capturing SDK

### Tutorial on how to capture entire screen and webcam video in VBScript and VB6

ByteScout tutorials are designed to explain the code for both VBScript and VB6 beginners and advanced programmers. ByteScout Screen Capturing SDK can capture entire screen and webcam video. It can be used from VBScript and VB6. ByteScout Screen Capturing SDK is the tool for developers who want to add screen capturing in their application. Can record screen into video and into single screenshots. Output formats are WMV, AVI, WebM for video and PNG for screenshots. You can adjust output video size, quality, resolution, framerate, video and audio codecs. Includes special privacy features for blacking out sensitive information on screen. Can also capture video from web camera, can add overlays with text or images.

The SDK samples like this one below explain how to quickly make your application do capture entire screen and webcam video in VBScript and VB6 with the help of ByteScout Screen Capturing SDK. In order to implement the functionality, you should copy and paste this code for VBScript and VB6 below into your code editor with your app, compile and run your application. Further enhancement of the code will make it more vigorous.

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

##### ****CaptureScreenVideoWithWebCam.vbs:**
    
```
' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' set output video file name (WMV), you can also set to AVI
capturer.OutputFileName = "ScreenWithWebCamera.wmv"

' set web camera device to add overlaying video to the source

' set webcamera device name or you can set the device by index using .CurrentWebCam property
capturer.CurrentWebCamName = "USB Video Device"

' set rectangle to show overlaying video from webcam into the rectangle 160x120 (starting with left point at 10, 10)
capturer.SetWebCamVideoRectangle 10, 10, 160, 120

' enable webcam overlaying capture device
capturer.AddWebCamVideo = true

' set capturing type to the caScreen =3 to capture the entire screen
capturer.CapturingType = 3

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

' uncomment to set Bytescout Lossless Video format output video compression method
' do not forget to set file to .avi format if you use Video Codec Name
' capturer.CurrentVideoCodecName = "Bytescout Lossless"

MsgBox "This script will record 160x120 video from web camera for 15 seconds. Output video will go to ScreenWithWebCamera.wmv."

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

<!-- code block begin -->

##### ****DisplayAllAvailableWebCams.vbs:**
    
```
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

if capturer.WebCamCount > 0 Then
 for i=0 to capturer.WebCamCount-1
  MsgBox "Webcamera device name = " & CStr(i) & ", Name: " & capturer.GetWebCamName (i)
 next
Else
 MsgBox "no web cam installed or plugged to this computer"
End If



Set Capturer = Nothing

```

<!-- code block end -->