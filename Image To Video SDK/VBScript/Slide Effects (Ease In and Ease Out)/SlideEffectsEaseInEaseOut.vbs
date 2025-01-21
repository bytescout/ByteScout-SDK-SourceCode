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

MsgBox "The script will now convert 3 slides into Result.wmv video file"

' Add images and set the duration for every slide
Set slide = converter.AddImageFromFileName("slide1.jpg")
slide.Duration = 3000 ' 3000ms = 3s
Slide.Effect = 1 ' 1 = EaseIn
slide.EffectDuration = 3000 ' 3000ms = 3s


Set slide = converter.AddImageFromFileName("slide2.jpg")
slide.Duration = 3000
Slide.Effect = 2 ' 2 = EaseOut
slide.EFfectDuration = 3000

Set slide = converter.AddImageFromFileName("slide3.jpg")
slide.Duration = 3000
Slide.Effect = 1 ' 1 = EaseIn
Slide.EffectDuration = 3000
' Set output video size
converter.OutputWidth = 640
converter.OutputHeight = 480

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
