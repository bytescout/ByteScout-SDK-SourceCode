# Bytescout\Client\SpreadsheetApi

All URIs are relative to *https://bytescout.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**spreadsheetSpreadsheetGet**](SpreadsheetApi.md#spreadsheetSpreadsheetGet) | **GET** /api/v1/spreadsheet/convert | Convert XLS, XLSX, ODS documents to CSV, HTML, TXT, XLS, XLSX, XML, PDF formats
[**spreadsheetSpreadsheetPost**](SpreadsheetApi.md#spreadsheetSpreadsheetPost) | **POST** /api/v1/spreadsheet/convert | Convert XLS, XLSX, ODS documents to CSV, HTML, TXT, XLS, XLSX, XML, PDF formats


# **spreadsheetSpreadsheetGet**
> string spreadsheetSpreadsheetGet($apikey, $propertiesUserName, $propertiesConvertType, $propertiesCreateNavigationLinks, $propertiesSheetIndex, $propertiesDelimiter, $propertiesQuoteSymbol, $propertiesAutoSize, $propertiesPassword, $propertiesEncoding, $outputType, $input, $inputType)

Convert XLS, XLSX, ODS documents to CSV, HTML, TXT, XLS, XLSX, XML, PDF formats

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\SpreadsheetApi();
$apikey = "apikey_example"; // string | User's ApiKey
$propertiesUserName = "propertiesUserName_example"; // string | Username of Spreadsheet\r\n            Default value: \"Bytescout\"
$propertiesConvertType = "propertiesConvertType_example"; // string | Save Spreadsheet as
$propertiesCreateNavigationLinks = true; // bool | Create Navigation Links (for ConvertType = HTML).\r\n            Default value: false
$propertiesSheetIndex = 56; // int | Index of Sheet in Spreadsheet (for ConvertType = CSV, TXT, XML, PDF).\r\n            Default: 0 (first sheet)
$propertiesDelimiter = "propertiesDelimiter_example"; // string | Dilimiter of items.\r\n            Default value: ,
$propertiesQuoteSymbol = "propertiesQuoteSymbol_example"; // string | Quote of items.\r\n            Default value \"
$propertiesAutoSize = true; // bool | Autosize of PDF file (for ConvertType = PDF).\r\n            Default value: true
$propertiesPassword = "propertiesPassword_example"; // string | Password of Spreadsheet (for ConvertType = XLSX).
$propertiesEncoding = "propertiesEncoding_example"; // string | Encoding of XML file (for ConvertType = CSV, XML).\r\n            Default value: Unicode
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data

try { 
    $result = $api_instance->spreadsheetSpreadsheetGet($apikey, $propertiesUserName, $propertiesConvertType, $propertiesCreateNavigationLinks, $propertiesSheetIndex, $propertiesDelimiter, $propertiesQuoteSymbol, $propertiesAutoSize, $propertiesPassword, $propertiesEncoding, $outputType, $input, $inputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SpreadsheetApi->spreadsheetSpreadsheetGet: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **propertiesUserName** | **string**| Username of Spreadsheet\r\n            Default value: \&quot;Bytescout\&quot; | [optional] 
 **propertiesConvertType** | **string**| Save Spreadsheet as | [optional] 
 **propertiesCreateNavigationLinks** | **bool**| Create Navigation Links (for ConvertType = HTML).\r\n            Default value: false | [optional] 
 **propertiesSheetIndex** | **int**| Index of Sheet in Spreadsheet (for ConvertType = CSV, TXT, XML, PDF).\r\n            Default: 0 (first sheet) | [optional] 
 **propertiesDelimiter** | **string**| Dilimiter of items.\r\n            Default value: , | [optional] 
 **propertiesQuoteSymbol** | **string**| Quote of items.\r\n            Default value \&quot; | [optional] 
 **propertiesAutoSize** | **bool**| Autosize of PDF file (for ConvertType = PDF).\r\n            Default value: true | [optional] 
 **propertiesPassword** | **string**| Password of Spreadsheet (for ConvertType = XLSX). | [optional] 
 **propertiesEncoding** | **string**| Encoding of XML file (for ConvertType = CSV, XML).\r\n            Default value: Unicode | [optional] 
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

# **spreadsheetSpreadsheetPost**
> string spreadsheetSpreadsheetPost($data, $apikey)

Convert XLS, XLSX, ODS documents to CSV, HTML, TXT, XLS, XLSX, XML, PDF formats

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\SpreadsheetApi();
$data = new \Bytescout\Client\Model\SpreadsheetRequestVm(); // \Bytescout\Client\Model\SpreadsheetRequestVm | 
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->spreadsheetSpreadsheetPost($data, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SpreadsheetApi->spreadsheetSpreadsheetPost: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**\Bytescout\Client\Model\SpreadsheetRequestVm**](\Bytescout\Client\Model\SpreadsheetRequestVm.md)|  | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

