program MakeThumbnail;

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
  Bytescout_PDFRenderer_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDFRenderer_TLB.pas';

var
  renderer: _RasterRenderer;
  left, top, width, height: single;

const
  PAGE_INDEX: integer = 0;
  INPUT_FILE_NAME: string = 'multipage.pdf';
  OUTPUT_FILE_NAME: string = 'thumbnail.jpg';

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it
  renderer := CoRasterRenderer.Create();
  renderer.RegistrationName := 'demo';
  renderer.RegistrationKey := 'demo';

  // load PDF document
  renderer.LoadDocumentFromFile(INPUT_FILE_NAME);

  left := renderer.GetPageRect_Left(PAGE_INDEX);
  top := renderer.GetPageRect_Top(PAGE_INDEX);
  width := renderer.GetPageRect_Width(PAGE_INDEX);
  height := renderer.GetPageRect_Height(PAGE_INDEX);

  // portrait page orientation
  if (width < height) then begin

    width := -1;  // width will be calculated from height keeping the aspect ratio
    height := 100;
  end else begin  // landscape page orientation

    width := 100;
    height := -1; // height will be calculated from width keeping the aspect ratio
  end;

  // render first page of the document to JPEG image file
  renderer.Save_3(OUTPUT_FILE_NAME, RasterImageFormat_JPEG, PAGE_INDEX, Trunc(width), Trunc(height));

  // free renderer object
  renderer.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
