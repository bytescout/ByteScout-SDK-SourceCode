program ExtractText;

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
  Bytescout_PDFExtractor_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDFExtractor_TLB.pas';

var
  extractor: _TextExtractor;

const
  INPUT_FILE_NAME: string = 'sample_english_arabic.pdf';
  OUTPUT_FILE_NAME: string = 'result.txt';

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create Bytescout.PDFExtractor.TextExtractor instance
  extractor := CoTextExtractor.Create();
  extractor.RegistrationName := 'demo';
  extractor.RegistrationKey := 'demo';

  // load sample PDF document
  extractor.LoadDocumentFromFile(INPUT_FILE_NAME);

  // enable Arabic (and other RTL languages) text detection
  extractor.RTLTextAutoDetectionEnabled := true;

  // save extracted text to file
  extractor.SaveTextToFile(OUTPUT_FILE_NAME);

  // cleanup
  extractor.Dispose();

  CoUninitialize();
end.
