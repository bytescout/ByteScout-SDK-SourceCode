program DisplayLicenseInfo;

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
  Bytescout_PDFRenderer_TLB in 'c:\program files\borland\bds\4.0\Imports\Bytescout_PDFRenderer_TLB.pas';

var
  renderer: _RasterRenderer;
  info: Variant;

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // LicenseInfo can be retrieved by createing instance of any renderer class,
  // Because all of them are derived from BaseRenderer
  renderer := CoRasterRenderer.Create();
  renderer.RegistrationName := 'demo';
  renderer.RegistrationKey := 'demo';

  // show Info
  WriteLn('===============================');
  WriteLn('======== License Info =========');
  WriteLn('===============================');

  info := renderer.LicenseInfo;
  WriteLn('License type:' + info.LicenseType);
  WriteLn('License limit type: ' + info.LimitType);
  WriteLn('Limit of license units:' + FloatToStr(info.Limit));
  WriteLn('License limit term: ' + info.LimitTerm);
  WriteLn('No of remaining license units: ' + FloatToStr(info.Remainder));
  WriteLn('Update expires On: ' + info.UpdatesExpireOn);

  // free renderer object
  renderer.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
