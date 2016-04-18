package com.bytescout.client.api;

import com.sun.jersey.api.client.GenericType;

import com.bytescout.client.ApiException;
import com.bytescout.client.ApiClient;
import com.bytescout.client.Configuration;
import com.bytescout.client.Pair;

import com.bytescout.client.model.ExceptionResponse;
import com.bytescout.client.model.BadRequestModel;
import com.bytescout.client.model.BarcodeRequestVm;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class BarcodeApi {
  private ApiClient apiClient;

  public BarcodeApi() {
    this(Configuration.getDefaultApiClient());
  }

  public BarcodeApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Generate barcode
   * 
   * @param apikey User&#39;s ApiKey (optional)
   * @param propertiesOutputFileType File format in which barcode will be generated.\r\n            Default value: PNG file (optional)
   * @param propertiesTiffUse1BitFormat Default value: False (optional)
   * @param propertiesProduceMonochromeImages Default value: False (optional)
   * @param propertiesAdditionalCaption Default value: (optional)
   * @param propertiesAddChecksum Default value: False (optional)
   * @param propertiesAddChecksumToCaption Default value: False (optional)
   * @param propertiesCaption  (optional)
   * @param propertiesDrawCaption Default value: True (optional)
   * @param propertiesDrawCaptionFor2DBarcodes Default value: False (optional)
   * @param propertiesDrawQuietZones Default value: True (optional)
   * @param propertiesSymbology Default value: Code39 (optional)
   * @param propertiesSupplementValue Default value: (optional)
   * @param propertiesAdditionalCaptionFont Default value: Arial, 12 (optional)
   * @param propertiesBarHeight Default value: 50 (optional)
   * @param propertiesCaptionFont Default value: Arial, 12 (optional)
   * @param propertiesNarrowBarWidth Default value: 3 (optional)
   * @param propertiesWideToNarrowRatio Default value: 3 (optional)
   * @param propertiesAdditionalCaptionPosition Default value: Above (optional)
   * @param propertiesAngle Default value: Degrees0 (optional)
   * @param propertiesBackColor Default value: Color [White] (optional)
   * @param propertiesCaptionPosition Default value: Below (optional)
   * @param propertiesForeColor Default value: Color [Black] (optional)
   * @param propertiesMarginsTop Top margin (in mm)\r\n            Default value: 10 (optional)
   * @param propertiesMarginsBottom Bottom margin (in mm)\r\n            Default value: 10 (optional)
   * @param propertiesMarginsLeft Left margin (in mm)\r\n            Default value: 10 (optional)
   * @param propertiesMarginsRight Right margin (in mm)\r\n            Default value: 10 (optional)
   * @param propertiesSmoothingMode Default value: Default (optional)
   * @param propertiesRenderingHint Default value: SystemDefault (optional)
   * @param propertiesResolutionX Default value: 96 (optional)
   * @param propertiesResolutionY Default value: 96 (optional)
   * @param propertiesCutUnusedSpace Default value: False (optional)
   * @param propertiesPreserveMinReadableSize Default value: True (optional)
   * @param propertiesSizeHeight Height of area (optional)
   * @param propertiesSizeWidth Width of area (optional)
   * @param propertiesSizeUnitOfMeasure Unit of measure.\r\n            Default value: Pixel (optional)
   * @param outputType Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! (optional)
   * @param input Input Data (optional)
   * @param inputType Type of Input Data (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String barcodeGetBarcode(String apikey, String propertiesOutputFileType, Boolean propertiesTiffUse1BitFormat, Boolean propertiesProduceMonochromeImages, String propertiesAdditionalCaption, Boolean propertiesAddChecksum, Boolean propertiesAddChecksumToCaption, String propertiesCaption, Boolean propertiesDrawCaption, Boolean propertiesDrawCaptionFor2DBarcodes, Boolean propertiesDrawQuietZones, String propertiesSymbology, String propertiesSupplementValue, String propertiesAdditionalCaptionFont, Integer propertiesBarHeight, String propertiesCaptionFont, Integer propertiesNarrowBarWidth, Integer propertiesWideToNarrowRatio, String propertiesAdditionalCaptionPosition, String propertiesAngle, String propertiesBackColor, String propertiesCaptionPosition, String propertiesForeColor, Float propertiesMarginsTop, Float propertiesMarginsBottom, Float propertiesMarginsLeft, Float propertiesMarginsRight, String propertiesSmoothingMode, String propertiesRenderingHint, Float propertiesResolutionX, Float propertiesResolutionY, Boolean propertiesCutUnusedSpace, Boolean propertiesPreserveMinReadableSize, Float propertiesSizeHeight, Float propertiesSizeWidth, String propertiesSizeUnitOfMeasure, String outputType, String input, String inputType) throws ApiException {
    Object localVarPostBody = null;
    
    // create path and map variables
    String localVarPath = "/api/v1/barcode/generate".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.outputFileType", propertiesOutputFileType));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.tiffUse1BitFormat", propertiesTiffUse1BitFormat));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.produceMonochromeImages", propertiesProduceMonochromeImages));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.additionalCaption", propertiesAdditionalCaption));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.addChecksum", propertiesAddChecksum));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.addChecksumToCaption", propertiesAddChecksumToCaption));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.caption", propertiesCaption));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.drawCaption", propertiesDrawCaption));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.drawCaptionFor2DBarcodes", propertiesDrawCaptionFor2DBarcodes));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.drawQuietZones", propertiesDrawQuietZones));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.symbology", propertiesSymbology));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.supplementValue", propertiesSupplementValue));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.additionalCaptionFont", propertiesAdditionalCaptionFont));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barHeight", propertiesBarHeight));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.captionFont", propertiesCaptionFont));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.narrowBarWidth", propertiesNarrowBarWidth));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.wideToNarrowRatio", propertiesWideToNarrowRatio));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.additionalCaptionPosition", propertiesAdditionalCaptionPosition));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.angle", propertiesAngle));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.backColor", propertiesBackColor));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.captionPosition", propertiesCaptionPosition));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.foreColor", propertiesForeColor));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.margins.top", propertiesMarginsTop));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.margins.bottom", propertiesMarginsBottom));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.margins.left", propertiesMarginsLeft));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.margins.right", propertiesMarginsRight));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.smoothingMode", propertiesSmoothingMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.renderingHint", propertiesRenderingHint));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.resolutionX", propertiesResolutionX));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.resolutionY", propertiesResolutionY));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.cutUnusedSpace", propertiesCutUnusedSpace));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.preserveMinReadableSize", propertiesPreserveMinReadableSize));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.size.height", propertiesSizeHeight));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.size.width", propertiesSizeWidth));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.size.unitOfMeasure", propertiesSizeUnitOfMeasure));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "outputType", outputType));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "input", input));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "inputType", inputType));
    

    

    

    final String[] localVarAccepts = {
      "application/json", "text/json", "application/xml", "text/xml"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] {  };

    
    GenericType<String> localVarReturnType = new GenericType<String>() {};
    return apiClient.invokeAPI(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
    
  }
  
  /**
   * Generate barcode
   * 
   * @param data  (required)
   * @param apikey User&#39;s ApiKey (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String barcodePostBarCode(BarcodeRequestVm data, String apikey) throws ApiException {
    Object localVarPostBody = data;
    
    // verify the required parameter 'data' is set
    if (data == null) {
      throw new ApiException(400, "Missing the required parameter 'data' when calling barcodePostBarCode");
    }
    
    // create path and map variables
    String localVarPath = "/api/v1/barcode/generate".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    

    

    

    final String[] localVarAccepts = {
      "application/json", "text/json", "application/xml", "text/xml"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json", "text/json", "application/xml", "text/xml"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] {  };

    
    GenericType<String> localVarReturnType = new GenericType<String>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
    
  }
  
}
