VERSION 5.00
Begin VB.Form Form1
   Caption         =   "Form1"
   ClientHeight    =   3090
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1
      Caption         =   "Convert"
      Height          =   975
      Left            =   1440
      TabIndex        =   0
      Top             =   960
      Width           =   1815
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()

    ' Create an instance of SWFToVideo ActiveX object
    Set converter = CreateObject("BytescoutSWFToVideo.SWFToVideo")

    ' Set debug log
    'converter.SetLogFile "log.txt"

    ' Register SWFToVideo
    converter.RegistrationName = "demo"
    converter.RegistrationKey = "demo"


    ' Set input SWF file
    converter.InputSWFFileName = "SlideShowWithEffects.swf"

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

	
    ' Set output video file
    converter.OutputVideoFileName = "result.webm"

    ' Set output movie dimensions
    converter.OutputWidth = 640
    converter.OutputHeight = 480

    ' Run conversion
    converter.RunAndWait

    ' Open result in default media player
	Set shell = CreateObject("WScript.Shell")
	shell.Run "result.webm", 1, false
	Set shell = Nothing

	Set converter = Nothing

End Sub

