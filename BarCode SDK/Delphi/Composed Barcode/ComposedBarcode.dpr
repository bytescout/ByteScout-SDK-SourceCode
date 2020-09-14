program ComposedBarcode;

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
  ShellApi,
  ActiveX,
  Windows,
  Bytescout_BarCode_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_BarCode_TLB.pas';

var
  bar_code: _Barcode;
  composer: _ImageComposer;

const
  INPUT_FILE_NAME1: string = 'image1.png';
  INPUT_FILE_NAME2: string = 'image2.png';
  OUTPUT_FILE_NAME: string = 'result.png';

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  bar_code := CoBarcode.Create();
  bar_code.RegistrationName := 'demo';
  bar_code.RegistrationKey := 'demo';

  bar_code.Symbology := SymbologyType_Code128;

  bar_code.Margins := CoMargins.Create();
  bar_code.Margins.left := 0;
  bar_code.Margins.top := 0;
  bar_code.Margins.right := 0;
  bar_code.Margins.bottom := 0;
  bar_code.DrawQuietZones := false;

  bar_code.Value := '123123';
  bar_code.SaveImage(INPUT_FILE_NAME1);

  bar_code.Value := '123';
  bar_code.SaveImage(INPUT_FILE_NAME2);

  composer := CoImageComposer.Create();
  composer.InnerGap := 10;
  composer.Margins := 5;
  composer.CompositionMode := CompositionMode_ArrangeHorizontally;

  composer.AddImage(INPUT_FILE_NAME1, 0, 0, 0);
  composer.AddImage(INPUT_FILE_NAME2, 0, 0, 90);

  composer.SaveComposedImage(OUTPUT_FILE_NAME);

  // show image in default image viewer
  ShellExecute(0, 'open', PAnsiChar(OUTPUT_FILE_NAME), nil, nil, SW_SHOWNORMAL);

  // free barcode object
  composer.Dispose();
  bar_code.Dispose();

  // calls to CoInitialize must be balanced by calls to CoUninitialize
  CoUninitialize();
end.
