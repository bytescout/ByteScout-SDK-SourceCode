program AddHeaderAndFooter;

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
  Bytescout_PDF_TLB in 'c:\program files\borland\bds\4.0\Imports\Bytescout_PDF_TLB.pas';

var
  doc: _Document;
  header_template, footer_template: _GraphicsTemplate;
  font: _Font;
  brush: _Brush;
  color: _Color;
  i: integer;
  page: _Page;

const
  INPUT_FILE_NAME: string = 'sample.pdf';
  OUTPUT_FILE_NAME: string = 'result.pdf';

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  doc := CoDocument.Create();
  doc.RegistrationName := 'demo';
  doc.RegistrationKey := 'demo';

  doc.Load(INPUT_FILE_NAME);

  // black characters color
  color := doc.ComHelpers.CreateColorRGB(0, 0, 0) as _Color;
  font := doc.ComHelpers.CreateStandardFont(STANDARDFONTS_COURIERBOLD, 15);
  brush := doc.ComHelpers.CreateSolidBrush(color) as _Brush;

  // prepare simple template (for example, a logo) and draw it on every page
  // create template of specified size
  header_template := doc.ComHelpers.CreateGraphicsTemplate(250, 50);
  header_template.DrawString('Here is a header text', font, brush, 30, 10);

  footer_template := doc.ComHelpers.CreateGraphicsTemplate(250, 50);
  footer_template.DrawString('Here is the footer text', font, brush, 30, 10);

  // write template in each pages
  for i := 0 to doc.Pages.Count - 1 do begin

    page := doc.Pages[i];
    page.Canvas.DrawTemplate(header_template, 40, 10);
    page.Canvas.DrawTemplate(footer_template, 350, (page.Height - 40));
  end;

  // save output file
  doc.Save(OUTPUT_FILE_NAME);

  // free document object
  doc.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
