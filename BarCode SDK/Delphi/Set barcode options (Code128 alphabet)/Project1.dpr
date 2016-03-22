//*******************************************************************
//       ByteScout BarCode SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

{
 IMPORTANT:
  To work with Bytescout BarCode SDK you need to import this as a component into Delphi

 To import Bytescout BarCode SDK into Delphi 2006 or higher do the following:
 1) Click Component | Import Component..
 2) Select Type Library and click Next
 3) Find and select Bytescout BarCode SDK in the list of available type libraries and
 4) Click Next
 5) Click Next on next screen
 6) Select "Add Bytescout_BarCode_TLB.pas" into Project" and click Finish

 This will add Bytescout_BarCode_TLB.pas into your project and now you can use BarCode object interface (_BarCode class)

}

program Project1;

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  Bytescout_BarCode_TLB in 'c:\program files\borland\bds\4.0\Imports\Bytescout_BarCode_TLB.pas';

var
 bc: _Barcode;
begin
  CoInitialize(nil);  // required for console applications, initializes ActiveX support

  // create barcode object using CoBarCode class
  bc:= CoBarCode.Create();
  // set symbology to Code128
  bc.Symbology := SymbologyType_Code128;
  bc.Options.Code128Alphabet := Code128Alphabet_B; // set code 128 alphabet to B alphabet
  // set barcode value
  bc.Value:= '12345';
  // save into PNG image
  bc.SaveImage('Code128.png');
  // free barcode object by setting to nil
  bc:= nil;

  CoUninitialize(); // required for console applications, initializes ActiveX support

end.
