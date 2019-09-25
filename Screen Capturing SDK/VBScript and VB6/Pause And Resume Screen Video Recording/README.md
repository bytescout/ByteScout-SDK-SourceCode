## pause and resume screen video recording in VBScript and VB6 using ByteScout Screen Capturing SDK

### How to code pause and resume screen video recording in VBScript and VB6: How-To tutorial

On this page you will learn from code samples for programming in VBScript and VB6. Pause and resume screen video recording in VBScript and VB6 can be implemented with ByteScout Screen Capturing SDK. ByteScout Screen Capturing SDK is the SDK for developers for quick implementation of screen video recording. The SDK records screen into video or into a series of screenshots. Can also record audio. Saves video into AVI,WMV and Google's WebM. Output video quality, size, resolution or framerate can be adjusted easily. Provides additional tools for privacy features like blacking out on scren areas with sensitive information on screen right during recording. Supports web camera as input and can add instant text and images into video output.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. To do pause and resume screen video recording in your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! You can use these VBScript and VB6 sample examples in one or many applications.

ByteScout Screen Capturing SDK is available as free trial. You may get it from our website along with all other source code samples for VBScript and VB6 applications.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Screen%20Capturing%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Screen%20Capturing%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=fujkvtWUVCw](https://www.youtube.com/watch?v=fujkvtWUVCw)




<!-- code block begin -->

##### ****PauseResume.vbs:**
    
```
' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' set output video file name (WMV), you can also set to AVI 
capturer.OutputFileName = "PauseAndResume.wmv" 

' set capturing type to the caScreen =3 to capture the entire screen
capturer.CapturingType = 3

' set width of the output video
' capturer.OutputWidth = 1280
' set height of the output video
' capturer.OutputHeight = 720

' uncomment to set Bytescout Lossless Video format output video compression method
' do not forget to set file to .avi format if you use Video Codec Name
' capturer.CurrentVideoCodecName = "Bytescout Lossless"

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

MsgBox "This script will record 2 parts video and will merge it automaticaly. Now recording of the first part 3 seconds will start"

' run video capturing 
capturer.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked

' wait for 3 seconds (3000 msec)
WScript.Sleep(3000)

' pause video capturing 
capturer.Pause()

MsgBox "The recording was paused. Click OK to resume the recording for another 3 seconds"

' run recording for another 3 seconds
capturer.Run()

' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
' using Thread.Sleep(1) inside the checking loop, so you have the loop like
' Do 
' Thread.Sleep(1) 
' While StopButtonNotClicked

' wait for 3 seconds (3000 msec)
WScript.Sleep(3000)

' finally stop capturing, we should get 6 seconds of the video
capturer.Stop()

MsgBox "The recording is done! Final video will be created now"


' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing

```

<!-- code block end -->