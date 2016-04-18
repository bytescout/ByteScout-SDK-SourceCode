package com.bytescout.client.api;

import com.sun.jersey.api.client.GenericType;

import com.bytescout.client.ApiException;
import com.bytescout.client.ApiClient;
import com.bytescout.client.Configuration;
import com.bytescout.client.Pair;

import com.bytescout.client.model.ExceptionResponse;
import com.bytescout.client.model.BadRequestModel;
import com.bytescout.client.model.PdfRasterRendererRequestVm;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class PDFRendererApi {
  private ApiClient apiClient;

  public PDFRendererApi() {
    this(Configuration.getDefaultApiClient());
  }

  public PDFRendererApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Convert PDF document to PNG, JPEG, TIFF, BMP images
   * 
   * @param apikey User&#39;s ApiKey (optional)
   * @param propertiesStartPageIndex Index of a page (zero-based) from which images will be generated (for RasterOutputFormat is TIFF). (optional)
   * @param propertiesEndPageIndex Index of a page (zero-based) on which generating of images will be finished (for RasterOutputFormat is TIFF). (optional)
   * @param propertiesTiffCompression Defines TIFF image compression. (for RasterOutputFormat is TIFF).\r\n            Default value: JPEG (optional)
   * @param propertiesPageIndex Index of a page (zero-based) from which image will be generated (for RasterOutputFormat is not TIFF).\r\n            Default value: 0 (first page) (optional)
   * @param propertiesResolution Default value: 300 (optional)
   * @param propertiesUseEmbeddedFonts Default value: True (optional)
   * @param propertiesTextLayerEnabled Default value: True (optional)
   * @param propertiesVectorLayerEnabled Default value: True (optional)
   * @param propertiesImageLayerEnabled Default value: True (optional)
   * @param propertiesSupportJBIGDecoding Default value: True (optional)
   * @param propertiesJpegQuality Default value: 80 (optional)
   * @param propertiesPassword Default value: \&quot;\&quot; (optional)
   * @param propertiesTextSmoothingMode Default value: HighQuality (optional)
   * @param propertiesVectorSmoothingMode Default value: HighQuality (optional)
   * @param propertiesImageInterpolationMode Default value: HighQuality (optional)
   * @param propertiesRasterOutputFormat File format in which page of PDF file will be generated.\r\n            Default value: PNG file (optional)
   * @param outputType Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! (optional)
   * @param input Input Data (optional)
   * @param inputType Type of Input Data (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFRendererPdfRasterRendererGet(String apikey, Integer propertiesStartPageIndex, Integer propertiesEndPageIndex, String propertiesTiffCompression, Integer propertiesPageIndex, Float propertiesResolution, Boolean propertiesUseEmbeddedFonts, Boolean propertiesTextLayerEnabled, Boolean propertiesVectorLayerEnabled, Boolean propertiesImageLayerEnabled, Boolean propertiesSupportJBIGDecoding, Integer propertiesJpegQuality, String propertiesPassword, String propertiesTextSmoothingMode, String propertiesVectorSmoothingMode, String propertiesImageInterpolationMode, String propertiesRasterOutputFormat, String outputType, String input, String inputType) throws ApiException {
    Object localVarPostBody = null;
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfrenderer/render".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.startPageIndex", propertiesStartPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.endPageIndex", propertiesEndPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.tiffCompression", propertiesTiffCompression));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.pageIndex", propertiesPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.resolution", propertiesResolution));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.useEmbeddedFonts", propertiesUseEmbeddedFonts));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.textLayerEnabled", propertiesTextLayerEnabled));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.vectorLayerEnabled", propertiesVectorLayerEnabled));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.imageLayerEnabled", propertiesImageLayerEnabled));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.supportJBIGDecoding", propertiesSupportJBIGDecoding));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.jpegQuality", propertiesJpegQuality));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.password", propertiesPassword));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.textSmoothingMode", propertiesTextSmoothingMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.vectorSmoothingMode", propertiesVectorSmoothingMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.imageInterpolationMode", propertiesImageInterpolationMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.rasterOutputFormat", propertiesRasterOutputFormat));
    
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
   * Convert PDF document to PNG, JPEG, TIFF, BMP images
   * 
   * @param data  (required)
   * @param apikey User&#39;s ApiKey (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String pDFRendererPdfRasterRendererPost(PdfRasterRendererRequestVm data, String apikey) throws ApiException {
    Object localVarPostBody = data;
    
    // verify the required parameter 'data' is set
    if (data == null) {
      throw new ApiException(400, "Missing the required parameter 'data' when calling pDFRendererPdfRasterRendererPost");
    }
    
    // create path and map variables
    String localVarPath = "/api/v1/pdfrenderer/render".replaceAll("\\{format\\}","json");

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
