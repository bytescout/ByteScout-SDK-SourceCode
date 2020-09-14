program ExtractText;

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
  ComObj,
  ByteScout_TextRecognition_TLB in 'c:\program files\borland\bds\4.0\Imports\ByteScout_TextRecognition_TLB.pas',
  mscorlib_TLB in 'c:\program files\borland\bds\4.0\Imports\mscorlib_TLB.pas';

var
  text_recognizer: _TextRecognizer;
  page_width, page_height: integer;
  ocr_object_list: _OCRObjectList;
  i: integer;
  encoding: _Encoding;

const
  INPUT_FILE_NAME: string = 'areas-sample.pdf';
  OUTPUT_FILE_NAME: string = 'result.txt';
  PAGE_INDEX: integer = 0;

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create and activate TextRecognizer instance
  text_recognizer := CoTextRecognizer.Create();
  text_recognizer.RegistrationName := 'demo';
  text_recognizer.RegistrationKey := 'demo';

  text_recognizer.LoadDocument(INPUT_FILE_NAME);

  // set the location of OCR language data files
  text_recognizer.OCRLanguageDataFolder := 'C:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\';

  // set OCR language.
  // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
  // find more language files at https://github.com/bytescout/ocrdata
  text_recognizer.OCRLanguage := 'eng';

  // get page size (in pixels)
  // size of PDF document is computed from PDF Points
  // and the rendering resolution specified by `textRecognizer.PDFRenderingResolution` (default 300 DPI)
  page_width := text_recognizer.GetPageWidth(PAGE_INDEX);
  page_height := text_recognizer.GetPageHeight(PAGE_INDEX);

  // add area of interest as a rectangle at the top-right corner of the page
  text_recognizer.RecognitionAreas.Add(page_width div 2, 0, page_width div 2, 300, AreaRotation_RotateNoneFlipNone, OCRProposedContentType_Auto);
  // add area of interest as a rectangle at the bottom-left corner of the page,
  // and indicate it should be rotated at 90 deg
  text_recognizer.RecognitionAreas.Add(0, page_height div 2, 300, page_height div 2, AreaRotation_Rotate90FlipNone, OCRProposedContentType_Auto);

  // now, you can get recognized text for further analysis as a list of objects
  // containing coordinates, object kind, confidence.
  ocr_object_list := text_recognizer.GetOCRObjects(PAGE_INDEX, OCRProposedContentType_Auto);
  for i := 0 to ocr_object_list.Count - 1 do
    WriteLn(ocr_object_list.Item[i].ToString);

  encoding := CoUnicodeEncoding.Create() as _Encoding;
  // ... or you can save recognized text pieces to file
  text_recognizer.KeepTextFormatting := false; // save without formatting
  text_recognizer.SaveText(OUTPUT_FILE_NAME, PAGE_INDEX, PAGE_INDEX, encoding);

  text_recognizer.Dispose();


  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
