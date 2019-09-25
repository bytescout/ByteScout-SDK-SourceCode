## How to capture entire screen video in JavaScript using ByteScout Screen Capturing SDK

### Write code in JavaScript to capture entire screen video with this step-by-step tutorial

Sample source code below will show you how to cope with a difficult task like capture entire screen video in JavaScript. ByteScout Screen Capturing SDK is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video. It can capture entire screen video in JavaScript.

The SDK samples like this one below explain how to quickly make your application do capture entire screen video in JavaScript with the help of ByteScout Screen Capturing SDK. Just copy and paste the code into your JavaScript application’s code and follow the instruction. You can use these JavaScript sample examples in one or many applications.

ByteScout Screen Capturing SDK free trial version is available on our website. JavaScript and other programming languages are supported.

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

##### ****HelloWorld.js:**
    
```
 var capturer = WScript.CreateObject('BytescoutScreenCapturing.Capturer');

 // set output video file name to .WMV or .AVI
 capturer.OutputFileName = "EntireScreenCaptured.wmv";

 // set capturing type to the caScreen =3 to capture the entire screen
 capturer.CapturingType = 3;

 // output video width
 capturer.OutputWidth = 640;

 // output video height
 capturer.OutputHeight = 480;
 
 // uncomment to set Bytescout Lossless Video format output video compression method
 // do not forget to set file to .avi format if you use Video Codec Name
 // capturer.CurrentVideoCodecName = "Bytescout Lossless"; 

 // uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
 // capturer.CaptureTransparentControls = true;


 // run video capturing 
 capturer.Run();

	// IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	// using Thread.Sleep(1) inside the checking loop, so you have the loop like
	// Do 
	// Thread.Sleep(1) 
	// While StopButtonNotClicked


 // wait for 15seconds (15000 msec)
 WScript.Sleep(15000);

 // stop capturing
 capturer.Stop();

 // destroy Capturer object so the video will be saved into the disk
 capturer = null;


```

<!-- code block end -->