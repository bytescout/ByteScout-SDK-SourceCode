program ParsingDataFromAirlineTickets;

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
  ByteScout_DocumentParser_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\ByteScout_DocumentParser_TLB.pas';

var
  document_parser: _DocumentParser;
  json: string;
  yaml: string;
  xml: string;

const
  INPUT_DOCUMENT: string = 'SampleTicket.pdf';
  TEMPLATE_DOCUMENT: string = 'SampleTicket.yml';

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);
  
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create and activate DocumentParser instance
  document_parser := CoDocumentParser.Create();
  document_parser.RegistrationName := 'demo';
  document_parser.RegistrationKey := 'demo';

  document_parser.AddTemplate(TEMPLATE_DOCUMENT);

  // parse document data in JSON format
  json := document_parser.ParseDocument_4(INPUT_DOCUMENT, OutputFormat_JSON, false);

  // display parsed data in console
  WriteLn('Parsing results in JSON format:');
  WriteLn('');
  WriteLn(json);

  WriteLn('=========================');

  // parse document data in YAML format
  yaml := document_parser.ParseDocument_4(INPUT_DOCUMENT, OutputFormat_YAML, false);

  // display parsed data in console
  WriteLn('Parsing results in YAML format:');
  WriteLn('');
  WriteLn(yaml);

  WriteLn('=========================');

  // parse document data in XML format
  xml := document_parser.ParseDocument_4(INPUT_DOCUMENT, OutputFormat_XML, false);
  // display parsed data in console
  WriteLn('Parsing results in XML format:');
  WriteLn('');
  WriteLn(xml);

  document_parser.Dispose();

  CoUninitialize();
end.
