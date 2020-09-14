program ReadRotatedBarcodes;

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
  Bytescout_BarCodeReader_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_BarCodeReader_TLB.pas';

var
  i: integer;
  reader: _Reader;

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  reader := CoReader.Create();
  reader.RegistrationName := 'demo';
  reader.RegistrationKey := 'demo';

  // set barcode type to find
  reader.BarcodeTypesToFind.Code128 := true;

  // set barcode Orientation
  // diagonalFromTopLeftToBottomRight11 - barcodes rotated clockwise by about 11 deg.
  reader.Orientation := OrientationType_DiagonalFromTopLeftToBottomRight11;

  reader.ReadFromFile('barcode_skewed2.png');

  for i := 0 to reader.FoundCount - 1 do begin

    WriteLn(Format('Found barcode with type %d and value %s',
      [reader.GetFoundBarcodeType(i), reader.GetFoundBarcodeValue(i)]));
  end;

  // free barcode reader object
  reader.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
