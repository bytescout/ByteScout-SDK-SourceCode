program ReduceMemoryUsage;

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
  Bytescout_PDF2HTML_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDF2HTML_TLB.pas';

var
  extractor: _HTMLExtractor;

const
  INPUT_FILE_NAME: string = 'sample2.pdf';
  OUTPUT_FILE_NAME: string = 'output.html';

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // When processing huge PDF documents you may run into OutOfMemoryException.
  // This example demonstrates a way to spare the memory by disabling page data caching.

  // create Bytescout.PDF2HTML.HTMLExtractor instance
  extractor := CoHTMLExtractor.Create();
  extractor.RegistrationName := 'demo';
  extractor.RegistrationKey := 'demo';

  // load sample PDF document
  extractor.LoadDocumentFromFile(INPUT_FILE_NAME);

  // disable page data caching, so processed pages will be disposed automatically
  extractor.PageDataCaching := PageDataCaching_None;

  // save result to file
  extractor.SaveHtmlToFile_2(OUTPUT_FILE_NAME);

  // free extractor object
  extractor.Dispose();

  CoUninitialize();
end.
