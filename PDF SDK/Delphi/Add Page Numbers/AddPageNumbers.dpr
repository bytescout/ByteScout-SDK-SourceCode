program AddPageNumbers;

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
  ComObj,
  Bytescout_PDF_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDF_TLB.pas';

type
  TPageNoStyle = (pnsTopLeft, pnsTopRight, pnsBottomLeft, pnsBottomRight);

var
  doc: _Document;
  i: integer;
  font: _Font;
  brush: _Brush;
  color: _Color;

const
  INPUT_FILE_NAME: string = 'sample.pdf';
  OUTPUT_FILE_NAME: string = 'result.pdf';

procedure __AddPageNo(page: _Page; page_no: integer; style: TPageNoStyle);
var
  left, top: Single;

begin
  left := 10;
  top := 10;

  case style of
  pnsTopRight:
    left := page.Width - 60;
  pnsBottomLeft:
    top := page.Height - 20;
  pnsBottomRight: begin
    top := page.Height - 20;
    left := page.Width - 60;
  end;
  pnsTopLeft: // no action
  end;

  // draw/write page no
  page.Canvas.DrawString(Format('Page #%d', [page_no]), font, brush, left, top);
end;

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  doc := CoDocument.Create();
  doc.RegistrationName := 'demo';
  doc.RegistrationKey := 'demo';

  doc.Load(INPUT_FILE_NAME);

  color := doc.ComHelpers.CreateColorRGB(0, 0, 0) as _Color;
  font := doc.ComHelpers.CreateStandardFont(STANDARDFONTS_COURIERBOLD, 15);
  brush := doc.ComHelpers.CreateSolidBrush(color) as _Brush;

  // write template in each pages
  for i := 0 to doc.Pages.Count - 1 do
    __AddPageNo(doc.Pages[i], i + 1, pnsBottomRight);

  // save output file
  doc.Save(OUTPUT_FILE_NAME);
  
  // free document object
  doc.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
