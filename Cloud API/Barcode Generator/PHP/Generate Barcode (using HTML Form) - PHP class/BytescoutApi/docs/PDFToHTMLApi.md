# Bytescout\Client\PDFToHTMLApi

All URIs are relative to *https://bytescout.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**pDFToHTMLHTMLExtractorGet**](PDFToHTMLApi.md#pDFToHTMLHTMLExtractorGet) | **GET** /api/v1/pdftohtml/htmlextractor/extract | Convert PDF document to HTML page
[**pDFToHTMLHTMLExtractorPost**](PDFToHTMLApi.md#pDFToHTMLHTMLExtractorPost) | **POST** /api/v1/pdftohtml/htmlextractor/extract | Convert PDF document to HTML page


# **pDFToHTMLHTMLExtractorGet**
> string pDFToHTMLHTMLExtractorGet($apikey, $propertiesStartPageIndex, $propertiesEndPageIndex, $propertiesDetectNewColumnBySpacesRatio, $propertiesExtractInvisibleText, $propertiesPreserveFormattingOnTextExtraction, $propertiesColumnDetectionMode, $propertiesLineGroupingMode, $propertiesDetectLinesInsteadOfParagraphs, $propertiesTrimSpaces, $propertiesOutputImageFormat, $propertiesExtractionMode, $propertiesOptimizeImages, $propertiesOutputPageWidth, $propertiesHighPrecisionTextPositioning, $propertiesAddFontStyleHTMLTagsToText, $propertiesControlsAsText, $propertiesDetectHyperLinks, $propertiesPassword, $propertiesCheckPermissions, $outputType, $input, $inputType)

Convert PDF document to HTML page

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFToHTMLApi();
$apikey = "apikey_example"; // string | User's ApiKey
$propertiesStartPageIndex = 56; // int | Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages
$propertiesEndPageIndex = 56; // int | Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages
$propertiesDetectNewColumnBySpacesRatio = 3.4; // float | Default value: 1.2
$propertiesExtractInvisibleText = true; // bool | Default value: True
$propertiesPreserveFormattingOnTextExtraction = true; // bool | Default value: True
$propertiesColumnDetectionMode = "propertiesColumnDetectionMode_example"; // string | Default value: ContentGroupsAndBorders
$propertiesLineGroupingMode = "propertiesLineGroupingMode_example"; // string | Default value: None
$propertiesDetectLinesInsteadOfParagraphs = true; // bool | Default value: True
$propertiesTrimSpaces = true; // bool | Default value: True
$propertiesOutputImageFormat = "propertiesOutputImageFormat_example"; // string | Default value: PNG
$propertiesExtractionMode = "propertiesExtractionMode_example"; // string | Default value: HTMLWithCSS
$propertiesOptimizeImages = true; // bool | Default value: True
$propertiesOutputPageWidth = 56; // int | Default value: 1024
$propertiesHighPrecisionTextPositioning = true; // bool | Default value: True
$propertiesAddFontStyleHTMLTagsToText = true; // bool | Default value: True
$propertiesControlsAsText = true; // bool | Default value: False
$propertiesDetectHyperLinks = true; // bool | Default value: True
$propertiesPassword = "propertiesPassword_example"; // string | Default value: null
$propertiesCheckPermissions = true; // bool | Default value: True
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data

try { 
    $result = $api_instance->pDFToHTMLHTMLExtractorGet($apikey, $propertiesStartPageIndex, $propertiesEndPageIndex, $propertiesDetectNewColumnBySpacesRatio, $propertiesExtractInvisibleText, $propertiesPreserveFormattingOnTextExtraction, $propertiesColumnDetectionMode, $propertiesLineGroupingMode, $propertiesDetectLinesInsteadOfParagraphs, $propertiesTrimSpaces, $propertiesOutputImageFormat, $propertiesExtractionMode, $propertiesOptimizeImages, $propertiesOutputPageWidth, $propertiesHighPrecisionTextPositioning, $propertiesAddFontStyleHTMLTagsToText, $propertiesControlsAsText, $propertiesDetectHyperLinks, $propertiesPassword, $propertiesCheckPermissions, $outputType, $input, $inputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFToHTMLApi->pDFToHTMLHTMLExtractorGet: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **propertiesStartPageIndex** | **int**| Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages | [optional] 
 **propertiesEndPageIndex** | **int**| Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages | [optional] 
 **propertiesDetectNewColumnBySpacesRatio** | **float**| Default value: 1.2 | [optional] 
 **propertiesExtractInvisibleText** | **bool**| Default value: True | [optional] 
 **propertiesPreserveFormattingOnTextExtraction** | **bool**| Default value: True | [optional] 
 **propertiesColumnDetectionMode** | **string**| Default value: ContentGroupsAndBorders | [optional] 
 **propertiesLineGroupingMode** | **string**| Default value: None | [optional] 
 **propertiesDetectLinesInsteadOfParagraphs** | **bool**| Default value: True | [optional] 
 **propertiesTrimSpaces** | **bool**| Default value: True | [optional] 
 **propertiesOutputImageFormat** | **string**| Default value: PNG | [optional] 
 **propertiesExtractionMode** | **string**| Default value: HTMLWithCSS | [optional] 
 **propertiesOptimizeImages** | **bool**| Default value: True | [optional] 
 **propertiesOutputPageWidth** | **int**| Default value: 1024 | [optional] 
 **propertiesHighPrecisionTextPositioning** | **bool**| Default value: True | [optional] 
 **propertiesAddFontStyleHTMLTagsToText** | **bool**| Default value: True | [optional] 
 **propertiesControlsAsText** | **bool**| Default value: False | [optional] 
 **propertiesDetectHyperLinks** | **bool**| Default value: True | [optional] 
 **propertiesPassword** | **string**| Default value: null | [optional] 
 **propertiesCheckPermissions** | **bool**| Default value: True | [optional] 
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

# **pDFToHTMLHTMLExtractorPost**
> string pDFToHTMLHTMLExtractorPost($data, $apikey)

Convert PDF document to HTML page

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFToHTMLApi();
$data = new \Bytescout\Client\Model\HTMLExtractorRequestVm(); // \Bytescout\Client\Model\HTMLExtractorRequestVm | 
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->pDFToHTMLHTMLExtractorPost($data, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFToHTMLApi->pDFToHTMLHTMLExtractorPost: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**\Bytescout\Client\Model\HTMLExtractorRequestVm**](\Bytescout\Client\Model\HTMLExtractorRequestVm.md)|  | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

