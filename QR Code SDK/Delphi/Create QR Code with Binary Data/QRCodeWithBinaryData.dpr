program QRCodeWithBinaryData;

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
  INPUT_BYTES: array [0..7] of byte = (0, 10, 11, 12, 13, 14, 15, 255);

function __BytesToStr(bytes: array of byte): string;
const
  BYTES_HEX: array[0..15] of char = ('0', '1', '2', '3', '4', '5', '6', '7',
    '8', '9', 'A', 'B', 'C', 'D', 'E', 'F');
var
  i, len: integer;
begin
  len := Length(bytes);
  SetLength(Result, len * 2);
  for i := 0 to len - 1 do begin

    Result[i * 2 + 1] := BYTES_HEX[bytes[i] shr 4];
    Result[i * 2 + 2] := BYTES_HEX[bytes[i] and $0F];
  end;
end;

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create and activate QRCode instance
  qr_code := CoQRCode.Create();
  qr_code.RegistrationName := 'demo';
  qr_code.RegistrationKey := 'demo';

  // set value by converting byte array to string
  qr_code.value := __BytesToStr(INPUT_BYTES);

  // save QRCode to image
  qr_code.SaveImage(OUTPUT_FILE_NAME);

  // show image in default viewer
  ShellExecute(0, 'open', PAnsiChar(OUTPUT_FILE_NAME), nil, nil, SW_SHOWNORMAL);

  // free QRCode object
  qr_code.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
