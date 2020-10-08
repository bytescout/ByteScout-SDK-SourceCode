## How to extract text from areas in Delphi and ByteScout Text Recognition SDK ByteScout Text Recognition SDK is the software development kit for automatic text recognition and OCR from pdf documents and images. Can recognize English and non-English languages.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Text%20Recognition%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Text%20Recognition%20SDK%20Question) 

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

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### **ExtractText.bdsproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<BorlandProject>
	<PersonalityInfo>
		<Option>
			<Option Name="Personality">Delphi.Personality</Option>
			<Option Name="ProjectType"></Option>
			<Option Name="Version">1.0</Option>
			<Option Name="GUID">{C55A2BA2-36F6-4F8B-8DB5-66DD6E9342D0}</Option>
		</Option>
	</PersonalityInfo>
	<Delphi.Personality>
		<Source>
			<Source Name="MainSource">ExtractText.dpr</Source>
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
			<Compiler Name="O">0</Compiler>
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
	</Delphi.Personality>
</BorlandProject>

```

<!-- code block end -->    

<!-- code block begin -->

##### **ExtractText.cfg:**
    
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
-$O-
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
-LE"C:\Users\Àíäðåé\Documents\Borland Studio Projects\Bpl"
-LN"C:\Users\Àíäðåé\Documents\Borland Studio Projects\Bpl"
-w-UNSAFE_TYPE
-w-UNSAFE_CODE
-w-UNSAFE_CAST

```

<!-- code block end -->    

<!-- code block begin -->

##### **ExtractText.dpr:**
    
```
program ExtractText;

//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  ComObj,
  ByteScout_TextRecognition_TLB in 'c:\program files\borland\bds\4.0\Imports\ByteScout_TextRecognition_TLB.pas',
  mscorlib_TLB in 'c:\program files\borland\bds\4.0\Imports\mscorlib_TLB.pas';

var
  text_recognizer: _TextRecognizer;
  page_width, page_height: integer;
  ocr_object_list: _OCRObjectList;
  i: integer;
  encoding: _Encoding;

const
  INPUT_FILE_NAME: string = 'areas-sample.pdf';
  OUTPUT_FILE_NAME: string = 'result.txt';
  PAGE_INDEX: integer = 0;

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW(
<!-- code block begin -->

##### **{codeFileName}:**
    
```
{code}
```

<!-- code block end -->    
33F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create and activate TextRecognizer instance
  text_recognizer := CoTextRecognizer.Create();
  text_recognizer.RegistrationName := 'demo';
  text_recognizer.RegistrationKey := 'demo';

  text_recognizer.LoadDocument(INPUT_FILE_NAME);

  // set the location of OCR language data files
  text_recognizer.OCRLanguageDataFolder := 'C:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\';

  // set OCR language.
  // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
  // find more language files at https://github.com/bytescout/ocrdata
  text_recognizer.OCRLanguage := 'eng';

  // get page size (in pixels)
  // size of PDF document is computed from PDF Points
  // and the rendering resolution specified by `textRecognizer.PDFRenderingResolution` (default 300 DPI)
  page_width := text_recognizer.GetPageWidth(PAGE_INDEX);
  page_height := text_recognizer.GetPageHeight(PAGE_INDEX);

  // add area of interest as a rectangle at the top-right corner of the page
  text_recognizer.RecognitionAreas.Add(page_width div 2, 0, page_width div 2, 300, AreaRotation_RotateNoneFlipNone, OCRProposedContentType_Auto);
  // add area of interest as a rectangle at the bottom-left corner of the page,
  // and indicate it should be rotated at 90 deg
  text_recognizer.RecognitionAreas.Add(0, page_height div 2, 300, page_height div 2, AreaRotation_Rotate90FlipNone, OCRProposedContentType_Auto);

  // now, you can get recognized text for further analysis as a list of objects
  // containing coordinates, object kind, confidence.
  ocr_object_list := text_recognizer.GetOCRObjects(PAGE_INDEX, OCRProposedContentType_Auto);
  for i := 0 to ocr_object_list.Count - 1 do
    WriteLn(ocr_object_list.Item[i].ToString);

  encoding := CoUnicodeEncoding.Create() as _Encoding;
  // ... or you can save recognized text pieces to file
  text_recognizer.KeepTextFormatting := false; // save without formatting
  text_recognizer.SaveText(OUTPUT_FILE_NAME, PAGE_INDEX, PAGE_INDEX, encoding);

  text_recognizer.Dispose();


  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.

```

<!-- code block end -->