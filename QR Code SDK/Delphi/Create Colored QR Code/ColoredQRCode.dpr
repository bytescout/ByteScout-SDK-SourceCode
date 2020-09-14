program ColoredQRCode;

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
  ShellApi,
  Windows,
  Bytescout_BarCode_QRCode_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_BarCode_QRCode_TLB.pas';

var
  qr_code: _QRCode;

const
  OUTPUT_FILE_NAME: string = 'result.png';

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create and activate QRCode instance
  qr_code := CoQRCode.Create();
  qr_code.RegistrationName := 'demo';
  qr_code.RegistrationKey := 'demo';

  // set background color
  qr_code.BackColor := $00FFFF; // yellow
  // set foreground color
  qr_code.ForeColor := $0000FF; // red
  // set value
  qr_code.Value := 'ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz 1234567890';
  // save QRCode to image
  qr_code.SaveImage(OUTPUT_FILE_NAME);

  // show image in default viewer
  ShellExecute(0, 'open', PAnsiChar(OUTPUT_FILE_NAME), nil, nil, SW_SHOWNORMAL);

  // free QRCode object
  qr_code.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
