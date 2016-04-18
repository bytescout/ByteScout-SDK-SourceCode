# Bytescout\Client\BarcodeReaderApi

All URIs are relative to *https://bytescout.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**barcodeReaderBarcodeReaderGet**](BarcodeReaderApi.md#barcodeReaderBarcodeReaderGet) | **GET** /api/v1/barcodereader/read | Read barcodes from PDF document or PNG, JPEG, TIFF, BMP image
[**barcodeReaderBarcodeReaderPost**](BarcodeReaderApi.md#barcodeReaderBarcodeReaderPost) | **POST** /api/v1/barcodereader/read | Read barcodes from PDF document or PNG, JPEG, TIFF, BMP image


# **barcodeReaderBarcodeReaderGet**
> string barcodeReaderBarcodeReaderGet($apikey, $propertiesStartPageIndex, $propertiesEndPageIndex, $propertiesCustomAreaX, $propertiesCustomAreaY, $propertiesCustomAreaWidth, $propertiesCustomAreaHeight, $propertiesCustomAreaLeft, $propertiesCustomAreaTop, $propertiesCustomAreaWidth2, $propertiesCustomAreaHeight2, $propertiesScanArea, $propertiesBarcodeTypesToFindEan8, $propertiesBarcodeTypesToFindGtin8, $propertiesBarcodeTypesToFindEan13, $propertiesBarcodeTypesToFindGtin13, $propertiesBarcodeTypesToFindUpce, $propertiesBarcodeTypesToFindUpca, $propertiesBarcodeTypesToFindGtin12, $propertiesBarcodeTypesToFindInterleaved2of5, $propertiesBarcodeTypesToFindCirculari2of5, $propertiesBarcodeTypesToFindItf14, $propertiesBarcodeTypesToFindGtin14, $propertiesBarcodeTypesToFindCode39, $propertiesBarcodeTypesToFindCode39Extended, $propertiesBarcodeTypesToFindCode39Mod43, $propertiesBarcodeTypesToFindCode39Mod43Extended, $propertiesBarcodeTypesToFindPzn, $propertiesBarcodeTypesToFindUpu, $propertiesBarcodeTypesToFindCode128, $propertiesBarcodeTypesToFindEan2, $propertiesBarcodeTypesToFindEan5, $propertiesBarcodeTypesToFindGs1, $propertiesBarcodeTypesToFindCodabar, $propertiesBarcodeTypesToFindTrioptic, $propertiesBarcodeTypesToFindPatchCode, $propertiesBarcodeTypesToFindGs1DataBarOmnidirectional, $propertiesBarcodeTypesToFindGs1DataBarExpanded, $propertiesBarcodeTypesToFindGs1DataBarLimited, $propertiesBarcodeTypesToFindGs1DataBarStacked, $propertiesBarcodeTypesToFindGs1DataBarExpandedStacked, $propertiesBarcodeTypesToFindPdf417, $propertiesBarcodeTypesToFindDataMatrix, $propertiesBarcodeTypesToFindQrCode, $propertiesBarcodeTypesToFindAztec, $propertiesBarcodeTypesToFindMaxiCode, $propertiesBarcodeTypesToFindMicr, $propertiesBarcodeTypesToFindIntelligentMail, $propertiesBarcodeTypesToFindRoyalMail, $propertiesBarcodeTypesToFindRoyalMailKIX, $propertiesBarcodeTypesToFindAustralianPostCode, $propertiesBarcodeTypesToFindCodablockF, $propertiesBarcodeTypesToFindCode16K, $propertiesBarcodeTypesToFindPostNet, $propertiesBarcodeTypesToFindMicroPDF, $propertiesBarcodeTypesToFindCode93, $propertiesBarcodeTypesToFindMsi, $propertiesBarcodeTypesToFindPharmacode, $propertiesBarcodeTypesToFindSegment, $propertiesBarcodeTypesToFindCircle, $propertiesBarcodeTypesToFindOval, $propertiesBarcodeTypesToFindCheckbox, $propertiesBarcodeTypesToFindHorizontalLine, $propertiesBarcodeTypesToFindVerticalLine, $propertiesBarcodeTypesToFindUnderlinedField, $propertiesBarcodeTypesToFindAll1D, $propertiesBarcodeTypesToFindAll2D, $propertiesBarcodeTypesToFindAllOMRElements, $propertiesBarcodeTypesToFindAll, $propertiesOrientation, $propertiesSearchNegative, $propertiesRequireQuietZones, $propertiesMaxNumberOfBarcodesPerPage, $propertiesDecodingTimeOut, $propertiesLastDecodingTimeOutExceeded, $propertiesMaxNumberOfBarcodesPerDocument, $propertiesAllowOrphanedSupplementals, $propertiesMinimalDataLength, $propertiesMediumTrustLevelCompatible, $propertiesOptimizedProcessingOfLargeImages, $propertiesOptimizedProcessingOfLargeImagesSizeLimit, $propertiesRemoveNoize, $propertiesNoiseRemovalFilterSize, $propertiesNoiseRemovalFilterType, $propertiesColorConversionMode, $propertiesContrast, $propertiesTextEncoding, $propertiesTextEncodingCodePage, $propertiesTextEncodingUseUTF8, $propertiesPdfReadingMode, $propertiesPdfRenderingResolution, $propertiesPdfRenderText, $outputType, $input, $inputType)

Read barcodes from PDF document or PNG, JPEG, TIFF, BMP image

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\BarcodeReaderApi();
$apikey = "apikey_example"; // string | User's ApiKey
$propertiesStartPageIndex = 56; // int | Index of a page (zero-based) from which searching of BarCodes will be started (for PDF files).\r\n            Default value: all pages
$propertiesEndPageIndex = 56; // int | Index of a page (zero-based) on which searching of BarCodes will be finished (for PDF files).\r\n            Default value: all pages
$propertiesCustomAreaX = 56; // int | 
$propertiesCustomAreaY = 56; // int | 
$propertiesCustomAreaWidth = 56; // int | 
$propertiesCustomAreaHeight = 56; // int | 
$propertiesCustomAreaLeft = 56; // int | Default value: 0
$propertiesCustomAreaTop = 56; // int | Default value: 0
$propertiesCustomAreaWidth2 = 56; // int | Default value: 0
$propertiesCustomAreaHeight2 = 56; // int | Default value: 0
$propertiesScanArea = "propertiesScanArea_example"; // string | Default value: WholePage
$propertiesBarcodeTypesToFindEan8 = true; // bool | 
$propertiesBarcodeTypesToFindGtin8 = true; // bool | 
$propertiesBarcodeTypesToFindEan13 = true; // bool | 
$propertiesBarcodeTypesToFindGtin13 = true; // bool | 
$propertiesBarcodeTypesToFindUpce = true; // bool | 
$propertiesBarcodeTypesToFindUpca = true; // bool | 
$propertiesBarcodeTypesToFindGtin12 = true; // bool | 
$propertiesBarcodeTypesToFindInterleaved2of5 = true; // bool | 
$propertiesBarcodeTypesToFindCirculari2of5 = true; // bool | 
$propertiesBarcodeTypesToFindItf14 = true; // bool | 
$propertiesBarcodeTypesToFindGtin14 = true; // bool | 
$propertiesBarcodeTypesToFindCode39 = true; // bool | 
$propertiesBarcodeTypesToFindCode39Extended = true; // bool | 
$propertiesBarcodeTypesToFindCode39Mod43 = true; // bool | 
$propertiesBarcodeTypesToFindCode39Mod43Extended = true; // bool | 
$propertiesBarcodeTypesToFindPzn = true; // bool | 
$propertiesBarcodeTypesToFindUpu = true; // bool | 
$propertiesBarcodeTypesToFindCode128 = true; // bool | 
$propertiesBarcodeTypesToFindEan2 = true; // bool | 
$propertiesBarcodeTypesToFindEan5 = true; // bool | 
$propertiesBarcodeTypesToFindGs1 = true; // bool | 
$propertiesBarcodeTypesToFindCodabar = true; // bool | 
$propertiesBarcodeTypesToFindTrioptic = true; // bool | 
$propertiesBarcodeTypesToFindPatchCode = true; // bool | 
$propertiesBarcodeTypesToFindGs1DataBarOmnidirectional = true; // bool | 
$propertiesBarcodeTypesToFindGs1DataBarExpanded = true; // bool | 
$propertiesBarcodeTypesToFindGs1DataBarLimited = true; // bool | 
$propertiesBarcodeTypesToFindGs1DataBarStacked = true; // bool | 
$propertiesBarcodeTypesToFindGs1DataBarExpandedStacked = true; // bool | 
$propertiesBarcodeTypesToFindPdf417 = true; // bool | 
$propertiesBarcodeTypesToFindDataMatrix = true; // bool | 
$propertiesBarcodeTypesToFindQrCode = true; // bool | 
$propertiesBarcodeTypesToFindAztec = true; // bool | 
$propertiesBarcodeTypesToFindMaxiCode = true; // bool | 
$propertiesBarcodeTypesToFindMicr = true; // bool | 
$propertiesBarcodeTypesToFindIntelligentMail = true; // bool | 
$propertiesBarcodeTypesToFindRoyalMail = true; // bool | 
$propertiesBarcodeTypesToFindRoyalMailKIX = true; // bool | 
$propertiesBarcodeTypesToFindAustralianPostCode = true; // bool | 
$propertiesBarcodeTypesToFindCodablockF = true; // bool | 
$propertiesBarcodeTypesToFindCode16K = true; // bool | 
$propertiesBarcodeTypesToFindPostNet = true; // bool | 
$propertiesBarcodeTypesToFindMicroPDF = true; // bool | 
$propertiesBarcodeTypesToFindCode93 = true; // bool | 
$propertiesBarcodeTypesToFindMsi = true; // bool | 
$propertiesBarcodeTypesToFindPharmacode = true; // bool | 
$propertiesBarcodeTypesToFindSegment = true; // bool | 
$propertiesBarcodeTypesToFindCircle = true; // bool | 
$propertiesBarcodeTypesToFindOval = true; // bool | 
$propertiesBarcodeTypesToFindCheckbox = true; // bool | 
$propertiesBarcodeTypesToFindHorizontalLine = true; // bool | 
$propertiesBarcodeTypesToFindVerticalLine = true; // bool | 
$propertiesBarcodeTypesToFindUnderlinedField = true; // bool | 
$propertiesBarcodeTypesToFindAll1D = true; // bool | 
$propertiesBarcodeTypesToFindAll2D = true; // bool | 
$propertiesBarcodeTypesToFindAllOMRElements = true; // bool | 
$propertiesBarcodeTypesToFindAll = true; // bool | 
$propertiesOrientation = "propertiesOrientation_example"; // string | Default value: Default
$propertiesSearchNegative = true; // bool | Default value: False
$propertiesRequireQuietZones = true; // bool | Default value: True
$propertiesMaxNumberOfBarcodesPerPage = 56; // int | Default value: 0
$propertiesDecodingTimeOut = 56; // int | Default value: 10000 (10 seconds)
$propertiesLastDecodingTimeOutExceeded = true; // bool | Default value: False
$propertiesMaxNumberOfBarcodesPerDocument = 56; // int | Default value: 0
$propertiesAllowOrphanedSupplementals = true; // bool | Default value: False
$propertiesMinimalDataLength = 56; // int | Default value: 0
$propertiesMediumTrustLevelCompatible = true; // bool | Default value: False
$propertiesOptimizedProcessingOfLargeImages = true; // bool | Default value: False
$propertiesOptimizedProcessingOfLargeImagesSizeLimit = 56; // int | Default value: 1600
$propertiesRemoveNoize = true; // bool | Default value: False
$propertiesNoiseRemovalFilterSize = 56; // int | Default value: 2
$propertiesNoiseRemovalFilterType = "propertiesNoiseRemovalFilterType_example"; // string | Default value: Blur
$propertiesColorConversionMode = "propertiesColorConversionMode_example"; // string | Default value: ImageBlocks
$propertiesContrast = 56; // int | Default value: 0
$propertiesTextEncoding = "propertiesTextEncoding_example"; // string | Default value: Default
$propertiesTextEncodingCodePage = 56; // int | Default value: 28591
$propertiesTextEncodingUseUTF8 = true; // bool | Default value: False
$propertiesPdfReadingMode = "propertiesPdfReadingMode_example"; // string | Default value: RenderPDF
$propertiesPdfRenderingResolution = 56; // int | Default value: 300
$propertiesPdfRenderText = true; // bool | Default value: True
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data

try { 
    $result = $api_instance->barcodeReaderBarcodeReaderGet($apikey, $propertiesStartPageIndex, $propertiesEndPageIndex, $propertiesCustomAreaX, $propertiesCustomAreaY, $propertiesCustomAreaWidth, $propertiesCustomAreaHeight, $propertiesCustomAreaLeft, $propertiesCustomAreaTop, $propertiesCustomAreaWidth2, $propertiesCustomAreaHeight2, $propertiesScanArea, $propertiesBarcodeTypesToFindEan8, $propertiesBarcodeTypesToFindGtin8, $propertiesBarcodeTypesToFindEan13, $propertiesBarcodeTypesToFindGtin13, $propertiesBarcodeTypesToFindUpce, $propertiesBarcodeTypesToFindUpca, $propertiesBarcodeTypesToFindGtin12, $propertiesBarcodeTypesToFindInterleaved2of5, $propertiesBarcodeTypesToFindCirculari2of5, $propertiesBarcodeTypesToFindItf14, $propertiesBarcodeTypesToFindGtin14, $propertiesBarcodeTypesToFindCode39, $propertiesBarcodeTypesToFindCode39Extended, $propertiesBarcodeTypesToFindCode39Mod43, $propertiesBarcodeTypesToFindCode39Mod43Extended, $propertiesBarcodeTypesToFindPzn, $propertiesBarcodeTypesToFindUpu, $propertiesBarcodeTypesToFindCode128, $propertiesBarcodeTypesToFindEan2, $propertiesBarcodeTypesToFindEan5, $propertiesBarcodeTypesToFindGs1, $propertiesBarcodeTypesToFindCodabar, $propertiesBarcodeTypesToFindTrioptic, $propertiesBarcodeTypesToFindPatchCode, $propertiesBarcodeTypesToFindGs1DataBarOmnidirectional, $propertiesBarcodeTypesToFindGs1DataBarExpanded, $propertiesBarcodeTypesToFindGs1DataBarLimited, $propertiesBarcodeTypesToFindGs1DataBarStacked, $propertiesBarcodeTypesToFindGs1DataBarExpandedStacked, $propertiesBarcodeTypesToFindPdf417, $propertiesBarcodeTypesToFindDataMatrix, $propertiesBarcodeTypesToFindQrCode, $propertiesBarcodeTypesToFindAztec, $propertiesBarcodeTypesToFindMaxiCode, $propertiesBarcodeTypesToFindMicr, $propertiesBarcodeTypesToFindIntelligentMail, $propertiesBarcodeTypesToFindRoyalMail, $propertiesBarcodeTypesToFindRoyalMailKIX, $propertiesBarcodeTypesToFindAustralianPostCode, $propertiesBarcodeTypesToFindCodablockF, $propertiesBarcodeTypesToFindCode16K, $propertiesBarcodeTypesToFindPostNet, $propertiesBarcodeTypesToFindMicroPDF, $propertiesBarcodeTypesToFindCode93, $propertiesBarcodeTypesToFindMsi, $propertiesBarcodeTypesToFindPharmacode, $propertiesBarcodeTypesToFindSegment, $propertiesBarcodeTypesToFindCircle, $propertiesBarcodeTypesToFindOval, $propertiesBarcodeTypesToFindCheckbox, $propertiesBarcodeTypesToFindHorizontalLine, $propertiesBarcodeTypesToFindVerticalLine, $propertiesBarcodeTypesToFindUnderlinedField, $propertiesBarcodeTypesToFindAll1D, $propertiesBarcodeTypesToFindAll2D, $propertiesBarcodeTypesToFindAllOMRElements, $propertiesBarcodeTypesToFindAll, $propertiesOrientation, $propertiesSearchNegative, $propertiesRequireQuietZones, $propertiesMaxNumberOfBarcodesPerPage, $propertiesDecodingTimeOut, $propertiesLastDecodingTimeOutExceeded, $propertiesMaxNumberOfBarcodesPerDocument, $propertiesAllowOrphanedSupplementals, $propertiesMinimalDataLength, $propertiesMediumTrustLevelCompatible, $propertiesOptimizedProcessingOfLargeImages, $propertiesOptimizedProcessingOfLargeImagesSizeLimit, $propertiesRemoveNoize, $propertiesNoiseRemovalFilterSize, $propertiesNoiseRemovalFilterType, $propertiesColorConversionMode, $propertiesContrast, $propertiesTextEncoding, $propertiesTextEncodingCodePage, $propertiesTextEncodingUseUTF8, $propertiesPdfReadingMode, $propertiesPdfRenderingResolution, $propertiesPdfRenderText, $outputType, $input, $inputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BarcodeReaderApi->barcodeReaderBarcodeReaderGet: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **propertiesStartPageIndex** | **int**| Index of a page (zero-based) from which searching of BarCodes will be started (for PDF files).\r\n            Default value: all pages | [optional] 
 **propertiesEndPageIndex** | **int**| Index of a page (zero-based) on which searching of BarCodes will be finished (for PDF files).\r\n            Default value: all pages | [optional] 
 **propertiesCustomAreaX** | **int**|  | [optional] 
 **propertiesCustomAreaY** | **int**|  | [optional] 
 **propertiesCustomAreaWidth** | **int**|  | [optional] 
 **propertiesCustomAreaHeight** | **int**|  | [optional] 
 **propertiesCustomAreaLeft** | **int**| Default value: 0 | [optional] 
 **propertiesCustomAreaTop** | **int**| Default value: 0 | [optional] 
 **propertiesCustomAreaWidth2** | **int**| Default value: 0 | [optional] 
 **propertiesCustomAreaHeight2** | **int**| Default value: 0 | [optional] 
 **propertiesScanArea** | **string**| Default value: WholePage | [optional] 
 **propertiesBarcodeTypesToFindEan8** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindGtin8** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindEan13** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindGtin13** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindUpce** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindUpca** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindGtin12** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindInterleaved2of5** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindCirculari2of5** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindItf14** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindGtin14** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindCode39** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindCode39Extended** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindCode39Mod43** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindCode39Mod43Extended** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindPzn** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindUpu** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindCode128** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindEan2** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindEan5** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindGs1** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindCodabar** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindTrioptic** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindPatchCode** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindGs1DataBarOmnidirectional** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindGs1DataBarExpanded** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindGs1DataBarLimited** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindGs1DataBarStacked** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindGs1DataBarExpandedStacked** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindPdf417** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindDataMatrix** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindQrCode** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindAztec** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindMaxiCode** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindMicr** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindIntelligentMail** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindRoyalMail** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindRoyalMailKIX** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindAustralianPostCode** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindCodablockF** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindCode16K** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindPostNet** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindMicroPDF** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindCode93** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindMsi** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindPharmacode** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindSegment** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindCircle** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindOval** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindCheckbox** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindHorizontalLine** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindVerticalLine** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindUnderlinedField** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindAll1D** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindAll2D** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindAllOMRElements** | **bool**|  | [optional] 
 **propertiesBarcodeTypesToFindAll** | **bool**|  | [optional] 
 **propertiesOrientation** | **string**| Default value: Default | [optional] 
 **propertiesSearchNegative** | **bool**| Default value: False | [optional] 
 **propertiesRequireQuietZones** | **bool**| Default value: True | [optional] 
 **propertiesMaxNumberOfBarcodesPerPage** | **int**| Default value: 0 | [optional] 
 **propertiesDecodingTimeOut** | **int**| Default value: 10000 (10 seconds) | [optional] 
 **propertiesLastDecodingTimeOutExceeded** | **bool**| Default value: False | [optional] 
 **propertiesMaxNumberOfBarcodesPerDocument** | **int**| Default value: 0 | [optional] 
 **propertiesAllowOrphanedSupplementals** | **bool**| Default value: False | [optional] 
 **propertiesMinimalDataLength** | **int**| Default value: 0 | [optional] 
 **propertiesMediumTrustLevelCompatible** | **bool**| Default value: False | [optional] 
 **propertiesOptimizedProcessingOfLargeImages** | **bool**| Default value: False | [optional] 
 **propertiesOptimizedProcessingOfLargeImagesSizeLimit** | **int**| Default value: 1600 | [optional] 
 **propertiesRemoveNoize** | **bool**| Default value: False | [optional] 
 **propertiesNoiseRemovalFilterSize** | **int**| Default value: 2 | [optional] 
 **propertiesNoiseRemovalFilterType** | **string**| Default value: Blur | [optional] 
 **propertiesColorConversionMode** | **string**| Default value: ImageBlocks | [optional] 
 **propertiesContrast** | **int**| Default value: 0 | [optional] 
 **propertiesTextEncoding** | **string**| Default value: Default | [optional] 
 **propertiesTextEncodingCodePage** | **int**| Default value: 28591 | [optional] 
 **propertiesTextEncodingUseUTF8** | **bool**| Default value: False | [optional] 
 **propertiesPdfReadingMode** | **string**| Default value: RenderPDF | [optional] 
 **propertiesPdfRenderingResolution** | **int**| Default value: 300 | [optional] 
 **propertiesPdfRenderText** | **bool**| Default value: True | [optional] 
 **outputType** | **string**| Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! | [optional] 
 **input** | **string**| Input Data | [optional] 
 **inputType** | **string**| Type of Input Data | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **barcodeReaderBarcodeReaderPost**
> string barcodeReaderBarcodeReaderPost($data, $apikey)

Read barcodes from PDF document or PNG, JPEG, TIFF, BMP image

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\BarcodeReaderApi();
$data = new \Bytescout\Client\Model\BarcodeReaderRequestVm(); // \Bytescout\Client\Model\BarcodeReaderRequestVm | 
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->barcodeReaderBarcodeReaderPost($data, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BarcodeReaderApi->barcodeReaderBarcodeReaderPost: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**\Bytescout\Client\Model\BarcodeReaderRequestVm**](\Bytescout\Client\Model\BarcodeReaderRequestVm.md)|  | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

