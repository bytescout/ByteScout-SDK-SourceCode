## How to read barcode from image with barcode reader sdk in C++ with ByteScout Premium Suite

### Step-by-step tutorial on how to read barcode from image with barcode reader sdk in C++

An easy to understand sample source code to learn how to read barcode from image with barcode reader sdk in C++ ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can read barcode from image with barcode reader sdk in C++.

The following code snippet for ByteScout Premium Suite works best when you need to quickly read barcode from image with barcode reader sdk in your C++ application.  Simply copy and paste in your C++ project or application you and then run your app! Use of ByteScout Premium Suite in C++ is also described in the documentation included along with the product.

Trial version of ByteScout Premium Suite is available for free. Source code samples are included to help you with your C++ app.

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