## SWF to PNG in VB6 and ByteScout SWF To Video SDK

### SWF to PNG in VB6

Today you are going to learn how to SWF to PNG in VB6. ByteScout SWF To Video SDK helps with SWF to PNG in VB6. ByteScout SWF To Video SDK is the library that can take SWF (Flash Macromedia) files and convert into WMV or AVI video with sound. Dynamic flash movie scenes, variables, actionscripts are supported and you also may adjust output video size, framerate and quality.

VB6 code snippet like this for ByteScout SWF To Video SDK works best when you need to quickly implement SWF to PNG in your VB6 application. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. You can use these VB6 sample examples in one or many applications.

Free trial version of ByteScout SWF To Video SDK is available on our website. Get it to try other samples for VB6.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20SWF%20To%20Video%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20SWF%20To%20Video%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




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

    ' Create an instance of SWFToVideo ActiveX object
    Set converter = CreateObject("BytescoutSWFToVideo.SWFToVideo")

    ' Set debug log
    'converter.SetLogFile "log.txt"

    ' Register SWFToVideo
    converter.RegistrationName = "demo"
    converter.RegistrationKey = "demo"


    ' uncomment to enable PNG with transparency
    ' converter.RGBAMode = true ' enable BEFORE setting InputSWFFileName property

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

	
    ' Set output movie dimensions
    converter.OutputWidth = 640
    converter.OutputHeight = 480

    converter.StartFrame = 25

    converter.ConvertToPNG "output.png"

    Set converter = Nothing

End Sub


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Project1.vbp:**
    
```
Type=Exe
Form=Form1.frm
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#..\WINDOWS\system32\stdole2.tlb#OLE Automation
Startup="Form1"
Command32=""
Name="Project1"
HelpContextID="0"
CompatibleMode="0"
MajorVer=1
MinorVer=0
RevisionVer=0
AutoIncrementVer=0
ServerSupportFiles=0
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