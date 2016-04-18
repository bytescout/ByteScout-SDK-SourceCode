package com.bytescout.client.api;

import com.sun.jersey.api.client.GenericType;

import com.bytescout.client.ApiException;
import com.bytescout.client.ApiClient;
import com.bytescout.client.Configuration;
import com.bytescout.client.Pair;

import com.bytescout.client.model.ExceptionResponse;
import com.bytescout.client.model.BadRequestModel;
import com.bytescout.client.model.BarcodeReaderRequestVm;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class BarcodeReaderApi {
  private ApiClient apiClient;

  public BarcodeReaderApi() {
    this(Configuration.getDefaultApiClient());
  }

  public BarcodeReaderApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Read barcodes from PDF document or PNG, JPEG, TIFF, BMP image
   * 
   * @param apikey User&#39;s ApiKey (optional)
   * @param propertiesStartPageIndex Index of a page (zero-based) from which searching of BarCodes will be started (for PDF files).\r\n            Default value: all pages (optional)
   * @param propertiesEndPageIndex Index of a page (zero-based) on which searching of BarCodes will be finished (for PDF files).\r\n            Default value: all pages (optional)
   * @param propertiesCustomAreaX  (optional)
   * @param propertiesCustomAreaY  (optional)
   * @param propertiesCustomAreaWidth  (optional)
   * @param propertiesCustomAreaHeight  (optional)
   * @param propertiesCustomAreaLeft Default value: 0 (optional)
   * @param propertiesCustomAreaTop Default value: 0 (optional)
   * @param propertiesCustomAreaWidth2 Default value: 0 (optional)
   * @param propertiesCustomAreaHeight2 Default value: 0 (optional)
   * @param propertiesScanArea Default value: WholePage (optional)
   * @param propertiesBarcodeTypesToFindEan8  (optional)
   * @param propertiesBarcodeTypesToFindGtin8  (optional)
   * @param propertiesBarcodeTypesToFindEan13  (optional)
   * @param propertiesBarcodeTypesToFindGtin13  (optional)
   * @param propertiesBarcodeTypesToFindUpce  (optional)
   * @param propertiesBarcodeTypesToFindUpca  (optional)
   * @param propertiesBarcodeTypesToFindGtin12  (optional)
   * @param propertiesBarcodeTypesToFindInterleaved2of5  (optional)
   * @param propertiesBarcodeTypesToFindCirculari2of5  (optional)
   * @param propertiesBarcodeTypesToFindItf14  (optional)
   * @param propertiesBarcodeTypesToFindGtin14  (optional)
   * @param propertiesBarcodeTypesToFindCode39  (optional)
   * @param propertiesBarcodeTypesToFindCode39Extended  (optional)
   * @param propertiesBarcodeTypesToFindCode39Mod43  (optional)
   * @param propertiesBarcodeTypesToFindCode39Mod43Extended  (optional)
   * @param propertiesBarcodeTypesToFindPzn  (optional)
   * @param propertiesBarcodeTypesToFindUpu  (optional)
   * @param propertiesBarcodeTypesToFindCode128  (optional)
   * @param propertiesBarcodeTypesToFindEan2  (optional)
   * @param propertiesBarcodeTypesToFindEan5  (optional)
   * @param propertiesBarcodeTypesToFindGs1  (optional)
   * @param propertiesBarcodeTypesToFindCodabar  (optional)
   * @param propertiesBarcodeTypesToFindTrioptic  (optional)
   * @param propertiesBarcodeTypesToFindPatchCode  (optional)
   * @param propertiesBarcodeTypesToFindGs1DataBarOmnidirectional  (optional)
   * @param propertiesBarcodeTypesToFindGs1DataBarExpanded  (optional)
   * @param propertiesBarcodeTypesToFindGs1DataBarLimited  (optional)
   * @param propertiesBarcodeTypesToFindGs1DataBarStacked  (optional)
   * @param propertiesBarcodeTypesToFindGs1DataBarExpandedStacked  (optional)
   * @param propertiesBarcodeTypesToFindPdf417  (optional)
   * @param propertiesBarcodeTypesToFindDataMatrix  (optional)
   * @param propertiesBarcodeTypesToFindQrCode  (optional)
   * @param propertiesBarcodeTypesToFindAztec  (optional)
   * @param propertiesBarcodeTypesToFindMaxiCode  (optional)
   * @param propertiesBarcodeTypesToFindMicr  (optional)
   * @param propertiesBarcodeTypesToFindIntelligentMail  (optional)
   * @param propertiesBarcodeTypesToFindRoyalMail  (optional)
   * @param propertiesBarcodeTypesToFindRoyalMailKIX  (optional)
   * @param propertiesBarcodeTypesToFindAustralianPostCode  (optional)
   * @param propertiesBarcodeTypesToFindCodablockF  (optional)
   * @param propertiesBarcodeTypesToFindCode16K  (optional)
   * @param propertiesBarcodeTypesToFindPostNet  (optional)
   * @param propertiesBarcodeTypesToFindMicroPDF  (optional)
   * @param propertiesBarcodeTypesToFindCode93  (optional)
   * @param propertiesBarcodeTypesToFindMsi  (optional)
   * @param propertiesBarcodeTypesToFindPharmacode  (optional)
   * @param propertiesBarcodeTypesToFindSegment  (optional)
   * @param propertiesBarcodeTypesToFindCircle  (optional)
   * @param propertiesBarcodeTypesToFindOval  (optional)
   * @param propertiesBarcodeTypesToFindCheckbox  (optional)
   * @param propertiesBarcodeTypesToFindHorizontalLine  (optional)
   * @param propertiesBarcodeTypesToFindVerticalLine  (optional)
   * @param propertiesBarcodeTypesToFindUnderlinedField  (optional)
   * @param propertiesBarcodeTypesToFindAll1D  (optional)
   * @param propertiesBarcodeTypesToFindAll2D  (optional)
   * @param propertiesBarcodeTypesToFindAllOMRElements  (optional)
   * @param propertiesBarcodeTypesToFindAll  (optional)
   * @param propertiesOrientation Default value: Default (optional)
   * @param propertiesSearchNegative Default value: False (optional)
   * @param propertiesRequireQuietZones Default value: True (optional)
   * @param propertiesMaxNumberOfBarcodesPerPage Default value: 0 (optional)
   * @param propertiesDecodingTimeOut Default value: 10000 (10 seconds) (optional)
   * @param propertiesLastDecodingTimeOutExceeded Default value: False (optional)
   * @param propertiesMaxNumberOfBarcodesPerDocument Default value: 0 (optional)
   * @param propertiesAllowOrphanedSupplementals Default value: False (optional)
   * @param propertiesMinimalDataLength Default value: 0 (optional)
   * @param propertiesMediumTrustLevelCompatible Default value: False (optional)
   * @param propertiesOptimizedProcessingOfLargeImages Default value: False (optional)
   * @param propertiesOptimizedProcessingOfLargeImagesSizeLimit Default value: 1600 (optional)
   * @param propertiesRemoveNoize Default value: False (optional)
   * @param propertiesNoiseRemovalFilterSize Default value: 2 (optional)
   * @param propertiesNoiseRemovalFilterType Default value: Blur (optional)
   * @param propertiesColorConversionMode Default value: ImageBlocks (optional)
   * @param propertiesContrast Default value: 0 (optional)
   * @param propertiesTextEncoding Default value: Default (optional)
   * @param propertiesTextEncodingCodePage Default value: 28591 (optional)
   * @param propertiesTextEncodingUseUTF8 Default value: False (optional)
   * @param propertiesPdfReadingMode Default value: RenderPDF (optional)
   * @param propertiesPdfRenderingResolution Default value: 300 (optional)
   * @param propertiesPdfRenderText Default value: True (optional)
   * @param outputType Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only! (optional)
   * @param input Input Data (optional)
   * @param inputType Type of Input Data (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String barcodeReaderBarcodeReaderGet(String apikey, Integer propertiesStartPageIndex, Integer propertiesEndPageIndex, Integer propertiesCustomAreaX, Integer propertiesCustomAreaY, Integer propertiesCustomAreaWidth, Integer propertiesCustomAreaHeight, Integer propertiesCustomAreaLeft, Integer propertiesCustomAreaTop, Integer propertiesCustomAreaWidth2, Integer propertiesCustomAreaHeight2, String propertiesScanArea, Boolean propertiesBarcodeTypesToFindEan8, Boolean propertiesBarcodeTypesToFindGtin8, Boolean propertiesBarcodeTypesToFindEan13, Boolean propertiesBarcodeTypesToFindGtin13, Boolean propertiesBarcodeTypesToFindUpce, Boolean propertiesBarcodeTypesToFindUpca, Boolean propertiesBarcodeTypesToFindGtin12, Boolean propertiesBarcodeTypesToFindInterleaved2of5, Boolean propertiesBarcodeTypesToFindCirculari2of5, Boolean propertiesBarcodeTypesToFindItf14, Boolean propertiesBarcodeTypesToFindGtin14, Boolean propertiesBarcodeTypesToFindCode39, Boolean propertiesBarcodeTypesToFindCode39Extended, Boolean propertiesBarcodeTypesToFindCode39Mod43, Boolean propertiesBarcodeTypesToFindCode39Mod43Extended, Boolean propertiesBarcodeTypesToFindPzn, Boolean propertiesBarcodeTypesToFindUpu, Boolean propertiesBarcodeTypesToFindCode128, Boolean propertiesBarcodeTypesToFindEan2, Boolean propertiesBarcodeTypesToFindEan5, Boolean propertiesBarcodeTypesToFindGs1, Boolean propertiesBarcodeTypesToFindCodabar, Boolean propertiesBarcodeTypesToFindTrioptic, Boolean propertiesBarcodeTypesToFindPatchCode, Boolean propertiesBarcodeTypesToFindGs1DataBarOmnidirectional, Boolean propertiesBarcodeTypesToFindGs1DataBarExpanded, Boolean propertiesBarcodeTypesToFindGs1DataBarLimited, Boolean propertiesBarcodeTypesToFindGs1DataBarStacked, Boolean propertiesBarcodeTypesToFindGs1DataBarExpandedStacked, Boolean propertiesBarcodeTypesToFindPdf417, Boolean propertiesBarcodeTypesToFindDataMatrix, Boolean propertiesBarcodeTypesToFindQrCode, Boolean propertiesBarcodeTypesToFindAztec, Boolean propertiesBarcodeTypesToFindMaxiCode, Boolean propertiesBarcodeTypesToFindMicr, Boolean propertiesBarcodeTypesToFindIntelligentMail, Boolean propertiesBarcodeTypesToFindRoyalMail, Boolean propertiesBarcodeTypesToFindRoyalMailKIX, Boolean propertiesBarcodeTypesToFindAustralianPostCode, Boolean propertiesBarcodeTypesToFindCodablockF, Boolean propertiesBarcodeTypesToFindCode16K, Boolean propertiesBarcodeTypesToFindPostNet, Boolean propertiesBarcodeTypesToFindMicroPDF, Boolean propertiesBarcodeTypesToFindCode93, Boolean propertiesBarcodeTypesToFindMsi, Boolean propertiesBarcodeTypesToFindPharmacode, Boolean propertiesBarcodeTypesToFindSegment, Boolean propertiesBarcodeTypesToFindCircle, Boolean propertiesBarcodeTypesToFindOval, Boolean propertiesBarcodeTypesToFindCheckbox, Boolean propertiesBarcodeTypesToFindHorizontalLine, Boolean propertiesBarcodeTypesToFindVerticalLine, Boolean propertiesBarcodeTypesToFindUnderlinedField, Boolean propertiesBarcodeTypesToFindAll1D, Boolean propertiesBarcodeTypesToFindAll2D, Boolean propertiesBarcodeTypesToFindAllOMRElements, Boolean propertiesBarcodeTypesToFindAll, String propertiesOrientation, Boolean propertiesSearchNegative, Boolean propertiesRequireQuietZones, Integer propertiesMaxNumberOfBarcodesPerPage, Integer propertiesDecodingTimeOut, Boolean propertiesLastDecodingTimeOutExceeded, Integer propertiesMaxNumberOfBarcodesPerDocument, Boolean propertiesAllowOrphanedSupplementals, Integer propertiesMinimalDataLength, Boolean propertiesMediumTrustLevelCompatible, Boolean propertiesOptimizedProcessingOfLargeImages, Integer propertiesOptimizedProcessingOfLargeImagesSizeLimit, Boolean propertiesRemoveNoize, Integer propertiesNoiseRemovalFilterSize, String propertiesNoiseRemovalFilterType, String propertiesColorConversionMode, Integer propertiesContrast, String propertiesTextEncoding, Integer propertiesTextEncodingCodePage, Boolean propertiesTextEncodingUseUTF8, String propertiesPdfReadingMode, Integer propertiesPdfRenderingResolution, Boolean propertiesPdfRenderText, String outputType, String input, String inputType) throws ApiException {
    Object localVarPostBody = null;
    
    // create path and map variables
    String localVarPath = "/api/v1/barcodereader/read".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "apikey", apikey));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.startPageIndex", propertiesStartPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.endPageIndex", propertiesEndPageIndex));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.customArea.x", propertiesCustomAreaX));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.customArea.y", propertiesCustomAreaY));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.customArea.width", propertiesCustomAreaWidth));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.customArea.height", propertiesCustomAreaHeight));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.customAreaLeft", propertiesCustomAreaLeft));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.customAreaTop", propertiesCustomAreaTop));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.customAreaWidth", propertiesCustomAreaWidth2));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.customAreaHeight", propertiesCustomAreaHeight2));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.scanArea", propertiesScanArea));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.ean8", propertiesBarcodeTypesToFindEan8));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.gtin8", propertiesBarcodeTypesToFindGtin8));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.ean13", propertiesBarcodeTypesToFindEan13));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.gtin13", propertiesBarcodeTypesToFindGtin13));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.upce", propertiesBarcodeTypesToFindUpce));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.upca", propertiesBarcodeTypesToFindUpca));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.gtin12", propertiesBarcodeTypesToFindGtin12));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.interleaved2of5", propertiesBarcodeTypesToFindInterleaved2of5));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.circulari2of5", propertiesBarcodeTypesToFindCirculari2of5));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.itf14", propertiesBarcodeTypesToFindItf14));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.gtin14", propertiesBarcodeTypesToFindGtin14));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.code39", propertiesBarcodeTypesToFindCode39));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.code39Extended", propertiesBarcodeTypesToFindCode39Extended));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.code39Mod43", propertiesBarcodeTypesToFindCode39Mod43));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.code39Mod43Extended", propertiesBarcodeTypesToFindCode39Mod43Extended));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.pzn", propertiesBarcodeTypesToFindPzn));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.upu", propertiesBarcodeTypesToFindUpu));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.code128", propertiesBarcodeTypesToFindCode128));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.ean2", propertiesBarcodeTypesToFindEan2));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.ean5", propertiesBarcodeTypesToFindEan5));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.gs1", propertiesBarcodeTypesToFindGs1));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.codabar", propertiesBarcodeTypesToFindCodabar));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.trioptic", propertiesBarcodeTypesToFindTrioptic));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.patchCode", propertiesBarcodeTypesToFindPatchCode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.gs1DataBarOmnidirectional", propertiesBarcodeTypesToFindGs1DataBarOmnidirectional));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.gs1DataBarExpanded", propertiesBarcodeTypesToFindGs1DataBarExpanded));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.gs1DataBarLimited", propertiesBarcodeTypesToFindGs1DataBarLimited));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.gs1DataBarStacked", propertiesBarcodeTypesToFindGs1DataBarStacked));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.gs1DataBarExpandedStacked", propertiesBarcodeTypesToFindGs1DataBarExpandedStacked));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.pdf417", propertiesBarcodeTypesToFindPdf417));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.dataMatrix", propertiesBarcodeTypesToFindDataMatrix));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.qrCode", propertiesBarcodeTypesToFindQrCode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.aztec", propertiesBarcodeTypesToFindAztec));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.maxiCode", propertiesBarcodeTypesToFindMaxiCode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.micr", propertiesBarcodeTypesToFindMicr));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.intelligentMail", propertiesBarcodeTypesToFindIntelligentMail));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.royalMail", propertiesBarcodeTypesToFindRoyalMail));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.royalMailKIX", propertiesBarcodeTypesToFindRoyalMailKIX));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.australianPostCode", propertiesBarcodeTypesToFindAustralianPostCode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.codablockF", propertiesBarcodeTypesToFindCodablockF));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.code16K", propertiesBarcodeTypesToFindCode16K));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.postNet", propertiesBarcodeTypesToFindPostNet));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.microPDF", propertiesBarcodeTypesToFindMicroPDF));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.code93", propertiesBarcodeTypesToFindCode93));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.msi", propertiesBarcodeTypesToFindMsi));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.pharmacode", propertiesBarcodeTypesToFindPharmacode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.segment", propertiesBarcodeTypesToFindSegment));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.circle", propertiesBarcodeTypesToFindCircle));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.oval", propertiesBarcodeTypesToFindOval));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.checkbox", propertiesBarcodeTypesToFindCheckbox));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.horizontalLine", propertiesBarcodeTypesToFindHorizontalLine));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.verticalLine", propertiesBarcodeTypesToFindVerticalLine));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.underlinedField", propertiesBarcodeTypesToFindUnderlinedField));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.all1D", propertiesBarcodeTypesToFindAll1D));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.all2D", propertiesBarcodeTypesToFindAll2D));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.allOMRElements", propertiesBarcodeTypesToFindAllOMRElements));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.barcodeTypesToFind.all", propertiesBarcodeTypesToFindAll));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.orientation", propertiesOrientation));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.searchNegative", propertiesSearchNegative));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.requireQuietZones", propertiesRequireQuietZones));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.maxNumberOfBarcodesPerPage", propertiesMaxNumberOfBarcodesPerPage));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.decodingTimeOut", propertiesDecodingTimeOut));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.lastDecodingTimeOutExceeded", propertiesLastDecodingTimeOutExceeded));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.maxNumberOfBarcodesPerDocument", propertiesMaxNumberOfBarcodesPerDocument));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.allowOrphanedSupplementals", propertiesAllowOrphanedSupplementals));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.minimalDataLength", propertiesMinimalDataLength));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.mediumTrustLevelCompatible", propertiesMediumTrustLevelCompatible));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.optimizedProcessingOfLargeImages", propertiesOptimizedProcessingOfLargeImages));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.optimizedProcessingOfLargeImagesSizeLimit", propertiesOptimizedProcessingOfLargeImagesSizeLimit));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.removeNoize", propertiesRemoveNoize));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.noiseRemovalFilterSize", propertiesNoiseRemovalFilterSize));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.noiseRemovalFilterType", propertiesNoiseRemovalFilterType));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.colorConversionMode", propertiesColorConversionMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.contrast", propertiesContrast));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.textEncoding", propertiesTextEncoding));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.textEncodingCodePage", propertiesTextEncodingCodePage));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.textEncodingUseUTF8", propertiesTextEncodingUseUTF8));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.pdfReadingMode", propertiesPdfReadingMode));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.pdfRenderingResolution", propertiesPdfRenderingResolution));
    
    localVarQueryParams.addAll(apiClient.parameterToPairs("", "properties.pdfRenderText", propertiesPdfRenderText));
    
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
   * Read barcodes from PDF document or PNG, JPEG, TIFF, BMP image
   * 
   * @param data  (required)
   * @param apikey User&#39;s ApiKey (optional)
   * @return String
   * @throws ApiException if fails to make API call
   */
  public String barcodeReaderBarcodeReaderPost(BarcodeReaderRequestVm data, String apikey) throws ApiException {
    Object localVarPostBody = data;
    
    // verify the required parameter 'data' is set
    if (data == null) {
      throw new ApiException(400, "Missing the required parameter 'data' when calling barcodeReaderBarcodeReaderPost");
    }
    
    // create path and map variables
    String localVarPath = "/api/v1/barcodereader/read".replaceAll("\\{format\\}","json");

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
