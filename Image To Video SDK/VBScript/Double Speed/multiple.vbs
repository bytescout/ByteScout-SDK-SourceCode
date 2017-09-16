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
