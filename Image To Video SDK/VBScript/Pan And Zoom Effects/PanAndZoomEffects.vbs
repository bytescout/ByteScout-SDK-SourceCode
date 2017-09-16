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
