## 70 advanced 3d effects in VBScript and ByteScout Image To Video SDK

### How to code 70 advanced 3d effects in VBScript: How-To tutorial

Today you are going to learn how to 70 advanced 3d effects in VBScript. ByteScout Image To Video SDK was made to help with 70 advanced 3d effects in VBScript. ByteScout Image To Video SDK is the software development kit that can take a set of images and generate video slide show from them. Includes built-in support for 100+ of 2-D and 3-D slide transitions effects. Supports output in WMV, AVI, WEBM video formats.

The SDK samples like this one below explain how to quickly make your application do 70 advanced 3d effects in VBScript with the help of ByteScout Image To Video SDK. VBScript sample code is all you need: copy and paste the code to your VBScript application's code editor, add a reference to ByteScout Image To Video SDK (if you haven't added yet) and you are ready to go! Enjoy writing a code with ready-to-use sample VBScript codes to add 70 advanced 3d effects functions using ByteScout Image To Video SDK in VBScript.

ByteScout Image To Video SDK free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

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

##### ****70advanced3DtransitionEffects.vbs:**
    
```

MsgBox "This sample script generates video with all 3D advanced transition effects! Please be patient (it takes about 1-2 min)"

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

' now try all 3D advanced transition effects from 67 (dissolve) to 140
for i=67 to 140

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
converter.OutputVideoFileName = "70advanced3DEffects.wmv"

' Run the conversion
converter.RunAndWait()

MsgBox "Done! See 70advanced3DEffects.wmv"

Set converter = Nothing

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "70advanced3DEffects.wmv", 1, false
Set shell = Nothing

```

<!-- code block end -->