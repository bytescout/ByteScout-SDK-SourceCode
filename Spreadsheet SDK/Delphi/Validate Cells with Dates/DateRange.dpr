program DateRange;

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
  DateUtils,
  Bytescout_Spreadsheet_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_Spreadsheet_TLB.pas';

var
  spreadsheet: _Spreadsheet;
  sheet: _Worksheet;
  range_min, range_max: integer;
  year_min, year_max: TDateTime;
  i: integer;
  current_cell: _Cell;
  date_birth: TDateTime;

const
  INPUT_FILE_NAME: string = 'data.xls';
  OUTPUT_FILE_NAME: string = 'changes.xls';

begin
  // in this sample we scan cells with ages data for people
  // then mark all dates where age is between 10 and 19 years and mark these cells with red color

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create new Spreadsheet object
  spreadsheet := CoSpreadsheet.Create();
  spreadsheet.RegistrationKey := 'demo';
  spreadsheet.RegistrationName := 'demo';

  spreadsheet.LoadFromFile(INPUT_FILE_NAME);

  // get worksheet by name
  sheet := spreadsheet.Workbook.Worksheets.Item_2['Sample'];

  // years range
  range_min := 10;
  range_max := 19;

  // minimum age
  year_min := Now();
  // maximum age
  year_max := Now();

  // minimum year
  year_max := IncYear(year_max, -range_min);
  // maximum year
  year_min := IncYear(year_min, -range_max);

  // Check dates
  for i := 1 to 7 do begin

    // set current cell
    current_cell := sheet.Cell(i, 1);

    date_birth := current_cell.ValueAsDateTime;

    // check current cell
    if ((date_birth < year_min) or (date_birth > year_max)) then begin

      // set fill pattern
      current_cell.FillPattern := PatternStyle_Solid;

      // markup wrong cell by red color
      current_cell.FillPatternForeColor := $0000FF;
    end;
    // set cell format
    current_cell.NumberFormatString := 'dd.mm.yyyy';
  end;

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
