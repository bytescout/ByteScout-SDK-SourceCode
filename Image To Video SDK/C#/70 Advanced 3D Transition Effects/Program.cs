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
using System.Diagnostics;
using BytescoutImageToVideo;
namespace TransitionEffects
{
	class Program
	{
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Converting JPG slides to video with 70 advanced 3D effects variations, please wait...");

                // Create BytescoutImageToVideoLib.ImageToVideo object instance
                ImageToVideo converter = new ImageToVideo();

                // Activate the component
                converter.RegistrationName = "demo";
                converter.RegistrationKey = "demo";

                // Enable transition effects for the first first slide
                converter.UseInEffectForFirstSlide = true;

                converter.Slides.DefaultSlideDuration = 1000;
                converter.Slides.DefaultSlideEffectDuration = 500;

                bool bChangeSlide = true; // temporary variable to change slides


                // now try all 70 advanced 3D transition effects from 70 to 140
                for (int i = 67; i < 140; i++)
                {

                    // Add slide image, set the duration

                    Slide slide = null;

                    if (!bChangeSlide)
                    {
                        slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide1.jpg");
                    }
                    else
                    {
                        slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide2.jpg");
                    }

                    bChangeSlide = !bChangeSlide; // switch to use another slide next tim

                    slide.InEffect = (TransitionEffectType)i; // effect index

                }


                // Set output video size
                converter.OutputWidth = 320;
                converter.OutputHeight = 240;

                // Set output video file name
                converter.OutputVideoFileName = "result.wmv";

                // Run the conversion
                converter.RunAndWait();

				// Release resources
				System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);
				converter = null;


                // Open the result video file in default media player
                Process.Start("result.wmv");

                Console.WriteLine("Done. Press any key to continue...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
            }
        }
	}
}
