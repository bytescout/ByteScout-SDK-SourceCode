## 60 standard transition effects in VBScript using ByteScout Image To Video SDK

### Make 60 standard transition effects in VBScript: ### Tutorial on how to do 60 standard transition effects in VBScript

The documentation is designed to help you to implement the features on your side. 60 standard transition effects in VBScript can be implemented with ByteScout Image To Video SDK. ByteScout Image To Video SDK is the software development kit that can take a set of images and generate video slide show from them. Includes built-in support for 100+ of 2-D and 3-D slide transitions effects. Supports output in WMV, AVI, WEBM video formats.

VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout Image To Video SDK. VBScript sample code is all you need: copy and paste the code to your VBScript application's code editor, add a reference to ByteScout Image To Video SDK (if you haven't added yet) and you are ready to go! Further enhancement of the code will make it more vigorous.

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

##### ****60standardTransitionEffects.vbs:**
    
```
MsgBox "This sample script generates demo video with more than 60 standard transition effects." & vbCLRF & "Please be patient, it takes 1-2 min)"

' Create an instance of BytescoutImageToVideo.ImageToVideo ActiveX object
Set converter = CreateObject("BytescoutImageToVideo.ImageToVideo")

' Activate the component
converter.RegistrationName = "demo"
converter.RegistrationKey = "demo"

' set default in effect for slides (you can also set effects for each single slide)
converter.Slides.DefaultSlideInEffect = 0 ' default effect
converter.Slides.DefaultSlideInEffectDuration = 1000 ' 1000 msec for slide transition effect effect

converter.Slides.DefaultSlideDuration = 1000

' uncomment to use background picture
' converter.SetBackgroundPictureFileName "..\..\background.jpg"

' set auto fit images mode
converter.AutoFitImages = True

' apply transition effect to the very first slide
converter.UseInEffectForFirstSlide = True

bChangeSlide = True ' temporary variable to change slides

' now try all 66 standard transition effects from 0 (none) to 66 (67 effects total)
for i=0 to 67

' Add slide image, set the duration

if not bChangeSlide then
	Set slide = converter.AddImageFromFileName("slide1.jpg")
Else 
	Set slide = converter.AddImageFromFileName("slide2.jpg")
End If

bChangeSlide = not bChangeSlide ' switch to use another slide next tim

slide.InEffect = i ' effect index

Next


' Set output video size
converter.OutputWidth = 640
converter.OutputHeight = 480

' Set output video file name
converter.OutputVideoFileName = "67standardTransionEffects.wmv"

' Run the conversion
converter.RunAndWait()

MsgBox "Done! See 67standardTransionEffects.wmv"

Set converter = Nothing


' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "67standardTransionEffects.wmv", 1, false
Set shell = Nothing

```

<!-- code block end -->