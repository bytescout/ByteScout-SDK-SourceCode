program Profiles;

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
  Variants,
  Bytescout_BarCodeReader_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_BarCodeReader_TLB.pas';

var
  reader: _Reader;
  waiting_any_key: char;
  i: integer;

const
  INPUT_PDF_FILE_NAME: string = 'sample1.pdf';
  INPUT_PNG_FILE_NAME: string = 'sample2.png';

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create Bytescout.BarCodeReader.Reader instance
  reader := CoReader.Create();
  reader.RegistrationName := 'demo';
  reader.RegistrationKey := 'demo';

  // Apply predefined profiles:
  // enable Code39;
  // enable EAN-13;
  // render PDF at 150 DPI resoultion.
  reader.Profiles := 'code39, ean13, pdf150dpi';

  // decode and show barcodes from sample1.pdf
  Writeln(Format('Reading from the "%s"', [INPUT_PDF_FILE_NAME]));
  reader.ReadFromFile(INPUT_PDF_FILE_NAME);
  for i := 0 to reader.FoundCount - 1 do begin

    WriteLn(Format('Found barcode with type %d and value %s',
      [reader.GetFoundBarcodeType(i), reader.GetFoundBarcodeValue(i)]));
  end;
  Writeln('');
  
  // free barcode reader object
  reader.Dispose();

  // create Bytescout.BarCodeReader.Reader instance
  reader := CoReader.Create();
  reader.RegistrationName := 'demo';
  reader.RegistrationKey := 'demo';

  // load and apply custom profiles
  reader.LoadProfiles('profiles.json');
  reader.Profiles := 'negative-distorted-datamatrix';

  // decode and show barcodes from sample2.png
  Writeln(Format('Reading from the "%s"', [INPUT_PNG_FILE_NAME]));
  reader.ReadFromFile(INPUT_PNG_FILE_NAME);
  for i := 0 to reader.FoundCount - 1 do begin

    WriteLn(Format('Found barcode with type %d and value %s',
      [reader.GetFoundBarcodeType(i), reader.GetFoundBarcodeValue(i)]));
  end;

  Writeln('Press any key to continue...');
  Readln(waiting_any_key);

  // free barcode reader object
  reader.Dispose();

  CoUninitialize();
end.
