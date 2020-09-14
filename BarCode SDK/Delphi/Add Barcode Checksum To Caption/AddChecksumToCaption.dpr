program AddChecksumToCaption;

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
  Bytescout_BarCode_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_BarCode_TLB.pas';

var
  bar_code: _Barcode;

const
  OUTPUT_FILE_NAME: string = 'result.png';

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  bar_code := CoBarcode.Create();
  bar_code.RegistrationName := 'demo';
  bar_code.RegistrationKey := 'demo';

  // set symbology
  bar_code.Symbology := SymbologyType_Codabar;
  // set value
  bar_code.Value := '123456';

  // add checksum to bar_code
  bar_code.AddChecksum := true;
  // add checksum to caption
  bar_code.AddChecksumToCaption := true;

  // save bar_code to image
  bar_code.SaveImage(OUTPUT_FILE_NAME);

  // show image in default image viewer
  ShellExecute(0, 'open', PAnsiChar(OUTPUT_FILE_NAME), nil, nil, SW_SHOWNORMAL);

  // free barcode object
  bar_code.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
