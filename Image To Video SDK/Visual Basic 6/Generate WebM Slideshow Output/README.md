## How to generate webm slideshow output in Visual Basic 6 with ByteScout Image To Video SDK

### The tutorial shows how to generate webm slideshow output in Visual Basic 6

Sample source code below will show you how to cope with a difficult task like generate webm slideshow output in Visual Basic 6. ByteScout Image To Video SDK is the SDK that is designed to generate video slideshow with 100+ 2d and 3D transition effects. Can generate WMV, AVI, WEBM video file with adjustable quality, framerate, output video size and you can use it to generate webm slideshow output with Visual Basic 6.

This rich sample source code in Visual Basic 6 for ByteScout Image To Video SDK includes the number of functions and options you should do calling the API to generate webm slideshow output. Follow the instructions from the scratch to work and copy the Visual Basic 6 code. Test Visual Basic 6 sample code examples whether they respond your needs and requirements for the project.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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
converter.OutputVideoFileName = "result.webm"

' Run the conversion
converter.RunAndWait

' Open result in default media player
' Set Shell = CreateObject("WScript.Shell")
' Shell.Run "result.webm", 1, False
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