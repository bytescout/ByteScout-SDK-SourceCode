program SplitDocumentByFoundBarcode;

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
  i: integer;
  reader: _Reader;
  page, next_page: integer;
  page_ranges: string;
  splitted_parts: PSafeArray;
  l_bound, u_bound: integer;
  file_name: WideString;
  
const
  INPUT_FILE_NAME: string = 'barcodes.pdf';

begin

  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  reader := CoReader.Create();
  reader.RegistrationName := 'demo';
  reader.RegistrationKey := 'demo';

  // set barcode type to find
  reader.BarcodeTypesToFind.Code39 := true;

  reader.ReadFromPdfFile(INPUT_FILE_NAME);

  if (reader.FoundCount > 0) then begin

    // Method 1: Split PDF document in two parts by found barcode
    // NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only.
    reader.SplitDocument(INPUT_FILE_NAME, 'part1.pdf', 'part2.pdf', reader.GetFoundBarcodePage(0) + 1);

    // Method 2: Extract page containing the barcode from PDF document
    // NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only.
    reader.ExtractPageFromDocument(INPUT_FILE_NAME, 'extracted_page.pdf', reader.GetFoundBarcodePage(0) + 1);

    // Method 3: Split PDF document into parts in one pass.
    // NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only.
    page_ranges := '';
    for i := 0 to reader.FoundCount - 1 do begin

      page := reader.GetFoundBarcodePage(i);
      // add pages before the first barcode found
      if ((i = 0) and (page > 0)) then begin

        page_ranges := page_ranges + '1';
        if (page > 1) then begin

          page_ranges := page_ranges + '-';
          page_ranges := page_ranges + IntToStr(page);
        end;
        page_ranges := page_ranges + ',';
      end;

      // add page with barcode
      // +1 because we skip the page with barcode and another +1 because need 1-based page numbers
      page_ranges := page_ranges + IntToStr(page + 1);

      // Add range untill the next barcode
      if (i < reader.FoundCount - 1) then begin

        next_page := reader.GetFoundBarcodePage(i + 1);
        if ((next_page - page) > 1) then begin

          page_ranges := page_ranges + '-';
          page_ranges := page_ranges + IntToStr(next_page);
        end;
        page_ranges := page_ranges + ',';
      end else begin

        // for the last found barcode add ending "-" meaning "to the last page"
        page_ranges := page_ranges + '-';
      end;
    end;

    if (Length(page_ranges) > 0) then begin

      // split document
      // The method returns array of file names. Rename files as desired.
      splitted_parts := reader.SplitDocument_2(INPUT_FILE_NAME, page_ranges);

      // display generated file names
      SafeArrayGetLBound(splitted_parts, 1, l_bound);
      SafeArrayGetUBound(splitted_parts, 1, u_bound);
      for i := l_bound to u_bound do begin

        SafeArrayGetElement(splitted_parts, i, file_name);
        WriteLn(file_name);
      end;
      SafeArrayDestroy(splitted_parts);
    end else
      WriteLn('No page ranges');

  end else
    WriteLn('No barcodes found');

  // free barcode reader object
  reader.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
