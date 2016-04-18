# Bytescout\Client\FileApi

All URIs are relative to *https://bytescout.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**fileDeleteFile**](FileApi.md#fileDeleteFile) | **DELETE** /api/v1/file/delete/{FileId} | Remove file from server permanently
[**fileGet**](FileApi.md#fileGet) | **GET** /api/v1/file/download/{FileId} | Download file
[**fileGetPublicFile**](FileApi.md#fileGetPublicFile) | **GET** /api/v1/file/download/public/{PublicFileId} | Download public file
[**fileUploadFile**](FileApi.md#fileUploadFile) | **POST** /api/v1/file/upload | Upload file to server to use it in conversions
[**fileUploadLink**](FileApi.md#fileUploadLink) | **GET** /api/v1/file/upload | Upload file to server to use it in conversions


# **fileDeleteFile**
> \Bytescout\Client\Model\Object fileDeleteFile($fileId, $apikey)

Remove file from server permanently

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\FileApi();
$fileId = "fileId_example"; // string | FileId
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->fileDeleteFile($fileId, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FileApi->fileDeleteFile: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**| FileId | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

[**\Bytescout\Client\Model\Object**](Object.md)

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **fileGet**
> string fileGet($fileId, $apikey, $outputType)

Download file

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\FileApi();
$fileId = "fileId_example"; // string | FileId
$apikey = "apikey_example"; // string | User's ApiKey
$outputType = "outputType_example"; // string | Type in which you want to get a File (Default value: Content)

try { 
    $result = $api_instance->fileGet($fileId, $apikey, $outputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FileApi->fileGet: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**| FileId | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **outputType** | **string**| Type in which you want to get a File (Default value: Content) | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **fileGetPublicFile**
> string fileGetPublicFile($publicFileId, $outputType)

Download public file

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\FileApi();
$publicFileId = "publicFileId_example"; // string | PublicFileId
$outputType = "outputType_example"; // string | Type in which you want to get a File (Default value: Content)

try { 
    $result = $api_instance->fileGetPublicFile($publicFileId, $outputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FileApi->fileGetPublicFile: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **publicFileId** | **string**| PublicFileId | 
 **outputType** | **string**| Type in which you want to get a File (Default value: Content) | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **fileUploadFile**
> string fileUploadFile($apikey, $file, $input, $inputType, $storageTime)

Upload file to server to use it in conversions

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\FileApi();
$apikey = "apikey_example"; // string | User's ApiKey
$file = "/path/to/file.txt"; // \SplFileObject | File
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data
$storageTime = 56; // int | Time of storage this file on server. Default value: 1800

try { 
    $result = $api_instance->fileUploadFile($apikey, $file, $input, $inputType, $storageTime);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FileApi->fileUploadFile: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **file** | **\SplFileObject**| File | [optional] 
 **input** | **string**| Input Data | [optional] 
 **inputType** | **string**| Type of Input Data | [optional] 
 **storageTime** | **int**| Time of storage this file on server. Default value: 1800 | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/octet-stream, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **fileUploadLink**
> string fileUploadLink($apikey, $storageTime, $outputType, $input, $inputType)

Upload file to server to use it in conversions

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\FileApi();
$apikey = "apikey_example"; // string | User's ApiKey
$storageTime = 56; // int | Time of storing of a file on server (seconds) (optional).\r\n            Default value: 1800
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data

try { 
    $result = $api_instance->fileUploadLink($apikey, $storageTime, $outputType, $input, $inputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FileApi->fileUploadLink: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **storageTime** | **int**| Time of storing of a file on server (seconds) (optional).\r\n            Default value: 1800 | [optional] 
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

