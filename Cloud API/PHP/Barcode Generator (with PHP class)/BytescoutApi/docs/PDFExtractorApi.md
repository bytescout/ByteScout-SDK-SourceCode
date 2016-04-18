# Bytescout\Client\PDFExtractorApi

All URIs are relative to *https://bytescout.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**pDFExtractorCSVExtractorFile**](PDFExtractorApi.md#pDFExtractorCSVExtractorFile) | **POST** /api/v1/pdfextractor/csvextractor/extract | Convert PDF document to CSV
[**pDFExtractorCSVExtractorLink**](PDFExtractorApi.md#pDFExtractorCSVExtractorLink) | **GET** /api/v1/pdfextractor/csvextractor/extract | Convert PDF document to CSV
[**pDFExtractorDocumentMergerGet**](PDFExtractorApi.md#pDFExtractorDocumentMergerGet) | **GET** /api/v1/pdfextractor/documentmerger | Merge PDF documents
[**pDFExtractorDocumentMergerPost**](PDFExtractorApi.md#pDFExtractorDocumentMergerPost) | **POST** /api/v1/pdfextractor/documentmerger | Merge PDF documents
[**pDFExtractorDocumentSplitterGet**](PDFExtractorApi.md#pDFExtractorDocumentSplitterGet) | **GET** /api/v1/pdfextractor/documentsplitter | Split PDF document
[**pDFExtractorDocumentSplitterPost**](PDFExtractorApi.md#pDFExtractorDocumentSplitterPost) | **POST** /api/v1/pdfextractor/documentsplitter | Split PDF document
[**pDFExtractorInfoExtractorFile**](PDFExtractorApi.md#pDFExtractorInfoExtractorFile) | **POST** /api/v1/pdfextractor/infoextractor/extract | Get PDF document information
[**pDFExtractorInfoExtractorLink**](PDFExtractorApi.md#pDFExtractorInfoExtractorLink) | **GET** /api/v1/pdfextractor/infoextractor/extract | Get PDF document information
[**pDFExtractorTextExtractorFile**](PDFExtractorApi.md#pDFExtractorTextExtractorFile) | **POST** /api/v1/pdfextractor/textextractor/extract | Convert PDF document to plain text (TXT)
[**pDFExtractorTextExtractorLink**](PDFExtractorApi.md#pDFExtractorTextExtractorLink) | **GET** /api/v1/pdfextractor/textextractor/extract | Convert PDF document to plain text (TXT)
[**pDFExtractorXMLExtractorFile**](PDFExtractorApi.md#pDFExtractorXMLExtractorFile) | **POST** /api/v1/pdfextractor/xmlextractor/extract | Convert PDF document to XML
[**pDFExtractorXMLExtractorLink**](PDFExtractorApi.md#pDFExtractorXMLExtractorLink) | **GET** /api/v1/pdfextractor/xmlextractor/extract | Convert PDF document to CSV


# **pDFExtractorCSVExtractorFile**
> string pDFExtractorCSVExtractorFile($data, $apikey)

Convert PDF document to CSV

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFExtractorApi();
$data = new \Bytescout\Client\Model\CSVExtractorRequestVm(); // \Bytescout\Client\Model\CSVExtractorRequestVm | 
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->pDFExtractorCSVExtractorFile($data, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFExtractorApi->pDFExtractorCSVExtractorFile: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**\Bytescout\Client\Model\CSVExtractorRequestVm**](\Bytescout\Client\Model\CSVExtractorRequestVm.md)|  | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pDFExtractorCSVExtractorLink**
> string pDFExtractorCSVExtractorLink($apikey, $propertiesStartPageIndex, $propertiesEndPageIndex, $propertiesCsvSeparatorSymbol, $propertiesCsvQuotaionSymbol, $propertiesXCoordinateToleranceFactor, $propertiesYCoordinateToleranceFactor, $propertiesTableXMinIntersectionRequiredInPercents, $propertiesTableYMinIntersectionRequiredInPercents, $propertiesRtlTextAutoDetectionEnabled, $propertiesExtractInvisibleText, $propertiesExtractShadowLikeText, $propertiesUnwrap, $propertiesRemoveHyphenation, $propertiesAutoAlignColumnsToHeader, $propertiesPreserveFormattingOnTextExtraction, $propertiesDetectLinesInsteadOfParagraphs, $propertiesTrimSpaces, $propertiesExtractColumnByColumn, $propertiesDetectNewColumnBySpacesRatio, $propertiesOcrMode, $propertiesLineGroupingMode, $propertiesColumnDetectionMode, $propertiesOcrCacheMode, $propertiesOcrLanguage, $propertiesOcrResolution, $propertiesTextEncodingCodePage, $propertiesConsiderFontNames, $propertiesConsiderFontSizes, $propertiesConsiderFontColors, $propertiesConsiderVerticalBorders, $propertiesPassword, $propertiesCheckPermissions, $propertiesExtractionAreaUsageMode, $outputType, $input, $inputType)

Convert PDF document to CSV

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFExtractorApi();
$apikey = "apikey_example"; // string | User's ApiKey
$propertiesStartPageIndex = 56; // int | Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages
$propertiesEndPageIndex = 56; // int | Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages
$propertiesCsvSeparatorSymbol = "propertiesCsvSeparatorSymbol_example"; // string | Default value: ,
$propertiesCsvQuotaionSymbol = "propertiesCsvQuotaionSymbol_example"; // string | Default value: \"
$propertiesXCoordinateToleranceFactor = 1.2; // double | Default value: 20
$propertiesYCoordinateToleranceFactor = 1.2; // double | Default value: 30
$propertiesTableXMinIntersectionRequiredInPercents = 56; // int | Default value: 49
$propertiesTableYMinIntersectionRequiredInPercents = 56; // int | Default value: 50
$propertiesRtlTextAutoDetectionEnabled = true; // bool | Default value: False
$propertiesExtractInvisibleText = true; // bool | Default value: True
$propertiesExtractShadowLikeText = true; // bool | Default value: True
$propertiesUnwrap = true; // bool | Default value: False
$propertiesRemoveHyphenation = true; // bool | Default value: True
$propertiesAutoAlignColumnsToHeader = true; // bool | Default value: True
$propertiesPreserveFormattingOnTextExtraction = true; // bool | Value indicating whether to preserve the text formatting on the extraction.\r\n            Default value: True
$propertiesDetectLinesInsteadOfParagraphs = true; // bool | Default value: True
$propertiesTrimSpaces = true; // bool | Default value: True
$propertiesExtractColumnByColumn = true; // bool | Default value: False
$propertiesDetectNewColumnBySpacesRatio = 3.4; // float | Space ratio between words.\r\n            Default value: 1
$propertiesOcrMode = "propertiesOcrMode_example"; // string | Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off
$propertiesLineGroupingMode = "propertiesLineGroupingMode_example"; // string | Default value: None
$propertiesColumnDetectionMode = "propertiesColumnDetectionMode_example"; // string | Default value: ContentGroupsAndBorders
$propertiesOcrCacheMode = "propertiesOcrCacheMode_example"; // string | Default value: Off
$propertiesOcrLanguage = "propertiesOcrLanguage_example"; // string | Default value: eng
$propertiesOcrResolution = 3.4; // float | Default value: 300
$propertiesTextEncodingCodePage = 56; // int | Default value: 1252
$propertiesConsiderFontNames = true; // bool | Default value: False
$propertiesConsiderFontSizes = true; // bool | Default value: False
$propertiesConsiderFontColors = true; // bool | Default value: False
$propertiesConsiderVerticalBorders = true; // bool | Default value: True
$propertiesPassword = "propertiesPassword_example"; // string | Default value:
$propertiesCheckPermissions = true; // bool | Default value: True
$propertiesExtractionAreaUsageMode = "propertiesExtractionAreaUsageMode_example"; // string | Default value: UseAllIntersectingObjects
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data

try { 
    $result = $api_instance->pDFExtractorCSVExtractorLink($apikey, $propertiesStartPageIndex, $propertiesEndPageIndex, $propertiesCsvSeparatorSymbol, $propertiesCsvQuotaionSymbol, $propertiesXCoordinateToleranceFactor, $propertiesYCoordinateToleranceFactor, $propertiesTableXMinIntersectionRequiredInPercents, $propertiesTableYMinIntersectionRequiredInPercents, $propertiesRtlTextAutoDetectionEnabled, $propertiesExtractInvisibleText, $propertiesExtractShadowLikeText, $propertiesUnwrap, $propertiesRemoveHyphenation, $propertiesAutoAlignColumnsToHeader, $propertiesPreserveFormattingOnTextExtraction, $propertiesDetectLinesInsteadOfParagraphs, $propertiesTrimSpaces, $propertiesExtractColumnByColumn, $propertiesDetectNewColumnBySpacesRatio, $propertiesOcrMode, $propertiesLineGroupingMode, $propertiesColumnDetectionMode, $propertiesOcrCacheMode, $propertiesOcrLanguage, $propertiesOcrResolution, $propertiesTextEncodingCodePage, $propertiesConsiderFontNames, $propertiesConsiderFontSizes, $propertiesConsiderFontColors, $propertiesConsiderVerticalBorders, $propertiesPassword, $propertiesCheckPermissions, $propertiesExtractionAreaUsageMode, $outputType, $input, $inputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFExtractorApi->pDFExtractorCSVExtractorLink: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **propertiesStartPageIndex** | **int**| Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages | [optional] 
 **propertiesEndPageIndex** | **int**| Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages | [optional] 
 **propertiesCsvSeparatorSymbol** | **string**| Default value: , | [optional] 
 **propertiesCsvQuotaionSymbol** | **string**| Default value: \&quot; | [optional] 
 **propertiesXCoordinateToleranceFactor** | **double**| Default value: 20 | [optional] 
 **propertiesYCoordinateToleranceFactor** | **double**| Default value: 30 | [optional] 
 **propertiesTableXMinIntersectionRequiredInPercents** | **int**| Default value: 49 | [optional] 
 **propertiesTableYMinIntersectionRequiredInPercents** | **int**| Default value: 50 | [optional] 
 **propertiesRtlTextAutoDetectionEnabled** | **bool**| Default value: False | [optional] 
 **propertiesExtractInvisibleText** | **bool**| Default value: True | [optional] 
 **propertiesExtractShadowLikeText** | **bool**| Default value: True | [optional] 
 **propertiesUnwrap** | **bool**| Default value: False | [optional] 
 **propertiesRemoveHyphenation** | **bool**| Default value: True | [optional] 
 **propertiesAutoAlignColumnsToHeader** | **bool**| Default value: True | [optional] 
 **propertiesPreserveFormattingOnTextExtraction** | **bool**| Value indicating whether to preserve the text formatting on the extraction.\r\n            Default value: True | [optional] 
 **propertiesDetectLinesInsteadOfParagraphs** | **bool**| Default value: True | [optional] 
 **propertiesTrimSpaces** | **bool**| Default value: True | [optional] 
 **propertiesExtractColumnByColumn** | **bool**| Default value: False | [optional] 
 **propertiesDetectNewColumnBySpacesRatio** | **float**| Space ratio between words.\r\n            Default value: 1 | [optional] 
 **propertiesOcrMode** | **string**| Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off | [optional] 
 **propertiesLineGroupingMode** | **string**| Default value: None | [optional] 
 **propertiesColumnDetectionMode** | **string**| Default value: ContentGroupsAndBorders | [optional] 
 **propertiesOcrCacheMode** | **string**| Default value: Off | [optional] 
 **propertiesOcrLanguage** | **string**| Default value: eng | [optional] 
 **propertiesOcrResolution** | **float**| Default value: 300 | [optional] 
 **propertiesTextEncodingCodePage** | **int**| Default value: 1252 | [optional] 
 **propertiesConsiderFontNames** | **bool**| Default value: False | [optional] 
 **propertiesConsiderFontSizes** | **bool**| Default value: False | [optional] 
 **propertiesConsiderFontColors** | **bool**| Default value: False | [optional] 
 **propertiesConsiderVerticalBorders** | **bool**| Default value: True | [optional] 
 **propertiesPassword** | **string**| Default value: | [optional] 
 **propertiesCheckPermissions** | **bool**| Default value: True | [optional] 
 **propertiesExtractionAreaUsageMode** | **string**| Default value: UseAllIntersectingObjects | [optional] 
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

# **pDFExtractorDocumentMergerGet**
> string pDFExtractorDocumentMergerGet($apikey, $propertiesCheckPermissions, $outputType, $inputFileIds)

Merge PDF documents

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFExtractorApi();
$apikey = "apikey_example"; // string | User's ApiKey
$propertiesCheckPermissions = true; // bool | Default value: True
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$inputFileIds = array("inputFileIds_example"); // string[] | 

try { 
    $result = $api_instance->pDFExtractorDocumentMergerGet($apikey, $propertiesCheckPermissions, $outputType, $inputFileIds);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFExtractorApi->pDFExtractorDocumentMergerGet: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **propertiesCheckPermissions** | **bool**| Default value: True | [optional] 
 **outputType** | **string**| Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! | [optional] 
 **inputFileIds** | [**string[]**](string.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pDFExtractorDocumentMergerPost**
> string pDFExtractorDocumentMergerPost($data, $apikey)

Merge PDF documents

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFExtractorApi();
$data = new \Bytescout\Client\Model\DocumentMergerRequestVm(); // \Bytescout\Client\Model\DocumentMergerRequestVm | 
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->pDFExtractorDocumentMergerPost($data, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFExtractorApi->pDFExtractorDocumentMergerPost: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**\Bytescout\Client\Model\DocumentMergerRequestVm**](\Bytescout\Client\Model\DocumentMergerRequestVm.md)|  | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pDFExtractorDocumentSplitterGet**
> string pDFExtractorDocumentSplitterGet($apikey, $propertiesOptimizeSplittedDocuments, $propertiesCheckPermissions, $propertiesRanges, $outputType, $input, $inputType)

Split PDF document

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFExtractorApi();
$apikey = "apikey_example"; // string | User's ApiKey
$propertiesOptimizeSplittedDocuments = true; // bool | Default value: False
$propertiesCheckPermissions = true; // bool | Default value: True
$propertiesRanges = "propertiesRanges_example"; // string | Comma-separated list of page ranges in form \"1-4,5,7,8-15,16-\". Page numbers are 1-based. Ending \"-\" means \"to the last page\". (required)
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: FileId.\r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data

try { 
    $result = $api_instance->pDFExtractorDocumentSplitterGet($apikey, $propertiesOptimizeSplittedDocuments, $propertiesCheckPermissions, $propertiesRanges, $outputType, $input, $inputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFExtractorApi->pDFExtractorDocumentSplitterGet: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **propertiesOptimizeSplittedDocuments** | **bool**| Default value: False | [optional] 
 **propertiesCheckPermissions** | **bool**| Default value: True | [optional] 
 **propertiesRanges** | **string**| Comma-separated list of page ranges in form \&quot;1-4,5,7,8-15,16-\&quot;. Page numbers are 1-based. Ending \&quot;-\&quot; means \&quot;to the last page\&quot;. (required) | [optional] 
 **outputType** | **string**| Type in which you want to get result of extracting (optional). Default value: FileId.\r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! | [optional] 
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

# **pDFExtractorDocumentSplitterPost**
> string pDFExtractorDocumentSplitterPost($data, $apikey)

Split PDF document

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFExtractorApi();
$data = new \Bytescout\Client\Model\DocumentSplitterRequestVm(); // \Bytescout\Client\Model\DocumentSplitterRequestVm | 
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->pDFExtractorDocumentSplitterPost($data, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFExtractorApi->pDFExtractorDocumentSplitterPost: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**\Bytescout\Client\Model\DocumentSplitterRequestVm**](\Bytescout\Client\Model\DocumentSplitterRequestVm.md)|  | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pDFExtractorInfoExtractorFile**
> string pDFExtractorInfoExtractorFile($data, $apikey)

Get PDF document information

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFExtractorApi();
$data = new \Bytescout\Client\Model\InfoExtractorRequestVm(); // \Bytescout\Client\Model\InfoExtractorRequestVm | 
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->pDFExtractorInfoExtractorFile($data, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFExtractorApi->pDFExtractorInfoExtractorFile: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**\Bytescout\Client\Model\InfoExtractorRequestVm**](\Bytescout\Client\Model\InfoExtractorRequestVm.md)|  | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pDFExtractorInfoExtractorLink**
> string pDFExtractorInfoExtractorLink($apikey, $propertiesPassword, $propertiesCheckPermissions, $propertiesExtractionAreaUsageMode, $outputType, $input, $inputType)

Get PDF document information

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFExtractorApi();
$apikey = "apikey_example"; // string | User's ApiKey
$propertiesPassword = "propertiesPassword_example"; // string | 
$propertiesCheckPermissions = true; // bool | Default value: True
$propertiesExtractionAreaUsageMode = "propertiesExtractionAreaUsageMode_example"; // string | Default value: UseAllIntersectingObjects
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data

try { 
    $result = $api_instance->pDFExtractorInfoExtractorLink($apikey, $propertiesPassword, $propertiesCheckPermissions, $propertiesExtractionAreaUsageMode, $outputType, $input, $inputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFExtractorApi->pDFExtractorInfoExtractorLink: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **propertiesPassword** | **string**|  | [optional] 
 **propertiesCheckPermissions** | **bool**| Default value: True | [optional] 
 **propertiesExtractionAreaUsageMode** | **string**| Default value: UseAllIntersectingObjects | [optional] 
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

# **pDFExtractorTextExtractorFile**
> string pDFExtractorTextExtractorFile($data, $apikey)

Convert PDF document to plain text (TXT)

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFExtractorApi();
$data = new \Bytescout\Client\Model\TextExtractorRequestVm(); // \Bytescout\Client\Model\TextExtractorRequestVm | 
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->pDFExtractorTextExtractorFile($data, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFExtractorApi->pDFExtractorTextExtractorFile: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**\Bytescout\Client\Model\TextExtractorRequestVm**](\Bytescout\Client\Model\TextExtractorRequestVm.md)|  | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pDFExtractorTextExtractorLink**
> string pDFExtractorTextExtractorLink($apikey, $propertiesStartPageIndex, $propertiesEndPageIndex, $propertiesRegexSearch, $propertiesWordMatchingMode, $propertiesPageSeparator, $propertiesWordMatchingPunctuationMarks, $propertiesXCoordinateToleranceFactor, $propertiesYCoordinateToleranceFactor, $propertiesTableXMinIntersectionRequiredInPercents, $propertiesTableYMinIntersectionRequiredInPercents, $propertiesRtlTextAutoDetectionEnabled, $propertiesExtractInvisibleText, $propertiesExtractShadowLikeText, $propertiesUnwrap, $propertiesRemoveHyphenation, $propertiesAutoAlignColumnsToHeader, $propertiesPreserveFormattingOnTextExtraction, $propertiesDetectLinesInsteadOfParagraphs, $propertiesTrimSpaces, $propertiesExtractColumnByColumn, $propertiesDetectNewColumnBySpacesRatio, $propertiesOcrMode, $propertiesLineGroupingMode, $propertiesColumnDetectionMode, $propertiesOcrCacheMode, $propertiesOcrLanguage, $propertiesOcrResolution, $propertiesTextEncodingCodePage, $propertiesConsiderFontNames, $propertiesConsiderFontSizes, $propertiesConsiderFontColors, $propertiesConsiderVerticalBorders, $propertiesPassword, $propertiesCheckPermissions, $propertiesExtractionAreaUsageMode, $outputType, $input, $inputType)

Convert PDF document to plain text (TXT)

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFExtractorApi();
$apikey = "apikey_example"; // string | User's ApiKey
$propertiesStartPageIndex = 56; // int | Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages
$propertiesEndPageIndex = 56; // int | Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages
$propertiesRegexSearch = true; // bool | Default value: False
$propertiesWordMatchingMode = "propertiesWordMatchingMode_example"; // string | Default value: SmartMatch
$propertiesPageSeparator = "propertiesPageSeparator_example"; // string | 
$propertiesWordMatchingPunctuationMarks = "propertiesWordMatchingPunctuationMarks_example"; // string | Default value: .\"'\u201C\u201D
$propertiesXCoordinateToleranceFactor = 1.2; // double | Default value: 20
$propertiesYCoordinateToleranceFactor = 1.2; // double | Default value: 30
$propertiesTableXMinIntersectionRequiredInPercents = 56; // int | Default value: 49
$propertiesTableYMinIntersectionRequiredInPercents = 56; // int | Default value: 50
$propertiesRtlTextAutoDetectionEnabled = true; // bool | Default value: False
$propertiesExtractInvisibleText = true; // bool | Default value: True
$propertiesExtractShadowLikeText = true; // bool | Default value: True
$propertiesUnwrap = true; // bool | Default value: False
$propertiesRemoveHyphenation = true; // bool | Default value: True
$propertiesAutoAlignColumnsToHeader = true; // bool | Default value: True
$propertiesPreserveFormattingOnTextExtraction = true; // bool | Value indicating whether to preserve the text formatting on the extraction.\r\n            Default value: True
$propertiesDetectLinesInsteadOfParagraphs = true; // bool | Default value: True
$propertiesTrimSpaces = true; // bool | Default value: False
$propertiesExtractColumnByColumn = true; // bool | Default value: False
$propertiesDetectNewColumnBySpacesRatio = 3.4; // float | Space ratio between words.\r\n            Default value: 1.2
$propertiesOcrMode = "propertiesOcrMode_example"; // string | Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off
$propertiesLineGroupingMode = "propertiesLineGroupingMode_example"; // string | Default value: None
$propertiesColumnDetectionMode = "propertiesColumnDetectionMode_example"; // string | Default value: ContentGroupsAndBorders
$propertiesOcrCacheMode = "propertiesOcrCacheMode_example"; // string | Default value: Off
$propertiesOcrLanguage = "propertiesOcrLanguage_example"; // string | Default value: eng
$propertiesOcrResolution = 3.4; // float | Default value: 300
$propertiesTextEncodingCodePage = 56; // int | Default value: 1252
$propertiesConsiderFontNames = true; // bool | Default value: False
$propertiesConsiderFontSizes = true; // bool | Default value: False
$propertiesConsiderFontColors = true; // bool | Default value: False
$propertiesConsiderVerticalBorders = true; // bool | Default value: False
$propertiesPassword = "propertiesPassword_example"; // string | Default value:
$propertiesCheckPermissions = true; // bool | Default value: True
$propertiesExtractionAreaUsageMode = "propertiesExtractionAreaUsageMode_example"; // string | Default value: UseAllIntersectingObjects
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data

try { 
    $result = $api_instance->pDFExtractorTextExtractorLink($apikey, $propertiesStartPageIndex, $propertiesEndPageIndex, $propertiesRegexSearch, $propertiesWordMatchingMode, $propertiesPageSeparator, $propertiesWordMatchingPunctuationMarks, $propertiesXCoordinateToleranceFactor, $propertiesYCoordinateToleranceFactor, $propertiesTableXMinIntersectionRequiredInPercents, $propertiesTableYMinIntersectionRequiredInPercents, $propertiesRtlTextAutoDetectionEnabled, $propertiesExtractInvisibleText, $propertiesExtractShadowLikeText, $propertiesUnwrap, $propertiesRemoveHyphenation, $propertiesAutoAlignColumnsToHeader, $propertiesPreserveFormattingOnTextExtraction, $propertiesDetectLinesInsteadOfParagraphs, $propertiesTrimSpaces, $propertiesExtractColumnByColumn, $propertiesDetectNewColumnBySpacesRatio, $propertiesOcrMode, $propertiesLineGroupingMode, $propertiesColumnDetectionMode, $propertiesOcrCacheMode, $propertiesOcrLanguage, $propertiesOcrResolution, $propertiesTextEncodingCodePage, $propertiesConsiderFontNames, $propertiesConsiderFontSizes, $propertiesConsiderFontColors, $propertiesConsiderVerticalBorders, $propertiesPassword, $propertiesCheckPermissions, $propertiesExtractionAreaUsageMode, $outputType, $input, $inputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFExtractorApi->pDFExtractorTextExtractorLink: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **propertiesStartPageIndex** | **int**| Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages | [optional] 
 **propertiesEndPageIndex** | **int**| Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages | [optional] 
 **propertiesRegexSearch** | **bool**| Default value: False | [optional] 
 **propertiesWordMatchingMode** | **string**| Default value: SmartMatch | [optional] 
 **propertiesPageSeparator** | **string**|  | [optional] 
 **propertiesWordMatchingPunctuationMarks** | **string**| Default value: .\&quot;&#39;\u201C\u201D | [optional] 
 **propertiesXCoordinateToleranceFactor** | **double**| Default value: 20 | [optional] 
 **propertiesYCoordinateToleranceFactor** | **double**| Default value: 30 | [optional] 
 **propertiesTableXMinIntersectionRequiredInPercents** | **int**| Default value: 49 | [optional] 
 **propertiesTableYMinIntersectionRequiredInPercents** | **int**| Default value: 50 | [optional] 
 **propertiesRtlTextAutoDetectionEnabled** | **bool**| Default value: False | [optional] 
 **propertiesExtractInvisibleText** | **bool**| Default value: True | [optional] 
 **propertiesExtractShadowLikeText** | **bool**| Default value: True | [optional] 
 **propertiesUnwrap** | **bool**| Default value: False | [optional] 
 **propertiesRemoveHyphenation** | **bool**| Default value: True | [optional] 
 **propertiesAutoAlignColumnsToHeader** | **bool**| Default value: True | [optional] 
 **propertiesPreserveFormattingOnTextExtraction** | **bool**| Value indicating whether to preserve the text formatting on the extraction.\r\n            Default value: True | [optional] 
 **propertiesDetectLinesInsteadOfParagraphs** | **bool**| Default value: True | [optional] 
 **propertiesTrimSpaces** | **bool**| Default value: False | [optional] 
 **propertiesExtractColumnByColumn** | **bool**| Default value: False | [optional] 
 **propertiesDetectNewColumnBySpacesRatio** | **float**| Space ratio between words.\r\n            Default value: 1.2 | [optional] 
 **propertiesOcrMode** | **string**| Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off | [optional] 
 **propertiesLineGroupingMode** | **string**| Default value: None | [optional] 
 **propertiesColumnDetectionMode** | **string**| Default value: ContentGroupsAndBorders | [optional] 
 **propertiesOcrCacheMode** | **string**| Default value: Off | [optional] 
 **propertiesOcrLanguage** | **string**| Default value: eng | [optional] 
 **propertiesOcrResolution** | **float**| Default value: 300 | [optional] 
 **propertiesTextEncodingCodePage** | **int**| Default value: 1252 | [optional] 
 **propertiesConsiderFontNames** | **bool**| Default value: False | [optional] 
 **propertiesConsiderFontSizes** | **bool**| Default value: False | [optional] 
 **propertiesConsiderFontColors** | **bool**| Default value: False | [optional] 
 **propertiesConsiderVerticalBorders** | **bool**| Default value: False | [optional] 
 **propertiesPassword** | **string**| Default value: | [optional] 
 **propertiesCheckPermissions** | **bool**| Default value: True | [optional] 
 **propertiesExtractionAreaUsageMode** | **string**| Default value: UseAllIntersectingObjects | [optional] 
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

# **pDFExtractorXMLExtractorFile**
> string pDFExtractorXMLExtractorFile($data, $apikey)

Convert PDF document to XML

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFExtractorApi();
$data = new \Bytescout\Client\Model\XMLExtractorRequestVm(); // \Bytescout\Client\Model\XMLExtractorRequestVm | 
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->pDFExtractorXMLExtractorFile($data, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFExtractorApi->pDFExtractorXMLExtractorFile: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**\Bytescout\Client\Model\XMLExtractorRequestVm**](\Bytescout\Client\Model\XMLExtractorRequestVm.md)|  | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pDFExtractorXMLExtractorLink**
> string pDFExtractorXMLExtractorLink($apikey, $propertiesStartPageIndex, $propertiesEndPageIndex, $propertiesXCoordinateToleranceFactor, $propertiesYCoordinateToleranceFactor, $propertiesTableXMinIntersectionRequiredInPercents, $propertiesTableYMinIntersectionRequiredInPercents, $propertiesRtlTextAutoDetectionEnabled, $propertiesExtractInvisibleText, $propertiesExtractShadowLikeText, $propertiesUnwrap, $propertiesRemoveHyphenation, $propertiesAutoAlignColumnsToHeader, $propertiesPreserveFormattingOnTextExtraction, $propertiesDetectLinesInsteadOfParagraphs, $propertiesTrimSpaces, $propertiesExtractColumnByColumn, $propertiesDetectNewColumnBySpacesRatio, $propertiesOcrMode, $propertiesLineGroupingMode, $propertiesColumnDetectionMode, $propertiesOcrCacheMode, $propertiesOcrLanguage, $propertiesOcrResolution, $propertiesTextEncodingCodePage, $propertiesConsiderFontNames, $propertiesConsiderFontSizes, $propertiesConsiderFontColors, $propertiesConsiderVerticalBorders, $propertiesPassword, $propertiesCheckPermissions, $propertiesExtractionAreaUsageMode, $outputType, $input, $inputType)

Convert PDF document to CSV

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFExtractorApi();
$apikey = "apikey_example"; // string | User's ApiKey
$propertiesStartPageIndex = 56; // int | Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages
$propertiesEndPageIndex = 56; // int | Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages
$propertiesXCoordinateToleranceFactor = 1.2; // double | Default value: 20
$propertiesYCoordinateToleranceFactor = 1.2; // double | Default value: 30
$propertiesTableXMinIntersectionRequiredInPercents = 56; // int | Default value: 49
$propertiesTableYMinIntersectionRequiredInPercents = 56; // int | Default value: 50
$propertiesRtlTextAutoDetectionEnabled = true; // bool | Default value: False
$propertiesExtractInvisibleText = true; // bool | Default value: True
$propertiesExtractShadowLikeText = true; // bool | Default value: True
$propertiesUnwrap = true; // bool | Default value: False
$propertiesRemoveHyphenation = true; // bool | Default value: True
$propertiesAutoAlignColumnsToHeader = true; // bool | Default value: True
$propertiesPreserveFormattingOnTextExtraction = true; // bool | Value indicating whether to preserve the text formatting on the extraction.\r\n            Default value: True
$propertiesDetectLinesInsteadOfParagraphs = true; // bool | Default value: True
$propertiesTrimSpaces = true; // bool | Default value: True
$propertiesExtractColumnByColumn = true; // bool | Default value: False
$propertiesDetectNewColumnBySpacesRatio = 3.4; // float | Space ratio between words.\r\n            Default value: 1
$propertiesOcrMode = "propertiesOcrMode_example"; // string | Default value: Off
$propertiesLineGroupingMode = "propertiesLineGroupingMode_example"; // string | Default value: None
$propertiesColumnDetectionMode = "propertiesColumnDetectionMode_example"; // string | Default value: ContentGroupsAndBorders
$propertiesOcrCacheMode = "propertiesOcrCacheMode_example"; // string | Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off
$propertiesOcrLanguage = "propertiesOcrLanguage_example"; // string | Default value: eng
$propertiesOcrResolution = 3.4; // float | Default value: 300
$propertiesTextEncodingCodePage = 56; // int | Default value: 1252
$propertiesConsiderFontNames = true; // bool | Default value: False
$propertiesConsiderFontSizes = true; // bool | Default value: False
$propertiesConsiderFontColors = true; // bool | Default value: False
$propertiesConsiderVerticalBorders = true; // bool | Default value: True
$propertiesPassword = "propertiesPassword_example"; // string | Default value:
$propertiesCheckPermissions = true; // bool | Default value: True
$propertiesExtractionAreaUsageMode = "propertiesExtractionAreaUsageMode_example"; // string | Default value: UseAllIntersectingObjects
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data

try { 
    $result = $api_instance->pDFExtractorXMLExtractorLink($apikey, $propertiesStartPageIndex, $propertiesEndPageIndex, $propertiesXCoordinateToleranceFactor, $propertiesYCoordinateToleranceFactor, $propertiesTableXMinIntersectionRequiredInPercents, $propertiesTableYMinIntersectionRequiredInPercents, $propertiesRtlTextAutoDetectionEnabled, $propertiesExtractInvisibleText, $propertiesExtractShadowLikeText, $propertiesUnwrap, $propertiesRemoveHyphenation, $propertiesAutoAlignColumnsToHeader, $propertiesPreserveFormattingOnTextExtraction, $propertiesDetectLinesInsteadOfParagraphs, $propertiesTrimSpaces, $propertiesExtractColumnByColumn, $propertiesDetectNewColumnBySpacesRatio, $propertiesOcrMode, $propertiesLineGroupingMode, $propertiesColumnDetectionMode, $propertiesOcrCacheMode, $propertiesOcrLanguage, $propertiesOcrResolution, $propertiesTextEncodingCodePage, $propertiesConsiderFontNames, $propertiesConsiderFontSizes, $propertiesConsiderFontColors, $propertiesConsiderVerticalBorders, $propertiesPassword, $propertiesCheckPermissions, $propertiesExtractionAreaUsageMode, $outputType, $input, $inputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFExtractorApi->pDFExtractorXMLExtractorLink: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **propertiesStartPageIndex** | **int**| Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages | [optional] 
 **propertiesEndPageIndex** | **int**| Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages | [optional] 
 **propertiesXCoordinateToleranceFactor** | **double**| Default value: 20 | [optional] 
 **propertiesYCoordinateToleranceFactor** | **double**| Default value: 30 | [optional] 
 **propertiesTableXMinIntersectionRequiredInPercents** | **int**| Default value: 49 | [optional] 
 **propertiesTableYMinIntersectionRequiredInPercents** | **int**| Default value: 50 | [optional] 
 **propertiesRtlTextAutoDetectionEnabled** | **bool**| Default value: False | [optional] 
 **propertiesExtractInvisibleText** | **bool**| Default value: True | [optional] 
 **propertiesExtractShadowLikeText** | **bool**| Default value: True | [optional] 
 **propertiesUnwrap** | **bool**| Default value: False | [optional] 
 **propertiesRemoveHyphenation** | **bool**| Default value: True | [optional] 
 **propertiesAutoAlignColumnsToHeader** | **bool**| Default value: True | [optional] 
 **propertiesPreserveFormattingOnTextExtraction** | **bool**| Value indicating whether to preserve the text formatting on the extraction.\r\n            Default value: True | [optional] 
 **propertiesDetectLinesInsteadOfParagraphs** | **bool**| Default value: True | [optional] 
 **propertiesTrimSpaces** | **bool**| Default value: True | [optional] 
 **propertiesExtractColumnByColumn** | **bool**| Default value: False | [optional] 
 **propertiesDetectNewColumnBySpacesRatio** | **float**| Space ratio between words.\r\n            Default value: 1 | [optional] 
 **propertiesOcrMode** | **string**| Default value: Off | [optional] 
 **propertiesLineGroupingMode** | **string**| Default value: None | [optional] 
 **propertiesColumnDetectionMode** | **string**| Default value: ContentGroupsAndBorders | [optional] 
 **propertiesOcrCacheMode** | **string**| Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off | [optional] 
 **propertiesOcrLanguage** | **string**| Default value: eng | [optional] 
 **propertiesOcrResolution** | **float**| Default value: 300 | [optional] 
 **propertiesTextEncodingCodePage** | **int**| Default value: 1252 | [optional] 
 **propertiesConsiderFontNames** | **bool**| Default value: False | [optional] 
 **propertiesConsiderFontSizes** | **bool**| Default value: False | [optional] 
 **propertiesConsiderFontColors** | **bool**| Default value: False | [optional] 
 **propertiesConsiderVerticalBorders** | **bool**| Default value: True | [optional] 
 **propertiesPassword** | **string**| Default value: | [optional] 
 **propertiesCheckPermissions** | **bool**| Default value: True | [optional] 
 **propertiesExtractionAreaUsageMode** | **string**| Default value: UseAllIntersectingObjects | [optional] 
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

