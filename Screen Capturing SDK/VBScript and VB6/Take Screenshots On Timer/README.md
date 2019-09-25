## take screenshots on timer in VBScript and VB6 and ByteScout Screen Capturing SDK

### Tutorial: how to do take screenshots on timer in VBScript and VB6

Writing of the code to take screenshots on timer in VBScript and VB6 can be done by developers of any level using ByteScout Screen Capturing SDK. ByteScout Screen Capturing SDK was made to help with take screenshots on timer in VBScript and VB6. ByteScout Screen Capturing SDK is the SDK for developers for quick implementation of screen video recording. The SDK records screen into video or into a series of screenshots. Can also record audio. Saves video into AVI,WMV and Google's WebM. Output video quality, size, resolution or framerate can be adjusted easily. Provides additional tools for privacy features like blacking out on scren areas with sensitive information on screen right during recording. Supports web camera as input and can add instant text and images into video output.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. To do take screenshots on timer in your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! VBScript and VB6 application implementation typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

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

##### ****CaptureScreenAndTakeScreenshotsOnTimer.vbs:**
    
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
capturer.ScreenshotSavingType = 2
' set output folder for the screenshots

set fso = CreateObject("Scripting.FileSystemObject")
' directory in which this script is currently running
CurrentDirectory = fso.GetAbsolutePathName(".")

capturer.ScreenshotOutputFolder = CurrentDirectory ' set output folder to the current one
' set image format for the screenshots (png = 0, bmp = 1)
capturer.ScreenshotImageFormat = 0
' set timer period for taking screenshots, in ms
capturer.ScreenshotTimerPeriod = 1000 ' set the timer for 1 second


MsgBox "This script will record 640x480 video from entire screen for 15 seconds. Output video will go to EntireScreenCaptured.avi"

' run video capturing 
capturer.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked


' wait for 15 seconds (15000 msec)
WScript.Sleep(15000)

' you may also make manual screenshots
capturer.TakeScreenshot "screenshot1.png"


' stop capturing
capturer.Stop()

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing

```

<!-- code block end -->