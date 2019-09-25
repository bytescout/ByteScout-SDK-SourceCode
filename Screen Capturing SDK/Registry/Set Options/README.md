## How to set options in Registry with ByteScout Screen Capturing SDK

### The tutorial below will demonstrate how to set options in Registry

These source code samples are listed and grouped by their programming language and functions they use. ByteScout Screen Capturing SDK: the tool for developers who want to add screen capturing in their application. Can record screen into video and into single screenshots. Output formats are WMV, AVI, WebM for video and PNG for screenshots. You can adjust output video size, quality, resolution, framerate, video and audio codecs. Includes special privacy features for blacking out sensitive information on screen. Can also capture video from web camera, can add overlays with text or images. It can set options in Registry.

This code snippet below for ByteScout Screen Capturing SDK works best when you need to quickly set options in your Registry application. In order to implement the functionality, you should copy and paste this code for Registry below into your code editor with your app, compile and run your application. Test Registry sample code examples whether they respond your needs and requirements for the project.

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

##### ****DisableLoadingFromRegistry.reg:**
    
```
Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\Software\Bytescout]

[HKEY_CURRENT_USER\Software\Bytescout\Screen Capturing Filter]
"AutoLoadSettingsFromRegistry"="0"

```

<!-- code block end -->    

<!-- code block begin -->

##### ****EnableLoadingSettingsFromRegistryAndSetMouseHotSpotSize.reg:**
    
```
Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\Software\Bytescout]

[HKEY_CURRENT_USER\Software\Bytescout\Screen Capturing Filter]
"AutoLoadSettingsFromRegistry"="1"
"CaptureAreaSource"="3"
"WindowToCapture"=""
"WindowClassToCapture"=""
"CaptureRectLeft"="0"
"CaptureRectTop"="0"
"CaptureRectWidth"="0"
"CaptureRectHeight"="0"
"FPS"="23.976"
"ResizeOutput"="0"
"CaptureMouseCursor"="0"
"AnimateMouseButtons"="0"
"AnimateMouseClicks"="0"
"ShowMouseHotSpot"="1"
"MouseCursorLeftClickAnimationColor"="16711680"
"MouseCursorRightClickAnimationColor"="65280"
"MouseHotSpotColor"="65535"
"MouseAnimationDuration"="1000"
"MouseSpotRadius"="120"
"CaptureTransparentControls"="0"
"KeepAspectRatio"="1"
"Key"="Demo"
"Name"="Demo"
```

<!-- code block end -->