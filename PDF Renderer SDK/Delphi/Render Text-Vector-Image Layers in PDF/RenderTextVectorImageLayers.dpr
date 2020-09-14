program RenderTextVectorImageLayers;

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
  rendering_options: RenderingOptions;
  i: integer;

const
  INPUT_FILE_NAME: string = 'multipage.pdf';

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it
  renderer := CoRasterRenderer.Create();
  renderer.RegistrationName := 'demo';
  renderer.RegistrationKey := 'demo';

  rendering_options := CoRenderingOptions.Create();

  // enable text objects rendering
  rendering_options.RenderTextObjects := true;
  // DISABLE vector objects rendering
  rendering_options.RenderVectorObjects := false;
  // DISABLE image objects rendering
  rendering_options.RenderImageObjects := false;

  // load PDF document.
  renderer.LoadDocumentFromFile(INPUT_FILE_NAME);

  for i := 0 to renderer.GetPageCount() - 1 do begin

    // render document page to PNG image file.
    renderer.Save_2('image' + IntToStr(i) + '.png', RasterImageFormat_PNG,
      i, 300, rendering_options);
  end;

  // free renderer object
  renderer.Dispose();

  CoUninitialize();
end.
