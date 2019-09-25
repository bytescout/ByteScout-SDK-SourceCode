## How to split protected PDF document (c++ clr) with PDF extractor SDK in C++ and ByteScout Premium Suite

### This code in C++ shows how to split protected PDF document (c++ clr) with PDF extractor SDK with this how to tutorial

ByteScout simple and easy to understand tutorials are planned to describe the code for both C++ beginners and advanced programmers. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording and you can use it to split protected PDF document (c++ clr) with PDF extractor SDK with C++.

Want to save time? You will save a lot of time on writing and testing code as you may just take the C++ code from ByteScout Premium Suite for split protected PDF document (c++ clr) with PDF extractor SDK below and use it in your application. This C++ sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Applying C++ application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

Our website gives trial version of ByteScout Premium Suite for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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
using Bytescout::PDFExtractor::DocumentSplitter;


// `PasswordRequired` event handler
void OnPasswordRequired(System::Object ^sender, System::String ^document, System::String ^%password);


int main(array<System::String ^> ^args)
{
	String^ input(".\\encrypted (password is 'password').pdf");
	String^ output1(".\\result1.pdf");
	String^ output2(".\\result2.pdf");

	// Create DocumentSplitter instance
	DocumentSplitter^ merger = gcnew DocumentSplitter("demo", "demo");

	// Handle `PasswordRequired` event
	merger->PasswordRequired += gcnew Bytescout::PDFExtractor::PasswordEventHandler(&OnPasswordRequired);

	// Ignore document permissions
	merger->CheckPermissions = false;

	// Split document
	merger->Split(input, output1, output2, 3);

	delete merger;

	// Open the output documents in default associated application (for demonstration)
	Diagnostics::Process::Start(output1);
	Diagnostics::Process::Start(output2);
	
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