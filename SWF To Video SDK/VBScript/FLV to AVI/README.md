## FLV to AVI in VBScript and ByteScout SWF To Video SDK

### Tutorial: how to do FLV to AVI in VBScript

We’ve created and updating regularly our sample code library so you may quickly learn FLV to AVI and the step-by-step process in VBScript. ByteScout SWF To Video SDK helps with FLV to AVI in VBScript. ByteScout SWF To Video SDK is the SDK that is capable of converting SWF macromedia files into WMV and AVI video. Supports dynamic flash movies, can transmit variable values. Options to change output video size, framerate, quality are available.

VBScript code snippet like this for ByteScout SWF To Video SDK works best when you need to quickly implement FLV to AVI in your VBScript application. This VBScript sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. Use of ByteScout SWF To Video SDK in VBScript is also explained in the documentation included along with the product.

Trial version can be obtained from our website for free. It includes this and other source code samples for VBScript.

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

##### ****simple.vbs:**
    
```
' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode. WHY? Because flash is not supported on x64 platform currently at all

' Create an instance of SWFToVideo ActiveX object
Set converter = CreateObject("BytescoutSWFToVideo.SWFToVideo")

' Set debug log
'converter.SetLogFile "log.txt"

' Register SWFToVideo
converter.RegistrationName = "demo"
converter.RegistrationKey = "demo"

' Set input SWF file
converter.InputSWFFileName = "../../video.flv"
	

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

' Set output WMV or AVI video file
converter.OutputVideoFileName = "result.AVI"

' Set output movie dimensions
converter.OutputWidth = 640
converter.OutputHeight = 480

' Run conversion
converter.RunAndWait

' Open result in default media player
Set shell = CreateObject("WScript.Shell")
shell.Run "result.avi", 1, false
Set shell = Nothing

Set converter = Nothing

```

<!-- code block end -->