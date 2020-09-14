program SaveOcrObjectAsJson;

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
  ByteScout_TextRecognition_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\ByteScout_TextRecognition_TLB.pas';

var
  text_recognizer: _TextRecognizer;

const
  INPUT_FILE_NAME: string = 'ocr-sample.pdf';
  OUTPUT_FILE_NAME: string = 'result.json';
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

  // recognize text from page and save each ocr word object to json
  text_recognizer.SaveOCRObjectsAsJSON(OUTPUT_FILE_NAME, PAGE_INDEX, OCRObjectType_Word);

  text_recognizer.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
