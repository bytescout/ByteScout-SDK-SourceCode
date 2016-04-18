package com.bytescout.client.api;

import com.sun.jersey.api.client.GenericType;

import com.bytescout.client.ApiException;
import com.bytescout.client.ApiClient;
import com.bytescout.client.Configuration;
import com.bytescout.client.Pair;

import com.bytescout.client.model.ExceptionResponse;
import com.bytescout.client.model.BadRequestModel;
import com.bytescout.client.model.SpreadsheetRequestVm;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class SpreadsheetApi {
  private ApiClient apiClient;

  public SpreadsheetApi() {
    this(Configuration.getDefaultApiClient());
  }

  public SpreadsheetApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Convert XLS, XLSX, ODS documents to CSV, HTML, TXT, XLS, XLSX, XML, PDF formats
   * 
   * @param apikey User&#39;s ApiKey (optional)
   * @param propertiesUserName Username of Spreadsheet\r\n            Default value: \&quot;Bytescout\&quot; (optional)
   * @param propertiesConvertType Save Spreadsheet as (optional)
   * @param propertiesCreateNavigationLinks Create Navigation Links (for ConvertType = HTML).\r\n            Default value: false (optional)
   * @param propertiesSheetIndex Index of Sheet in Spreadsheet (for ConvertType = CSV, TXT, XML, PDF).\r\n            Default: 0 (first sheet) (optional)
   * @param propertiesDelimiter Dilimiter of items.\r\n            Default value: , (optional)
   * @param propertiesQuoteSymbol Quote of items.\r\n            Default value \&quot; (optional)
   * @param propertiesAutoSize Autosize of PDF file (for ConvertType = PDF).\r\n            Default value: true (optional)
   * @param propertiesPassword Password of Spreadsheet (for ConvertType = XLSX). (optional)
   * @param propertiesEncoding Encoding of XML file (for ConvertType = CSV, XML).\r\n            Default value: Unicode (optional)
   * @param outputType Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! (optional)
   * @param input Input Data (optional)
   * @param inputType Type of Input Data (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String spreadsheetSpreadsheetGet(String apikey, String propertiesUserName, String propertiesConvertType, Boolean propertiesCreateNavigationLinks, Integer propertiesSheetIndex, String propertiesDelimiter, String propertiesQuoteSymbol, Boolean propertiesAutoSize, String propertiesPassword, String propertiesEncoding, String outputType, String input, String inputType) throws ApiException {
    Object localVarPostBody = null;
    
    // create path and map variables
    String localVarPath = "/api/v1/spreadsheet/convert".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.userName", propertiesUserName));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.convertType", propertiesConvertType));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.createNavigationLinks", propertiesCreateNavigationLinks));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.sheetIndex", propertiesSheetIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.delimiter", propertiesDelimiter));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.quoteSymbol", propertiesQuoteSymbol));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.autoSize", propertiesAutoSize));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.password", propertiesPassword));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.encoding", propertiesEncoding));
    
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
   * Convert XLS, XLSX, ODS documents to CSV, HTML, TXT, XLS, XLSX, XML, PDF formats
   * 
   * @param data  (required)
   * @param apikey User&#39;s ApiKey (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String spreadsheetSpreadsheetPost(SpreadsheetRequestVm data, String apikey) throws ApiException {
    Object localVarPostBody = data;
    
    // verify the required parameter 'data' is set
    if (data == null) {
      throw new ApiException(400, "Missing the required parameter 'data' when calling spreadsheetSpreadsheetPost");
    }
    
    // create path and map variables
    String localVarPath = "/api/v1/spreadsheet/convert".replaceAll("\\{format\\}","json");

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
