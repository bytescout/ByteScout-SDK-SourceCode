## How to merge WMV video files in VBScript and VB6 and ByteScout Screen Capturing SDK

### This code in VBScript and VB6 shows how to merge WMV video files with this how to tutorial

These sample source codes on this page below are displaying how to merge WMV video files in VBScript and VB6. ByteScout Screen Capturing SDK: the tool for developers who want to add screen capturing in their application. Can record screen into video and into single screenshots. Output formats are WMV, AVI, WebM for video and PNG for screenshots. You can adjust output video size, quality, resolution, framerate, video and audio codecs. Includes special privacy features for blacking out sensitive information on screen. Can also capture video from web camera, can add overlays with text or images. It can merge WMV video files in VBScript and VB6.

Want to quickly learn? This fast application programming interfaces of ByteScout Screen Capturing SDK for VBScript and VB6 plus the guidelines and the code below will help you quickly learn how to merge WMV video files.  Simply copy and paste in your VBScript and VB6 project or application you and then run your app! Use of ByteScout Screen Capturing SDK in VBScript and VB6 is also described in the documentation included along with the product.

ByteScout provides the free trial version of ByteScout Screen Capturing SDK along with the documentation and source code samples.

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

##### **MergeWMVVideoFiles.vbs:**
    
```
' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' Merge WMV files that were previously created by the ByteScout Screen Capturer (must be of same size, FPS and type)
capturer.JoinWMVFiles "Sample1.wmv", "Sample2.wmv", "output.wmv"

MsgBox "Files merged successfully!"

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing

```

<!-- code block end -->