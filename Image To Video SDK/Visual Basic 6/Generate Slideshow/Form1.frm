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

' First add the reference to the object using Project | References and then check reference to Bytescout Image To Video type library and click OK

' Dim converter object
Dim converter As BytescoutImageToVideo.ImageToVideo

' Create an instance of BytescoutImageToVideo.ImageToVideo ActiveX object
Set converter = CreateObject("BytescoutImageToVideo.ImageToVideo")

' Activate the component
converter.RegistrationName = "demo"
converter.RegistrationKey = "demo"

' set default in effect for slides (you can also set effects for each single slide)
Dim Slides As BytescoutImageToVideo.Slides
Set Slides = converter.Slides
Slides.DefaultSlideInEffect = 1 ' teFadeIn (1) - fades in effect for slides transition
Slides.DefaultSlideInEffectDuration = 500 ' 500 msec for in effect

' Add images and set the duration for every slide
Dim Slide As BytescoutImageToVideo.Slide

Set Slide = converter.AddImageFromFileName("slide1.jpg")
Slide.Duration = 3000 ' 3000ms = 3s

Set Slide = converter.AddImageFromFileName("slide2.jpg")
Slide.Duration = 3000

Set Slide = converter.AddImageFromFileName("slide3.jpg")
Slide.Duration = 3000

' Set output video size
converter.OutputWidth = 640
converter.OutputHeight = 480

' Set output video file name
converter.OutputVideoFileName = "result.wmv"

' Run the conversion
converter.RunAndWait

' Open result in default media player
' Set Shell = CreateObject("WScript.Shell")
' Shell.Run "result.wmv", 1, False
' Set Shell = Nothing

Set converter = Nothing

End Sub

