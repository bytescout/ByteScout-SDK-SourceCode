# BarcodeReaderOptionsVm

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**startPageIndex** | **int** | Index of a page (zero-based) from which searching of BarCodes will be started (for PDF files).\r\n            Default value: all pages | [optional] 
**endPageIndex** | **int** | Index of a page (zero-based) on which searching of BarCodes will be finished (for PDF files).\r\n            Default value: all pages | [optional] 
**customArea** | [**\Bytescout\Client\Model\RectangleVm**](RectangleVm.md) | Default value: {X=0,Y=0,Width=0,Height=0} | [optional] 
**customAreaLeft** | **int** | Default value: 0 | [optional] 
**customAreaTop** | **int** | Default value: 0 | [optional] 
**customAreaWidth** | **int** | Default value: 0 | [optional] 
**customAreaHeight** | **int** | Default value: 0 | [optional] 
**scanArea** | **string** | Default value: WholePage | [optional] 
**barcodeTypesToFind** | [**\Bytescout\Client\Model\BarcodeTypeSelector**](BarcodeTypeSelector.md) | Default value: All = true | [optional] 
**orientation** | **string** | Default value: Default | [optional] 
**searchNegative** | **bool** | Default value: False | [optional] 
**requireQuietZones** | **bool** | Default value: True | [optional] 
**maxNumberOfBarcodesPerPage** | **int** | Default value: 0 | [optional] 
**decodingTimeOut** | **int** | Default value: 10000 (10 seconds) | [optional] 
**lastDecodingTimeOutExceeded** | **bool** | Default value: False | [optional] 
**maxNumberOfBarcodesPerDocument** | **int** | Default value: 0 | [optional] 
**allowOrphanedSupplementals** | **bool** | Default value: False | [optional] 
**minimalDataLength** | **int** | Default value: 0 | [optional] 
**mediumTrustLevelCompatible** | **bool** | Default value: False | [optional] 
**optimizedProcessingOfLargeImages** | **bool** | Default value: False | [optional] 
**optimizedProcessingOfLargeImagesSizeLimit** | **int** | Default value: 1600 | [optional] 
**removeNoize** | **bool** | Default value: False | [optional] 
**noiseRemovalFilterSize** | **int** | Default value: 2 | [optional] 
**noiseRemovalFilterType** | **string** | Default value: Blur | [optional] 
**colorConversionMode** | **string** | Default value: ImageBlocks | [optional] 
**contrast** | **int** | Default value: 0 | [optional] 
**textEncoding** | **string** | Default value: Default | [optional] 
**textEncodingCodePage** | **int** | Default value: 28591 | [optional] 
**textEncodingUseUTF8** | **bool** | Default value: False | [optional] 
**pdfReadingMode** | **string** | Default value: RenderPDF | [optional] 
**pdfRenderingResolution** | **int** | Default value: 300 | [optional] 
**pdfRenderText** | **bool** | Default value: True | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


