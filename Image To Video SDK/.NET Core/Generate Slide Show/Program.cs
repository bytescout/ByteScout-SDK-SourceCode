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
using System.Reflection;

namespace NetCoreExample
{
    /// <summary>
    /// This example demonstrates the use of "ImageToVideo" ActiveX object from .NET Core application using the reflection.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of BytescoutImageToVideo.ImageToVideo ActiveX object
            object converter = Activator.CreateInstance(Type.GetTypeFromProgID("BytescoutImageToVideo.ImageToVideo", true));

            // Activate the component
            SetProperty(converter, "RegistrationName", "demo");
            SetProperty(converter, "RegistrationKey", "demo");

            // Get Slides collection
            object slides = GetProperty(converter, "Slides");

            // Set default "in" effect for slides (you can also set effects for each slide separately)
            SetProperty(slides, "DefaultSlideInEffect", 1); // 1 - "Fade-in" effect\
            // Set default "in" effect duration (you can also set it for each slide separately)
            SetProperty(slides, "DefaultSlideInEffectDuration", 500);
            
            // Add slides and set durations
            object slide1 = InvokeMethod(converter, "AddImageFromFileName", new object[] { @".\slide1.jpg" });
            SetProperty(slide1, "Duration", 3000);
            object slide2 = InvokeMethod(converter, "AddImageFromFileName", new object[] { @".\slide2.jpg" });
            SetProperty(slide2, "Duration", 3000);
            object slide3 = InvokeMethod(converter, "AddImageFromFileName", new object[] { @".\slide3.jpg" });
            SetProperty(slide3, "Duration", 3000);

            // Set output video size
            SetProperty(converter, "OutputWidth", 640);
            SetProperty(converter, "OutputHeight", 480);

            // Set output video file name
            SetProperty(converter, "OutputVideoFileName", "result.wmv");

            // Run the conversion
            InvokeMethod(converter, "RunAndWait", null);
        }

        static void SetProperty(object target, string propertyName, object value)
        {
            target.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, target, new object[] { value });
        }

        static object GetProperty(object target, string propertyName)
        {
            return target.GetType().InvokeMember(propertyName, BindingFlags.GetProperty, null, target, null);
        }

        static object InvokeMethod(object target, string methodName, object[] parameters)
        {
            return target.GetType().InvokeMember(methodName, BindingFlags.InvokeMethod, null, target, parameters);
        }
    }
}
