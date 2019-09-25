## How to set barcode options and code128 alphabet in Delphi and ByteScout Barcode SDK

### The tutorial below will demonstrate how to set barcode options and code128 alphabet in Delphi

The code below will help you to implement an Delphi app to set barcode options and code128 alphabet. ByteScout Barcode SDK can set barcode options and code128 alphabet. It can be used from Delphi. ByteScout Barcode SDK is the robost SDK that generates high quality barcode images and pdf. Can generate all popular types of barcodes from QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix to more exotic barcode types. Fully customizable fonts, colors, print sizes. Includes special functions to ensure output quality, and tools for adding barcodes to new or existing pdf files and images.

You will save a lot of time on writing and testing code as you may just take the Delphi code from ByteScout Barcode SDK for set barcode options and code128 alphabet below and use it in your application. Just copy and paste the code into your Delphi application’s code and follow the instruction. You can use these Delphi sample examples in one or many applications.

Our website provides trial version of ByteScout Barcode SDK for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=REnj3A-oSPI](https://www.youtube.com/watch?v=REnj3A-oSPI)




<!-- code block begin -->

##### ****Project1.bdsproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<BorlandProject>
	<PersonalityInfo>
		<Option>
			<Option Name="Personality">Delphi.Personality</Option>
			<Option Name="ProjectType"></Option>
			<Option Name="Version">1.0</Option>
			<Option Name="GUID">{2168453D-CDA3-43AE-A177-0DDAEFD0CDF0}</Option>
		</Option>
	</PersonalityInfo>
	<Delphi.Personality>
		<Source>
			<Source Name="MainSource">Project1.dpr</Source>
		</Source>
		<FileVersion>
			<FileVersion Name="Version">7.0</FileVersion>
		</FileVersion>
		<Compiler>
			<Compiler Name="A">8</Compiler>
			<Compiler Name="B">0</Compiler>
			<Compiler Name="C">1</Compiler>
			<Compiler Name="D">1</Compiler>
			<Compiler Name="E">0</Compiler>
			<Compiler Name="F">0</Compiler>
			<Compiler Name="G">1</Compiler>
			<Compiler Name="H">1</Compiler>
			<Compiler Name="I">1</Compiler>
			<Compiler Name="J">0</Compiler>
			<Compiler Name="K">0</Compiler>
			<Compiler Name="L">1</Compiler>
			<Compiler Name="M">0</Compiler>
			<Compiler Name="N">1</Compiler>
			<Compiler Name="O">1</Compiler>
			<Compiler Name="P">1</Compiler>
			<Compiler Name="Q">0</Compiler>
			<Compiler Name="R">0</Compiler>
			<Compiler Name="S">0</Compiler>
			<Compiler Name="T">0</Compiler>
			<Compiler Name="U">0</Compiler>
			<Compiler Name="V">1</Compiler>
			<Compiler Name="W">0</Compiler>
			<Compiler Name="X">1</Compiler>
			<Compiler Name="Y">1</Compiler>
			<Compiler Name="Z">1</Compiler>
			<Compiler Name="ShowHints">True</Compiler>
			<Compiler Name="ShowWarnings">True</Compiler>
			<Compiler Name="UnitAliases">WinTypes=Windows;WinProcs=Windows;DbiTypes=BDE;DbiProcs=BDE;DbiErrs=BDE;</Compiler>
			<Compiler Name="NamespacePrefix"></Compiler>
			<Compiler Name="GenerateDocumentation">False</Compiler>
			<Compiler Name="DefaultNamespace"></Compiler>
			<Compiler Name="SymbolDeprecated">True</Compiler>
			<Compiler Name="SymbolLibrary">True</Compiler>
			<Compiler Name="SymbolPlatform">True</Compiler>
			<Compiler Name="SymbolExperimental">True</Compiler>
			<Compiler Name="UnitLibrary">True</Compiler>
			<Compiler Name="UnitPlatform">True</Compiler>
			<Compiler Name="UnitDeprecated">True</Compiler>
			<Compiler Name="UnitExperimental">True</Compiler>
			<Compiler Name="HResultCompat">True</Compiler>
			<Compiler Name="HidingMember">True</Compiler>
			<Compiler Name="HiddenVirtual">True</Compiler>
			<Compiler Name="Garbage">True</Compiler>
			<Compiler Name="BoundsError">True</Compiler>
			<Compiler Name="ZeroNilCompat">True</Compiler>
			<Compiler Name="StringConstTruncated">True</Compiler>
			<Compiler Name="ForLoopVarVarPar">True</Compiler>
			<Compiler Name="TypedConstVarPar">True</Compiler>
			<Compiler Name="AsgToTypedConst">True</Compiler>
			<Compiler Name="CaseLabelRange">True</Compiler>
			<Compiler Name="ForVariable">True</Compiler>
			<Compiler Name="ConstructingAbstract">True</Compiler>
			<Compiler Name="ComparisonFalse">True</Compiler>
			<Compiler Name="ComparisonTrue">True</Compiler>
			<Compiler Name="ComparingSignedUnsigned">True</Compiler>
			<Compiler Name="CombiningSignedUnsigned">True</Compiler>
			<Compiler Name="UnsupportedConstruct">True</Compiler>
			<Compiler Name="FileOpen">True</Compiler>
			<Compiler Name="FileOpenUnitSrc">True</Compiler>
			<Compiler Name="BadGlobalSymbol">True</Compiler>
			<Compiler Name="DuplicateConstructorDestructor">True</Compiler>
			<Compiler Name="InvalidDirective">True</Compiler>
			<Compiler Name="PackageNoLink">True</Compiler>
			<Compiler Name="PackageThreadVar">True</Compiler>
			<Compiler Name="ImplicitImport">True</Compiler>
			<Compiler Name="HPPEMITIgnored">True</Compiler>
			<Compiler Name="NoRetVal">True</Compiler>
			<Compiler Name="UseBeforeDef">True</Compiler>
			<Compiler Name="ForLoopVarUndef">True</Compiler>
			<Compiler Name="UnitNameMismatch">True</Compiler>
			<Compiler Name="NoCFGFileFound">True</Compiler>
			<Compiler Name="ImplicitVariants">True</Compiler>
			<Compiler Name="UnicodeToLocale">True</Compiler>
			<Compiler Name="LocaleToUnicode">True</Compiler>
			<Compiler Name="ImagebaseMultiple">True</Compiler>
			<Compiler Name="SuspiciousTypecast">True</Compiler>
			<Compiler Name="PrivatePropAccessor">True</Compiler>
			<Compiler Name="UnsafeType">False</Compiler>
			<Compiler Name="UnsafeCode">False</Compiler>
			<Compiler Name="UnsafeCast">False</Compiler>
			<Compiler Name="OptionTruncated">True</Compiler>
			<Compiler Name="WideCharReduced">True</Compiler>
			<Compiler Name="DuplicatesIgnored">True</Compiler>
			<Compiler Name="UnitInitSeq">True</Compiler>
			<Compiler Name="LocalPInvoke">True</Compiler>
			<Compiler Name="MessageDirective">True</Compiler>
			<Compiler Name="CodePage"></Compiler>
		</Compiler>
		<Linker>
			<Linker Name="MapFile">0</Linker>
			<Linker Name="OutputObjs">0</Linker>
			<Linker Name="GenerateHpps">False</Linker>
			<Linker Name="ConsoleApp">1</Linker>
			<Linker Name="DebugInfo">False</Linker>
			<Linker Name="RemoteSymbols">False</Linker>
			<Linker Name="GenerateDRC">False</Linker>
			<Linker Name="MinStackSize">16384</Linker>
			<Linker Name="MaxStackSize">1048576</Linker>
			<Linker Name="ImageBase">4194304</Linker>
			<Linker Name="ExeDescription"></Linker>
		</Linker>
		<Directories>
			<Directories Name="OutputDir"></Directories>
			<Directories Name="UnitOutputDir"></Directories>
			<Directories Name="PackageDLLOutputDir"></Directories>
			<Directories Name="PackageDCPOutputDir"></Directories>
			<Directories Name="SearchPath"></Directories>
			<Directories Name="Packages"></Directories>
			<Directories Name="Conditionals"></Directories>
			<Directories Name="DebugSourceDirs"></Directories>
			<Directories Name="UsePackages">False</Directories>
		</Directories>
		<Parameters>
			<Parameters Name="RunParams"></Parameters>
			<Parameters Name="HostApplication"></Parameters>
			<Parameters Name="Launcher"></Parameters>
			<Parameters Name="UseLauncher">False</Parameters>
			<Parameters Name="DebugCWD"></Parameters>
			<Parameters Name="Debug Symbols Search Path"></Parameters>
			<Parameters Name="LoadAllSymbols">True</Parameters>
			<Parameters Name="LoadUnspecifiedSymbols">False</Parameters>
		</Parameters>
		<Language>
			<Language Name="ActiveLang"></Language>
			<Language Name="ProjectLang">$00000000</Language>
			<Language Name="RootDir"></Language>
		</Language>
		<VersionInfo>
			<VersionInfo Name="IncludeVerInfo">False</VersionInfo>
			<VersionInfo Name="AutoIncBuild">False</VersionInfo>
			<VersionInfo Name="MajorVer">1</VersionInfo>
			<VersionInfo Name="MinorVer">0</VersionInfo>
			<VersionInfo Name="Release">0</VersionInfo>
			<VersionInfo Name="Build">0</VersionInfo>
			<VersionInfo Name="Debug">False</VersionInfo>
			<VersionInfo Name="PreRelease">False</VersionInfo>
			<VersionInfo Name="Special">False</VersionInfo>
			<VersionInfo Name="Private">False</VersionInfo>
			<VersionInfo Name="DLL">False</VersionInfo>
			<VersionInfo Name="Locale">1049</VersionInfo>
			<VersionInfo Name="CodePage">1251</VersionInfo>
		</VersionInfo>
		<VersionInfoKeys>
			<VersionInfoKeys Name="CompanyName"></VersionInfoKeys>
			<VersionInfoKeys Name="FileDescription"></VersionInfoKeys>
			<VersionInfoKeys Name="FileVersion">1.0.0.0</VersionInfoKeys>
			<VersionInfoKeys Name="InternalName"></VersionInfoKeys>
			<VersionInfoKeys Name="LegalCopyright"></VersionInfoKeys>
			<VersionInfoKeys Name="LegalTrademarks"></VersionInfoKeys>
			<VersionInfoKeys Name="OriginalFilename"></VersionInfoKeys>
			<VersionInfoKeys Name="ProductName"></VersionInfoKeys>
			<VersionInfoKeys Name="ProductVersion">1.0.0.0</VersionInfoKeys>
			<VersionInfoKeys Name="Comments"></VersionInfoKeys>
		</VersionInfoKeys>  
    <Excluded_Packages>
      <Excluded_Packages Name="c:\program files\borland\bds\4.0\Bin\bcbie100.bpl">Borland C++Builder Internet Explorer 5 Components Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\DSPack_D2006.bpl">DSPack 2.3: Multimedia Package for Delphi</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\DirectX9_D2006.bpl">DirectX 9 Headers</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\SynEdit_R2005.bpl">SynEdit component suite runtime</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\tntExtendedEditors.bpl">TNT Extended Editors by lummie.co.uk</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\VirtualTreesD10.bpl">Virtual Treeview runtime package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\TntUnicodeVcl100.bpl">TntWare Unicode Controls - Runtime</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\Jcl100.bpl">JEDI Code Library RTL package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JclVcl100.bpl">JEDI Code Library VCL package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvCoreD10R.bpl">JVCL Core Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvSystemD10R.bpl">JVCL System Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvStdCtrlsD10R.bpl">JVCL Standard Controls Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvAppFrmD10R.bpl">JVCL Application and Form Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvCtrlsD10R.bpl">JVCL Visual Controls Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvBandsD10R.bpl">JVCL Band Objects Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvDBD10R.bpl">JVCL Database Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvDlgsD10R.bpl">JVCL Dialog Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvCustomD10R.bpl">JVCL Custom Controls Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvBDED10R.bpl">JVCL BDE Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvCmpD10R.bpl">JVCL Non-Visual Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvCryptD10R.bpl">JVCL Encryption and Compression Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvDockingD10R.bpl">JVCL Docking Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvDotNetCtrlsD10R.bpl">JVCL DotNet Controls Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvEDID10R.bpl">JVCL EDI Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvGlobusD10R.bpl">JVCL Globus Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvHMID10R.bpl">JVCL HMI Controls Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvInterpreterD10R.bpl">JVCL Interpreter Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvJansD10R.bpl">JVCL Jans Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvManagedThreadsD10R.bpl">JVCL Managed Threads Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvMMD10R.bpl">JVCL Multimedia and Image Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvNetD10R.bpl">JVCL Network Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvPageCompsD10R.bpl">JVCL Page Style Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvPluginD10R.bpl">JVCL Plugin Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvPrintPreviewD10R.bpl">JVCL Print Preview Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvRuntimeDesignD10R.bpl">JVCL Runtime Design Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvTimeFrameworkD10R.bpl">JVCL Time Framework Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvValidatorsD10R.bpl">JVCL Validators and Error Provider Components Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvWizardD10R.bpl">JVCL Wizard Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\JvXPCtrlsD10R.bpl">JVCL XP Controls Runtime Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\dklang10.bpl">DKLang Localization Package</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\tbx_d10.bpl">Toolbar2000 -- TBX Extensions (Alex Denisov)</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\tb2k_d10.bpl">Toolbar2000 Components (Jordan Russell)</Excluded_Packages>
      <Excluded_Packages Name="c:\program files\borland\bds\4.0\Bin\dclie100.bpl">Internet Explorer Components</Excluded_Packages>
      <Excluded_Packages Name="X:\My_projects\CODE\delphi-compo\bpl\ShockwaveFlashObjects.bpl">Shockwave Flash Objects</Excluded_Packages>
    </Excluded_Packages>
  </Delphi.Personality>
	<StarTeamAssociation></StarTeamAssociation>
	<StarTeamNonRelativeFiles></StarTeamNonRelativeFiles>
</BorlandProject>

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Project1.cfg:**
    
```
-$A8
-$B-
-$C+
-$D+
-$E-
-$F-
-$G+
-$H+
-$I+
-$J-
-$K-
-$L+
-$M-
-$N+
-$O+
-$P+
-$Q-
-$R-
-$S-
-$T-
-$U-
-$V+
-$W-
-$X+
-$YD
-$Z1
-cg
-AWinTypes=Windows;WinProcs=Windows;DbiTypes=BDE;DbiProcs=BDE;DbiErrs=BDE;
-H+
-W+
-M
-$M16384,1048576
-K$00400000
-LE"C:\Documents and Settings\Administrator\My Documents\Borland Studio Projects\Bpl"
-LN"C:\Documents and Settings\Administrator\My Documents\Borland Studio Projects\Bpl"
-w-UNSAFE_TYPE
-w-UNSAFE_CODE
-w-UNSAFE_CAST

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Project1.dpr:**
    
```
//*******************************************************************
//       ByteScout BarCode SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

{
 IMPORTANT:
  To work with Bytescout BarCode SDK you need to import this as a component into Delphi

 To import Bytescout BarCode SDK into Delphi 2006 or higher do the following:
 1) Click Component | Import Component..
 2) Select Type Library and click Next
 3) Find and select Bytescout BarCode SDK in the list of available type libraries and
 4) Click Next
 5) Click Next on next screen
 6) Select "Add Bytescout_BarCode_TLB.pas" into Project" and click Finish

 This will add Bytescout_BarCode_TLB.pas into your project and now you can use BarCode object interface (_BarCode class)

}

program Project1;

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  Bytescout_BarCode_TLB in 'c:\program files\borland\bds\4.0\Imports\Bytescout_BarCode_TLB.pas';

var
 bc: _Barcode;
begin
  CoInitialize(nil);  // required for console applications, initializes ActiveX support

  // create barcode object using CoBarCode class
  bc:= CoBarCode.Create();
  // set symbology to Code128
  bc.Symbology := SymbologyType_Code128;
  bc.Options.Code128Alphabet := Code128Alphabet_B; // set code 128 alphabet to B alphabet
  // set barcode value
  bc.Value:= '12345';
  // save into PNG image
  bc.SaveImage('Code128.png');
  // free barcode object by setting to nil
  bc:= nil;

  CoUninitialize(); // required for console applications, initializes ActiveX support

end.

```

<!-- code block end -->