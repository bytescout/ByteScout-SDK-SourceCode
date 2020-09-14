program ParseMultipageTable;

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

// This example demonstrates parsing of multipage tables in two different approaches.
// See comments in the code of templates.

uses
  SysUtils,
  ActiveX,
  ByteScout_DocumentParser_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\ByteScout_DocumentParser_TLB.pas';

var
  document_parser: _DocumentParser;

const
  INPUT_DOCUMENT: string = 'MultiPageTable.pdf';
  CUSTOM_TEMPLATE1: string = 'MultiPageTable-template1.yml';
  CUSTOM_TEMPLATE2: string = 'MultiPageTable-template2.yml';
  OUTPUT_FILE_NAME1: string = 'result1.json';
  OUTPUT_FILE_NAME2: string = 'result2.json';

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create and activate DocumentParser instance
  document_parser := CoDocumentParser.Create();
  document_parser.RegistrationName := 'demo';
  document_parser.RegistrationKey := 'demo';

  WriteLn('Loading template 1...');
  document_parser.AddTemplate(CUSTOM_TEMPLATE1);

  WriteLn('Template 1 loaded.');
  WriteLn('');

  WriteLn('Parsing ' + INPUT_DOCUMENT + '...');
  WriteLn('');

  // parse document data in JSON format
  document_parser.ParseDocument_3(INPUT_DOCUMENT, OUTPUT_FILE_NAME1, OutputFormat_JSON, false);

  WriteLn('Parsing results saved to ' + OUTPUT_FILE_NAME1);
  WriteLn('');

  document_parser.Dispose();

  document_parser := CoDocumentParser.Create();
  document_parser.RegistrationName := 'demo';
  document_parser.RegistrationKey := 'demo';

  WriteLn('Loading template 2...');
  document_parser.AddTemplate(CUSTOM_TEMPLATE2);

  WriteLn('Template 2 loaded.');
  WriteLn('');

  WriteLn('Parsing ' + INPUT_DOCUMENT + '...');
  WriteLn('');

  // parse document data in JSON format
  document_parser.ParseDocument_3(INPUT_DOCUMENT, OUTPUT_FILE_NAME2, OutputFormat_JSON, false);

  WriteLn('Parsing results saved to ' + OUTPUT_FILE_NAME2);
  WriteLn('');

  document_parser.Dispose();

  CoUninitialize();
end.
