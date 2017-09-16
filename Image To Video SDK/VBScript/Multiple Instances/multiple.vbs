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
