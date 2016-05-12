# PdfRasterRendererOptionsVm

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**startPageIndex** | **int** | Index of a page (zero-based) from which images will be generated (for RasterOutputFormat is TIFF). | [optional] 
**endPageIndex** | **int** | Index of a page (zero-based) on which generating of images will be finished (for RasterOutputFormat is TIFF). | [optional] 
**tiffCompression** | **string** | Defines TIFF image compression. (for RasterOutputFormat is TIFF).\r\n            Default value: JPEG | [optional] 
**pageIndex** | **int** | Index of a page (zero-based) from which image will be generated (for RasterOutputFormat is not TIFF).\r\n            Default value: 0 (first page) | [optional] 
**resolution** | **float** | Default value: 300 | [optional] 
**useEmbeddedFonts** | **bool** | Default value: True | [optional] 
**textLayerEnabled** | **bool** | Default value: True | [optional] 
**vectorLayerEnabled** | **bool** | Default value: True | [optional] 
**imageLayerEnabled** | **bool** | Default value: True | [optional] 
**supportJBIGDecoding** | **bool** | Default value: True | [optional] 
**jpegQuality** | **int** | Default value: 80 | [optional] 
**password** | **string** | Default value: \&quot;\&quot; | [optional] 
**textSmoothingMode** | **string** | Default value: HighQuality | [optional] 
**vectorSmoothingMode** | **string** | Default value: HighQuality | [optional] 
**imageInterpolationMode** | **string** | Default value: HighQuality | [optional] 
**rasterOutputFormat** | **string** | File format in which page of PDF file will be generated.\r\n            Default value: PNG file | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


