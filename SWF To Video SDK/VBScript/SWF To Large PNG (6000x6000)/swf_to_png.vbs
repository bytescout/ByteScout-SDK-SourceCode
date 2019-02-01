'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode. WHY? Because flash is not supported on x64 platform currently at all

' Create an instance of SWFToVideo ActiveX object
Set converter = CreateObject("BytescoutSWFToVideo.SWFToVideo")

' Set debug log
'converter.SetLogFile "log.txt"

' Register SWFToVideo
converter.RegistrationName = "demo"
converter.RegistrationKey = "demo"

' uncomment to enable PNG with transparency
' converter.RGBAMode = true ' enable BEFORE setting InputSWFFileName property


' you may calculate output video duration using information about the the source swf movie
' WARNING #1: this method to calculate the output video duration is not working for movies with dynamic scenes 
' and interactive scripts as in these movies it is not possible to calculate the precise duration of the movie 
' WARNING #2: you should set the input swf or flv filename (or url) before this calculation

' So the movie duration is calculated as the following:
' as swf frame count (number of frames in the swf) / movieFPS (frames per second defined in swf)
' and then multiplied by 1000 (as we are setting the .ConverstionTimeout in milliseconds)
' as the following (uncomment if you want to set the length of the output video to the same as the original swf)
' or as the following source code (uncomment to enable):

' converter.ConversionTimeout = 1000 * (converter.FrameCount / converter.MovieFPS)


' Set output movie dimensions

' start my code
converter.OutputWidth = 6000
converter.OutputHeight = 6000

' end my code


' Set input SWF file
converter.InputSWFFileName = "informationstechnik.swf"

converter.StartFrame = 0

converter.ConvertToPNG "large_output.png"

Set converter = Nothing
