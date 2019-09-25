## How to use registration free deployment in C# using ByteScout Screen Capturing SDK

### How to code in C# to use registration free deployment with this step-by-step tutorial

Learn how to use registration free deployment in C# with this source code sample. ByteScout Screen Capturing SDK: the tool for developers who want to add screen capturing in their application. Can record screen into video and into single screenshots. Output formats are WMV, AVI, WebM for video and PNG for screenshots. You can adjust output video size, quality, resolution, framerate, video and audio codecs. Includes special privacy features for blacking out sensitive information on screen. Can also capture video from web camera, can add overlays with text or images. It can use registration free deployment in C#.

You will save a lot of time on writing and testing code as you may just take the C# code from ByteScout Screen Capturing SDK for use registration free deployment below and use it in your application. In order to implement the functionality, you should copy and paste this code for C# below into your code editor with your app, compile and run your application. Implementing C# application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Download free trial version of ByteScout Screen Capturing SDK from our website with this and other source code samples for C#.

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

##### ****Program.cs:**
    
```
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

```

<!-- code block end -->    

<!-- code block begin -->

##### ****README-FIRST.txt:**
    
```
** How to setup the registration free deployment in your project **

1. Right-click your project in the solution tree, select 'Add'->'Existing Items...' menu item and add "app.manifest" file.

2. Open the project properties. On the Application tab select "app.manifest" in "Manifest" combo-box. 
   Now when you build the project the manifest will embedded into the assembly resources.

   * Alternative way *
   Rename the added "app.manifest" into "YourAssemblyName.exe.manifest".
   In the file's properties set "Copy to Output Directory" to "Copy always".
   Now the file will be copied to the output folder automatically and the manifest will be loaded from 
   the file instead of resources.

3. Right-click your project in the solution tree, select 'Add'->'Existing Items...' menu item and add 
   "ByteScoutScreenCapturing.dll", "ByteScoutScreenCapturingFilter.dll" and "ByteScoutVideoMixerFilter.dll" files.
   Set "Copy to Output Directory" property to "Copy always" for the each file.
   * You can find these files in "Redistributable" folder of the SDK installation directory.
   (Default location: "c:\Program Files\ByteScout Screen Capturing SDK\Redistributable").

4. Clean and rebuild your project.

```

<!-- code block end -->    

<!-- code block begin -->

##### ****SimpleCaptureCSharp.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{21F1C67C-7C5A-46F4-ADB8-84FC70E99969}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>SimpleCaptureCSharp</RootNamespace>
    <AssemblyName>SimpleCaptureCSharp</AssemblyName>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup>
    <NoWin32Manifest>true</NoWin32Manifest>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup>
    <ApplicationManifest>app.manifest</ApplicationManifest>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutScreenCapturingLib">
      <Guid>{8EDAD3BB-AE5F-43B4-A2F1-B04F4130F2E0}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
      <EmbedInteropTypes>True</EmbedInteropTypes>
    </COMReference>
    <COMReference Include="stdole">
      <Guid>{00020430-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>2</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
    <None Include="app.manifest" />
  </ItemGroup>
  <ItemGroup>
    <None Include="README-FIRST.txt" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="C:\Program Files\Bytescout Screen Capturing SDK\Redistributable\x64\BytescoutScreenCapturing.dll">
      <Link>BytescoutScreenCapturing.dll</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="C:\Program Files\Bytescout Screen Capturing SDK\Redistributable\x64\BytescoutScreenCapturingFilter.dll">
      <Link>BytescoutScreenCapturingFilter.dll</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="C:\Program Files\Bytescout Screen Capturing SDK\Redistributable\x64\BytescoutVideoMixerFilter.dll">
      <Link>BytescoutVideoMixerFilter.dll</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>
```

<!-- code block end -->