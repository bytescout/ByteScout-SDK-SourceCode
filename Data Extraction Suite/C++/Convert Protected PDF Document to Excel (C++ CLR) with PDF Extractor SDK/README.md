## How to convert protected PDF document to excel (c++ clr) with PDF extractor SDK in C++ and ByteScout Data Extraction Suite

### Step-by-step tutorial on how to convert protected PDF document to excel (c++ clr) with PDF extractor SDK in C++

This sample source code below will display you how to convert protected PDF document to excel (c++ clr) with PDF extractor SDK in C++. What is ByteScout Data Extraction Suite? It is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can help you to convert protected PDF document to excel (c++ clr) with PDF extractor SDK in your C++ application.

Want to save time? You will save a lot of time on writing and testing code as you may just take the C++ code from ByteScout Data Extraction Suite for convert protected PDF document to excel (c++ clr) with PDF extractor SDK below and use it in your application. Follow the instructions from scratch to work and copy the C++ code. This basic programming language sample code for C++ will do the whole work for you to convert protected PDF document to excel (c++ clr) with PDF extractor SDK.

Our website gives trial version of ByteScout Data Extraction Suite for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

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

##### ****CPPCLRConsoleApplication.cpp:**
    
```
#include "stdafx.h"

//
// This example demonstrates how to provide password for protected PDF files.
//

using namespace System;
using Bytescout::PDFExtractor::XLSExtractor;


// `PasswordRequired` event handler
void OnPasswordRequired(System::Object ^sender, System::EventArgs ^e);


int main(array<System::String ^> ^args)
{
	String^ input(".\\encrypted (password is 'password').pdf");
	String^ output(".\\result.xls");

	// Create XLSExtractor instance
	XLSExtractor^ pExtractor = gcnew XLSExtractor("demo", "demo");

	// Handle `PasswordRequired` event
	pExtractor->PasswordRequired += gcnew System::EventHandler(&OnPasswordRequired);

	// Load PDF document
	pExtractor->LoadDocumentFromFile(input);

	// Save Excel document
	pExtractor->SaveToXLSFile(output);

	delete pExtractor;

	// Open the output document in default associated application (for demonstration)
	Diagnostics::Process::Start(output);
	
    return 0;
}

// `PasswordRequired` event handler
void OnPasswordRequired(System::Object ^sender, System::EventArgs ^e)
{
	// Ask user for password and put it to `Password` property.
	safe_cast<XLSExtractor^>(sender)->Password = "password";
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****CPPCLRConsoleApplication.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.28307.705
MinimumVisualStudioVersion = 10.0.40219.1
Project("{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}") = "CPPCLRConsoleApplication", "CPPCLRConsoleApplication.vcxproj", "{C5FC8356-2624-40BA-B81B-AF20C3A31850}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|x64 = Debug|x64
		Debug|x86 = Debug|x86
		Release|x64 = Release|x64
		Release|x86 = Release|x86
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{C5FC8356-2624-40BA-B81B-AF20C3A31850}.Debug|x64.ActiveCfg = Debug|x64
		{C5FC8356-2624-40BA-B81B-AF20C3A31850}.Debug|x64.Build.0 = Debug|x64
		{C5FC8356-2624-40BA-B81B-AF20C3A31850}.Debug|x86.ActiveCfg = Debug|Win32
		{C5FC8356-2624-40BA-B81B-AF20C3A31850}.Debug|x86.Build.0 = Debug|Win32
		{C5FC8356-2624-40BA-B81B-AF20C3A31850}.Release|x64.ActiveCfg = Release|x64
		{C5FC8356-2624-40BA-B81B-AF20C3A31850}.Release|x64.Build.0 = Release|x64
		{C5FC8356-2624-40BA-B81B-AF20C3A31850}.Release|x86.ActiveCfg = Release|Win32
		{C5FC8356-2624-40BA-B81B-AF20C3A31850}.Release|x86.Build.0 = Release|Win32
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {73422647-4D59-42C4-8FF2-714AE7051319}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Resource.h:**
    
```
//{{NO_DEPENDENCIES}}
// Microsoft Visual C++ generated include file.
// Used by app.rc

```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.cpp:**
    
```
#include "stdafx.h"

```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.h:**
    
```
#pragma once

// TODO: reference additional headers your program requires here

```

<!-- code block end -->