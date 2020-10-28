## How to generate slide show in .NET Core with ByteScout Image To Video SDK

### Tutorial on how to generate slide show in .NET Core

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. ByteScout Image To Video SDK is the library for conversion of images into video slideshow. Provides built-in support for more than hundred of 2D and 3D transition effects. Output formats supported are AVI,WMV and WEBM video files. You may adjust output video size, quality, framerate and add audio. It can be used to generate slide show using .NET Core.

Fast application programming interfaces of ByteScout Image To Video SDK for .NET Core plus the instruction and the code below will help you quickly learn how to generate slide show. Just copy and paste the code into your .NET Core application’s code and follow the instruction. Further enhancement of the code will make it more vigorous.

Free trial version of ByteScout Image To Video SDK is available for download from our website. Get it to try other source code samples for .NET Core.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Image%20To%20Video%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Image%20To%20Video%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=FzPgeGFL8YA](https://www.youtube.com/watch?v=FzPgeGFL8YA)




<!-- code block begin -->

##### ****NetCoreExample.csproj:**
    
```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.1</TargetFramework>
    <StartupObject>NetCoreExample.Program</StartupObject>
  </PropertyGroup>

  <ItemGroup>
    <None Update="slide1.jpg">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Update="slide2.jpg">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Update="slide3.jpg">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>

</Project>

```

<!-- code block end -->    

<!-- code block begin -->

##### ****NetCoreExample.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.28010.2046
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "NetCoreExample", "NetCoreExample.csproj", "{84CBDE72-A4DD-405D-8033-ED59361CE926}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{84CBDE72-A4DD-405D-8033-ED59361CE926}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{84CBDE72-A4DD-405D-8033-ED59361CE926}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{84CBDE72-A4DD-405D-8033-ED59361CE926}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{84CBDE72-A4DD-405D-8033-ED59361CE926}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {4AAF333D-20BB-4420-B6BF-E8BEC84CCEC5}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
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

```

<!-- code block end -->