## How to create spreadsheet in PHP with ByteScout Spreadsheet SDK

### The tutorial shows how to create spreadsheet in PHP

The sample source codes on this page shows how to create spreadsheet in PHP. What is ByteScout Spreadsheet SDK? It is the SDK component for writing, reading, modifying and calculating Excel and CSV spreadsheets. Can calculate and reculculate formulas with Excel installed. You may import or export data to and from CSV, XML, JSON. Supports export to databases, arrays, streams. It can help you to create spreadsheet in your PHP application.

You will save a lot of time on writing and testing code as you may just take the PHP code from ByteScout Spreadsheet SDK for create spreadsheet below and use it in your application. In your PHP project or application you may simply copy & paste the code and then run your app! Detailed tutorials and documentation are available along with installed ByteScout Spreadsheet SDK if you'd like to dive deeper into the topic and the details of the API.

You can download free trial version of ByteScout Spreadsheet SDK from our website to see and try many others source code samples for PHP.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Spreadsheet%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Spreadsheet%20SDK%20Question) 

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

[https://www.youtube.com/watch?v=nm_7I0PN1TY](https://www.youtube.com/watch?v=nm_7I0PN1TY)




<!-- code block begin -->

##### **HelloWorld.php:**
    
```
<?php

// this PHP script creates XLS file using Spreadsheet SDK and streams it into the browser for user to download

/*

IMPORTANT: 
to use COM objects in PHP need to enable it by adding the following line into php.ini:

extension=php_com_dotnet.dll

If you are usiung EasyPHP DevServer then to edit php.ini just right-click on the tray icon and select "Configuration"->"PHP"
*/

try
{

// create spreadsheet object
$document = new COM("Bytescout.Spreadsheet.Spreadsheet");

// Add new worksheet
$worksheet = $document->Workbook->Worksheets->Add("123HelloWorld");

// get cell value
$cell = $worksheet->Cell(0,0); // you can also use worksheet.Cell_2("A1") as well. Cell_2() is because all overloads are accessible via _Index postfix, like .Cell_2(), .Cell_3() etc

// set cell value
$cell->Value = "Hello, World!";

// generate and get xls document as an array of bytes
$XLSDocumentArray = $document->GetAsBytesArrayXLS();

// now set headers to properly tell what kind of content we stream into browser
header("Content-Type: vnd.ms-excel");

// set file name to save into
header("Content-Disposition: attachment; filename=\"HelloWorld.xls\"");

// now write the array with content into the output 
foreach ($XLSDocumentArray as $byte) echo chr($byte);

}
catch(Exception $err) // catch exception if any
{
header("Content-Type: text/plain"); // switch to plain text output type
echo($err->getMessage()); // write error message to the output
}


?>
```

<!-- code block end -->    

<!-- code block begin -->

##### **HowToUseViaDOTNETclass.txt:**
    
```
You may use the SDK from PHP on Windows using DOTNET() class in PHP

1) Install the DLL into the GAC (global assembly cache)

 a) Open "c:\Windows\assembly" in Windows Explorer and drag-and-drop the dll into this folder
 OR
 b) install via command line:

"%programfiles%\Microsoft SDKs\Windows\v6.0\bin\gacutil.exe" -i "Bytescout.Spreadsheet.dll"

NOTE: you may need to change %programfiles%\Microsoft SDKs\Windows\v6.0\bin\ into 
%programfiles%\Microsoft SDKs\Windows\v6.0A\bin\
or into
%programfiles%\Microsoft SDKs\Windows\v7.0A\bin\

If you are still getting "File not found" then run the search for gacutil.exe in "Program Files" folder to find it.

2) Now run Windows Explorer and open "C:\WINDOWS\assembly" to view installed .NET assemblies in the GAC to verify if the dll was installed into the GAC
3) Find the installed and right-click on it and select "Properties"
4) In the Properties window double-click on "Assembly Name" and copy it to your PHP code (see below)
5) In the Properties window double-click on "Public Key Token" and copy it to your PHP code (see below)
6) In the Properties window double-click on "Version" value and copy it to your PHP code (see below)

from (4), (5) and (6) you should compose the following string:

$dotnetobj = new DOTNET("ASSEMBLYNAME, Version=VERSIONVALUE, Culture=neutral, PublicKeyToken=PUBLICKEYVALUE", 
"ASSEMBLYNAME.CLASSNAME"); 

Where 
ASSEMBLYNAME = the assembly name  (like Bytescout.Spreadsheet)
VERSIONVALUE = version value you got on step (5)
PUBLICKEYVALUE = public key value you got on step (4)
CLASSNAME = class name from the dll you want to create (for example, "Spreadsheet")

Example for Spreadsheet SDK version 2.4.0.1370:

$dotnetobj = new DOTNET("Bytescout.Spreadsheet, Version=2.4.0.1370, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb", 
"Bytescout.Spreadsheet.Spreadsheet");

Then you may use $dotnetobj and call its methods like this:
$dotnetobj->SomeMethod() (see the documentation of the SDK for available classes and methods and properties)

```

<!-- code block end -->