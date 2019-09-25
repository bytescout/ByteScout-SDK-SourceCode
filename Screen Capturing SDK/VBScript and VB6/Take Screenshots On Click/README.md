## take screenshots on click in VBScript and VB6 with ByteScout Screen Capturing SDK

### Tutorial: how to do take screenshots on click in VBScript and VB6

Here you may find thousands pre-made source code pieces for easy implementation in your own programming VBScript and VB6 projects. ByteScout Screen Capturing SDK was made to help with take screenshots on click in VBScript and VB6. ByteScout Screen Capturing SDK is the tool for developers who want to add screen capturing in their application. Can record screen into video and into single screenshots. Output formats are WMV, AVI, WebM for video and PNG for screenshots. You can adjust output video size, quality, resolution, framerate, video and audio codecs. Includes special privacy features for blacking out sensitive information on screen. Can also capture video from web camera, can add overlays with text or images.

Fast application programming interfaces of ByteScout Screen Capturing SDK for VBScript and VB6 plus the instruction and the VBScript and VB6 code below will help you quickly learn take screenshots on click. Follow the instruction from the scratch to work and copy and paste code for VBScript and VB6 into your editor. Test VBScript and VB6 sample code examples whether they respond your needs and requirements for the project.

Visit our website provides for free trial version of ByteScout Screen Capturing SDK. Free trial includes lots of source code samples to help you with your VBScript and VB6 project.

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

##### ****CaptureScreenAndTakeScreenshotsOnClick.vbs:**
    
```
' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' set output video file name to .WMV or .AVI file
capturer.OutputFileName = "EntireScreenCaptured.wmv" 

' set capturing type to the caScreen =3 to capture the entire screen
capturer.CapturingType = 3

' output video width
capturer.OutputWidth = 640

' output video height
capturer.OutputHeight = 480

' uncomment to set Bytescout Lossless Video format output video compression method
' do not forget to set file to .avi format if you use Video Codec Name
' capturer.CurrentVideoCodecName = "Bytescout Lossless";             

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true


' set the screenshot saving mode type: 0=none (default), 1=onmouseclick, 2=ontimer, 3=manual (using TakeScreenshot() method only)
capturer.ScreenshotSavingType = 1 ' take screenshots on mouse click

' set output folder for the screenshots
set fso = CreateObject("Scripting.FileSystemObject")
' directory in which this script is currently running
CurrentDirectory = fso.GetAbsolutePathName(".")
capturer.ScreenshotOutputFolder = CurrentDirectory ' set output folder to the current one

' set image format for the screenshots (png = 0, bmp = 1)
capturer.ScreenshotImageFormat = 0


MsgBox "This script will record 640x480 video from entire screen for 10 seconds. Output video will go to EntireScreenCaptured.wmv"

' run video capturing 
capturer.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked


' you may also make manual screenshots
capturer.TakeScreenshot "screenshot1.png"


' wait for 10 seconds (10000 msec)
WScript.Sleep(10000)

' stop capturing
capturer.Stop()

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing

```

<!-- code block end -->