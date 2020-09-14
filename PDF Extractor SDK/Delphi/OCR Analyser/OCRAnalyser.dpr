program OCRAnalyser;

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  ComObj,
  Bytescout_PDFExtractor_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDFExtractor_TLB.pas';

var
  extractor: _TextExtractor;
  page_index: integer;
  ocr_language_data_folder: string;
  ocr_language: string;
  analyzer: _OCRAnalyzer;
  analysis_results: OCRAnalysisResults;
  left, top, width, height: single;

const
  INPUT_FILE_NAME: string = 'sample_ocr.pdf';
  OUTPUT_FILE_NAME: string = 'result.txt';


procedure ProgressChanged (obj: Pointer; mes: string; progress: double; var cancel: boolean);
begin
  WriteLn(mes);
end;

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // document page index
  page_index := 0;

  // Location of language data files
  ocr_language_data_folder := 'c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\';

  // OCR language
  // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
  // Find more language files at https://github.com/bytescout/ocrdata
  ocr_language := 'eng';

  // create OCRAnalyzer instance and activate it with your registration information
  analyzer := CoOCRAnalyzer.Create();
  analyzer.RegistrationName := 'demo';
  analyzer.RegistrationKey := 'demo';

  // load document to OCRAnalyzer
  analyzer.LoadDocumentFromFile(INPUT_FILE_NAME);

  left := analyzer.GetPageRect_Left(page_index);
  top := analyzer.GetPageRect_Top(page_index);
  width := analyzer.GetPageRect_Width(page_index);
  height := analyzer.GetPageRect_Height(page_index);

  // setup OCRAnalyzer
  analyzer.OCRLanguage := ocr_language;
  analyzer.OCRLanguageDataFolder := ocr_language_data_folder;

  WriteLn('Starting the OCR analysis. Click OK and wait, it may last long.');

  // set page area for analysis (optional)
  // area of the document page to perform the analysis (optional).
  analyzer.SetExtractionArea(left, top, width, height);

  // perform analysis and get results
  analysis_results := analyzer.AnalyzeByOCRConfidence(page_index);

  // now extract the text using detected OCR parameters

  // create Bytescout.PDFExtractor.TextExtractor instance
  extractor := CoTextExtractor.Create();
  extractor.RegistrationName := 'demo';
  extractor.RegistrationKey := 'demo';

  // load document to TextExtractor
  extractor.LoadDocumentFromFile(INPUT_FILE_NAME);

  // setup TextExtractor
  extractor.OCRMode := OCRMode_Auto;
  extractor.OCRLanguageDataFolder := ocr_language_data_folder;
  extractor.OCRLanguage := ocr_language;

  // apply analysis results to TextExtractor instance
  analyzer.ApplyResults(analysis_results, extractor as _BaseTextExtractor);

  // set extraction area (optional)
  extractor.SetExtractionArea(left, top, width, height);

  // save extracted text to file
  extractor.SaveTextToFile(OUTPUT_FILE_NAME);

  analyzer.Dispose();
  extractor.Dispose();

  CoUninitialize();
end.
