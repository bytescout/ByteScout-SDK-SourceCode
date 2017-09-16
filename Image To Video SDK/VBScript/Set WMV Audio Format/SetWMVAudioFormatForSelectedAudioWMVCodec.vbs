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
