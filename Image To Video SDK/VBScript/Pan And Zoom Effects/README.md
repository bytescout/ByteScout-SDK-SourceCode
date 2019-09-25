## pan and zoom effects in VBScript using ByteScout Image To Video SDK

### pan and zoom effects in VBScript

Every ByteScout tool contains example VBScript source codes that you can find here or in the folder with installed ByteScout product. ByteScout Image To Video SDK was made to help with pan and zoom effects in VBScript. ByteScout Image To Video SDK is the library for conversion of images into video slideshow. Provides built-in support for more than hundred of 2D and 3D transition effects. Output formats supported are AVI,WMV and WEBM video files. You may adjust output video size, quality, framerate and add audio.

VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout Image To Video SDK. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Further enhancement of the code will make it more vigorous.

On our website you may get trial version of ByteScout Image To Video SDK for free. Source code samples are included to help you with your VBScript application.

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

##### ****PanAndZoomEffects.vbs:**
    
```
' Create an instance of BytescoutImageToVideo.ImageToVideo ActiveX object
Set converter = CreateObject("BytescoutImageToVideo.ImageToVideo")

' Activate the component
converter.RegistrationName = "demo"
converter.RegistrationKey = "demo"

' set default in effect for slides (you can also set effects for each single slide)
converter.Slides.DefaultSlideInEffect = 0 ' default effect
converter.Slides.DefaultSlideInEffectDuration = 1000 ' 1000 msec for slide transition effect effect

converter.Slides.DefaultSlideDuration = 2000 ' total duration is 2000 = slide transition (1000 ms) + 1000 ms of slide it self (with pan and zoom effect applied)


' uncomment to use background picture
' converter.SetBackgroundPictureFileName "..\..\background.jpg"

' apply transition effect to the very first slide
converter.UseInEffectForFirstSlide = false

Randomize ' initialize random values generator 

bChangeSlide = True ' temporary variable to change slides


' now try all 12 pan zoom effects for slides from 1 to 12
' list of PanZoom effects (Slide.PanZoomEffect property)
'   pzeNone = 0, // default
'	pzeMoveCamFromLeftTopToRightTop = 1,
'	pzeMoveCamFromRightTopToLeftTop = 2,
'
'	pzeMoveCamFromLeftTopToRightBottom = 3,
'	pzeMoveCamFromRightBottomToLeftTop = 4,
'
'	pzeMoveCamFromLeftCenterToRightCenter = 5,
'	pzeMoveCamFromRightCenterToLeftCenter = 6,
'
'	pzeMoveCamFromLeftBottomToRightBottom = 7,
'	pzeMoveCamFromRightBottomToLeftBottom = 8,
'
'	pzeMoveCamFromCenterTopToCenterBottom = 9,
'	pzeMoveCamFromCenterBottomToCenterTop = 10,
'
'	pzeMoveCamFromLeftBottomToRightTop = 11,
'	pzeMoveCamFromRightTopToLeftBottom = 12,


for i=1 to 11

' Add slide image, set the duration

if not bChangeSlide then
	Set slide = converter.AddImageFromFileName("koala.jpg")
Else 
	Set slide = converter.AddImageFromFileName("penguins.jpg")
End If

bChangeSlide = not bChangeSlide ' switch to use another slide next tim

slide.Duration = 2000 ' 2 seconds (2000 ms)
slide.InEffect = Rnd * 100 + 1' set random slide transition effect
Slide.InEffectDuration = 1000 ' 1000 ms for slide transition effect
slide.PanZoomEffect = i ' set panzoom effect will be shown on whole slide duration (2000 ms)

Next


' Set output video size
converter.OutputWidth = 640
converter.OutputHeight = 480

' Set output video file name
converter.OutputVideoFileName = "PanZoomEffects.wmv"

' Run the conversion
converter.RunAndWait()

MsgBox "Done! See PanZoomEffects.wmv"

Set converter = Nothing


' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "PanZoomEffects.wmv", 1, false
Set shell = Nothing

```

<!-- code block end -->