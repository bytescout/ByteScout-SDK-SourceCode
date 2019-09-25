## How to create simple spreadsheet with spreadsheet sdk in C++ with ByteScout Barcode Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to create simple spreadsheet with spreadsheet sdk in C++

The sample source codes on this page shows how to create simple spreadsheet with spreadsheet sdk in C++. ByteScout Barcode Suite: the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can create simple spreadsheet with spreadsheet sdk in C++.

The following code snippet for ByteScout Barcode Suite works best when you need to quickly create simple spreadsheet with spreadsheet sdk in your C++ application. This C++ sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Use of ByteScout Barcode Suite in C++ is also described in the documentation included along with the product.

If you want to try other source code samples then the free trial version of ByteScout Barcode Suite is available for download from our website. Just try other source code samples for C++.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

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

##### ****AssemblyInfo.cpp:**
    
```
#include "stdafx.h"

using namespace System;
using namespace System::Reflection;
using namespace System::Runtime::CompilerServices;
using namespace System::Runtime::InteropServices;
using namespace System::Security::Permissions;

//
// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly:AssemblyTitleAttribute("HelloWorld")];
[assembly:AssemblyDescriptionAttribute("")];
[assembly:AssemblyConfigurationAttribute("")];
[assembly:AssemblyCompanyAttribute("")];
[assembly:AssemblyProductAttribute("HelloWorld")];
[assembly:AssemblyCopyrightAttribute("Copyright (c)  2010")];
[assembly:AssemblyTrademarkAttribute("")];
[assembly:AssemblyCultureAttribute("")];

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the value or you can default the Revision and Build Numbers
// by using the '*' as shown below:

[assembly:AssemblyVersionAttribute("1.0.*")];

[assembly:ComVisible(false)];

[assembly:CLSCompliantAttribute(true)];

[assembly:SecurityPermission(SecurityAction::RequestMinimum, UnmanagedCode = true)];

```

<!-- code block end -->    

<!-- code block begin -->

##### ****HelloWorld.cpp:**
    
```
// HelloWorld.cpp : main project file.

#include "stdafx.h"

using namespace System;
using namespace System::IO;
using namespace Bytescout::Spreadsheet;

int main(array<System::String ^> ^args)
{
    // Create new Spreadsheet
	Spreadsheet document;

	// Add new worksheet
	Worksheet^ worksheet = document.Workbook->Worksheets->Add("HelloWorld");

	// Set cell value
	worksheet->Cell(0, 0)->Value = "Hello, World!";

	// delete output file if exists already
	if (File::Exists("Output.xls"))
	{
		File::Delete("Output.xls");
	}

	// Save document
	document.SaveAs("Output.xls");

	// Close Spreadsheet
	document.Close();

	System::Diagnostics::Process::Start("Output.xls");

    return 0;
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****resource.h:**
    
```
//{{NO_DEPENDENCIES}}
// Microsoft Visual C++ generated include file.
// Used by app.rc

```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.cpp:**
    
```
// stdafx.cpp : source file that includes just the standard includes
// HelloWorld.pch will be the pre-compiled header
// stdafx.obj will contain the pre-compiled type information

#include "stdafx.h"



```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.h:**
    
```
// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once

// TODO: reference additional headers your program requires here

```

<!-- code block end -->