program AddImage;

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
  OUTPUT_FILE_NAME: string = 'output.xls';

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create new Spreadsheet object
  spreadsheet := CoSpreadsheet.Create();
  spreadsheet.RegistrationKey := 'demo';
  spreadsheet.RegistrationName := 'demo';

  // add new worksheet
  sheet := spreadsheet.Workbook.Worksheets.Add('Sample');

  // add a picture to worksheet
  sheet.Pictures.Add_3('image.jpg', 100, 100);
  sheet.Cell_2('A1').ValueAsHTML := '<b>Image from</b> from <i>Image.jpg</i>';

  if (FileExists(OUTPUT_FILE_NAME)) then
    DeleteFile(OUTPUT_FILE_NAME);

  // save it as XLS
  spreadsheet.SaveAs(OUTPUT_FILE_NAME);

  // close the document
  spreadsheet.Close();
  spreadsheet.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
