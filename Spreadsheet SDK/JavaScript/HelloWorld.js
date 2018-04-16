//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


var document = WScript.CreateObject('Bytescout.Spreadsheet.Spreadsheet');

// Add new worksheet
var worksheet = document.Workbook.Worksheets.Add("HelloWorld");

// get cell value
var cell = worksheet.Item(0,0); // you can also use worksheet.Cell("A1") as well

// set cell value
cell.Value = "Hello, World!";

// delete output file if exists already
var fso = WScript.CreateObject('Scripting.FileSystemObject');
if (fso.FileExists('Output.xls')) { fso.DeleteFile('Output.xls'); }
fso = null;

// save document
document.SaveAs ('Output.xls');

// close Spreadsheet
document = null
