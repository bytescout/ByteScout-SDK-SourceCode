package com.bytescout.client.api;

import com.sun.jersey.api.client.GenericType;

import com.bytescout.client.ApiException;
import com.bytescout.client.ApiClient;
import com.bytescout.client.Configuration;
import com.bytescout.client.Pair;

import com.bytescout.client.model.ExceptionResponse;
import com.bytescout.client.model.CSVExtractorRequestVm;
import com.bytescout.client.model.BadRequestModel;
import com.bytescout.client.model.DocumentMergerRequestVm;
import com.bytescout.client.model.DocumentSplitterRequestVm;
import com.bytescout.client.model.InfoExtractorRequestVm;
import com.bytescout.client.model.TextExtractorRequestVm;
import com.bytescout.client.model.XMLExtractorRequestVm;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class PDFExtractorApi {
  private ApiClient apiClient;

  public PDFExtractorApi() {
    this(Configuration.getDefaultApiClient());
  }

  public PDFExtractorApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Convert PDF document to CSV
   * 
   * @param data  (required)
   * @param apikey User&#39;s ApiKey (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFExtractorCSVExtractorFile(CSVExtractorRequestVm data, String apikey) throws ApiException {
    Object localVarPostBody = data;
    
    // verify the required parameter 'data' is set
    if (data == null) {
      throw new ApiException(400, "Missing the required parameter 'data' when calling pDFExtractorCSVExtractorFile");
    }
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfextractor/csvextractor/extract".replaceAll("\\{format\\}","json");

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
  
  /**
   * Convert PDF document to CSV
   * 
   * @param apikey User&#39;s ApiKey (optional)
   * @param propertiesStartPageIndex Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages (optional)
   * @param propertiesEndPageIndex Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages (optional)
   * @param propertiesCsvSeparatorSymbol Default value: , (optional)
   * @param propertiesCsvQuotaionSymbol Default value: \&quot; (optional)
   * @param propertiesXCoordinateToleranceFactor Default value: 20 (optional)
   * @param propertiesYCoordinateToleranceFactor Default value: 30 (optional)
   * @param propertiesTableXMinIntersectionRequiredInPercents Default value: 49 (optional)
   * @param propertiesTableYMinIntersectionRequiredInPercents Default value: 50 (optional)
   * @param propertiesRtlTextAutoDetectionEnabled Default value: False (optional)
   * @param propertiesExtractInvisibleText Default value: True (optional)
   * @param propertiesExtractShadowLikeText Default value: True (optional)
   * @param propertiesUnwrap Default value: False (optional)
   * @param propertiesRemoveHyphenation Default value: True (optional)
   * @param propertiesAutoAlignColumnsToHeader Default value: True (optional)
   * @param propertiesPreserveFormattingOnTextExtraction Value indicating whether to preserve the text formatting on the extraction.\r\n            Default value: True (optional)
   * @param propertiesDetectLinesInsteadOfParagraphs Default value: True (optional)
   * @param propertiesTrimSpaces Default value: True (optional)
   * @param propertiesExtractColumnByColumn Default value: False (optional)
   * @param propertiesDetectNewColumnBySpacesRatio Space ratio between words.\r\n            Default value: 1 (optional)
   * @param propertiesOcrMode Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off (optional)
   * @param propertiesLineGroupingMode Default value: None (optional)
   * @param propertiesColumnDetectionMode Default value: ContentGroupsAndBorders (optional)
   * @param propertiesOcrCacheMode Default value: Off (optional)
   * @param propertiesOcrLanguage Default value: eng (optional)
   * @param propertiesOcrResolution Default value: 300 (optional)
   * @param propertiesTextEncodingCodePage Default value: 1252 (optional)
   * @param propertiesConsiderFontNames Default value: False (optional)
   * @param propertiesConsiderFontSizes Default value: False (optional)
   * @param propertiesConsiderFontColors Default value: False (optional)
   * @param propertiesConsiderVerticalBorders Default value: True (optional)
   * @param propertiesPassword Default value: (optional)
   * @param propertiesCheckPermissions Default value: True (optional)
   * @param propertiesExtractionAreaUsageMode Default value: UseAllIntersectingObjects (optional)
   * @param outputType Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! (optional)
   * @param input Input Data (optional)
   * @param inputType Type of Input Data (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFExtractorCSVExtractorLink(String apikey, Integer propertiesStartPageIndex, Integer propertiesEndPageIndex, String propertiesCsvSeparatorSymbol, String propertiesCsvQuotaionSymbol, Double propertiesXCoordinateToleranceFactor, Double propertiesYCoordinateToleranceFactor, Integer propertiesTableXMinIntersectionRequiredInPercents, Integer propertiesTableYMinIntersectionRequiredInPercents, Boolean propertiesRtlTextAutoDetectionEnabled, Boolean propertiesExtractInvisibleText, Boolean propertiesExtractShadowLikeText, Boolean propertiesUnwrap, Boolean propertiesRemoveHyphenation, Boolean propertiesAutoAlignColumnsToHeader, Boolean propertiesPreserveFormattingOnTextExtraction, Boolean propertiesDetectLinesInsteadOfParagraphs, Boolean propertiesTrimSpaces, Boolean propertiesExtractColumnByColumn, Float propertiesDetectNewColumnBySpacesRatio, String propertiesOcrMode, String propertiesLineGroupingMode, String propertiesColumnDetectionMode, String propertiesOcrCacheMode, String propertiesOcrLanguage, Float propertiesOcrResolution, Integer propertiesTextEncodingCodePage, Boolean propertiesConsiderFontNames, Boolean propertiesConsiderFontSizes, Boolean propertiesConsiderFontColors, Boolean propertiesConsiderVerticalBorders, String propertiesPassword, Boolean propertiesCheckPermissions, String propertiesExtractionAreaUsageMode, String outputType, String input, String inputType) throws ApiException {
    Object localVarPostBody = null;
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfextractor/csvextractor/extract".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.startPageIndex", propertiesStartPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.endPageIndex", propertiesEndPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.csvSeparatorSymbol", propertiesCsvSeparatorSymbol));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.csvQuotaionSymbol", propertiesCsvQuotaionSymbol));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.xCoordinateToleranceFactor", propertiesXCoordinateToleranceFactor));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.yCoordinateToleranceFactor", propertiesYCoordinateToleranceFactor));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.tableXMinIntersectionRequiredInPercents", propertiesTableXMinIntersectionRequiredInPercents));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.tableYMinIntersectionRequiredInPercents", propertiesTableYMinIntersectionRequiredInPercents));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.rtlTextAutoDetectionEnabled", propertiesRtlTextAutoDetectionEnabled));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractInvisibleText", propertiesExtractInvisibleText));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractShadowLikeText", propertiesExtractShadowLikeText));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.unwrap", propertiesUnwrap));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.removeHyphenation", propertiesRemoveHyphenation));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.autoAlignColumnsToHeader", propertiesAutoAlignColumnsToHeader));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.preserveFormattingOnTextExtraction", propertiesPreserveFormattingOnTextExtraction));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.detectLinesInsteadOfParagraphs", propertiesDetectLinesInsteadOfParagraphs));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.trimSpaces", propertiesTrimSpaces));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractColumnByColumn", propertiesExtractColumnByColumn));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.detectNewColumnBySpacesRatio", propertiesDetectNewColumnBySpacesRatio));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ocrMode", propertiesOcrMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.lineGroupingMode", propertiesLineGroupingMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.columnDetectionMode", propertiesColumnDetectionMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ocrCacheMode", propertiesOcrCacheMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ocrLanguage", propertiesOcrLanguage));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ocrResolution", propertiesOcrResolution));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.textEncodingCodePage", propertiesTextEncodingCodePage));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.considerFontNames", propertiesConsiderFontNames));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.considerFontSizes", propertiesConsiderFontSizes));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.considerFontColors", propertiesConsiderFontColors));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.considerVerticalBorders", propertiesConsiderVerticalBorders));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.password", propertiesPassword));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.checkPermissions", propertiesCheckPermissions));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractionAreaUsageMode", propertiesExtractionAreaUsageMode));
    
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
   * Merge PDF documents
   * 
   * @param apikey User&#39;s ApiKey (optional)
   * @param propertiesCheckPermissions Default value: True (optional)
   * @param outputType Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! (optional)
   * @param inputFileIds  (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFExtractorDocumentMergerGet(String apikey, Boolean propertiesCheckPermissions, String outputType, List<String> inputFileIds) throws ApiException {
    Object localVarPostBody = null;
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfextractor/documentmerger".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.checkPermissions", propertiesCheckPermissions));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "outputType", outputType));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("multi", "inputFileIds", inputFileIds));
    

    

    

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
   * Merge PDF documents
   * 
   * @param data  (required)
   * @param apikey User&#39;s ApiKey (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFExtractorDocumentMergerPost(DocumentMergerRequestVm data, String apikey) throws ApiException {
    Object localVarPostBody = data;
    
    // verify the required parameter 'data' is set
    if (data == null) {
      throw new ApiException(400, "Missing the required parameter 'data' when calling pDFExtractorDocumentMergerPost");
    }
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfextractor/documentmerger".replaceAll("\\{format\\}","json");

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
  
  /**
   * Split PDF document
   * 
   * @param apikey User&#39;s ApiKey (optional)
   * @param propertiesOptimizeSplittedDocuments Default value: False (optional)
   * @param propertiesCheckPermissions Default value: True (optional)
   * @param propertiesRanges Comma-separated list of page ranges in form \&quot;1-4,5,7,8-15,16-\&quot;. Page numbers are 1-based. Ending \&quot;-\&quot; means \&quot;to the last page\&quot;. (required) (optional)
   * @param outputType Type in which you want to get result of extracting (optional). Default value: FileId.\r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! (optional)
   * @param input Input Data (optional)
   * @param inputType Type of Input Data (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFExtractorDocumentSplitterGet(String apikey, Boolean propertiesOptimizeSplittedDocuments, Boolean propertiesCheckPermissions, String propertiesRanges, String outputType, String input, String inputType) throws ApiException {
    Object localVarPostBody = null;
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfextractor/documentsplitter".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.optimizeSplittedDocuments", propertiesOptimizeSplittedDocuments));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.checkPermissions", propertiesCheckPermissions));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ranges", propertiesRanges));
    
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
   * Split PDF document
   * 
   * @param data  (required)
   * @param apikey User&#39;s ApiKey (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFExtractorDocumentSplitterPost(DocumentSplitterRequestVm data, String apikey) throws ApiException {
    Object localVarPostBody = data;
    
    // verify the required parameter 'data' is set
    if (data == null) {
      throw new ApiException(400, "Missing the required parameter 'data' when calling pDFExtractorDocumentSplitterPost");
    }
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfextractor/documentsplitter".replaceAll("\\{format\\}","json");

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
  
  /**
   * Get PDF document information
   * 
   * @param data  (required)
   * @param apikey User&#39;s ApiKey (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFExtractorInfoExtractorFile(InfoExtractorRequestVm data, String apikey) throws ApiException {
    Object localVarPostBody = data;
    
    // verify the required parameter 'data' is set
    if (data == null) {
      throw new ApiException(400, "Missing the required parameter 'data' when calling pDFExtractorInfoExtractorFile");
    }
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfextractor/infoextractor/extract".replaceAll("\\{format\\}","json");

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
  
  /**
   * Get PDF document information
   * 
   * @param apikey User&#39;s ApiKey (optional)
   * @param propertiesPassword  (optional)
   * @param propertiesCheckPermissions Default value: True (optional)
   * @param propertiesExtractionAreaUsageMode Default value: UseAllIntersectingObjects (optional)
   * @param outputType Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! (optional)
   * @param input Input Data (optional)
   * @param inputType Type of Input Data (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFExtractorInfoExtractorLink(String apikey, String propertiesPassword, Boolean propertiesCheckPermissions, String propertiesExtractionAreaUsageMode, String outputType, String input, String inputType) throws ApiException {
    Object localVarPostBody = null;
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfextractor/infoextractor/extract".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.password", propertiesPassword));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.checkPermissions", propertiesCheckPermissions));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractionAreaUsageMode", propertiesExtractionAreaUsageMode));
    
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
   * Convert PDF document to plain text (TXT)
   * 
   * @param data  (required)
   * @param apikey User&#39;s ApiKey (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFExtractorTextExtractorFile(TextExtractorRequestVm data, String apikey) throws ApiException {
    Object localVarPostBody = data;
    
    // verify the required parameter 'data' is set
    if (data == null) {
      throw new ApiException(400, "Missing the required parameter 'data' when calling pDFExtractorTextExtractorFile");
    }
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfextractor/textextractor/extract".replaceAll("\\{format\\}","json");

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
  
  /**
   * Convert PDF document to plain text (TXT)
   * 
   * @param apikey User&#39;s ApiKey (optional)
   * @param propertiesStartPageIndex Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages (optional)
   * @param propertiesEndPageIndex Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages (optional)
   * @param propertiesRegexSearch Default value: False (optional)
   * @param propertiesWordMatchingMode Default value: SmartMatch (optional)
   * @param propertiesPageSeparator  (optional)
   * @param propertiesWordMatchingPunctuationMarks Default value: .\&quot;&#39;\u201C\u201D (optional)
   * @param propertiesXCoordinateToleranceFactor Default value: 20 (optional)
   * @param propertiesYCoordinateToleranceFactor Default value: 30 (optional)
   * @param propertiesTableXMinIntersectionRequiredInPercents Default value: 49 (optional)
   * @param propertiesTableYMinIntersectionRequiredInPercents Default value: 50 (optional)
   * @param propertiesRtlTextAutoDetectionEnabled Default value: False (optional)
   * @param propertiesExtractInvisibleText Default value: True (optional)
   * @param propertiesExtractShadowLikeText Default value: True (optional)
   * @param propertiesUnwrap Default value: False (optional)
   * @param propertiesRemoveHyphenation Default value: True (optional)
   * @param propertiesAutoAlignColumnsToHeader Default value: True (optional)
   * @param propertiesPreserveFormattingOnTextExtraction Value indicating whether to preserve the text formatting on the extraction.\r\n            Default value: True (optional)
   * @param propertiesDetectLinesInsteadOfParagraphs Default value: True (optional)
   * @param propertiesTrimSpaces Default value: False (optional)
   * @param propertiesExtractColumnByColumn Default value: False (optional)
   * @param propertiesDetectNewColumnBySpacesRatio Space ratio between words.\r\n            Default value: 1.2 (optional)
   * @param propertiesOcrMode Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off (optional)
   * @param propertiesLineGroupingMode Default value: None (optional)
   * @param propertiesColumnDetectionMode Default value: ContentGroupsAndBorders (optional)
   * @param propertiesOcrCacheMode Default value: Off (optional)
   * @param propertiesOcrLanguage Default value: eng (optional)
   * @param propertiesOcrResolution Default value: 300 (optional)
   * @param propertiesTextEncodingCodePage Default value: 1252 (optional)
   * @param propertiesConsiderFontNames Default value: False (optional)
   * @param propertiesConsiderFontSizes Default value: False (optional)
   * @param propertiesConsiderFontColors Default value: False (optional)
   * @param propertiesConsiderVerticalBorders Default value: False (optional)
   * @param propertiesPassword Default value: (optional)
   * @param propertiesCheckPermissions Default value: True (optional)
   * @param propertiesExtractionAreaUsageMode Default value: UseAllIntersectingObjects (optional)
   * @param outputType Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! (optional)
   * @param input Input Data (optional)
   * @param inputType Type of Input Data (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFExtractorTextExtractorLink(String apikey, Integer propertiesStartPageIndex, Integer propertiesEndPageIndex, Boolean propertiesRegexSearch, String propertiesWordMatchingMode, String propertiesPageSeparator, String propertiesWordMatchingPunctuationMarks, Double propertiesXCoordinateToleranceFactor, Double propertiesYCoordinateToleranceFactor, Integer propertiesTableXMinIntersectionRequiredInPercents, Integer propertiesTableYMinIntersectionRequiredInPercents, Boolean propertiesRtlTextAutoDetectionEnabled, Boolean propertiesExtractInvisibleText, Boolean propertiesExtractShadowLikeText, Boolean propertiesUnwrap, Boolean propertiesRemoveHyphenation, Boolean propertiesAutoAlignColumnsToHeader, Boolean propertiesPreserveFormattingOnTextExtraction, Boolean propertiesDetectLinesInsteadOfParagraphs, Boolean propertiesTrimSpaces, Boolean propertiesExtractColumnByColumn, Float propertiesDetectNewColumnBySpacesRatio, String propertiesOcrMode, String propertiesLineGroupingMode, String propertiesColumnDetectionMode, String propertiesOcrCacheMode, String propertiesOcrLanguage, Float propertiesOcrResolution, Integer propertiesTextEncodingCodePage, Boolean propertiesConsiderFontNames, Boolean propertiesConsiderFontSizes, Boolean propertiesConsiderFontColors, Boolean propertiesConsiderVerticalBorders, String propertiesPassword, Boolean propertiesCheckPermissions, String propertiesExtractionAreaUsageMode, String outputType, String input, String inputType) throws ApiException {
    Object localVarPostBody = null;
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfextractor/textextractor/extract".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.startPageIndex", propertiesStartPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.endPageIndex", propertiesEndPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.regexSearch", propertiesRegexSearch));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.wordMatchingMode", propertiesWordMatchingMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.pageSeparator", propertiesPageSeparator));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.wordMatchingPunctuationMarks", propertiesWordMatchingPunctuationMarks));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.xCoordinateToleranceFactor", propertiesXCoordinateToleranceFactor));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.yCoordinateToleranceFactor", propertiesYCoordinateToleranceFactor));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.tableXMinIntersectionRequiredInPercents", propertiesTableXMinIntersectionRequiredInPercents));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.tableYMinIntersectionRequiredInPercents", propertiesTableYMinIntersectionRequiredInPercents));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.rtlTextAutoDetectionEnabled", propertiesRtlTextAutoDetectionEnabled));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractInvisibleText", propertiesExtractInvisibleText));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractShadowLikeText", propertiesExtractShadowLikeText));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.unwrap", propertiesUnwrap));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.removeHyphenation", propertiesRemoveHyphenation));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.autoAlignColumnsToHeader", propertiesAutoAlignColumnsToHeader));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.preserveFormattingOnTextExtraction", propertiesPreserveFormattingOnTextExtraction));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.detectLinesInsteadOfParagraphs", propertiesDetectLinesInsteadOfParagraphs));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.trimSpaces", propertiesTrimSpaces));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractColumnByColumn", propertiesExtractColumnByColumn));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.detectNewColumnBySpacesRatio", propertiesDetectNewColumnBySpacesRatio));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ocrMode", propertiesOcrMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.lineGroupingMode", propertiesLineGroupingMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.columnDetectionMode", propertiesColumnDetectionMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ocrCacheMode", propertiesOcrCacheMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ocrLanguage", propertiesOcrLanguage));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ocrResolution", propertiesOcrResolution));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.textEncodingCodePage", propertiesTextEncodingCodePage));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.considerFontNames", propertiesConsiderFontNames));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.considerFontSizes", propertiesConsiderFontSizes));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.considerFontColors", propertiesConsiderFontColors));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.considerVerticalBorders", propertiesConsiderVerticalBorders));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.password", propertiesPassword));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.checkPermissions", propertiesCheckPermissions));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractionAreaUsageMode", propertiesExtractionAreaUsageMode));
    
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
   * Convert PDF document to XML
   * 
   * @param data  (required)
   * @param apikey User&#39;s ApiKey (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFExtractorXMLExtractorFile(XMLExtractorRequestVm data, String apikey) throws ApiException {
    Object localVarPostBody = data;
    
    // verify the required parameter 'data' is set
    if (data == null) {
      throw new ApiException(400, "Missing the required parameter 'data' when calling pDFExtractorXMLExtractorFile");
    }
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfextractor/xmlextractor/extract".replaceAll("\\{format\\}","json");

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
  
  /**
   * Convert PDF document to CSV
   * 
   * @param apikey User&#39;s ApiKey (optional)
   * @param propertiesStartPageIndex Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages (optional)
   * @param propertiesEndPageIndex Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages (optional)
   * @param propertiesXCoordinateToleranceFactor Default value: 20 (optional)
   * @param propertiesYCoordinateToleranceFactor Default value: 30 (optional)
   * @param propertiesTableXMinIntersectionRequiredInPercents Default value: 49 (optional)
   * @param propertiesTableYMinIntersectionRequiredInPercents Default value: 50 (optional)
   * @param propertiesRtlTextAutoDetectionEnabled Default value: False (optional)
   * @param propertiesExtractInvisibleText Default value: True (optional)
   * @param propertiesExtractShadowLikeText Default value: True (optional)
   * @param propertiesUnwrap Default value: False (optional)
   * @param propertiesRemoveHyphenation Default value: True (optional)
   * @param propertiesAutoAlignColumnsToHeader Default value: True (optional)
   * @param propertiesPreserveFormattingOnTextExtraction Value indicating whether to preserve the text formatting on the extraction.\r\n            Default value: True (optional)
   * @param propertiesDetectLinesInsteadOfParagraphs Default value: True (optional)
   * @param propertiesTrimSpaces Default value: True (optional)
   * @param propertiesExtractColumnByColumn Default value: False (optional)
   * @param propertiesDetectNewColumnBySpacesRatio Space ratio between words.\r\n            Default value: 1 (optional)
   * @param propertiesOcrMode Default value: Off (optional)
   * @param propertiesLineGroupingMode Default value: None (optional)
   * @param propertiesColumnDetectionMode Default value: ContentGroupsAndBorders (optional)
   * @param propertiesOcrCacheMode Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off (optional)
   * @param propertiesOcrLanguage Default value: eng (optional)
   * @param propertiesOcrResolution Default value: 300 (optional)
   * @param propertiesTextEncodingCodePage Default value: 1252 (optional)
   * @param propertiesConsiderFontNames Default value: False (optional)
   * @param propertiesConsiderFontSizes Default value: False (optional)
   * @param propertiesConsiderFontColors Default value: False (optional)
   * @param propertiesConsiderVerticalBorders Default value: True (optional)
   * @param propertiesPassword Default value: (optional)
   * @param propertiesCheckPermissions Default value: True (optional)
   * @param propertiesExtractionAreaUsageMode Default value: UseAllIntersectingObjects (optional)
   * @param outputType Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! (optional)
   * @param input Input Data (optional)
   * @param inputType Type of Input Data (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFExtractorXMLExtractorLink(String apikey, Integer propertiesStartPageIndex, Integer propertiesEndPageIndex, Double propertiesXCoordinateToleranceFactor, Double propertiesYCoordinateToleranceFactor, Integer propertiesTableXMinIntersectionRequiredInPercents, Integer propertiesTableYMinIntersectionRequiredInPercents, Boolean propertiesRtlTextAutoDetectionEnabled, Boolean propertiesExtractInvisibleText, Boolean propertiesExtractShadowLikeText, Boolean propertiesUnwrap, Boolean propertiesRemoveHyphenation, Boolean propertiesAutoAlignColumnsToHeader, Boolean propertiesPreserveFormattingOnTextExtraction, Boolean propertiesDetectLinesInsteadOfParagraphs, Boolean propertiesTrimSpaces, Boolean propertiesExtractColumnByColumn, Float propertiesDetectNewColumnBySpacesRatio, String propertiesOcrMode, String propertiesLineGroupingMode, String propertiesColumnDetectionMode, String propertiesOcrCacheMode, String propertiesOcrLanguage, Float propertiesOcrResolution, Integer propertiesTextEncodingCodePage, Boolean propertiesConsiderFontNames, Boolean propertiesConsiderFontSizes, Boolean propertiesConsiderFontColors, Boolean propertiesConsiderVerticalBorders, String propertiesPassword, Boolean propertiesCheckPermissions, String propertiesExtractionAreaUsageMode, String outputType, String input, String inputType) throws ApiException {
    Object localVarPostBody = null;
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfextractor/xmlextractor/extract".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.startPageIndex", propertiesStartPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.endPageIndex", propertiesEndPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.xCoordinateToleranceFactor", propertiesXCoordinateToleranceFactor));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.yCoordinateToleranceFactor", propertiesYCoordinateToleranceFactor));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.tableXMinIntersectionRequiredInPercents", propertiesTableXMinIntersectionRequiredInPercents));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.tableYMinIntersectionRequiredInPercents", propertiesTableYMinIntersectionRequiredInPercents));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.rtlTextAutoDetectionEnabled", propertiesRtlTextAutoDetectionEnabled));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractInvisibleText", propertiesExtractInvisibleText));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractShadowLikeText", propertiesExtractShadowLikeText));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.unwrap", propertiesUnwrap));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.removeHyphenation", propertiesRemoveHyphenation));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.autoAlignColumnsToHeader", propertiesAutoAlignColumnsToHeader));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.preserveFormattingOnTextExtraction", propertiesPreserveFormattingOnTextExtraction));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.detectLinesInsteadOfParagraphs", propertiesDetectLinesInsteadOfParagraphs));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.trimSpaces", propertiesTrimSpaces));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractColumnByColumn", propertiesExtractColumnByColumn));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.detectNewColumnBySpacesRatio", propertiesDetectNewColumnBySpacesRatio));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ocrMode", propertiesOcrMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.lineGroupingMode", propertiesLineGroupingMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.columnDetectionMode", propertiesColumnDetectionMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ocrCacheMode", propertiesOcrCacheMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ocrLanguage", propertiesOcrLanguage));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.ocrResolution", propertiesOcrResolution));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.textEncodingCodePage", propertiesTextEncodingCodePage));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.considerFontNames", propertiesConsiderFontNames));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.considerFontSizes", propertiesConsiderFontSizes));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.considerFontColors", propertiesConsiderFontColors));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.considerVerticalBorders", propertiesConsiderVerticalBorders));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.password", propertiesPassword));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.checkPermissions", propertiesCheckPermissions));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.extractionAreaUsageMode", propertiesExtractionAreaUsageMode));
    
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
  
}
