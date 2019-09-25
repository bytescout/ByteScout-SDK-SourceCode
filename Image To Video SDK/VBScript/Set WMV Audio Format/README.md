## How to set WMV audio format in VBScript with ByteScout Image To Video SDK

### The tutorial shows how to set WMV audio format in VBScript

Set WMV audio format is easy to implement in VBScript if you use these source codes below. ByteScout Image To Video SDK is the software development kit that can take a set of images and generate video slide show from them. Includes built-in support for 100+ of 2-D and 3-D slide transitions effects. Supports output in WMV, AVI, WEBM video formats and you can use it to set WMV audio format with VBScript.

You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Image To Video SDK for set WMV audio format below and use it in your application. In your VBScript project or application you may simply copy & paste the code and then run your app! Code testing will allow the function to be tested and work properly with your data.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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

##### ****SetWMVAudioFormatForSelectedAudioWMVCodec.vbs:**
    
```
' Create an instance of BytescoutImageToVideo.ImageToVideo ActiveX object
Set converter = CreateObject("BytescoutImageToVideo.ImageToVideo")

' Activate the component
converter.RegistrationName = "demo"
converter.RegistrationKey = "demo"

' Add images and set the duration for every slide
Set slide = converter.AddImageFromFileName("..\..\slide1.jpg")
slide.Duration = 1000 ' 3000ms = 3s

' Set output video size
converter.OutputWidth = 320
converter.OutputHeight = 240

' converter.SetLogFile "log.txt"

' Set background music
converter.ExternalAudioTrackFromFileName = "..\..\bgmusic.mp3"

' set current WMV audio codec - we set it to "Windows Media Audio 9"
' to view all available wmv audio codecs use .WMVAudioCodecsCount and GetWMVAudioCodecName(index) 
' or you can see all available codecs in the log file (use .SetLogFile("log.txt")

converter.CurrentWMVAudioCodecName = "Windows Media Audio 9"

' now list available audio formats for current WMV audio codec

sWMVAudioFormatsInfo = ""

For i = 0 to converter.WMVAudioFormatCount -1 
 sWMVAudioFormatsInfo = sWMVAudioFormatsInfo & vbCRLF & CStr(i) & " : " & converter.GetWMVAudioFormatDescription (i)
Next

MsgBox "WMV audio codec formats for Windows Media Audio 9 audio codec available are:" & sWMVAudioFormatsInfo

' now set wmv audio format to the first available
converter.CurrentWMVAudioFormat = 0


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