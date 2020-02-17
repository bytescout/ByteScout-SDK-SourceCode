//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2020 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

{

 IMPORTANT NOTICE for DELPHI 2007, Delphi 2006 or earlier versions:
 -----------------------------------------------------------------------
 Usual approach with type library import (so called "early binding") will crash with "stackoverflow" or "floating point error" due to issues in this versions of Delphi. 
 SOLUTION: Please use so called "late binding" that requires NO type library import and works by creating objects at the runtime like this:  
 // -----------------
 program Project1;
 uses
   SysUtils,
   ComObj,
   ActiveX;
 var
 extractor: Variant;
 begin
 CoInitialize(nil);
 // Create and initialize 
 extractor := CreateOleObject('Bytescout.PDFExtractor.CSVExtractor') ;
 // as usual 
 extractor.LoadDocumentFromFile ('../../sample3.pdf');
 // …
 // destroy the object by setting to varEmpty
 extractor := varEmpty;  
 end.
 // -----------------  

}

program PdfToJpeg;

{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils,
  ComObj,
  ActiveX;

var
  renderer: Variant;
  renderingResolution: Integer;
  outputImageFormat: Integer;
  pageIndex: Integer;

begin

  try

    CoInitialize(nil);

    // Create and initialize Bytescout.PDFRenderer.RasterRenderer object
    renderer := CreateOleObject('Bytescout.PDFRenderer.RasterRenderer');
    renderer.RegistrationName := 'demo';
    renderer.RegistrationKey := 'demo';

    // Load sample PDF document
    renderer.LoadDocumentFromFile('..\..\multipage.pdf');

    // Render PDF document at 96 DPI - default PC display resolution
    // To get higher quality output, set 200, 300 or more
    renderingResolution := 96;

    // Image format: 0 - BMP; 1 - JPEG; 2 - PNG; 3 - TIFF; 4 - GIF
    outputImageFormat := 1;

    // Iterate through pages
    for pageIndex := 0 to renderer.GetPageCount - 1 do
    begin
      // Render document page to JPEG image file
      renderer.Save('page' + IntToStr(pageIndex) + '.jpg', outputImageFormat, pageIndex, renderingResolution);
    end;

  except
    on E: Exception do
      Writeln(E.ClassName, ': ', E.Message);
  end;
end.
