program CopyPasteRows;

//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  Bytescout_Spreadsheet_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_Spreadsheet_TLB.pas';

var
  spreadsheet: _Spreadsheet;
  sheet: _Worksheet;

const
  INPUT_FILE_NAME: string = 'example.xls';
  OUTPUT_FILE_NAME: string = 'changes.xls';

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create new Spreadsheet object
  spreadsheet := CoSpreadsheet.Create();
  spreadsheet.RegistrationKey := 'demo';
  spreadsheet.RegistrationName := 'demo';

  spreadsheet.LoadFromFile(INPUT_FILE_NAME);

  // get first worksheet
  sheet := spreadsheet.Workbook.Worksheets.item[0];

  // copy first eight rows to the 10th row
  sheet.Rows.CopyAndPaste(0, 7, 9);

  if (FileExists(OUTPUT_FILE_NAME)) then
    DeleteFile(OUTPUT_FILE_NAME);

  // save document
  spreadsheet.SaveAs(OUTPUT_FILE_NAME);

  // close spreadsheet
  spreadsheet.Close();
  spreadsheet.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
