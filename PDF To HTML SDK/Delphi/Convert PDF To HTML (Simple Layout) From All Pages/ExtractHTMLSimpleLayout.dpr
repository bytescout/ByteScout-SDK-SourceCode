program ExtractHTMLSimpleLayout;

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
  Bytescout_PDF2HTML_TLB in 'c:\program files\borland\bds\4.0\Imports\Bytescout_PDF2HTML_TLB.pas';

var
  extractor: _HTMLExtractor;

const
  INPUT_FILE_NAME: string = 'sample2.pdf';
  OUTPUT_FILE_NAME: string = 'output.html';

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create Bytescout.PDF2HTML.HTMLExtractor instance
  extractor := CoHTMLExtractor.Create();
  extractor.RegistrationName := 'demo';
  extractor.RegistrationKey := 'demo';

  // set plain HTML extraction mode
  extractor.ExtractionMode := HTMLExtractionMode_PlainHTML;

  // load sample PDF document
  extractor.LoadDocumentFromFile(INPUT_FILE_NAME);

  // save extracted HTML to file
  extractor.SaveHtmlToFile_2(OUTPUT_FILE_NAME);

  // free extractor object
  extractor.Dispose();

  CoUninitialize();
end.
