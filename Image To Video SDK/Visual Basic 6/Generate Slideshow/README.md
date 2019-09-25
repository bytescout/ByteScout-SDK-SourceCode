## How to generate slideshow in Visual Basic 6 using ByteScout Image To Video SDK

### How to code in Visual Basic 6 to generate slideshow with this step-by-step tutorial

Source code documentation samples provide quick and easy way to add a required functionality into your application. ByteScout Image To Video SDK can generate slideshow. It can be used from Visual Basic 6. ByteScout Image To Video SDK is the library for conversion of images into video slideshow. Provides built-in support for more than hundred of 2D and 3D transition effects. Output formats supported are AVI,WMV and WEBM video files. You may adjust output video size, quality, framerate and add audio.

Visual Basic 6 code samples for Visual Basic 6 developers help to speed up coding of your application when using ByteScout Image To Video SDK. Just copy and paste the code into your Visual Basic 6 application’s code and follow the instruction. You can use these Visual Basic 6 sample examples in one or many applications.

Trial version of ByteScout Image To Video SDK is available for free. Source code samples are included to help you with your Visual Basic 6 app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Image%20To%20Video%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Image%20To%20Video%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=FzPgeGFL8YA](https://www.youtube.com/watch?v=FzPgeGFL8YA)




<!-- code block begin -->

##### ****Form1.frm:**
    
```
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

Set Slide = converter.AddImageFromFileName("..\..\slide1.jpg")
Slide.Duration = 3000 ' 3000ms = 3s

Set Slide = converter.AddImageFromFileName("..\..\slide2.jpg")
Slide.Duration = 3000

Set Slide = converter.AddImageFromFileName("..\..\slide3.jpg")
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


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Project1.vbp:**
    
```
Type=Exe
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#C:\WINDOWS\system32\stdole2.tlb#OLE Automation
Reference=*\G{5212739C-A95B-4CDA-B116-F540A549B648}#1.0#0#c:\WINDOWS\system32\BytescoutImageToVideo.dll#Bytescout Image To Video 1.0 Type Library
Form=Form1.frm
IconForm="Form1"
Startup="Form1"
ExeName32="Project1.exe"
Command32=""
Name="Project1"
HelpContextID="0"
CompatibleMode="0"
MajorVer=1
MinorVer=0
RevisionVer=0
AutoIncrementVer=0
ServerSupportFiles=0
VersionCompanyName="Visual C++"
CompilationType=0
OptimizationType=0
FavorPentiumPro(tm)=0
CodeViewDebugInfo=0
NoAliasing=0
BoundsCheck=0
OverflowCheck=0
FlPointCheck=0
FDIVCheck=0
UnroundedFP=0
StartMode=0
Unattended=0
Retained=0
ThreadPerObject=0
MaxNumberOfThreads=1

[MS Transaction Server]
AutoRefresh=1

```

<!-- code block end -->