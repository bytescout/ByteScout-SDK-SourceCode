# Bytescout\Client\HTMLToPDFApi

All URIs are relative to *https://bytescout.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**hTMLToPDFGetHtmlToPdf**](HTMLToPDFApi.md#hTMLToPDFGetHtmlToPdf) | **GET** /api/v1/htmltopdf/convert | Convert HTML page to PDF document
[**hTMLToPDFPostHtmlToPdf**](HTMLToPDFApi.md#hTMLToPDFPostHtmlToPdf) | **POST** /api/v1/htmltopdf/convert | Convert HTML page to PDF document


# **hTMLToPDFGetHtmlToPdf**
> string hTMLToPDFGetHtmlToPdf($apikey, $propertiesTitle, $propertiesOrientation, $propertiesPageSizeWidth, $propertiesPageSizeHeight, $propertiesPageSizeUnit, $propertiesMarginsBottom, $propertiesMarginsLeft, $propertiesMarginsRight, $propertiesMarginsTop, $propertiesMarginsUnit, $propertiesPrintBackground, $propertiesHeaderHTML, $propertiesFooterHTML, $propertiesTemplateData, $outputType, $input, $inputType)

Convert HTML page to PDF document

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\HTMLToPDFApi();
$apikey = "apikey_example"; // string | User's ApiKey
$propertiesTitle = "propertiesTitle_example"; // string | Title of a PDF file.
$propertiesOrientation = "propertiesOrientation_example"; // string | Orientation of pages of a PDF file.\r\n            Default value: Portrait
$propertiesPageSizeWidth = 1.2; // double | 
$propertiesPageSizeHeight = 1.2; // double | 
$propertiesPageSizeUnit = "propertiesPageSizeUnit_example"; // string | Default value: Millimeters
$propertiesMarginsBottom = 1.2; // double | 
$propertiesMarginsLeft = 1.2; // double | 
$propertiesMarginsRight = 1.2; // double | 
$propertiesMarginsTop = 1.2; // double | 
$propertiesMarginsUnit = "propertiesMarginsUnit_example"; // string | Default value: Millimeters
$propertiesPrintBackground = true; // bool | Define print background of a page or not.\r\n            Default value: true
$propertiesHeaderHTML = "propertiesHeaderHTML_example"; // string | HTML code which will be inserted in header of pages.\r\n            Default value: null
$propertiesFooterHTML = "propertiesFooterHTML_example"; // string | HTML code which will be inserted in footer of pages.\r\n            Default value: null
$propertiesTemplateData = "propertiesTemplateData_example"; // string | String of JSON data which will be used for generation PDF file from template
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data

try { 
    $result = $api_instance->hTMLToPDFGetHtmlToPdf($apikey, $propertiesTitle, $propertiesOrientation, $propertiesPageSizeWidth, $propertiesPageSizeHeight, $propertiesPageSizeUnit, $propertiesMarginsBottom, $propertiesMarginsLeft, $propertiesMarginsRight, $propertiesMarginsTop, $propertiesMarginsUnit, $propertiesPrintBackground, $propertiesHeaderHTML, $propertiesFooterHTML, $propertiesTemplateData, $outputType, $input, $inputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HTMLToPDFApi->hTMLToPDFGetHtmlToPdf: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **propertiesTitle** | **string**| Title of a PDF file. | [optional] 
 **propertiesOrientation** | **string**| Orientation of pages of a PDF file.\r\n            Default value: Portrait | [optional] 
 **propertiesPageSizeWidth** | **double**|  | [optional] 
 **propertiesPageSizeHeight** | **double**|  | [optional] 
 **propertiesPageSizeUnit** | **string**| Default value: Millimeters | [optional] 
 **propertiesMarginsBottom** | **double**|  | [optional] 
 **propertiesMarginsLeft** | **double**|  | [optional] 
 **propertiesMarginsRight** | **double**|  | [optional] 
 **propertiesMarginsTop** | **double**|  | [optional] 
 **propertiesMarginsUnit** | **string**| Default value: Millimeters | [optional] 
 **propertiesPrintBackground** | **bool**| Define print background of a page or not.\r\n            Default value: true | [optional] 
 **propertiesHeaderHTML** | **string**| HTML code which will be inserted in header of pages.\r\n            Default value: null | [optional] 
 **propertiesFooterHTML** | **string**| HTML code which will be inserted in footer of pages.\r\n            Default value: null | [optional] 
 **propertiesTemplateData** | **string**| String of JSON data which will be used for generation PDF file from template | [optional] 
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

# **hTMLToPDFPostHtmlToPdf**
> string hTMLToPDFPostHtmlToPdf($data, $apikey)

Convert HTML page to PDF document

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\HTMLToPDFApi();
$data = new \Bytescout\Client\Model\HtmlToPdfRequestVm(); // \Bytescout\Client\Model\HtmlToPdfRequestVm | 
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->hTMLToPDFPostHtmlToPdf($data, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HTMLToPDFApi->hTMLToPDFPostHtmlToPdf: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**\Bytescout\Client\Model\HtmlToPdfRequestVm**](\Bytescout\Client\Model\HtmlToPdfRequestVm.md)|  | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

