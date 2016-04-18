# HtmlToPdfOptionsVm

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**title** | **string** | Title of a PDF file. | [optional] 
**orientation** | **string** | Orientation of pages of a PDF file.\r\n            Default value: Portrait | [optional] 
**pageSize** | [**\Bytescout\Client\Model\PageSizeVm**](PageSizeVm.md) | Size of pages of a PDF file.\r\n            Default value: A4. | [optional] 
**margins** | [**\Bytescout\Client\Model\MarginSettingsVm**](MarginSettingsVm.md) | Margin of pages of a PDF file. | [optional] 
**printBackground** | **bool** | Define print background of a page or not.\r\n            Default value: true | [optional] 
**headerHTML** | **string** | HTML code which will be inserted in header of pages.\r\n            Default value: null | [optional] 
**footerHTML** | **string** | HTML code which will be inserted in footer of pages.\r\n            Default value: null | [optional] 
**templateData** | **string** | String of JSON data which will be used for generation PDF file from template | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


