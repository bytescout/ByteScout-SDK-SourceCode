## How to show capturing properties dialog in VBScript and VB6 with ByteScout Screen Capturing SDK

### Write code in VBScript and VB6 to show capturing properties dialog with this step-by-step tutorial

The sample shows steps and algorithm of how to show capturing properties dialog and how to make it work in your VBScript and VB6 application. What is ByteScout Screen Capturing SDK? It is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video. It can help you to show capturing properties dialog in your VBScript and VB6 application.

This code snippet below for ByteScout Screen Capturing SDK works best when you need to quickly show capturing properties dialog in your VBScript and VB6 application. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! You can use these VBScript and VB6 sample examples in one or many applications.

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

##### ****CaptureShowDialog.vbs:**
    
```
' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' set output video file name
capturer.OutputFileName = "CapturedOutput.avi" 

' show capturing properties dialog
capturer.ShowCaptureFilterPropertiesDialog (0)


' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing

```

<!-- code block end -->