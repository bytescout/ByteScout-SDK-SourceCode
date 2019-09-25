## take manual screenshots during video recording in VBScript and VB6 and ByteScout Screen Capturing SDK

### How To: tutorial on take manual screenshots during video recording in VBScript and VB6

Here you may find thousands pre-made source code pieces for easy implementation in your own programming VBScript and VB6 projects. ByteScout Screen Capturing SDK helps with take manual screenshots during video recording in VBScript and VB6. ByteScout Screen Capturing SDK is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video.

VBScript and VB6 code snippet like this for ByteScout Screen Capturing SDK works best when you need to quickly implement take manual screenshots during video recording in your VBScript and VB6 application. To do take manual screenshots during video recording in your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! Use of ByteScout Screen Capturing SDK in VBScript and VB6 is also explained in the documentation included along with the product.

Free trial version of ByteScout Screen Capturing SDK is available on our website. Get it to try other samples for VBScript and VB6.

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

##### ****RecordVideoAndScreenshots.vbs:**
    
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
capturer.ScreenshotSavingType = 3 ' take screenshots on mouse click

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


capturer.TakeScreenshot "screenshot1.png"

' sleep 2 seconds
WScript.sleep (2000)

capturer.TakeScreenshot "screenshot2.png"

' sleep 8 seconds
WScript.sleep (8000)

capturer.TakeScreenshot "screenshot3.png"


' stop capturing
capturer.Stop()

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing

```

<!-- code block end -->