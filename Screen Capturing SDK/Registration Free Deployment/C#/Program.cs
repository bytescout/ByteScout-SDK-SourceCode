//*******************************************************************
//       ByteScout Screen Capturing SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

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
 * REGISTRRATION FREE SCENARIO DEPLOYMENT: allows to just copy DLLs from the SDK without installing them
 * See SAMPLE.EXE.manfest as the sample. 
 * 1) Rename "SAMPLE.EXE.manifest" into the actual application name (e.g. "MyApp.exe.manifest")
 * 2) Edit this .manifest file and replace "SAMPLE.EXE" with your application name (e.g. "MyApp.exe")
 * 3) Copy put this .manifest file into the same folder where your MyApp.exe is located
 * 4) Copy all dlls from /x86/ folder into the same folder as your application
 * So you will have files in the folder:
 * - MyApp.exe
 * - MyApp.exe.manifest
 * - BytescoutVideoMixerFilter.dll
 * - BytescoutScreenCapturingFilter.dll
 * - BytescoutScreenCapturing.dll
 * 5) IMPORTANT: since Windows Server 2003 external manifests are IGNORED in favor of internal ones. 
 * To disable the embedded manifest open Project | Properties.. | Application | Resources | Icon and Manifest | Manifest and change to "Create Application without manifest"
 * 6) Now you should be able run MyApp.exe without Screen Capturing SDK installed
 * 7) IMPORTANT: for Windows x86 you should copy dlls from /Redistributable/x86/ into the same folder as MyApp.exe
      but for Windows x64 you should copy dlls from /Redistributable/x64/ !

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

                Capturer capturer = new Capturer(); // create new screen capturer object

                capturer.CapturingType = CaptureAreaType.catScreen; // set capturing area type to catScreen to capture whole screen

                capturer.OutputFileName = "EntireScreenCaptured.wmv"; // set output video filename to .WVM or .AVI filename

                // set output video width and height
                capturer.OutputWidth = 640;
                capturer.OutputHeight = 480;

                // set border around captured area if we are not capturing entire screen
                if (
                    capturer.CapturingType != CaptureAreaType.catScreen &&
                    capturer.CapturingType != CaptureAreaType.catWebcamFullScreen
                    )
                {
                    // set border style
                    capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed;
                }

                // uncomment to set Bytescout Lossless Video format output video compression method
                //do not forget to set file to .avi format if you use Video Codec Name
                //capturer.CurrentVideoCodecName = "Bytescout Lossless";             


                // uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
                // capturer.CaptureTransparentControls = true;

                capturer.Run(); // run screen video capturing 

                // IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
                // using Thread.Sleep(1) inside the checking loop, so you have the loop like
                // Do {
                // Thread.Sleep(1) 
                // }
                // While(StopButtonNotClicked);

                Console.WriteLine("Capturing entire screen for 15 seconds...");

                Thread.Sleep(15000); // wait for 15 seconds

                capturer.Stop(); // stop video capturing

                // Release resources
                System.Runtime.InteropServices.Marshal.ReleaseComObject(capturer);
                capturer = null;

                Console.WriteLine("Done");

                Process.Start("EntireScreenCaptured.wmv");
            }
            finally
            {
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
