## How to double speed in VBScript and ByteScout Image To Video SDK

### Tutorial on how to double speed in VBScript

Source code documentation samples provide quick and easy way to add a required functionality into your application. ByteScout Image To Video SDK is the library for conversion of images into video slideshow. Provides built-in support for more than hundred of 2D and 3D transition effects. Output formats supported are AVI,WMV and WEBM video files. You may adjust output video size, quality, framerate and add audio. It can be used to double speed using VBScript.

The SDK samples like this one below explain how to quickly make your application do double speed in VBScript with the help of ByteScout Image To Video SDK. In your VBScript project or application you may simply copy & paste the code and then run your app! You can use these VBScript sample examples in one or many applications.

Download free trial version of ByteScout Image To Video SDK from our website with this and other source code samples for VBScript.

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

##### ****multiple.vbs:**
    
```
' You can speed up the conversion using the following technique:
' 1) Generate video parts in parallel threads;
' 2) Combine these parts into final video.
' Let us say you have 20 slides.
' Then you can run a thread to convert 1-10 slides and another one to convert 11-20 slides.
' Finally combine these parts into a single one using .JoinWMVFiles(part1, part2, output) 
' or .JoingAVIFiles(part1, part2, output) functions.


Set converter1 = CreateObject("BytescoutImageToVideo.ImageToVideo") 
Set converter2 = CreateObject("BytescoutImageToVideo.ImageToVideo") 

converter1.SetLogFile "log1.txt" 
converter2.SetLogFile "log2.txt" 

' 1st thread
converter1.AddImageFromFileName("slide1.jpg")
converter1.AddImageFromFileName("slide2.jpg")
converter1.AddImageFromFileName("slide3.jpg")

' 2nd thread
converter2.AddImageFromFileName("slide4.jpg")
converter2.AddImageFromFileName("slide5.jpg")
converter2.AddImageFromFileName("slide6.jpg")
    
Set slides1 = converter1.Slides
Set slides2 = converter2.Slides

slides1.GetSlide(0).Effect = 1
slides1.GetSlide(1).Effect = 1
slides1.GetSlide(2).Effect = 1


slides2.GetSlide(0).Effect = 1
slides2.GetSlide(1).Effect = 1
slides2.GetSlide(2).Effect = 1

' set output video filename for parts (WMV or AVI)
converter1.OutputVideoFileName = "part1.wmv"
converter2.OutputVideoFileName = "part2.wmv"

converter2.Run
converter1.Run

while converter1.IsRunning Or converter2.IsRunning
     WScript.Sleep 100
wend

' Join parts into the final video file (you may also use .JoinAVIFiles() to join AVI files)
converter1.JoinWMVFiles "part1.wmv", "part2.wmv", "Final.wmv"

MsgBox "All threads are done."

Set slide1 = Nothing
Set slides1 = Nothing
Set converter1 = Nothing

Set slide2 = Nothing
Set slides2 = Nothing
Set converter2 = Nothing


' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "final.wmv", 1, false
Set shell = Nothing

```

<!-- code block end -->