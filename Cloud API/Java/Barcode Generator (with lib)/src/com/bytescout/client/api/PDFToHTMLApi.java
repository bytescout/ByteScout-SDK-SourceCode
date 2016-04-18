package com.bytescout.client.api;

import com.sun.jersey.api.client.GenericType;

import com.bytescout.client.ApiException;
import com.bytescout.client.ApiClient;
import com.bytescout.client.Configuration;
import com.bytescout.client.Pair;

import com.bytescout.client.model.ExceptionResponse;
import com.bytescout.client.model.BadRequestModel;
import com.bytescout.client.model.HTMLExtractorRequestVm;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class PDFToHTMLApi {
  private ApiClient apiClient;

  public PDFToHTMLApi() {
    this(Configuration.getDefaultApiClient());
  }

  public PDFToHTMLApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Convert PDF document to HTML page
   * 
   * @param apikey User&#39;s ApiKey (optional)
   * @param propertiesStartPageIndex Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages (optional)
   * @param propertiesEndPageIndex Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages (optional)
   * @param propertiesDetectNewColumnBySpacesRatio Default value: 1.2 (optional)
   * @param propertiesExtractInvisibleText Default value: True (optional)
   * @param propertiesPreserveFormattingOnTextExtraction Default value: True (optional)
   * @param propertiesColumnDetectionMode Default value: ContentGroupsAndBorders (optional)
   * @param propertiesLineGroupingMode Default value: None (optional)
   * @param propertiesDetectLinesInsteadOfParagraphs Default value: True (optional)
   * @param propertiesTrimSpaces Default value: True (optional)
   * @param propertiesOutputImageFormat Default value: PNG (optional)
   * @param propertiesExtractionMode Default value: HTMLWithCSS (optional)
   * @param propertiesOptimizeImages Default value: True (optional)
   * @param propertiesOutputPageWidth Default value: 1024 (optional)
   * @param propertiesHighPrecisionTextPositioning Default value: True (optional)
   * @param propertiesAddFontStyleHTMLTagsToText Default value: True (optional)
   * @param propertiesControlsAsText Default value: False (optional)
   * @param propertiesDetectHyperLinks Default value: True (optional)
   * @param propertiesPassword Default value: null (optional)
   * @param propertiesCheckPermissions Default value: True (optional)
   * @param outputType Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! (optional)
   * @param input Input Data (optional)
   * @param inputType Type of Input Data (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFToHTMLHTMLExtractorGet(String apikey, Integer propertiesStartPageIndex, Integer propertiesEndPageIndex, Float propertiesDetectNewColumnBySpacesRatio, Boolean propertiesExtractInvisibleText, Boolean propertiesPreserveFormattingOnTextExtraction, String propertiesColumnDetectionMode, String propertiesLineGroupingMode, Boolean propertiesDetectLinesInsteadOfParagraphs, Boolean propertiesTrimSpaces, String propertiesOutputImageFormat, String propertiesExtractionMode, Boolean propertiesOptimizeImages, Integer propertiesOutputPageWidth, Boolean propertiesHighPrecisionTextPositioning, Boolean propertiesAddFontStyleHTMLTagsToText, Boolean propertiesControlsAsText, Boolean propertiesDetectHyperLinks, String propertiesPassword, Boolean propertiesCheckPermissions, String outputType, String input, String inputType) throws ApiException {
    Object localVarPostBody = null;
    
    // create path and map variables
    String localVarPath = "/api/v1/pdftohtml/htmlextractor/extract".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.startPageIndex", propertiesStartPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.endPageIndex", propertiesEndPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.detectNewColumnBySpacesRatio", propertiesDetectNewColumnBySpacesRatio));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractInvisibleText", propertiesExtractInvisibleText));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.preserveFormattingOnTextExtraction", propertiesPreserveFormattingOnTextExtraction));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.columnDetectionMode", propertiesColumnDetectionMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.lineGroupingMode", propertiesLineGroupingMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.detectLinesInsteadOfParagraphs", propertiesDetectLinesInsteadOfParagraphs));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.trimSpaces", propertiesTrimSpaces));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.outputImageFormat", propertiesOutputImageFormat));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractionMode", propertiesExtractionMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.optimizeImages", propertiesOptimizeImages));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.outputPageWidth", propertiesOutputPageWidth));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.highPrecisionTextPositioning", propertiesHighPrecisionTextPositioning));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.addFontStyleHTMLTagsToText", propertiesAddFontStyleHTMLTagsToText));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.controlsAsText", propertiesControlsAsText));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.detectHyperLinks", propertiesDetectHyperLinks));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.password", propertiesPassword));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.checkPermissions", propertiesCheckPermissions));
    
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
   * Convert PDF document to HTML page
   * 
   * @param data  (required)
   * @param apikey User&#39;s ApiKey (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFToHTMLHTMLExtractorPost(HTMLExtractorRequestVm data, String apikey) throws ApiException {
    Object localVarPostBody = data;
    
    // verify the required parameter 'data' is set
    if (data == null) {
      throw new ApiException(400, "Missing the required parameter 'data' when calling pDFToHTMLHTMLExtractorPost");
    }
    
    // create path and map variables
    String localVarPath = "/api/v1/pdftohtml/htmlextractor/extract".replaceAll("\\{format\\}","json");

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
