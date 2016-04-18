# Bytescout\Client\PDFRendererApi

All URIs are relative to *https://bytescout.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**pDFRendererPdfRasterRendererGet**](PDFRendererApi.md#pDFRendererPdfRasterRendererGet) | **GET** /api/v1/pdfrenderer/render | Convert PDF document to PNG, JPEG, TIFF, BMP images
[**pDFRendererPdfRasterRendererPost**](PDFRendererApi.md#pDFRendererPdfRasterRendererPost) | **POST** /api/v1/pdfrenderer/render | Convert PDF document to PNG, JPEG, TIFF, BMP images


# **pDFRendererPdfRasterRendererGet**
> string pDFRendererPdfRasterRendererGet($apikey, $propertiesStartPageIndex, $propertiesEndPageIndex, $propertiesTiffCompression, $propertiesPageIndex, $propertiesResolution, $propertiesUseEmbeddedFonts, $propertiesTextLayerEnabled, $propertiesVectorLayerEnabled, $propertiesImageLayerEnabled, $propertiesSupportJBIGDecoding, $propertiesJpegQuality, $propertiesPassword, $propertiesTextSmoothingMode, $propertiesVectorSmoothingMode, $propertiesImageInterpolationMode, $propertiesRasterOutputFormat, $outputType, $input, $inputType)

Convert PDF document to PNG, JPEG, TIFF, BMP images

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFRendererApi();
$apikey = "apikey_example"; // string | User's ApiKey
$propertiesStartPageIndex = 56; // int | Index of a page (zero-based) from which images will be generated (for RasterOutputFormat is TIFF).
$propertiesEndPageIndex = 56; // int | Index of a page (zero-based) on which generating of images will be finished (for RasterOutputFormat is TIFF).
$propertiesTiffCompression = "propertiesTiffCompression_example"; // string | Defines TIFF image compression. (for RasterOutputFormat is TIFF).\r\n            Default value: JPEG
$propertiesPageIndex = 56; // int | Index of a page (zero-based) from which image will be generated (for RasterOutputFormat is not TIFF).\r\n            Default value: 0 (first page)
$propertiesResolution = 3.4; // float | Default value: 300
$propertiesUseEmbeddedFonts = true; // bool | Default value: True
$propertiesTextLayerEnabled = true; // bool | Default value: True
$propertiesVectorLayerEnabled = true; // bool | Default value: True
$propertiesImageLayerEnabled = true; // bool | Default value: True
$propertiesSupportJBIGDecoding = true; // bool | Default value: True
$propertiesJpegQuality = 56; // int | Default value: 80
$propertiesPassword = "propertiesPassword_example"; // string | Default value: \"\"
$propertiesTextSmoothingMode = "propertiesTextSmoothingMode_example"; // string | Default value: HighQuality
$propertiesVectorSmoothingMode = "propertiesVectorSmoothingMode_example"; // string | Default value: HighQuality
$propertiesImageInterpolationMode = "propertiesImageInterpolationMode_example"; // string | Default value: HighQuality
$propertiesRasterOutputFormat = "propertiesRasterOutputFormat_example"; // string | File format in which page of PDF file will be generated.\r\n            Default value: PNG file
$outputType = "outputType_example"; // string | Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
$input = "input_example"; // string | Input Data
$inputType = "inputType_example"; // string | Type of Input Data

try { 
    $result = $api_instance->pDFRendererPdfRasterRendererGet($apikey, $propertiesStartPageIndex, $propertiesEndPageIndex, $propertiesTiffCompression, $propertiesPageIndex, $propertiesResolution, $propertiesUseEmbeddedFonts, $propertiesTextLayerEnabled, $propertiesVectorLayerEnabled, $propertiesImageLayerEnabled, $propertiesSupportJBIGDecoding, $propertiesJpegQuality, $propertiesPassword, $propertiesTextSmoothingMode, $propertiesVectorSmoothingMode, $propertiesImageInterpolationMode, $propertiesRasterOutputFormat, $outputType, $input, $inputType);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFRendererApi->pDFRendererPdfRasterRendererGet: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey** | **string**| User&#39;s ApiKey | [optional] 
 **propertiesStartPageIndex** | **int**| Index of a page (zero-based) from which images will be generated (for RasterOutputFormat is TIFF). | [optional] 
 **propertiesEndPageIndex** | **int**| Index of a page (zero-based) on which generating of images will be finished (for RasterOutputFormat is TIFF). | [optional] 
 **propertiesTiffCompression** | **string**| Defines TIFF image compression. (for RasterOutputFormat is TIFF).\r\n            Default value: JPEG | [optional] 
 **propertiesPageIndex** | **int**| Index of a page (zero-based) from which image will be generated (for RasterOutputFormat is not TIFF).\r\n            Default value: 0 (first page) | [optional] 
 **propertiesResolution** | **float**| Default value: 300 | [optional] 
 **propertiesUseEmbeddedFonts** | **bool**| Default value: True | [optional] 
 **propertiesTextLayerEnabled** | **bool**| Default value: True | [optional] 
 **propertiesVectorLayerEnabled** | **bool**| Default value: True | [optional] 
 **propertiesImageLayerEnabled** | **bool**| Default value: True | [optional] 
 **propertiesSupportJBIGDecoding** | **bool**| Default value: True | [optional] 
 **propertiesJpegQuality** | **int**| Default value: 80 | [optional] 
 **propertiesPassword** | **string**| Default value: \&quot;\&quot; | [optional] 
 **propertiesTextSmoothingMode** | **string**| Default value: HighQuality | [optional] 
 **propertiesVectorSmoothingMode** | **string**| Default value: HighQuality | [optional] 
 **propertiesImageInterpolationMode** | **string**| Default value: HighQuality | [optional] 
 **propertiesRasterOutputFormat** | **string**| File format in which page of PDF file will be generated.\r\n            Default value: PNG file | [optional] 
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

# **pDFRendererPdfRasterRendererPost**
> string pDFRendererPdfRasterRendererPost($data, $apikey)

Convert PDF document to PNG, JPEG, TIFF, BMP images

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Bytescout\Client\Api\PDFRendererApi();
$data = new \Bytescout\Client\Model\PdfRasterRendererRequestVm(); // \Bytescout\Client\Model\PdfRasterRendererRequestVm | 
$apikey = "apikey_example"; // string | User's ApiKey

try { 
    $result = $api_instance->pDFRendererPdfRasterRendererPost($data, $apikey);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PDFRendererApi->pDFRendererPdfRasterRendererPost: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**\Bytescout\Client\Model\PdfRasterRendererRequestVm**](\Bytescout\Client\Model\PdfRasterRendererRequestVm.md)|  | 
 **apikey** | **string**| User&#39;s ApiKey | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

