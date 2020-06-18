## How to fix scaling and incorrect coordinates in Windows with ByteScout Screen Capturing SDK ByteScout Screen Capturing SDK is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video.

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

##### **HowTo.txt:**
    
```
## How to Solve Issues with Scaling

#### Issues to be solved: 

- incorrect coordinates for mouse cursor when recording video from screen.
- incorrect scaling or incorrect area on Windows with non-standard DPI (High DPI) settings or display or screen scaling enabled.

#### Solution

For Windows 10: Screen Capturing SDK automatically checks scaling and DPI settings and adjusts coordinates when needed.
For Windows XP to Windows 8: need to add "manifest" file to enable "dpi awareness" flag for your application. With this flag Windows will adjust pass correct coordinates to ByteScout Screen Capturing SDK and to your application.

IMPORTANT 1: when screen DPI or scaling settings are changed (from 100% to lets say 125%) then the user MUST log out and then log in (or restart the machine) for the application to work correctly.

IMPORTANT 2: the application that uses SDK has to declare itself as "DPI Aware". After this the application will get correct coordinates from Windows. 


HOW TO ADD "DPI Awareness" FLAG: 

Solution from Microsoft: https://msdn.microsoft.com/en-us/library/windows/desktop/mt846517%28v=vs.85%29.aspx?f=255&MSPPError=-2147217396

From Stackoverflow (different Visual Studio versions): https://stackoverflow.com/questions/6050478/how-do-i-create-edit-a-manifest-file

Now, to make ScreenCapturingConsoleTest C++ application DPI aware, I have added additional Manifest file (in the project the file is called manifest.xml). You have to add this in the ManifestTool, like in the image:
manifest_configuration

In Visual Studio 2005 or later you can't explicitly add manifest file to the project. You'll have to do it manually. The explanation is here: https://support.microsoft.com/en-za/help/944276/how-to-embed-a-manifest-file-in-an-executable-file-in-visual-studio-20

For C++ apps, starting from VS 2010, you can add manifest files directly from the project in VS. It will be embedded in the final executable.

HOW TO CHECK IF YOUR APP IS DPI AWARE: 

You can check it with SysInternals Process Explorer (https://docs.microsoft.com/en-us/sysinternals/downloads/process-explorer) 
Enable and select the "DPI Awareness Column". If your app is "DPI Aware" then it will display "System Aware" or "Per Monitor Aware". If it is not dpi aware then it will display "Unaware".
```

<!-- code block end -->