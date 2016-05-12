# Bytescout\Client\UserInfoApi

All URIs are relative to *https://bytescout.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userInfoGetLeftCredits**](UserInfoApi.md#userInfoGetLeftCredits) | **GET** /api/v1/user/info/credits | Get information about remaining credits


# **userInfoGetLeftCredits**
> string userInfoGetLeftCredits($apikey)

Get information about remaining credits

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\UserInfoApi();
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->userInfoGetLeftCredits($apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling UserInfoApi->userInfoGetLeftCredits: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

