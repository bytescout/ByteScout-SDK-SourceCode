# PDF Extractor SDK Tips
In this document we'll be listing out all useful tips when dealing with complex issue.

## PDF Data Extraction such as CSV is not extracting data
In some scenarios text in document is drawn with vector curves instead of fonts, which makes it impossible to decode tect. To extract text from such a document we need to enable optical recognition (OCR).

Following code snippet is useful here.

`````
extractor.OCRMode = OCRMode.Auto;
extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best";
extractor.OCRResolution = 300;
extractor.OCRMaximizeCPUUtilization = true; // this will speed up OCR but utilizes CPU up to 100%
`````

## Reading text from inverted image
In cases when text is not getting extracted from inverted image, we can provide following additional instructions to OCR engine for better result.

`````
extractor.OCRResolution = 450;
extractor.OCRImagePreprocessingFilters.AddMedian();
`````