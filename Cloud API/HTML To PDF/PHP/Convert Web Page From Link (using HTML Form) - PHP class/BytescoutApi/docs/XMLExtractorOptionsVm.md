# XMLExtractorOptionsVm

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**startPageIndex** | **int** | Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages | [optional] 
**endPageIndex** | **int** | Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages | [optional] 
**xCoordinateToleranceFactor** | **double** | Default value: 20 | [optional] 
**yCoordinateToleranceFactor** | **double** | Default value: 30 | [optional] 
**tableXMinIntersectionRequiredInPercents** | **int** | Default value: 49 | [optional] 
**tableYMinIntersectionRequiredInPercents** | **int** | Default value: 50 | [optional] 
**rtlTextAutoDetectionEnabled** | **bool** | Default value: False | [optional] 
**extractInvisibleText** | **bool** | Default value: True | [optional] 
**extractShadowLikeText** | **bool** | Default value: True | [optional] 
**unwrap** | **bool** | Default value: False | [optional] 
**removeHyphenation** | **bool** | Default value: True | [optional] 
**autoAlignColumnsToHeader** | **bool** | Default value: True | [optional] 
**preserveFormattingOnTextExtraction** | **bool** | Value indicating whether to preserve the text formatting on the extraction.\r\n            Default value: True | [optional] 
**detectLinesInsteadOfParagraphs** | **bool** | Default value: True | [optional] 
**trimSpaces** | **bool** | Default value: True | [optional] 
**extractColumnByColumn** | **bool** | Default value: False | [optional] 
**detectNewColumnBySpacesRatio** | **float** | Space ratio between words.\r\n            Default value: 1 | [optional] 
**ocrMode** | **string** | Default value: Off | [optional] 
**lineGroupingMode** | **string** | Default value: None | [optional] 
**columnDetectionMode** | **string** | Default value: ContentGroupsAndBorders | [optional] 
**ocrCacheMode** | **string** | Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off | [optional] 
**ocrLanguage** | **string** | Default value: eng | [optional] 
**ocrResolution** | **float** | Default value: 300 | [optional] 
**textEncodingCodePage** | **int** | Default value: 1252 | [optional] 
**considerFontNames** | **bool** | Default value: False | [optional] 
**considerFontSizes** | **bool** | Default value: False | [optional] 
**considerFontColors** | **bool** | Default value: False | [optional] 
**considerVerticalBorders** | **bool** | Default value: True | [optional] 
**password** | **string** | Default value: | [optional] 
**checkPermissions** | **bool** | Default value: True | [optional] 
**extractionAreaUsageMode** | **string** | Default value: UseAllIntersectingObjects | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


