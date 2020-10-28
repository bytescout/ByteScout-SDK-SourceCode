## How to record screen video in Java using ByteScout Screen Capturing SDK

### Write code in Java to record screen video with this step-by-step tutorial

With this source code sample you may quickly learn how to record screen video in Java. ByteScout Screen Capturing SDK is the SDK for developers for quick implementation of screen video recording. The SDK records screen into video or into a series of screenshots. Can also record audio. Saves video into AVI,WMV and Google's WebM. Output video quality, size, resolution or framerate can be adjusted easily. Provides additional tools for privacy features like blacking out on scren areas with sensitive information on screen right during recording. Supports web camera as input and can add instant text and images into video output and you can use it to record screen video with Java.

You will save a lot of time on writing and testing code as you may just take the Java code from ByteScout Screen Capturing SDK for record screen video below and use it in your application. This Java sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Test Java sample code examples whether they respond your needs and requirements for the project.

ByteScout Screen Capturing SDK free trial version is available on our website. Java and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Screen%20Capturing%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Screen%20Capturing%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=fujkvtWUVCw](https://www.youtube.com/watch?v=fujkvtWUVCw)




<!-- code block begin -->

##### **Readme.txt:**
    
```
If you are running your Java application on Windows then you may use Screen Capturing SDK from Java using the Jacob library ( you may get it from http://danadler.com/jacob/ )

The final code (using Jacob) code should look like this 

import com.ms.com.*;
import com.ms.activeX.*;

public class DispatchTest
{
 public static void main(String[] args)
 {
   ActiveXComponent captureLib = new ActiveXComponent("BytescoutScreenCapturing.Capturer");
   Object capturer = captureLib.getObject();
   try {
     // output file name
     Dispatch.put(capturer, "OutputFileName", "EntireScreenCaptured.wmv");
    // output width 
    Dispatch.put(capturer, "OutputWidth", 640);
    // output height
     Dispatch.put(capturer, "OutputHeight", 480);
    // setting the capturing type to 3 (entire screen)
     Dispatch.put(capturer, "CapturingType", 3);

    // run the recording
     Variant f = new Variant(false);
     Dispatch.call(workbook, "Run", f);

     // record for 5 seconds
     Thread.sleep(4000);

   } catch (Exception e) {
     e.printStackTrace();
   } finally {
           ;
   }
 }
}
```

<!-- code block end -->    

<!-- code block begin -->

##### **Test.java:**
    
```
/*
If you are running your Java application on Windows then you may use Screen Capturing SDK from Java using the Jacob library ( you may get it from http://danadler.com/jacob/ )

The final code (using Jacob) code should look like this 
*/
import com.ms.com.*;
import com.ms.activeX.*;

public class DispatchTest
{
 public static void main(String[] args)
 {
   ActiveXComponent captureLib = new ActiveXComponent("BytescoutScreenCapturing.Capturer");
   Object capturer = captureLib.getObject();
   try {
     // output file name
     Dispatch.put(capturer, "OutputFileName", "EntireScreenCaptured.wmv");
    // output width 
    Dispatch.put(capturer, "OutputWidth", 640);
    // output height
     Dispatch.put(capturer, "OutputHeight", 480);
    // setting the capturing type to 3 (entire screen)
     Dispatch.put(capturer, "CapturingType", 3);

    // run the recording
     Variant f = new Variant(false);
     Dispatch.call(workbook, "Run", f);

     // record for 5 seconds
     Thread.sleep(4000);

   } catch (Exception e) {
     e.printStackTrace();
   } finally {
           ;
   }
 }
}
```

<!-- code block end -->