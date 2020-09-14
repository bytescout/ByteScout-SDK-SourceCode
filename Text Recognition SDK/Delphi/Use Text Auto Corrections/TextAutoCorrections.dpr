program TextAutoCorrections;

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
  ComObj;

var
  text_recognizer: Variant;

const
  INPUT_FILE_NAME: string = 'bad-quality.png';
  OUTPUT_FILE_NAME: string = 'result.txt';

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  text_recognizer := CreateOleObject('Bytescout.TextRecognition.TextRecognizer');
  text_recognizer.RegistrationName := 'demo';
  text_recognizer.RegistrationKey := 'demo';

  text_recognizer.LoadDocument(INPUT_FILE_NAME);

  // set the location of OCR language data files
  text_recognizer.OCRLanguageDataFolder := 'C:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\';

  // set OCR language.
  // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
  // find more language files at https://github.com/bytescout/ocrdata
  text_recognizer.OCRLanguage := 'eng';

  // add error corrections that will be applied after the recognition
  text_recognizer.Corrections.Add('Tut ', 'Test ', false);
  text_recognizer.Corrections.Add('Recog\\w{1,}on', 'Recognition', true);

  // recognize text from all pages and save it to file
  text_recognizer.SaveText(OUTPUT_FILE_NAME);

  text_recognizer := varEmpty;

  // required for console applications, initializes ActiveX support
  CoUninitialize();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
