'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


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
' converter.SetBackgroundPictureFileName "background.jpg"

' set auto fit images mode
converter.AutoFitImages = True

' apply transition effect to the very first slide
converter.UseInEffectForFirstSlide = True

bChangeSlide = True ' temporary variable to change slides

' now try all 140 transition effects from 0 (none) to 140
for i=0 to 140

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
converter.OutputVideoFileName = "AllTransitionEffects.wmv"

' Run the conversion
converter.RunAndWait()

MsgBox "Done! See AllTransitionEffects.wmv"

Set converter = Nothing


' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "AllTransitionEffects.wmv", 1, false
Set shell = Nothing
