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