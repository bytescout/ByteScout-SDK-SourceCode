//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

program Project1;

{$APPTYPE CONSOLE}

{
 IMPORTANT:
  To work with Bytescout PDF Extractor SDK you may also use Late Binding

}

uses
  SysUtils,
  ActiveX;

var
 extractor: Variant;
begin
 CoInitialize(nil);

// Create Bytescout.PDFExtractor.CSVExtractor object using CoCSVExtractor class
extractor := CreateOleObject('Bytescout.PDFExtractor.CSVExtractor') ; 


 extractor.RegistrationName := 'demo';
 extractor.RegistrationKey := 'demo';

 // Load sample PDF document
 extractor.LoadDocumentFromFile ('../../sample3.pdf');

// extractor.CSVSeparatorSymbol = ','; // you can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales

 extractor.SaveCSVToFile ('output.csv');

 // destroy the extractor object
 extractor := nil;

end.
