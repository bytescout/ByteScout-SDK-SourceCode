program QRCodeWithCalenderEntry;

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
  Bytescout_BarCode_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_BarCode_TLB.pas';

var
  bar_code: _Barcode;

function GetCalenderEntryFormatText(): string;
begin
  Result := 'BEGIN:VCALENDAR ' +
    'BEGIN:VEVENT ' +
    'DTSTART:20181113T100000Z ' +
    'DTEND:20181113T150000Z ' +
    'SUMMARY:New Calendar Entry ' +
    'DESCRIPTION:Description Text ' +
    'LOCATION:Chicago ' +
    'RRULE:FREQ=YEARLY;BYDAY=-1SU;BYMONTH=3 ' +
    'END:VEVENT ' +
    'END:VCALENDAR';
end;

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  bar_code := CoBarcode.Create();
  bar_code.RegistrationName := 'demo';
  bar_code.RegistrationKey := 'demo';

  // set symbology
  bar_code.Symbology := SymbologyType_QRCode;

  // get QRCode value in CalenderEntry format
  bar_code.Value := GetCalenderEntryFormatText();

  // save barcode to image
  bar_code.SaveImage('result.png');

  // free barcode object
  bar_code.Dispose();

  // calls to CoInitialize must be balanced by calls to CoUninitialize
  CoUninitialize();
end.
