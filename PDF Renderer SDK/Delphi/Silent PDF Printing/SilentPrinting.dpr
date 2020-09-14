program SilentPrinting;

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
  Bytescout_PDFRenderer_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDFRenderer_TLB.pas';

var
  document_printer: _DocumentPrinter;
  pages: OleVariant;

const
  PRINTER_NAME: string = 'Microsoft Print to PDF';
  INPUT_FILE_NAME: string = 'multipage.pdf';

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create an instance of Bytescout.PDFRenderer.DocumentPrinter object and register it.
  document_printer := CoDocumentPrinter.Create();
  document_printer.RegistrationName := 'demo';
  document_printer.RegistrationKey := 'demo';

  // load PDF document.
  document_printer.LoadDocumentFromFile(INPUT_FILE_NAME);

  // Change some printing options for demo purposes
  // (note, some options might be not supported by the printer):

  // change paper orientation
  document_printer.Landscape := true;
  // set number of copies
  document_printer.Copies := 2;
  // set collation
  document_printer.Collate := true;
  // force black and white printing
  document_printer.Color := false;

  // print all document pages to the specified printer
  document_printer.PrintDocument(PRINTER_NAME);

  // to print specific pages use overridden methods allowing to define pages to print:
  // document_printer.PrintDocument_3(PRINTER_NAME, 2, 4); // printer pages from 3 to 5

  // print specific pages
  // pages := VarArrayCreate([0, 4], VT_I4);
  // pages[0] := 0; pages[1] := 2; pages[2] := 3; pages[3] := 4; pages[4] := 6;
  // document_printer.PrintDocument_4(PRINTER_NAME, PSafeArray(TVarData(pages).VArray));

  // document_printer.PrintDocument_2(PRINTER_NAME, '1,3-5,7-');

  // free printer object
  document_printer.Dispose();

  CoUninitialize();
end.
