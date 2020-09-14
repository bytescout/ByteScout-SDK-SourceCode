program QRCodeWithWebsiteUrl;

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
  Bytescout_BarCode_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_BarCode_TLB.pas';

var
  bar_code: _Barcode;
  url: string;

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  bar_code := CoBarcode.Create();
  bar_code.RegistrationName := 'demo';
  bar_code.RegistrationKey := 'demo';

  // set symbology
  bar_code.Symbology := SymbologyType_QRCode;

  // input URL
  url := 'https://bytescout.com';

  // set value
  bar_code.Value := url;

  // save barcode to image
  bar_code.SaveImage('result.png');

  // free barcode object
  bar_code.Dispose();

  // calls to CoInitialize must be balanced by calls to CoUninitialize
  CoUninitialize();
end.
