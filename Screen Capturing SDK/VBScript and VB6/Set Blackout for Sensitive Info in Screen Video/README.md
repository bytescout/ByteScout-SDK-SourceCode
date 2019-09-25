## How to set blackout for sensitive info in screen video in VBScript and VB6 using ByteScout Screen Capturing SDK

### The tutorial shows how to set blackout for sensitive info in screen video in VBScript and VB6

Sample source code below will show you how to cope with a difficult task like set blackout for sensitive info in screen video in VBScript and VB6. ByteScout Screen Capturing SDK is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video. It can be used to set blackout for sensitive info in screen video using VBScript and VB6.

This rich sample source code in VBScript and VB6 for ByteScout Screen Capturing SDK includes the number of functions and options you should do calling the API to set blackout for sensitive info in screen video. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Use of ByteScout Screen Capturing SDK in VBScript and VB6 is also explained in the documentation included along with the product.

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

##### ****RecordScreenAndBlackoutSensitiveInfo.vbs:**
    
```
' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' set output video file name to .WMV or .AVI file
capturer.OutputFileName = "output.wmv" 

' set capturing type to the caScreen =3 to capture the entire screen
capturer.CapturingType = 3

' output video width
capturer.OutputWidth = 640

' output video height
capturer.OutputHeight = 480

' set border type to show around captured area
capturer.CaptureAreaBorderType = 2 ' CaptureAreaBorderType.cabtDashed;

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

MsgBox "This script will record entire screen for 5 seconds. From 1st to 5 seconds some areas will be blackouted"

' run video capturing 
capturer.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked


' wait for 1 second (1000 msec)
WScript.Sleep(1000)

capturer.BlackoutAddArea 20,100,500,80
capturer.BlackoutAddArea 10,200,550,80
capturer.BlackoutAddArea 20,400,550,120

' record for 5 seconds more
WScript.Sleep(5000)

' reset all blackouts
capturer.BlackoutReset

' record 1 second more
WScript.Sleep(1000)

' stop capturing
capturer.Stop()

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing

```

<!-- code block end -->