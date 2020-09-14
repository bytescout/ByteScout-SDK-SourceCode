program ReadTextFromNoisyImage;

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
  Bytescout_PDFExtractor_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDFExtractor_TLB.pas';

var
  extractor: _TextExtractor;
  all_text: string;

const
  INPUT_FILE_NAME: string = 'sample.png';

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create Bytescout.PDFExtractor.TextExtractor instance
  extractor := CoTextExtractor.Create();
  extractor.RegistrationName := 'demo';
  extractor.RegistrationKey := 'demo';

  // load noisy image document
  extractor.LoadDocumentFromFile(INPUT_FILE_NAME);

  // set the font repairing OCR mode
  extractor.OCRMode := OCRMode_TextFromImagesAndVectorsAndRepairedFonts;

  // Set the location of OCR language data files
  extractor.OCRLanguageDataFolder := 'C:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\';

  // set OCR language
  // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
  // find more language files at https://github.com/bytescout/ocrdata
  extractor.OCRLanguage := 'eng';

  // set document rendering resolution
  extractor.OCRResolution := 300;

  // you can also apply various preprocessing filters
  // to improve the recognition on low-quality scans.
  WriteLn('Please wait while PDF Extractor SDK is processing noisy image to read data...');

  // automatically deskew skewed scans
  extractor.OCRImagePreprocessingFilters.AddDeskew();

  // remove vertical or horizontal lines (sometimes helps to avoid OCR engine's page segmentation errors)
  // extractor.OCRImagePreprocessingFilters.AddVerticalLinesRemover();
  // extractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover();

  // repair broken letters
  extractor.OCRImagePreprocessingFilters.AddDilate();

  // remove noise
  extractor.OCRImagePreprocessingFilters.AddMedian();

  // apply gamma correction
  extractor.OCRImagePreprocessingFilters.AddGammaCorrection();

  // add contrast
  // extractor.OCRImagePreprocessingFilters.AddContrast(20);

  // (!) you can use new OCRAnalyser class to find an optimal set of image
  // preprocessing filters for your specific document; see "OCR Analyser" example

  // read all text
  all_text := extractor.GetText();

  WriteLn('Extracted Text:');
  WriteLn(all_text);

  // cleanup
  extractor.Dispose();

  CoUninitialize();
end.
