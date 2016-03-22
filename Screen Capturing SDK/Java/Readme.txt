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