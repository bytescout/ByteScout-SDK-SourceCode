//*******************************************************************
//       ByteScout BarCode Reader SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

{
 IMPORTANT:
  To work with Bytescout BarCode Reader SDK you need to import this as a component into Delphi

 To import Bytescout BarCode Reader SDK into Delphi 5 or higher to the following:
 1) Click Component | Import ActiveX control
 2) Find and select Bytescout BarCode Reader  SDK in the list of available type libraries and
 4) Click Next
 5) Select "Add Bytescout_BarCodeReader_TLB.pas" into Project" and click Finish


 To import Bytescout BarCode Reader SDK into Delphi 2006 or higher do the following:
 1) Click Component | Import Component..
 2) Select Type Library and click Next
 3) Find and select Bytescout BarCode Reader SDK in the list of available type libraries and
 4) Click Next
 5) Click Next on next screen
 6) Select "Add Bytescout_BarCodeReader_TLB.pas" into Project" and click Finish

 This will add Bytescout_BarCodeReader_TLB.pas into your project and now you can use Reader object interface (_Reader class)

}

program Project1;

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  Bytescout_BarCodeReader_TLB in 'c:\program files\borland\bds\4.0\Imports\Bytescout_BarCodeReader_TLB.pas';

var
 reader: _Reader;
 i: integer;
begin
  
  // Disable floating point exception to conform to .NET floating point operations behavior. 
  System.Set8087CW($133f);

  CoInitialize(nil);  // required for console applications, initializes ActiveX support

  // create barcode reader object using CoReader class
  reader := CoReader.Create();
  // set barcode types to look for in image
  reader.BarcodeTypesToFind.SetAll1D(); // see BarcodeTypeSelector for all possible values in Bytescout_BarCodeReader_TLB.pas
  reader.ReadFromFile('BarcodePhoto.jpg');

  For i:= 0 To reader.FoundCount - 1 Do begin
    WriteLn('Found barcode on page #' + IntToStr(reader.GetFoundBarcodePage(i)) + ' with type " & Cstr(bc.GetFoundBarcodeType(i)) & " and value = ' + reader.GetFoundBarcodeValue(i));
  End;

  WriteLn('Press any key to exit...');
  ReadLn;

  // free barcode reader object by setting to nil
  reader:= nil;

  CoUninitialize(); // required for console applications, initializes ActiveX support

end.
