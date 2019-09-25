## multiple instances in VBScript and ByteScout Image To Video SDK

### How to code multiple instances in VBScript: How-To tutorial

The coding tutorials are designed to help you test the features without need to write your own code. ByteScout Image To Video SDK helps with multiple instances in VBScript. ByteScout Image To Video SDK is the library for conversion of images into video slideshow. Provides built-in support for more than hundred of 2D and 3D transition effects. Output formats supported are AVI,WMV and WEBM video files. You may adjust output video size, quality, framerate and add audio.

VBScript code snippet like this for ByteScout Image To Video SDK works best when you need to quickly implement multiple instances in your VBScript application. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Test VBScript sample code examples whether they respond your needs and requirements for the project.

ByteScout Image To Video SDK is available as free trial. You may get it from our website along with all other source code samples for VBScript applications.

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
Set converter1 = CreateObject("BytescoutImageToVideo.ImageToVideo") 
Set converter2 = CreateObject("BytescoutImageToVideo.ImageToVideo") 

converter1.SetLogFile "log1.txt" 
converter2.SetLogFile "log2.txt" 

converter1.AddImageFromFileName("Desert.jpg")
converter1.AddImageFromFileName("Koala.jpg")
converter1.AddImageFromFileName("Penguins.jpg")

converter2.AddImageFromFileName("..\..\slide1.jpg")
converter2.AddImageFromFileName("..\..\slide2.jpg")
converter2.AddImageFromFileName("..\..\slide3.jpg")
    
Set slides1 = converter1.Slides
Set slides2 = converter2.Slides

Set slide1 = slides1.GetSlide(0)
slide1.Effect = 1

Set slide2 = slides2.GetSlide(0)
slide2.Effect = 1

converter1.OutputVideoFileName = "Output1.wmv"
converter2.OutputVideoFileName = "Output2.wmv"

converter2.Run
converter1.Run

while converter1.IsRunning Or converter2.IsRunning
     WScript.Sleep 100
wend

converter1.JoinWMVFiles "output1.wmv", "output2.wmv", "Final.wmv"

msgbox "All threads are done."

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