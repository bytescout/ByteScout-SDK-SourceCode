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
  To work with Bytescout PDF Extractor SDK you need to import this as a component into Delphi

 To import Bytescout PDF Extractor SDK into Delphi 2006 or higher do the following:
 1) Click Component | Import Component..
 2) Select Type Library and click Next
 3) Find and select Bytescout PDF Extractor SDK in the list of available type libraries and
 4) Click Next
 5) Click Next on next screen
 6) Select "Add Bytescout_PDFExtractor_TLB.pas" into Project" and click Finish

 This will add Bytescout_PDFExtractor_TLB.pas into your project and now you can use TextExtractor, InfoExtractor, CSVExtractor, XMLExtractor, ImageExtractor object interfaces (_TextExtractor, _InfoExtractor, _CSVExtractor, _XMLExtractor, _ImageExtractor classes)

 For Delphi 5,6,7,8 / C++ Builder 5,6,7,8 (for 2006 or higher versions please see above)
1) Start Delphi (or C++ Builder)
2) Select Component menu and "Import ActiveX control.."
3) Find the library in the list of available ActiveX/COM objects
4) Select this library and click "Install" 
5) Create a new package for this library imported (for example, TPDFExtractorSDKActiveX)
6) Click OK
7) Answer "Yes" when Delphi (or C++ Builder) asks to rebuild the package
8) The IDE will rebuild the package and will inform that the control has been installed. Close the package and answer "Yes" to save changes
9) The library object is now available on "ActiveX" tab on Tools Pallete. You can simply drag and drop it into the form in your application and use it

}

uses
  SysUtils,
  ActiveX,
  Bytescout_PDFExtractor_TLB in 'c:\program files\borland\bds\4.0\Imports\Bytescout_PDFExtractor_TLB.pas';

var
 extractor: _CSVExtractor;
begin
 CoInitialize(nil);

// Create Bytescout.PDFExtractor.CSVExtractor object using CoCSVExtractor class
 extractor := CoCSVExtractor.Create();


 extractor.RegistrationName := 'demo';
 extractor.RegistrationKey := 'demo';

 // Load sample PDF document
 extractor.LoadDocumentFromFile ('../../sample3.pdf');

// extractor.CSVSeparatorSymbol = ','; // you can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales

 extractor.SaveCSVToFile ('output.csv');

 // reset the extractor so could load another file
 extractor.Reset();

 // now load another file
 // Load sample PDF document
 extractor.LoadDocumentFromFile ('../../sample2.pdf');

 extractor.SaveCSVToFile ('output2.csv');


 // destroy the extractor object
 extractor := nil;

end.
