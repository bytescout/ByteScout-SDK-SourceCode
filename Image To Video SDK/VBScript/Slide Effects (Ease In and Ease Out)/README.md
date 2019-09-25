## slide effects (ease in and ease out) in VBScript with ByteScout Image To Video SDK

### slide effects (ease in and ease out) in VBScript

Every ByteScout tool contains example VBScript source codes that you can find here or in the folder with installed ByteScout product. Slide effects (ease in and ease out) in VBScript can be implemented with ByteScout Image To Video SDK. ByteScout Image To Video SDK is the software development kit that can take a set of images and generate video slide show from them. Includes built-in support for 100+ of 2-D and 3-D slide transitions effects. Supports output in WMV, AVI, WEBM video formats.

This rich sample source code in VBScript for ByteScout Image To Video SDK includes the number of functions and options you should do calling the API to implement slide effects (ease in and ease out). Follow the instruction from the scratch to work and copy and paste code for VBScript into your editor. Code testing will allow the function to be tested and work properly with your data.

Free trial version of ByteScout Image To Video SDK is available on our website. Get it to try other samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Image%20To%20Video%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Image%20To%20Video%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=FzPgeGFL8YA](https://www.youtube.com/watch?v=FzPgeGFL8YA)




<!-- code block begin -->

##### ****SlideEffectsEaseInEaseOut.vbs:**
    
```
' Create an instance of BytescoutImageToVideo.ImageToVideo ActiveX object
Set converter = CreateObject("BytescoutImageToVideo.ImageToVideo")

' Activate the component
converter.RegistrationName = "demo"
converter.RegistrationKey = "demo"

MsgBox "The script will now convert 3 slides into Result.wmv video file"

' Add images and set the duration for every slide
Set slide = converter.AddImageFromFileName("..\..\slide1.jpg")
slide.Duration = 3000 ' 3000ms = 3s
Slide.Effect = 1 ' 1 = EaseIn
slide.EffectDuration = 3000 ' 3000ms = 3s


Set slide = converter.AddImageFromFileName("..\..\slide2.jpg")
slide.Duration = 3000
Slide.Effect = 2 ' 2 = EaseOut
slide.EFfectDuration = 3000

Set slide = converter.AddImageFromFileName("..\..\slide3.jpg")
slide.Duration = 3000
Slide.Effect = 1 ' 1 = EaseIn
Slide.EffectDuration = 3000
' Set output video size
converter.OutputWidth = 640
converter.OutputHeight = 480

' Set output video file name
converter.OutputVideoFileName = "result.wmv"

' Run the conversion
converter.RunAndWait()

MsgBox "Result.wmv is ready. Script will try to open the video in default media player"

' Open result in default media player
Set shell = CreateObject("WScript.Shell")
shell.Run "result.wmv", 1, false
Set shell = Nothing

Set converter = Nothing

```

<!-- code block end -->