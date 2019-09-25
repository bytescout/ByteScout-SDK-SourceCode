## How to read barcode from image with barcode reader sdk in C++ using ByteScout Data Extraction Suite

### If you want to learn more then this tutorial will show how to read barcode from image with barcode reader sdk in C++

These source code samples are assembled by their programming language and functions they apply. ByteScout Data Extraction Suite can read barcode from image with barcode reader sdk. It can be applied from C++. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

The following code snippet for ByteScout Data Extraction Suite works best when you need to quickly read barcode from image with barcode reader sdk in your C++ application. Just copy and paste the code into your C++ application’s code and follow the instructions. If you want to use these C++ sample examples in one or many applications then they can be used easily.

You can download free trial version of ByteScout Data Extraction Suite from our website to see and try many others source code samples for C++.

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

##### ****CommonExample.cpp:**
    
```
#include "stdafx.h"

using namespace System;
using namespace System::IO;
using namespace System::Drawing;
using namespace Bytescout::BarCodeReader;

int main(array<System::String ^> ^args)
{
	String ^path = "BarcodePhoto.jpg";
	
	Console::WriteLine("Reading barcode(s) from image " + Path::GetFullPath(path));

	Reader ^bc = gcnew Reader();
	
	// Set to find all barcode types
	bc->BarcodeTypesToFind->All = true;
	// But we recommend to use specific barcode types to avoid false positives, e.g.:
	// bc->BarcodeTypesToFind->QRCOde = true;
	// bc->BarcodeTypesToFind->Code39 = true;
	
	// Decode barcodes
	bc->ReadFrom(path);

	for (int i=0; i < bc->FoundCount; i++)
	{
		Console::WriteLine("Found barcode with type: " + bc->GetFoundBarcodeType(i).ToString() + " and value: " + bc->GetFoundBarcodeValue(i));
	}

	Console::WriteLine("Press any key to exit..");            
	Console::ReadKey();

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