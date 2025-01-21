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
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing;
using BytescoutScreenCapturingLib;


// NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
// try to do the following:
// 1) remove the reference to the SDK by View - Solution Explorer
// then click on References, select Bytescout... reference name and right-click it and select Remove
// 2) To re-add click on the menu: Project - Add Reference
// 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
// 4) Select it and click "Add" 
// 5) Recompile the application 
// Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference

namespace CaptureScreenCSharp
{
    public class Win32Interop
    {
        [DllImport("crtdll.dll")]
        public static extern int _kbhit();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Capturer capturer = new Capturer(); // create new screen capturer object


            if (args.Length < 1)
            {
                usage(capturer);
                return;
            }

            capturer.OutputFileName = args[0];
            capturer.CapturingType = CaptureAreaType.catRegion;
            setParams(args, capturer);

            // set border around captured area if we are not capturing entire screen
            if (
                capturer.CapturingType != CaptureAreaType.catScreen &&
                capturer.CapturingType != CaptureAreaType.catWebcamFullScreen
                )
            {
                // set border style
                capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed;
                capturer.CaptureAreaBorderColor = (uint)ColorTranslator.ToOle(Color.Red);
            }

	    // uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
	    // capturer.CaptureTransparentControls = true;

	    // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
   	    // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
	    // capturer.WMVVideoBitrate = capturer.WMVVideoBitrate * 2;


            try
            {
                capturer.Run();

	// IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	// using Thread.Sleep(1) inside the checking loop, so you have the loop like
	// Do {
	// Thread.Sleep(1) 
	// }
	// While(StopButtonNotClicked);

                Console.WriteLine("Starting capture - Hit a key to stop ...");

                string s = capturer.CurrentVideoCodecName;
                Console.WriteLine(string.Format("Using video compressor - {0}", s));

                s = capturer.CurrentAudioCodecName;
                Console.WriteLine(string.Format("Using audio compressor - {0}", s));

                s = capturer.CurrentAudioDeviceLineName;
                Console.WriteLine(string.Format("Using audio input line - {0}", s));

                int i = 0;
                string spin = "|/-\\";
                while (Win32Interop._kbhit() == 0)
                {
                    Console.Write(string.Format("\rEncoding {0}", spin[i++]));
                    i %= 4;
                    Thread.Sleep(50);
                }

                capturer.Stop();

            // Release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(capturer);
            capturer = null;

                Console.Write("\nDone");
                Console.Read();
            }
            catch (Exception)
            {
                Console.WriteLine(capturer.LastError);
            }
        }

        static void usage(Capturer capturer)
        {
            Console.WriteLine("Usage : CaptureScreenCSharp.exe <outfilename> [left] [top] [width] [height] [fps] [v-codec] [a-codec] [audioline]\n");
            Console.WriteLine("[left, top, width, height] is the rectangle to be captured");
            Console.WriteLine("[v-codec] is the index of the video codec in the list to use.");
            Console.WriteLine("[a-codec] is the index of the audio codec in the list to use.");
            Console.WriteLine("[audioline] is the index of the audio line in the list to capture from");
            Console.WriteLine("If either codec is unspecified, it defaults to 'Microsoft Video 1' and 'GSM 6.10'");
            Console.WriteLine("If audioline is unspecified, it uses the microphone");
            Console.WriteLine("To capture the currently playing output, select the stereo, mono or wave mix");
            
            Console.WriteLine("Installed Video Codecs (Note : Not all of them may work)");

            for (int i = 0; i < capturer.VideoCodecsCount; i++)
            {
                string name = capturer.GetVideoCodecName(i);
                Console.WriteLine(string.Format("    {0}. {1}", i, name));
            }

            Console.WriteLine("\nInstalled Audio Codecs (Note : Not all of them may work)");
            for (int i = 0; i < capturer.AudioCodecsCount; i++)
            {
                string name = capturer.GetAudioCodecName(i);
                Console.WriteLine(string.Format("    {0}. {1}", i, name));
            }

            Console.WriteLine("\nAudio input lines");
            for (int i = 0; i < capturer.CurrentAudioDeviceLineCount; i++)
            {
                string name = capturer.GetCurrentAudioDeviceLineName(i);
                Console.WriteLine(string.Format("    {0}. {1}", i, name));
            }
        }

        static void setParams(string[] args, Capturer capturer)
        {
            if (args.Length > 1)
            {
                int left = int.Parse(args[1]);
                capturer.CaptureRectLeft = left;
            }

            if (args.Length > 2)
            {
                int top = int.Parse(args[2]);
                capturer.CaptureRectTop = top;
            }

            if (args.Length > 3)
            {
                int width = int.Parse(args[3]);
                capturer.CaptureRectWidth = width;
            }

            if (args.Length > 5)
            {
                int height = int.Parse(args[5]);
                capturer.CaptureRectHeight = height;
            }

            if (args.Length > 6)
            {
                float fps = float.Parse(args[6], CultureInfo.InvariantCulture);
                capturer.FPS = fps;
            }

            if (args.Length > 7)
            {
                int vCodec = int.Parse(args[7]);
                capturer.CurrentVideoCodec = vCodec;
            }

            if (args.Length > 8)
            {
                int aCodec = int.Parse(args[8]);
                capturer.CurrentAudioCodec = aCodec;
            }

            if (args.Length > 9)
            {
                int aLine = int.Parse(args[9]);
                capturer.CurrentAudioDeviceLine = aLine;
            }
        }
    }
}
