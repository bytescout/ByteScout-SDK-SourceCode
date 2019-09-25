## How to create side by side manifest for ummm-master in VB6 using ByteScout PDF Suite

### How to create side by side manifest for ummm-master in VB6: Step By Step Instructions

Every ByteScout tool includes sample VB6 source codes that you can find here or in the folder with installed ByteScout product. Ummm-master in VB6 can be applied with ByteScout PDF Suite. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

Want to learn quickly? These fast application programming interfaces of ByteScout PDF Suite for VB6 plus the instruction and the code below will help to learn how to create side by side manifest. This VB6 sample code can be used by copying and pasting into your project. Once done,just compile your project and click Run. Further improvement of the code will make it more robust.

Our website provides free trial version of ByteScout PDF Suite that gives source code samples to assist with your VB6 project.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****Ummm.vbp:**
    
```
Type=Exe
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#..\..\..\..\Windows\SysWOW64\stdole2.tlb#OLE Automation
Reference=*\G{8B217740-717D-11CE-AB5B-D41203C10000}#1.0#0#..\..\..\..\Windows\SysWow64\TLBINF32.DLL#TypeLib Information
Module=mdUmmm; mdUmmm.bas
Startup="Sub Main"
HelpFile=""
Title="Unattended MMM"
ExeName32="UMMM.exe"
Path32=".."
Command32=""
Name="Ummm"
HelpContextID="0"
Description="Unattended MMM 1.0.12"
CompatibleMode="0"
MajorVer=1
MinorVer=0
RevisionVer=12
AutoIncrementVer=0
ServerSupportFiles=0
VersionComments="Unattended MMM"
VersionCompanyName="Unicontsoft"
VersionFileDescription="Unattended MMM 1.0.12"
VersionLegalCopyright="Copyright (c) 2009-2016 by wqweto@gmail.com"
CompilationType=0
OptimizationType=0
FavorPentiumPro(tm)=0
CodeViewDebugInfo=0
NoAliasing=0
BoundsCheck=0
OverflowCheck=0
FlPointCheck=0
FDIVCheck=0
UnroundedFP=0
StartMode=0
Unattended=0
Retained=0
ThreadPerObject=0
MaxNumberOfThreads=1

[VBCompiler]
LinkSwitches=/SUBSYSTEM:CONSOLE

```

<!-- code block end -->