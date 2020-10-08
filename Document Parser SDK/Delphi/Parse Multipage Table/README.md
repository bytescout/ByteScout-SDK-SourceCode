## How to parse multipage table in Delphi and ByteScout Document Parser SDK What is ByteScout Document Parser SDK? It is the template based data extraction engine can process thousands and millions of documents per day based on templates. Can work online and offline for privacy focused tasks. Templates can be supported and updated without any programming or technical knowledge required. Output is generated in JSON, CSV, XML and custom format if required.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Document%20Parser%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Document%20Parser%20SDK%20Question) 

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

[https://www.youtube.com/watch?v=MG5FfTWWSVE](https://www.youtube.com/watch?v=MG5FfTWWSVE)




<!-- code block begin -->

##### **MultiPageTable-template1.yml:**
    
```
templateName: Multipage Table Test
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - Sample document with multi-page table
objects:
- name: total
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: TOTAL{{Spaces}}({{Number}})
    regex: true
    dataType: decimal
- name: table1
  objectType: table
  tableProperties:
    start:
      expression: Item{{Spaces}}Description{{Spaces}}Price
      regex: true
    end:
      expression: TOTAL{{Spaces}}{{Number}}
      regex: true
    row:
      expression: '{{LineStart}}{{Spaces}}(?<itemNo>{{Digits}}){{Spaces}}(?<description>{{SentenceWithSingleSpaces}}){{Spaces}}(?<price>{{Number}}){{Spaces}}(?<qty>{{Digits}}){{Spaces}}(?<extPrice>{{Number}})'
      regex: true
    columns:
    - name: itemNo
      dataType: integer
    - name: description
      dataType: string
    - name: price
      dataType: decimal
    - name: qty
      dataType: integer
    - name: extPrice
      dataType: decimal
    multipage: true


```

<!-- code block end -->    

<!-- code block begin -->

##### **MultiPageTable-template2.yml:**
    
```
templateName: Multipage Table Test
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - Sample document with multi-page table
objects:
- name: total
  objectType: field
  fieldProperties:
    fieldType: regex
    expression: TOTAL{{Spaces}}({{Number}})
    regex: true
    dataType: decimal
- name: table1
  objectType: table
  tableProperties:
    start:
      expression: Item{{Spaces}}Description{{Spaces}}Price
      regex: true
    end:
      expression: (Page {{Digits}} of {{Digits}})|(TOTAL{{Spaces}}{{Number}})
      regex: true
    left: 51
    right: 528
    columns:
    - x: 51
      name: itemNo
      dataType: integer
    - x: 102
      name: description
      dataType: string
    - x: 324
      name: price
      dataType: decimal
    - x: 396
      name: qty
      dataType: integer
    - x: 441
      name: extPrice
      dataType: decimal
    multipage: true


```

<!-- code block end -->    

<!-- code block begin -->

##### **ParseMultipageTable.bdsproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<BorlandProject>
  <PersonalityInfo>
    <Option>
      <Option Name="Personality">Delphi.Personality</Option>
      <Option Name="ProjectType"></Option>
      <Option Name="Version">1.0</Option>
      <Option Name="GUID">{477A61E2-8E0C-4CF1-A9DE-D0718035587A}</Option>
    </Option>
  </PersonalityInfo>
  <Delphi.Personality>
    <Source>
      <Source Name="MainSource">ParseMultipageTable.dpr</Source>
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
  </Delphi.Personality>
</BorlandProject>

```

<!-- code block end -->    

<!-- code block begin -->

##### **ParseMultipageTable.cfg:**
    
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
-LE"C:\Users\Àíäðåé\Documents\Borland Studio Projects\Bpl"
-LN"C:\Users\Àíäðåé\Documents\Borland Studio Projects\Bpl"
-w-UNSAFE_TYPE
-w-UNSAFE_CODE
-w-UNSAFE_CAST

```

<!-- code block end -->    

<!-- code block begin -->

##### **ParseMultipageTable.dpr:**
    
```
program ParseMultipageTable;

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

// This example demonstrates parsing of multipage tables in two different approaches.
// See comments in the code of templates.

uses
  SysUtils,
  ActiveX,
  ByteScout_DocumentParser_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\ByteScout_DocumentParser_TLB.pas';

var
  document_parser: _DocumentParser;

const
  INPUT_DOCUMENT: string = 'MultiPageTable.pdf';
  CUSTOM_TEMPLATE1: string = 'MultiPageTable-template1.yml';
  CUSTOM_TEMPLATE2: string = 'MultiPageTable-template2.yml';
  OUTPUT_FILE_NAME1: string = 'result1.json';
  OUTPUT_FILE_NAME2: string = 'result2.json';

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

  // create and activate DocumentParser instance
  document_parser := CoDocumentParser.Create();
  document_parser.RegistrationName := 'demo';
  document_parser.RegistrationKey := 'demo';

  WriteLn('Loading template 1...');
  document_parser.AddTemplate(CUSTOM_TEMPLATE1);

  WriteLn('Template 1 loaded.');
  WriteLn('');

  WriteLn('Parsing ' + INPUT_DOCUMENT + '...');
  WriteLn('');

  // parse document data in JSON format
  document_parser.ParseDocument_3(INPUT_DOCUMENT, OUTPUT_FILE_NAME1, OutputFormat_JSON, false);

  WriteLn('Parsing results saved to ' + OUTPUT_FILE_NAME1);
  WriteLn('');

  document_parser.Dispose();

  document_parser := CoDocumentParser.Create();
  document_parser.RegistrationName := 'demo';
  document_parser.RegistrationKey := 'demo';

  WriteLn('Loading template 2...');
  document_parser.AddTemplate(CUSTOM_TEMPLATE2);

  WriteLn('Template 2 loaded.');
  WriteLn('');

  WriteLn('Parsing ' + INPUT_DOCUMENT + '...');
  WriteLn('');

  // parse document data in JSON format
  document_parser.ParseDocument_3(INPUT_DOCUMENT, OUTPUT_FILE_NAME2, OutputFormat_JSON, false);

  WriteLn('Parsing results saved to ' + OUTPUT_FILE_NAME2);
  WriteLn('');

  document_parser.Dispose();

  CoUninitialize();
end.

```

<!-- code block end -->