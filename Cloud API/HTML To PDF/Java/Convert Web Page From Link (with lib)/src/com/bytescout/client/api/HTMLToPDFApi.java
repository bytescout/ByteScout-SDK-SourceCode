package com.bytescout.client.api;

import com.sun.jersey.api.client.GenericType;

import com.bytescout.client.ApiException;
import com.bytescout.client.ApiClient;
import com.bytescout.client.Configuration;
import com.bytescout.client.Pair;

import com.bytescout.client.model.ExceptionResponse;
import com.bytescout.client.model.BadRequestModel;
import com.bytescout.client.model.HtmlToPdfRequestVm;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class HTMLToPDFApi {
  private ApiClient apiClient;

  public HTMLToPDFApi() {
    this(Configuration.getDefaultApiClient());
  }

  public HTMLToPDFApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Convert HTML page to PDF document
   * 
   * @param apikey User&#39;s ApiKey (optional)
   * @param propertiesTitle Title of a PDF file. (optional)
   * @param propertiesOrientation Orientation of pages of a PDF file.\r\n            Default value: Portrait (optional)
   * @param propertiesPageSizeWidth  (optional)
   * @param propertiesPageSizeHeight  (optional)
   * @param propertiesPageSizeUnit Default value: Millimeters (optional)
   * @param propertiesMarginsBottom  (optional)
   * @param propertiesMarginsLeft  (optional)
   * @param propertiesMarginsRight  (optional)
   * @param propertiesMarginsTop  (optional)
   * @param propertiesMarginsUnit Default value: Millimeters (optional)
   * @param propertiesPrintBackground Define print background of a page or not.\r\n            Default value: true (optional)
   * @param propertiesHeaderHTML HTML code which will be inserted in header of pages.\r\n            Default value: null (optional)
   * @param propertiesFooterHTML HTML code which will be inserted in footer of pages.\r\n            Default value: null (optional)
   * @param propertiesTemplateData String of JSON data which will be used for generation PDF file from template (optional)
   * @param outputType Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! (optional)
   * @param input Input Data (optional)
   * @param inputType Type of Input Data (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String hTMLToPDFGetHtmlToPdf(String apikey, String propertiesTitle, String propertiesOrientation, Double propertiesPageSizeWidth, Double propertiesPageSizeHeight, String propertiesPageSizeUnit, Double propertiesMarginsBottom, Double propertiesMarginsLeft, Double propertiesMarginsRight, Double propertiesMarginsTop, String propertiesMarginsUnit, Boolean propertiesPrintBackground, String propertiesHeaderHTML, String propertiesFooterHTML, String propertiesTemplateData, String outputType, String input, String inputType) throws ApiException {
    Object localVarPostBody = null;
    
    // create path and map variables
    String localVarPath = "/api/v1/htmltopdf/convert".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.title", propertiesTitle));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.orientation", propertiesOrientation));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.pageSize.width", propertiesPageSizeWidth));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.pageSize.height", propertiesPageSizeHeight));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.pageSize.unit", propertiesPageSizeUnit));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.margins.bottom", propertiesMarginsBottom));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.margins.left", propertiesMarginsLeft));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.margins.right", propertiesMarginsRight));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.margins.top", propertiesMarginsTop));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.margins.unit", propertiesMarginsUnit));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.printBackground", propertiesPrintBackground));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.headerHTML", propertiesHeaderHTML));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.footerHTML", propertiesFooterHTML));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.templateData", propertiesTemplateData));
    
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
   * Convert HTML page to PDF document
   * 
   * @param data  (required)
   * @param apikey User&#39;s ApiKey (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String hTMLToPDFPostHtmlToPdf(HtmlToPdfRequestVm data, String apikey) throws ApiException {
    Object localVarPostBody = data;
    
    // verify the required parameter 'data' is set
    if (data == null) {
      throw new ApiException(400, "Missing the required parameter 'data' when calling hTMLToPDFPostHtmlToPdf");
    }
    
    // create path and map variables
    String localVarPath = "/api/v1/htmltopdf/convert".replaceAll("\\{format\\}","json");

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
