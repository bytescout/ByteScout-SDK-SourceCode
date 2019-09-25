## How to merge protected PDF documents (c++ clr) with PDF extractor SDK in C++ using ByteScout PDF Suite

### Learn to code in C++ to merge protected PDF documents (c++ clr) with PDF extractor SDK with this step-by-step tutorial

These source code samples are assembled by their programming language and functions they apply. ByteScout PDF Suite can merge protected PDF documents (c++ clr) with PDF extractor SDK. It can be applied from C++. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

The following code snippet for ByteScout PDF Suite works best when you need to quickly merge protected PDF documents (c++ clr) with PDF extractor SDK in your C++ application. Just copy and paste the code into your C++ application’s code and follow the instructions. Applying C++ application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

You can download free trial version of ByteScout PDF Suite from our website with this and other source code samples for C++.

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