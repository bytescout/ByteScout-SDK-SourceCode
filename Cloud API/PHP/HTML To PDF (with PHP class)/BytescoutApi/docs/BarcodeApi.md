# Bytescout\Client\BarcodeApi

All URIs are relative to *https://bytescout.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**barcodeGetBarcode**](BarcodeApi.md#barcodeGetBarcode) | **GET** /api/v1/barcode/generate | Generate barcode
[**barcodePostBarCode**](BarcodeApi.md#barcodePostBarCode) | **POST** /api/v1/barcode/generate | Generate barcode


# **barcodeGetBarcode**
> string barcodeGetBarcode($apikey, $propertiesOutputFileType, $propertiesTiffUse1BitFormat, $propertiesProduceMonochromeImages, $propertiesAdditionalCaption, $propertiesAddChecksum, $propertiesAddChecksumToCaption, $propertiesCaption, $propertiesDrawCaption, $propertiesDrawCaptionFor2DBarcodes, $propertiesDrawQuietZones, $propertiesSymbology, $propertiesSupplementValue, $propertiesAdditionalCaptionFont, $propertiesBarHeight, $propertiesCaptionFont, $propertiesNarrowBarWidth, $propertiesWideToNarrowRatio, $propertiesAdditionalCaptionPosition, $propertiesAngle, $propertiesBackColor, $propertiesCaptionPosition, $propertiesForeColor, $propertiesMarginsTop, $propertiesMarginsBottom, $propertiesMarginsLeft, $propertiesMarginsRight, $propertiesSmoothingMode, $propertiesRenderingHint, $propertiesResolutionX, $propertiesResolutionY, $propertiesCutUnusedSpace, $propertiesPreserveMinReadableSize, $propertiesSizeHeight, $propertiesSizeWidth, $propertiesSizeUnitOfMeasure, $outputType, $input, $inputType)

Generate barcode

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\BarcodeApi();
$apikey = "apikey_example"; // string | User's ApiKey
$propertiesOutputFileType = "propertiesOutputFileType_example"; // string | File format in which barcode will be generated.\r\n            Default value: PNG file
$propertiesTiffUse1BitFormat = true; // bool | Default value: False
$propertiesProduceMonochromeImages = true; // bool | Default value: False
$propertiesAdditionalCaption = "propertiesAdditionalCaption_example"; // string | Default value:
$propertiesAddChecksum = true; // bool | Default value: False
$propertiesAddChecksumToCaption = true; // bool | Default value: False
$propertiesCaption = "propertiesCaption_example"; // string | 
$propertiesDrawCaption = true; // bool | Default value: True
$propertiesDrawCaptionFor2DBarcodes = true; // bool | Default value: False
$propertiesDrawQuietZones = true; // bool | Default value: True
$propertiesSymbology = "propertiesSymbology_example"; // string | Default value: Code39
$propertiesSupplementValue = "propertiesSupplementValue_example"; // string | Default value:
$propertiesAdditionalCaptionFont = "propertiesAdditionalCaptionFont_example"; // string | Default value: Arial, 12
$propertiesBarHeight = 56; // int | Default value: 50
$propertiesCaptionFont = "propertiesCaptionFont_example"; // string | Default value: Arial, 12
$propertiesNarrowBarWidth = 56; // int | Default value: 3
$propertiesWideToNarrowRatio = 56; // int | Default value: 3
$propertiesAdditionalCaptionPosition = "propertiesAdditionalCaptionPosition_example"; // string | Default value: Above
$propertiesAngle = "propertiesAngle_example"; // string | Default value: Degrees0
$propertiesBackColor = "propertiesBackColor_example"; // string | Default value: Color [White]
$propertiesCaptionPosition = "propertiesCaptionPosition_example"; // string | Default value: Below
$propertiesForeColor = "propertiesForeColor_example"; // string | Default value: Color [Black]
$propertiesMarginsTop = 3.4; // float | Top margin (in mm)\r\n            Default value: 10
$propertiesMarginsBottom = 3.4; // float | Bottom margin (in mm)\r\n            Default value: 10
$propertiesMarginsLeft = 3.4; // float | Left margin (in mm)\r\n            Default value: 10
$propertiesMarginsRight = 3.4; // float | Right margin (in mm)\r\n            Default value: 10
$propertiesSmoothingMode = "propertiesSmoothingMode_example"; // string | Default value: Default
$propertiesRenderingHint = "propertiesRenderingHint_example"; // string | Default value: SystemDefault
$propertiesResolutionX = 3.4; // float | Default value: 96
$propertiesResolutionY = 3.4; // float | Default value: 96
$propertiesCutUnusedSpace = true; // bool | Default value: False
$propertiesPreserveMinReadableSize = true; // bool | Default value: True
$propertiesSizeHeight = 3.4; // float | Height of area
$propertiesSizeWidth = 3.4; // float | Width of area
$propertiesSizeUnitOfMeasure = "propertiesSizeUnitOfMeasure_example"; // string | Unit of measure.\r\n            Default value: Pixel
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data

try { 
    $result = $api_instance->barcodeGetBarcode($apikey, $propertiesOutputFileType, $propertiesTiffUse1BitFormat, $propertiesProduceMonochromeImages, $propertiesAdditionalCaption, $propertiesAddChecksum, $propertiesAddChecksumToCaption, $propertiesCaption, $propertiesDrawCaption, $propertiesDrawCaptionFor2DBarcodes, $propertiesDrawQuietZones, $propertiesSymbology, $propertiesSupplementValue, $propertiesAdditionalCaptionFont, $propertiesBarHeight, $propertiesCaptionFont, $propertiesNarrowBarWidth, $propertiesWideToNarrowRatio, $propertiesAdditionalCaptionPosition, $propertiesAngle, $propertiesBackColor, $propertiesCaptionPosition, $propertiesForeColor, $propertiesMarginsTop, $propertiesMarginsBottom, $propertiesMarginsLeft, $propertiesMarginsRight, $propertiesSmoothingMode, $propertiesRenderingHint, $propertiesResolutionX, $propertiesResolutionY, $propertiesCutUnusedSpace, $propertiesPreserveMinReadableSize, $propertiesSizeHeight, $propertiesSizeWidth, $propertiesSizeUnitOfMeasure, $outputType, $input, $inputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BarcodeApi->barcodeGetBarcode: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **propertiesOutputFileType** | **string**| File format in which barcode will be generated.\r\n            Default value: PNG file | [optional] 
 **propertiesTiffUse1BitFormat** | **bool**| Default value: False | [optional] 
 **propertiesProduceMonochromeImages** | **bool**| Default value: False | [optional] 
 **propertiesAdditionalCaption** | **string**| Default value: | [optional] 
 **propertiesAddChecksum** | **bool**| Default value: False | [optional] 
 **propertiesAddChecksumToCaption** | **bool**| Default value: False | [optional] 
 **propertiesCaption** | **string**|  | [optional] 
 **propertiesDrawCaption** | **bool**| Default value: True | [optional] 
 **propertiesDrawCaptionFor2DBarcodes** | **bool**| Default value: False | [optional] 
 **propertiesDrawQuietZones** | **bool**| Default value: True | [optional] 
 **propertiesSymbology** | **string**| Default value: Code39 | [optional] 
 **propertiesSupplementValue** | **string**| Default value: | [optional] 
 **propertiesAdditionalCaptionFont** | **string**| Default value: Arial, 12 | [optional] 
 **propertiesBarHeight** | **int**| Default value: 50 | [optional] 
 **propertiesCaptionFont** | **string**| Default value: Arial, 12 | [optional] 
 **propertiesNarrowBarWidth** | **int**| Default value: 3 | [optional] 
 **propertiesWideToNarrowRatio** | **int**| Default value: 3 | [optional] 
 **propertiesAdditionalCaptionPosition** | **string**| Default value: Above | [optional] 
 **propertiesAngle** | **string**| Default value: Degrees0 | [optional] 
 **propertiesBackColor** | **string**| Default value: Color [White] | [optional] 
 **propertiesCaptionPosition** | **string**| Default value: Below | [optional] 
 **propertiesForeColor** | **string**| Default value: Color [Black] | [optional] 
 **propertiesMarginsTop** | **float**| Top margin (in mm)\r\n            Default value: 10 | [optional] 
 **propertiesMarginsBottom** | **float**| Bottom margin (in mm)\r\n            Default value: 10 | [optional] 
 **propertiesMarginsLeft** | **float**| Left margin (in mm)\r\n            Default value: 10 | [optional] 
 **propertiesMarginsRight** | **float**| Right margin (in mm)\r\n            Default value: 10 | [optional] 
 **propertiesSmoothingMode** | **string**| Default value: Default | [optional] 
 **propertiesRenderingHint** | **string**| Default value: SystemDefault | [optional] 
 **propertiesResolutionX** | **float**| Default value: 96 | [optional] 
 **propertiesResolutionY** | **float**| Default value: 96 | [optional] 
 **propertiesCutUnusedSpace** | **bool**| Default value: False | [optional] 
 **propertiesPreserveMinReadableSize** | **bool**| Default value: True | [optional] 
 **propertiesSizeHeight** | **float**| Height of area | [optional] 
 **propertiesSizeWidth** | **float**| Width of area | [optional] 
 **propertiesSizeUnitOfMeasure** | **string**| Unit of measure.\r\n            Default value: Pixel | [optional] 
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

# **barcodePostBarCode**
> string barcodePostBarCode($data, $apikey)

Generate barcode

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\BarcodeApi();
$data = new \Bytescout\Client\Model\BarcodeRequestVm(); // \Bytescout\Client\Model\BarcodeRequestVm | 
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->barcodePostBarCode($data, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BarcodeApi->barcodePostBarCode: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**\Bytescout\Client\Model\BarcodeRequestVm**](\Bytescout\Client\Model\BarcodeRequestVm.md)|  | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

