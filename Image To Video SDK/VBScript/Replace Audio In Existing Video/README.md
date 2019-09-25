## How to replace audio in existing video in VBScript using ByteScout Image To Video SDK

### The tutorial shows how to replace audio in existing video in VBScript

Source code documentation samples provide quick and easy way to add a required functionality into your application. What is ByteScout Image To Video SDK? It is the software development kit that can take a set of images and generate video slide show from them. Includes built-in support for 100+ of 2-D and 3-D slide transitions effects. Supports output in WMV, AVI, WEBM video formats. It can help you to replace audio in existing video in your VBScript application.

This code snippet below for ByteScout Image To Video SDK works best when you need to quickly replace audio in existing video in your VBScript application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Test VBScript sample code examples whether they respond your needs and requirements for the project.

Free trial version of ByteScout Image To Video SDK is available for download from our website. Get it to try other source code samples for VBScript.

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

##### ****ReplaceAudio.vbs:**
    
```
' Create an instance of BytescoutImageToVideo.ImageToVideo ActiveX object
Set converter = CreateObject("BytescoutImageToVideo.ImageToVideo")

' Activate the component
converter.RegistrationName = "demo"
converter.RegistrationKey = "demo"

' converter.SetLogFile "log.txt"

' set input video file
converter.InputVideoFileName = "input.wmv"

' set input audio file
converter.ExternalAudioTrackFromFileName = "11k16bitpcm.wav"

' Set output video file name
converter.OutputVideoFileName = "ReplacedAudio.wmv"

' Run the conversion
converter.RunAndWait()

MsgBox "ReplacedAudio.wmv is ready. Script will try to open the video in default media player"

' Open result in default media player
Set shell = CreateObject("WScript.Shell")
shell.Run "ReplacedAudio.wmv", 1, false
Set shell = Nothing

Set converter = Nothing

```

<!-- code block end -->