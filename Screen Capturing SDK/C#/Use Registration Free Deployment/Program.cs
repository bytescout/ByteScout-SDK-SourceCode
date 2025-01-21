//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using BytescoutScreenCapturingLib; // import bytescout screen capturing activex object 

/*
// NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
// try to do the following:
// 1) remove the reference to the SDK by View - Solution Explorer
// then click on References, select Bytescout... reference name and right-click it and select Remove
// 2) To re-add click on the menu: Project - Add Reference
// 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
// 4) Select it and click "Add" 
// 5) Recompile the application 
// Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference
*/

/*
 * REGISTRATION FREE SCENARIO DEPLOYMENT: 

Please check README-FIRST.txt for more details!!


HOW MANIFEST FILES WERE GENERATED

1) Files from Redistributable\x86 were copied into the folder ScreenCapturingSDK\x86\
2) The regsvr42 tool ran with the following command: (The tool is acailable from http://www.codeproject.com/Articles/28682/regsvr-Generate-SxS-Manifest-Files-from-Native-D )
regsvr42 -client:SimpleCaptureCSharp.exe -dir:ScreenCapturingSDK\x86
3)the following file was generated x86.manifest
4) copy everything from this x86.manifest file from this tag:
<file 

to the beginning of the </assembly> tag (do not include this tag)
5) Main application was recompiled
6) The copied code (from 4) was pasted into the main MyApp.exe.manifest right after the  <assemblyIdentity> tag
7) Due to the bug in regsvr42 needs to remove duplicated COM interfaces declaration:
  
For example the first COM interface declaration:
 
<comInterfaceExternalProxyStub
   name="ICapturer"
   iid="{DCAFCA37-546E-4D0A-9C02-D3221E65FCA9}"

But the same interface (with the same GUID) is declared again (removed the duplicated declaration):
 
<comInterfaceExternalProxyStub
   name="{DCAFCA37-546E-4D0A-9C02-D3221E65FCA9}"
   iid="{DCAFCA37-546E-4D0A-9C02-D3221E65FCA9}"

Need to remove all these duplicates 

8) Now you may run your application MyApp.exe without need for the Administrator level installation
 * 
 * 
 */


namespace SimpleCaptureCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create Capturer instance.
                Capturer capturer = new Capturer();

                // Set capturing area type to catScreen to capture entire screen.
                capturer.CapturingType = CaptureAreaType.catScreen;

                // Set output video file name.
                // (!) The file extension defines the output video format (.WVM or .AVI).
                capturer.OutputFileName = "EntireScreenCaptured.wmv"; 

                // Set output video width and height
                capturer.OutputWidth = 1024;
                capturer.OutputHeight = 600;

                // Start capturing .
                capturer.Run(); 

                Console.WriteLine("Capturing entire screen for 10 seconds...");

                // Wait for 10 seconds...
                new ManualResetEvent(false).WaitOne(10000);

                // Stop capturing.
                capturer.Stop();

                // Release objects
                Marshal.ReleaseComObject(capturer);
                
                Console.WriteLine("Done");

                Process.Start("EntireScreenCaptured.wmv");
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
