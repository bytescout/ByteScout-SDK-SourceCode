## simple in VBScript using ByteScout Image To Video SDK

### How to code simple in VBScript: How-To tutorial

Today we will explain the steps and algorithm of implementing simple and how to make it work in your application. ByteScout Image To Video SDK helps with simple in VBScript. ByteScout Image To Video SDK is the software development kit that can take a set of images and generate video slide show from them. Includes built-in support for 100+ of 2-D and 3-D slide transitions effects. Supports output in WMV, AVI, WEBM video formats.

VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout Image To Video SDK. This VBScript sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. Further enhancement of the code will make it more vigorous.

Visit our website provides for free trial version of ByteScout Image To Video SDK. Free trial includes lots of source code samples to help you with your VBScript project.

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

##### ****SimpleSlideshow.vbs:**
    
```
' Create an instance of BytescoutImageToVideo.ImageToVideo ActiveX object
Set converter = CreateObject("BytescoutImageToVideo.ImageToVideo")

' Activate the component
converter.RegistrationName = "demo"
converter.RegistrationKey = "demo"

MsgBox "The script will now convert 3 slides into Result.wmv video file"

' Set default "in" effect for slides (you can also set effects for each slide separately)
converter.Slides.DefaultSlideInEffect = 1 ' teFadeIn (1) - "fade-in" slides transition effect
converter.Slides.DefaultSlideInEffectDuration = 500 ' "in" effect duration

' Add images and set the duration for every slide
Set slide = converter.AddImageFromFileName("..\..\slide1.jpg")
slide.Duration = 3000 ' 3000ms = 3s
Set slide = converter.AddImageFromFileName("..\..\slide2.jpg")
slide.Duration = 3000
Set slide = converter.AddImageFromFileName("..\..\slide3.jpg")
slide.Duration = 3000

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