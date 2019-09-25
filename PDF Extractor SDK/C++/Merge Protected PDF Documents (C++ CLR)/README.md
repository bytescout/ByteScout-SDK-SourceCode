## How to merge protected PDF documents (c++ clr) in C++ using ByteScout PDF Extractor SDK

### This code in C++ shows how to merge protected PDF documents (c++ clr) with this how to tutorial

These source code samples are listed and grouped by their programming language and functions they use. ByteScout PDF Extractor SDK can merge protected PDF documents (c++ clr). It can be used from C++. ByteScout PDF Extractor SDK is the SDK that helps developers to extract data from unstructured documents, pdf, images, scanned and electronic forms. Includes AI functions like automatic table detection, automatic table extraction and restructuring, text recognition and text restoration from pdf and scanned documents. Includes PDF to CSV, PDF to XML, PDF to JSON, PDF to searchable PDF functions as well as methods for low level data extraction.

Fast application programming interfaces of ByteScout PDF Extractor SDK for C++ plus the instruction and the code below will help you quickly learn how to merge protected PDF documents (c++ clr). Just copy and paste the code into your C++ application’s code and follow the instruction. Further enhancement of the code will make it more vigorous.

You can download free trial version of ByteScout PDF Extractor SDK from our website to see and try many others source code samples for C++.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




<!-- code block begin -->

##### ****CPPCLRConsoleApplication.cpp:**
    
```
#include "stdafx.h"

//
// This example demonstrates how to provide password for protected PDF files.
//

using namespace System;
using Bytescout::PDFExtractor::DocumentMerger;


// `PasswordRequired` event handler
void OnPasswordRequired(System::Object ^sender, System::String ^document, System::String ^%password);


int main(array<System::String ^> ^args)
{
	String^ input1(".\\encrypted1 (password is 'password').pdf");
	String^ input2(".\\encrypted2 (password is 'password').pdf");
	String^ output(".\\result.pdf");

	// Create DocumentMerger instance
	DocumentMerger^ merger = gcnew DocumentMerger("demo", "demo");

	// Handle `PasswordRequired` event
	merger->PasswordRequired += gcnew Bytescout::PDFExtractor::PasswordEventHandler(&OnPasswordRequired);

	// Ignore document permissions
	merger->CheckPermissions = false;

	// Merge documents 
	array<String^>^ files = gcnew array<String^>(2) { input1, input2 };
	merger->Merge(files, output);

	delete merger;

	// Open the output document in default associated application (for demonstration)
	Diagnostics::Process::Start(output);
	
    return 0;
}

// `PasswordRequired` event handler
void OnPasswordRequired(System::Object ^sender, System::String ^document, System::String ^%password)
{
	// Ask user for password and put it to `Password` property.
	password = "password";
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