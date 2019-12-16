## How to merge AVI video files in VBScript and VB6 using ByteScout Screen Capturing SDK

### Continuous learning is a crucial part of computer science and this tutorial shows how to merge AVI video files in VBScript and VB6

Sample source code below will display you how to manage a complex task like merge AVI video files in VBScript and VB6. ByteScout Screen Capturing SDK can merge AVI video files. It can be applied from VBScript and VB6. ByteScout Screen Capturing SDK is the SDK for developers for quick implementation of screen video recording. The SDK records screen into video or into a series of screenshots. Can also record audio. Saves video into AVI,WMV and Google's WebM. Output video quality, size, resolution or framerate can be adjusted easily. Provides additional tools for privacy features like blacking out on scren areas with sensitive information on screen right during recording. Supports web camera as input and can add instant text and images into video output.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript and VB6 code from ByteScout Screen Capturing SDK for merge AVI video files below and use it in your application. Just copy and paste the code into your VBScript and VB6 application’s code and follow the instructions. Check VBScript and VB6 sample code samples to see if they respond to your needs and requirements for the project.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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

##### **MergeAVIVideoFiles.vbs:**
    
```
' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' Merge AVI files that were previously created by the ByteScout Screen Capturer (must be of same size, FPS and type)
capturer.JoinAVIFiles "Sample1.avi", "Sample2.avi", "output.avi"

MsgBox "Files merged successfully!"

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing

```

<!-- code block end -->