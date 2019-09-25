## How to fix audio recording not working in Windows using ByteScout Screen Capturing SDK

### How to fix audio recording not working in Windows

Learn how to fix audio recording not working in Windows with this source code sample. ByteScout Screen Capturing SDK is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video and you can use it to fix audio recording not working with Windows.

Windows code samples for Windows developers help to speed up coding of your application when using ByteScout Screen Capturing SDK. Just copy and paste the code into your Windows application’s code and follow the instruction. Code testing will allow the function to be tested and work properly with your data.

You can download free trial version of ByteScout Screen Capturing SDK from our website to see and try many others source code samples for Windows.

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

##### ****HowTo.txt:**
    
```

If you have no sound in Screen Capturing then try the following: If you are running Windows 7 and have a Realtek sound card the virtual-audio-capturer or Stereo Mix may be missing from the selectable Audio Input > Device setting.

**[!] Before attempting this solution, make sure your Windows is fully up-to-date and you have the latest Realtek drivers.**

Solution:

1. Press Windows Key + R to open Run
2. type "control mmsys.cpl sounds" (without the quotes) and hit Enter
3. Click the Recording tab and check if the Stereo Mix device is there
-  If yes, right-click on it and select Enable then restart the Screen Capturing app
-  If no, right-click in a blank area and make sure Show Disabled Devices is checked then do the step 3.1
4. Enjoy!

```

<!-- code block end -->