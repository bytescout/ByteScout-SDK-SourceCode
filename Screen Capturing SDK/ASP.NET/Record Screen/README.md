## How to record screen in ASP.NET with ByteScout Screen Capturing SDK

### Tutorial on how to record screen in ASP.NET

On this page you will learn from code samples for programming in ASP.NET.Writing of the code to record screen in ASP.NET can be done by developers of any level using ByteScout Screen Capturing SDK. ByteScout Screen Capturing SDK is the SDK for developers for quick implementation of screen video recording. The SDK records screen into video or into a series of screenshots. Can also record audio. Saves video into AVI,WMV and Google's WebM. Output video quality, size, resolution or framerate can be adjusted easily. Provides additional tools for privacy features like blacking out on scren areas with sensitive information on screen right during recording. Supports web camera as input and can add instant text and images into video output. It can record screen in ASP.NET.

This rich sample source code in ASP.NET for ByteScout Screen Capturing SDK includes the number of functions and options you should do calling the API to record screen. This ASP.NET sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Implementing ASP.NET application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Free trial version of ByteScout Screen Capturing SDK is available on our website. Documentation and source code samples are included.

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

##### ****README-FIRST.txt:**
    
```
Interact with desktop permission may be required to run Screen Capturing SDK or SWF To Video SDK from service or to convert interactive ("live") flash movies with SWF To Video SDK

You may set this "Allow to interact with desktop" checkbox for the user that is used to run the service/app 
For IIS asp.net apps this user name is typically IIS_... user name

Important note for Windows Server 2008 or later

Newest Windows has disabled interactive services 

New Windows versions are no longer allowing to run interactive services by default to prevent services from accessing the desktop (to provide more security)

If you must run a Screen Capturing SDK or SWF To Video SDK from an interactive service then you may sacrifice server stability for compatibility by changing the following registry value from the default of "1" to "0".

HKLM\SYSTEM\CurrentControlSet\Control\Windows 
NoInteractiveServices

Then reboot so Windows will pick the new value from the registry and the Interactive Services Detection Service will start.

To make this change manually please do the following 

Start the registry editor (regedit.exe) in As Administrator mode
Locate the following Registry key: HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Windows on the left side
double-click the NoInteractiveServices entry on the right side and change its value from 1 to 0
Then click OK and close the registry editor
Restart the computer
```

<!-- code block end -->