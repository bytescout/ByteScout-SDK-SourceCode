## How to set background music from file in VBScript with ByteScout Image To Video SDK

### The tutorial shows how to set background music from file in VBScript

Set background music from file is easy to implement in VBScript if you use these source codes below. What is ByteScout Image To Video SDK? It is the software development kit that can take a set of images and generate video slide show from them. Includes built-in support for 100+ of 2-D and 3-D slide transitions effects. Supports output in WMV, AVI, WEBM video formats. It can help you to set background music from file in your VBScript application.

You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Image To Video SDK for set background music from file below and use it in your application. In order to implement the functionality, you should copy and paste this code for VBScript below into your code editor with your app, compile and run your application. This basic programming language sample code for VBScript will do the whole work for you to set background music from file.

Trial version of ByteScout Image To Video SDK can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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

converter.SetLogFile "log.txt"

MsgBox "The script will now convert 3 slides into Result.wmv video file"

' set default in effect for slides (you can also set effects for each single slide)
converter.Slides.DefaultSlideInEffect = 1 ' teFadeIn (1) - fades in effect for slides transition
converter.Slides.DefaultSlideInEffectDuration = 500 ' 500 msec for in effect

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

' Set background music
converter.ExternalAudioTrackFromFileName = "bgmusic.mp3"

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