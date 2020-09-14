program BarcodesFromPDF;

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
  Windows,
  Bytescout_BarCodeReader_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_BarCodeReader_TLB.pas';

var
  i: integer;
  reader_default, reader_with_filter: _Reader;
  time_start, time_stop: cardinal;
  rect: string;

function RectAsString(left, top, width, height: integer): string;
begin
  Result := Format('[left: %d, top: %d, width: %d, height: %d]',
    [left, top, width, height]);
end;

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  reader_default := CoReader.Create();
  reader_default.RegistrationName := 'demo';
  reader_default.RegistrationKey := 'demo';

  // Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
  // Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
  // or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
  reader_default.BarcodeTypesToFind.All1D := true;

  // track operation time
  time_start := GetTickCount();

  WriteLn('Reading barcodes from PDF document with default resolution ...');

  reader_default.ReadFromPdfFile('example.pdf');

  for i := 0 to reader_default.FoundCount - 1 do begin

    // barcode area
    rect := RectAsString(reader_default.GetFoundBarcodeLeft(i),
      reader_default.GetFoundBarcodeTop(i), reader_default.GetFoundBarcodeWidth(i),
      reader_default.GetFoundBarcodeHeight(i));

    WriteLn(Format('Found barcode with type %d and value %s on page %d at %s',
      [reader_default.GetFoundBarcodeType(i), reader_default.GetFoundBarcodeValue(i),
      reader_default.GetFoundBarcodePage(i), rect]));
  end;

  time_stop := GetTickCount();
  WriteLn(Format('Elapsed time (in milliseconds): %d', [time_stop - time_start]));

  WriteLn('');
  WriteLn('===============');
  WriteLn('');

  reader_with_filter := CoReader.Create();
  reader_with_filter.RegistrationName := 'demo';
  reader_with_filter.RegistrationKey := 'demo';

  // Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
  // Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
  // or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
  reader_with_filter.BarcodeTypesToFind.All1D := true;

  // Setting PDF rendering resolution to 150
  reader_with_filter.PDFRenderingResolution := 150;

  time_start := GetTickCount();

  WriteLn('Reading barcodes from PDF document with filter set for resolution ...');

  reader_with_filter.ReadFromPdfFile('example.pdf');

  for i := 0 to reader_with_filter.FoundCount - 1 do begin

    // barcode area
    rect := RectAsString(reader_with_filter.GetFoundBarcodeLeft(i),
      reader_with_filter.GetFoundBarcodeTop(i), reader_with_filter.GetFoundBarcodeWidth(i),
      reader_with_filter.GetFoundBarcodeHeight(i));

    WriteLn(Format('Found barcode with type %d and value %s on page %d at %s',
      [reader_with_filter.GetFoundBarcodeType(i), reader_with_filter.GetFoundBarcodeValue(i),
      reader_with_filter.GetFoundBarcodePage(i), rect]));
  end;

  time_stop := GetTickCount();
  WriteLn(Format('Elapsed time (in milliseconds): %d', [time_stop - time_start]));

  // free barcode reader objects
  reader_default.Dispose();
  reader_with_filter.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
