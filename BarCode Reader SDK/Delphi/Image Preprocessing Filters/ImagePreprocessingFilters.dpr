program ImagePreprocessingFilters;

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

const
  LOW_CONTRAST_BARCODE_FILE_NAME: string = 'low-contrast-barcode.png';
  NOISY_BARCODE_FILE_NAME: string = 'noisy-barcode.png';
  TOO_DENSE_BARCODE_FILE_NAME: string = 'too-dense-barcode.png';
  BARCODE_WITH_LARGE_MARGINS_FILE_NAME: string = 'barcode-with-large-margins.png';

procedure ReadAndShowBarcodes(const reader: _Reader; const file_name: string);
var
  i: integer;
begin
  Writeln(Format('Image "%s"', [file_name]));

  reader.ReadFromFile(file_name);
  if (reader.FoundCount = 0) then
    Writeln('No barcode found!')
  else begin

    for i := 0 to reader.FoundCount - 1 do begin

      WriteLn(Format('Found barcode with type %d and value %s',
        [reader.GetFoundBarcodeType(i), reader.GetFoundBarcodeValue(i)]));
    end;
  end;
  Writeln('');
end;

begin
  // This exmaple demonstrates the use of image filters to improve the decoding or speed.

  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  reader := CoReader.Create();
  reader.RegistrationName := 'demo';
  reader.RegistrationKey := 'demo';

  // Set barcode type to find
  reader.BarcodeTypesToFind.Code128 := true;

  // WORKING WITH LOW CONTRAST BARCODE IMAGES

  // Add contrast adjustment for low-contrast image
  reader.ImagePreprocessingFilters.AddContrast(40);
  ReadAndShowBarcodes(reader, LOW_CONTRAST_BARCODE_FILE_NAME);

  // WORKING WITH NOISY BARCODE IMAGES

  // Add the median filter to lower the noise
  reader.ImagePreprocessingFilters.Clear();
  reader.ImagePreprocessingFilters.AddMedian();
  ReadAndShowBarcodes(reader, NOISY_BARCODE_FILE_NAME);

  // WORKING WITH DENSE AND ILLEGIBLE BARCODES

  // Add the scale filter to enlarge the barcode to make gaps between bars more distinguishable
  reader.ImagePreprocessingFilters.Clear();
  reader.ImagePreprocessingFilters.AddScale_2(2); // enlarge twice
  ReadAndShowBarcodes(reader, TOO_DENSE_BARCODE_FILE_NAME);

  // REMOVE EMPTY MARGINS FROM IMAGE TO SPEED UP THE PROCESSING

  // Add the crop filter to cut off empty margins from the image.
  // This will not improve the recognition quality but may speed up the processing
  // if you enabled multiple barcode types to search.
  reader.ImagePreprocessingFilters.Clear();
  reader.ImagePreprocessingFilters.AddCropDark();
  ReadAndShowBarcodes(reader, BARCODE_WITH_LARGE_MARGINS_FILE_NAME);

  Writeln('Press any key to continue...');
  Readln(waiting_any_key);

  // free barcode reader object
  reader.Dispose();

  CoUninitialize();
end.
