'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'



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
