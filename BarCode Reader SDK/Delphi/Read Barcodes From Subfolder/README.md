## How to read barcodes from subfolder in Delphi with ByteScout BarCode Reader SDK

### The tutorial shows how to read barcodes from subfolder in Delphi

The documentation is designed to help you to implement the features on your side. ByteScout BarCode Reader SDK is the barcode decoder with support for code 39, code 128, QR Code, Datamatrix, GS1, PDF417 and all other popular barcodes. Can read barcodes from images, pdf, tiff documents and live web camera. Supports noisy and damaged documents, can split and merge pdf and tiff documents based on barcodes. Can export barcode decoder results to XML, JSON, CSV and into custom data structures and you can use it to read barcodes from subfolder with Delphi.

Delphi code samples for Delphi developers help to speed up coding of your application when using ByteScout BarCode Reader SDK. In order to implement the functionality, you should copy and paste this code for Delphi below into your code editor with your app, compile and run your application. Further enhancement of the code will make it more vigorous.

Our website provides trial version of ByteScout BarCode Reader SDK for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20BarCode%20Reader%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20BarCode%20Reader%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=EARSPJFIJMU](https://www.youtube.com/watch?v=EARSPJFIJMU)




<!-- code block begin -->

##### ****Project1.dpr:**
    
```
//*******************************************************************
//       ByteScout Barcode Reader SDK		                                     
//                                                                   
//       Copyright � 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

program Project1;

{$APPTYPE CONSOLE}

{
 Sample that shows reading of barcodes from images in /Images/ subfolder
}

uses
  SysUtils,
  ComObj,
  ActiveX;
var
 reader: Variant;
 SR: TSearchRec;
 arrayOutput: Variant;
 varItem: Variant;
 i: integer;
 pathWithImages, imageType: string;
begin
 CoInitialize(nil);

 // Disable floating point exception to conform to .NET floating point operations behavior.
 System.Set8087CW(
<!-- code block begin -->

##### ****{codeFileName}:**
    
```
{code}
```

<!-- code block end -->    
33f);

 // Create and initialize Bytescout.BarCodeReader.Reader object
 reader := CreateOleObject('Bytescout.BarCodeReader.Reader');
 reader.RegistrationName := 'demo';
 reader.RegistrationKey := 'demo';

 // Enable Code 39 decoding, you may also enable other types (dozens of types supported)
 // see .BarCodeTypesToFind for more values.
 reader.BarcodeTypesToFind.Code39 := true;

 // For example to enable Code128 uncomment line below
 // reader.BarcodeTypesToFind.Code128 := true;

 // For example to enable QR Code uncomment line below
 // reader.BarcodeTypesToFind.QRCode := true;

 // Setup possible barcode orientations ( ato support rotated images)
 // see BarCode Reader SDK - OrientationType enum for more variations
 // uncomment to support more orientations like right to left 
 {
 reader.Orientation :=
					1 or //OrientationType.HorizontalFromLeftToRight
					16 or // OrientationType.HorizontalFromRightToLeft
					32768 or // OrientationType.VerticalFromBottomToTop
					2; // OrientationType.VerticalFromTopToBottom;
 }

 // uncomment to enable processing of negative barcodes (white bars on dark background)
 // reader.SearchNegative := true;

 // uncomment to Enable Heuristic Mode (try different image processing modes if the default failed).
 // Helps on photos with poor lighting conditions.
 //reader.HeuristicMode := true;

 // define subfolder where we have images 
 pathWithImages := '.\Images\';
 imageType := '*.jpg'; // can also be *.png, *.tiff, *.bmp, *.PDF

 // now search for files with images and processing them one by one
 if FindFirst(pathWithImages + imageType, faAnyFile, SR) = 0 then begin
    repeat
      if (SR.Attr <> faDirectory) then begin
        writeLn(SR.Name);
        writeLn('------------------');
        // processing the file
        reader.ReadFromFile(pathWithImages + SR.Name);
        for i := 0 to reader.FoundCount - 1 do begin
          writeLn(
            '#' + IntToStr(i) + ' barcode with value ' +
            reader.GetFoundBarcodeValue(i)+
            ' at ' + FloatToStr(reader.GetFoundBarCodeLeft(i)) +
            ',' + FloatToStr(reader.GetFoundBarCodeTop(i))
          );
        end;
        writeLn('------------------');
      end;
    until FindNext(SR) <> 0;
    FindClose(SR);
 end;

 WriteLn('Press any key to exit...');
 ReadLn;

 reader := varEmpty;

end.


```

<!-- code block end -->