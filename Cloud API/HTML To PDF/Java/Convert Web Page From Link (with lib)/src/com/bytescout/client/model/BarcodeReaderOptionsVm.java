package com.bytescout.client.model;

import java.util.Objects;
import com.bytescout.client.model.BarcodeTypeSelector;
import com.bytescout.client.model.RectangleVm;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class BarcodeReaderOptionsVm   {
  
  private Integer startPageIndex = null;
  private Integer endPageIndex = null;
  private RectangleVm customArea = null;
  private Integer customAreaLeft = null;
  private Integer customAreaTop = null;
  private Integer customAreaWidth = null;
  private Integer customAreaHeight = null;


  public enum ScanAreaEnum {
    CUSTOM("custom"),
    TOPLEFTQUARTER("topLeftQuarter"),
    TOPRIGHTQUARTER("topRightQuarter"),
    TOPHALF("topHalf"),
    BOTTOMRIGHTQUARTER("bottomRightQuarter"),
    BOTTOMLEFTQUARTER("bottomLeftQuarter"),
    BOTTOMHALF("bottomHalf"),
    WHOLEPAGE("wholePage");

    private String value;

    ScanAreaEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private ScanAreaEnum scanArea = null;
  private BarcodeTypeSelector barcodeTypesToFind = null;


  public enum OrientationEnum {
    HORIZONTALFROMLEFTTORIGHT("horizontalFromLeftToRight"),
    DEFAULT("default"),
    VERTICALFROMTOPTOBOTTOM("verticalFromTopToBottom"),
    DIAGONALFROMTOPLEFTTOBOTTOMRIGHT45("diagonalFromTopLeftToBottomRight45"),
    DIAGONALFROMBOTTOMLEFTTOTOPRIGHT45("diagonalFromBottomLeftToTopRight45"),
    HORIZONTALFROMRIGHTTOLEFT("horizontalFromRightToLeft"),
    DIAGONALFROMTOPLEFTTOBOTTOMRIGHT11("diagonalFromTopLeftToBottomRight11"),
    DIAGONALFROMBOTTOMRIGHTTOTOPLEFT11("diagonalFromBottomRightToTopLeft11"),
    DIAGONALFROMBOTTOMLEFTTOTOPRIGHT11("diagonalFromBottomLeftToTopRight11"),
    DIAGONALFROMTOPRIGHTTOBOTTOMLEFT11("diagonalFromTopRightToBottomLeft11"),
    DIAGONALFROMTOPLEFTTOBOTTOMRIGHT22("diagonalFromTopLeftToBottomRight22"),
    DIAGONALFROMBOTTOMRIGHTTOTOPLEFT22("diagonalFromBottomRightToTopLeft22"),
    DIAGONALFROMBOTTOMLEFTTOTOPRIGHT22("diagonalFromBottomLeftToTopRight22"),
    DIAGONALFROMTOPRIGHTTOBOTTOMLEFT22("diagonalFromTopRightToBottomLeft22"),
    DIAGONALFROMBOTTOMRIGHTTOTOPLEFT45("diagonalFromBottomRightToTopLeft45"),
    DIAGONALFROMTOPRIGHTTOBOTTOMLEFT45("diagonalFromTopRightToBottomLeft45"),
    VERTICALFROMBOTTOMTOTOP("verticalFromBottomToTop"),
    SEARCHALL("searchAll");

    private String value;

    OrientationEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private OrientationEnum orientation = null;
  private Boolean searchNegative = null;
  private Boolean requireQuietZones = null;
  private Integer maxNumberOfBarcodesPerPage = null;
  private Integer decodingTimeOut = null;
  private Boolean lastDecodingTimeOutExceeded = null;
  private Integer maxNumberOfBarcodesPerDocument = null;
  private Boolean allowOrphanedSupplementals = null;
  private Integer minimalDataLength = null;
  private Boolean mediumTrustLevelCompatible = null;
  private Boolean optimizedProcessingOfLargeImages = null;
  private Integer optimizedProcessingOfLargeImagesSizeLimit = null;
  private Boolean removeNoize = null;
  private Integer noiseRemovalFilterSize = null;


  public enum NoiseRemovalFilterTypeEnum {
    BLUR("blur"),
    MEDIAN("median");

    private String value;

    NoiseRemovalFilterTypeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private NoiseRemovalFilterTypeEnum noiseRemovalFilterType = null;


  public enum ColorConversionModeEnum {
    IMAGEBLOCKS("imageBlocks"),
    IMAGE("image");

    private String value;

    ColorConversionModeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private ColorConversionModeEnum colorConversionMode = null;
  private Integer contrast = null;


  public enum TextEncodingEnum {
    ASCII("ascii"),
    DEFAULT("default"),
    UNICODE("unicode"),
    BIGENDIANUNICODE("bigEndianUnicode"),
    UTF7("utf7"),
    UTF8("utf8"),
    UTF32("utf32");

    private String value;

    TextEncodingEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private TextEncodingEnum textEncoding = null;
  private Integer textEncodingCodePage = null;
  private Boolean textEncodingUseUTF8 = null;


  public enum PdfReadingModeEnum {
    RENDERPDF("renderPDF"),
    EXTRACTEMBEDDEDIMAGESONLY("extractEmbeddedImagesOnly");

    private String value;

    PdfReadingModeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private PdfReadingModeEnum pdfReadingMode = null;
  private Integer pdfRenderingResolution = null;
  private Boolean pdfRenderText = null;

  
  /**
   * Index of a page (zero-based) from which searching of BarCodes will be started (for PDF files).\r\n            Default value: all pages
   **/
  public BarcodeReaderOptionsVm startPageIndex(Integer startPageIndex) {
    this.startPageIndex = startPageIndex;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Index of a page (zero-based) from which searching of BarCodes will be started (for PDF files).\r\n            Default value: all pages")
  @JsonProperty("startPageIndex")
  public Integer getStartPageIndex() {
    return startPageIndex;
  }
  public void setStartPageIndex(Integer startPageIndex) {
    this.startPageIndex = startPageIndex;
  }

  
  /**
   * Index of a page (zero-based) on which searching of BarCodes will be finished (for PDF files).\r\n            Default value: all pages
   **/
  public BarcodeReaderOptionsVm endPageIndex(Integer endPageIndex) {
    this.endPageIndex = endPageIndex;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Index of a page (zero-based) on which searching of BarCodes will be finished (for PDF files).\r\n            Default value: all pages")
  @JsonProperty("endPageIndex")
  public Integer getEndPageIndex() {
    return endPageIndex;
  }
  public void setEndPageIndex(Integer endPageIndex) {
    this.endPageIndex = endPageIndex;
  }

  
  /**
   * Default value: {X=0,Y=0,Width=0,Height=0}
   **/
  public BarcodeReaderOptionsVm customArea(RectangleVm customArea) {
    this.customArea = customArea;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: {X=0,Y=0,Width=0,Height=0}")
  @JsonProperty("customArea")
  public RectangleVm getCustomArea() {
    return customArea;
  }
  public void setCustomArea(RectangleVm customArea) {
    this.customArea = customArea;
  }

  
  /**
   * Default value: 0
   **/
  public BarcodeReaderOptionsVm customAreaLeft(Integer customAreaLeft) {
    this.customAreaLeft = customAreaLeft;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 0")
  @JsonProperty("customAreaLeft")
  public Integer getCustomAreaLeft() {
    return customAreaLeft;
  }
  public void setCustomAreaLeft(Integer customAreaLeft) {
    this.customAreaLeft = customAreaLeft;
  }

  
  /**
   * Default value: 0
   **/
  public BarcodeReaderOptionsVm customAreaTop(Integer customAreaTop) {
    this.customAreaTop = customAreaTop;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 0")
  @JsonProperty("customAreaTop")
  public Integer getCustomAreaTop() {
    return customAreaTop;
  }
  public void setCustomAreaTop(Integer customAreaTop) {
    this.customAreaTop = customAreaTop;
  }

  
  /**
   * Default value: 0
   **/
  public BarcodeReaderOptionsVm customAreaWidth(Integer customAreaWidth) {
    this.customAreaWidth = customAreaWidth;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 0")
  @JsonProperty("customAreaWidth")
  public Integer getCustomAreaWidth() {
    return customAreaWidth;
  }
  public void setCustomAreaWidth(Integer customAreaWidth) {
    this.customAreaWidth = customAreaWidth;
  }

  
  /**
   * Default value: 0
   **/
  public BarcodeReaderOptionsVm customAreaHeight(Integer customAreaHeight) {
    this.customAreaHeight = customAreaHeight;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 0")
  @JsonProperty("customAreaHeight")
  public Integer getCustomAreaHeight() {
    return customAreaHeight;
  }
  public void setCustomAreaHeight(Integer customAreaHeight) {
    this.customAreaHeight = customAreaHeight;
  }

  
  /**
   * Default value: WholePage
   **/
  public BarcodeReaderOptionsVm scanArea(ScanAreaEnum scanArea) {
    this.scanArea = scanArea;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: WholePage")
  @JsonProperty("scanArea")
  public ScanAreaEnum getScanArea() {
    return scanArea;
  }
  public void setScanArea(ScanAreaEnum scanArea) {
    this.scanArea = scanArea;
  }

  
  /**
   * Default value: All = true
   **/
  public BarcodeReaderOptionsVm barcodeTypesToFind(BarcodeTypeSelector barcodeTypesToFind) {
    this.barcodeTypesToFind = barcodeTypesToFind;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: All = true")
  @JsonProperty("barcodeTypesToFind")
  public BarcodeTypeSelector getBarcodeTypesToFind() {
    return barcodeTypesToFind;
  }
  public void setBarcodeTypesToFind(BarcodeTypeSelector barcodeTypesToFind) {
    this.barcodeTypesToFind = barcodeTypesToFind;
  }

  
  /**
   * Default value: Default
   **/
  public BarcodeReaderOptionsVm orientation(OrientationEnum orientation) {
    this.orientation = orientation;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Default")
  @JsonProperty("orientation")
  public OrientationEnum getOrientation() {
    return orientation;
  }
  public void setOrientation(OrientationEnum orientation) {
    this.orientation = orientation;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeReaderOptionsVm searchNegative(Boolean searchNegative) {
    this.searchNegative = searchNegative;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("searchNegative")
  public Boolean getSearchNegative() {
    return searchNegative;
  }
  public void setSearchNegative(Boolean searchNegative) {
    this.searchNegative = searchNegative;
  }

  
  /**
   * Default value: True
   **/
  public BarcodeReaderOptionsVm requireQuietZones(Boolean requireQuietZones) {
    this.requireQuietZones = requireQuietZones;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("requireQuietZones")
  public Boolean getRequireQuietZones() {
    return requireQuietZones;
  }
  public void setRequireQuietZones(Boolean requireQuietZones) {
    this.requireQuietZones = requireQuietZones;
  }

  
  /**
   * Default value: 0
   **/
  public BarcodeReaderOptionsVm maxNumberOfBarcodesPerPage(Integer maxNumberOfBarcodesPerPage) {
    this.maxNumberOfBarcodesPerPage = maxNumberOfBarcodesPerPage;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 0")
  @JsonProperty("maxNumberOfBarcodesPerPage")
  public Integer getMaxNumberOfBarcodesPerPage() {
    return maxNumberOfBarcodesPerPage;
  }
  public void setMaxNumberOfBarcodesPerPage(Integer maxNumberOfBarcodesPerPage) {
    this.maxNumberOfBarcodesPerPage = maxNumberOfBarcodesPerPage;
  }

  
  /**
   * Default value: 10000 (10 seconds)
   **/
  public BarcodeReaderOptionsVm decodingTimeOut(Integer decodingTimeOut) {
    this.decodingTimeOut = decodingTimeOut;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 10000 (10 seconds)")
  @JsonProperty("decodingTimeOut")
  public Integer getDecodingTimeOut() {
    return decodingTimeOut;
  }
  public void setDecodingTimeOut(Integer decodingTimeOut) {
    this.decodingTimeOut = decodingTimeOut;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeReaderOptionsVm lastDecodingTimeOutExceeded(Boolean lastDecodingTimeOutExceeded) {
    this.lastDecodingTimeOutExceeded = lastDecodingTimeOutExceeded;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("lastDecodingTimeOutExceeded")
  public Boolean getLastDecodingTimeOutExceeded() {
    return lastDecodingTimeOutExceeded;
  }
  public void setLastDecodingTimeOutExceeded(Boolean lastDecodingTimeOutExceeded) {
    this.lastDecodingTimeOutExceeded = lastDecodingTimeOutExceeded;
  }

  
  /**
   * Default value: 0
   **/
  public BarcodeReaderOptionsVm maxNumberOfBarcodesPerDocument(Integer maxNumberOfBarcodesPerDocument) {
    this.maxNumberOfBarcodesPerDocument = maxNumberOfBarcodesPerDocument;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 0")
  @JsonProperty("maxNumberOfBarcodesPerDocument")
  public Integer getMaxNumberOfBarcodesPerDocument() {
    return maxNumberOfBarcodesPerDocument;
  }
  public void setMaxNumberOfBarcodesPerDocument(Integer maxNumberOfBarcodesPerDocument) {
    this.maxNumberOfBarcodesPerDocument = maxNumberOfBarcodesPerDocument;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeReaderOptionsVm allowOrphanedSupplementals(Boolean allowOrphanedSupplementals) {
    this.allowOrphanedSupplementals = allowOrphanedSupplementals;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("allowOrphanedSupplementals")
  public Boolean getAllowOrphanedSupplementals() {
    return allowOrphanedSupplementals;
  }
  public void setAllowOrphanedSupplementals(Boolean allowOrphanedSupplementals) {
    this.allowOrphanedSupplementals = allowOrphanedSupplementals;
  }

  
  /**
   * Default value: 0
   **/
  public BarcodeReaderOptionsVm minimalDataLength(Integer minimalDataLength) {
    this.minimalDataLength = minimalDataLength;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 0")
  @JsonProperty("minimalDataLength")
  public Integer getMinimalDataLength() {
    return minimalDataLength;
  }
  public void setMinimalDataLength(Integer minimalDataLength) {
    this.minimalDataLength = minimalDataLength;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeReaderOptionsVm mediumTrustLevelCompatible(Boolean mediumTrustLevelCompatible) {
    this.mediumTrustLevelCompatible = mediumTrustLevelCompatible;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("mediumTrustLevelCompatible")
  public Boolean getMediumTrustLevelCompatible() {
    return mediumTrustLevelCompatible;
  }
  public void setMediumTrustLevelCompatible(Boolean mediumTrustLevelCompatible) {
    this.mediumTrustLevelCompatible = mediumTrustLevelCompatible;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeReaderOptionsVm optimizedProcessingOfLargeImages(Boolean optimizedProcessingOfLargeImages) {
    this.optimizedProcessingOfLargeImages = optimizedProcessingOfLargeImages;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("optimizedProcessingOfLargeImages")
  public Boolean getOptimizedProcessingOfLargeImages() {
    return optimizedProcessingOfLargeImages;
  }
  public void setOptimizedProcessingOfLargeImages(Boolean optimizedProcessingOfLargeImages) {
    this.optimizedProcessingOfLargeImages = optimizedProcessingOfLargeImages;
  }

  
  /**
   * Default value: 1600
   **/
  public BarcodeReaderOptionsVm optimizedProcessingOfLargeImagesSizeLimit(Integer optimizedProcessingOfLargeImagesSizeLimit) {
    this.optimizedProcessingOfLargeImagesSizeLimit = optimizedProcessingOfLargeImagesSizeLimit;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 1600")
  @JsonProperty("optimizedProcessingOfLargeImagesSizeLimit")
  public Integer getOptimizedProcessingOfLargeImagesSizeLimit() {
    return optimizedProcessingOfLargeImagesSizeLimit;
  }
  public void setOptimizedProcessingOfLargeImagesSizeLimit(Integer optimizedProcessingOfLargeImagesSizeLimit) {
    this.optimizedProcessingOfLargeImagesSizeLimit = optimizedProcessingOfLargeImagesSizeLimit;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeReaderOptionsVm removeNoize(Boolean removeNoize) {
    this.removeNoize = removeNoize;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("removeNoize")
  public Boolean getRemoveNoize() {
    return removeNoize;
  }
  public void setRemoveNoize(Boolean removeNoize) {
    this.removeNoize = removeNoize;
  }

  
  /**
   * Default value: 2
   **/
  public BarcodeReaderOptionsVm noiseRemovalFilterSize(Integer noiseRemovalFilterSize) {
    this.noiseRemovalFilterSize = noiseRemovalFilterSize;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 2")
  @JsonProperty("noiseRemovalFilterSize")
  public Integer getNoiseRemovalFilterSize() {
    return noiseRemovalFilterSize;
  }
  public void setNoiseRemovalFilterSize(Integer noiseRemovalFilterSize) {
    this.noiseRemovalFilterSize = noiseRemovalFilterSize;
  }

  
  /**
   * Default value: Blur
   **/
  public BarcodeReaderOptionsVm noiseRemovalFilterType(NoiseRemovalFilterTypeEnum noiseRemovalFilterType) {
    this.noiseRemovalFilterType = noiseRemovalFilterType;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Blur")
  @JsonProperty("noiseRemovalFilterType")
  public NoiseRemovalFilterTypeEnum getNoiseRemovalFilterType() {
    return noiseRemovalFilterType;
  }
  public void setNoiseRemovalFilterType(NoiseRemovalFilterTypeEnum noiseRemovalFilterType) {
    this.noiseRemovalFilterType = noiseRemovalFilterType;
  }

  
  /**
   * Default value: ImageBlocks
   **/
  public BarcodeReaderOptionsVm colorConversionMode(ColorConversionModeEnum colorConversionMode) {
    this.colorConversionMode = colorConversionMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: ImageBlocks")
  @JsonProperty("colorConversionMode")
  public ColorConversionModeEnum getColorConversionMode() {
    return colorConversionMode;
  }
  public void setColorConversionMode(ColorConversionModeEnum colorConversionMode) {
    this.colorConversionMode = colorConversionMode;
  }

  
  /**
   * Default value: 0
   **/
  public BarcodeReaderOptionsVm contrast(Integer contrast) {
    this.contrast = contrast;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 0")
  @JsonProperty("contrast")
  public Integer getContrast() {
    return contrast;
  }
  public void setContrast(Integer contrast) {
    this.contrast = contrast;
  }

  
  /**
   * Default value: Default
   **/
  public BarcodeReaderOptionsVm textEncoding(TextEncodingEnum textEncoding) {
    this.textEncoding = textEncoding;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Default")
  @JsonProperty("textEncoding")
  public TextEncodingEnum getTextEncoding() {
    return textEncoding;
  }
  public void setTextEncoding(TextEncodingEnum textEncoding) {
    this.textEncoding = textEncoding;
  }

  
  /**
   * Default value: 28591
   **/
  public BarcodeReaderOptionsVm textEncodingCodePage(Integer textEncodingCodePage) {
    this.textEncodingCodePage = textEncodingCodePage;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 28591")
  @JsonProperty("textEncodingCodePage")
  public Integer getTextEncodingCodePage() {
    return textEncodingCodePage;
  }
  public void setTextEncodingCodePage(Integer textEncodingCodePage) {
    this.textEncodingCodePage = textEncodingCodePage;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeReaderOptionsVm textEncodingUseUTF8(Boolean textEncodingUseUTF8) {
    this.textEncodingUseUTF8 = textEncodingUseUTF8;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("textEncodingUseUTF8")
  public Boolean getTextEncodingUseUTF8() {
    return textEncodingUseUTF8;
  }
  public void setTextEncodingUseUTF8(Boolean textEncodingUseUTF8) {
    this.textEncodingUseUTF8 = textEncodingUseUTF8;
  }

  
  /**
   * Default value: RenderPDF
   **/
  public BarcodeReaderOptionsVm pdfReadingMode(PdfReadingModeEnum pdfReadingMode) {
    this.pdfReadingMode = pdfReadingMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: RenderPDF")
  @JsonProperty("pdfReadingMode")
  public PdfReadingModeEnum getPdfReadingMode() {
    return pdfReadingMode;
  }
  public void setPdfReadingMode(PdfReadingModeEnum pdfReadingMode) {
    this.pdfReadingMode = pdfReadingMode;
  }

  
  /**
   * Default value: 300
   **/
  public BarcodeReaderOptionsVm pdfRenderingResolution(Integer pdfRenderingResolution) {
    this.pdfRenderingResolution = pdfRenderingResolution;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 300")
  @JsonProperty("pdfRenderingResolution")
  public Integer getPdfRenderingResolution() {
    return pdfRenderingResolution;
  }
  public void setPdfRenderingResolution(Integer pdfRenderingResolution) {
    this.pdfRenderingResolution = pdfRenderingResolution;
  }

  
  /**
   * Default value: True
   **/
  public BarcodeReaderOptionsVm pdfRenderText(Boolean pdfRenderText) {
    this.pdfRenderText = pdfRenderText;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("pdfRenderText")
  public Boolean getPdfRenderText() {
    return pdfRenderText;
  }
  public void setPdfRenderText(Boolean pdfRenderText) {
    this.pdfRenderText = pdfRenderText;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BarcodeReaderOptionsVm barcodeReaderOptionsVm = (BarcodeReaderOptionsVm) o;
    return Objects.equals(this.startPageIndex, barcodeReaderOptionsVm.startPageIndex) &&
        Objects.equals(this.endPageIndex, barcodeReaderOptionsVm.endPageIndex) &&
        Objects.equals(this.customArea, barcodeReaderOptionsVm.customArea) &&
        Objects.equals(this.customAreaLeft, barcodeReaderOptionsVm.customAreaLeft) &&
        Objects.equals(this.customAreaTop, barcodeReaderOptionsVm.customAreaTop) &&
        Objects.equals(this.customAreaWidth, barcodeReaderOptionsVm.customAreaWidth) &&
        Objects.equals(this.customAreaHeight, barcodeReaderOptionsVm.customAreaHeight) &&
        Objects.equals(this.scanArea, barcodeReaderOptionsVm.scanArea) &&
        Objects.equals(this.barcodeTypesToFind, barcodeReaderOptionsVm.barcodeTypesToFind) &&
        Objects.equals(this.orientation, barcodeReaderOptionsVm.orientation) &&
        Objects.equals(this.searchNegative, barcodeReaderOptionsVm.searchNegative) &&
        Objects.equals(this.requireQuietZones, barcodeReaderOptionsVm.requireQuietZones) &&
        Objects.equals(this.maxNumberOfBarcodesPerPage, barcodeReaderOptionsVm.maxNumberOfBarcodesPerPage) &&
        Objects.equals(this.decodingTimeOut, barcodeReaderOptionsVm.decodingTimeOut) &&
        Objects.equals(this.lastDecodingTimeOutExceeded, barcodeReaderOptionsVm.lastDecodingTimeOutExceeded) &&
        Objects.equals(this.maxNumberOfBarcodesPerDocument, barcodeReaderOptionsVm.maxNumberOfBarcodesPerDocument) &&
        Objects.equals(this.allowOrphanedSupplementals, barcodeReaderOptionsVm.allowOrphanedSupplementals) &&
        Objects.equals(this.minimalDataLength, barcodeReaderOptionsVm.minimalDataLength) &&
        Objects.equals(this.mediumTrustLevelCompatible, barcodeReaderOptionsVm.mediumTrustLevelCompatible) &&
        Objects.equals(this.optimizedProcessingOfLargeImages, barcodeReaderOptionsVm.optimizedProcessingOfLargeImages) &&
        Objects.equals(this.optimizedProcessingOfLargeImagesSizeLimit, barcodeReaderOptionsVm.optimizedProcessingOfLargeImagesSizeLimit) &&
        Objects.equals(this.removeNoize, barcodeReaderOptionsVm.removeNoize) &&
        Objects.equals(this.noiseRemovalFilterSize, barcodeReaderOptionsVm.noiseRemovalFilterSize) &&
        Objects.equals(this.noiseRemovalFilterType, barcodeReaderOptionsVm.noiseRemovalFilterType) &&
        Objects.equals(this.colorConversionMode, barcodeReaderOptionsVm.colorConversionMode) &&
        Objects.equals(this.contrast, barcodeReaderOptionsVm.contrast) &&
        Objects.equals(this.textEncoding, barcodeReaderOptionsVm.textEncoding) &&
        Objects.equals(this.textEncodingCodePage, barcodeReaderOptionsVm.textEncodingCodePage) &&
        Objects.equals(this.textEncodingUseUTF8, barcodeReaderOptionsVm.textEncodingUseUTF8) &&
        Objects.equals(this.pdfReadingMode, barcodeReaderOptionsVm.pdfReadingMode) &&
        Objects.equals(this.pdfRenderingResolution, barcodeReaderOptionsVm.pdfRenderingResolution) &&
        Objects.equals(this.pdfRenderText, barcodeReaderOptionsVm.pdfRenderText);
  }

  @Override
  public int hashCode() {
    return Objects.hash(startPageIndex, endPageIndex, customArea, customAreaLeft, customAreaTop, customAreaWidth, customAreaHeight, scanArea, barcodeTypesToFind, orientation, searchNegative, requireQuietZones, maxNumberOfBarcodesPerPage, decodingTimeOut, lastDecodingTimeOutExceeded, maxNumberOfBarcodesPerDocument, allowOrphanedSupplementals, minimalDataLength, mediumTrustLevelCompatible, optimizedProcessingOfLargeImages, optimizedProcessingOfLargeImagesSizeLimit, removeNoize, noiseRemovalFilterSize, noiseRemovalFilterType, colorConversionMode, contrast, textEncoding, textEncodingCodePage, textEncodingUseUTF8, pdfReadingMode, pdfRenderingResolution, pdfRenderText);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BarcodeReaderOptionsVm {\n");
    
    sb.append("    startPageIndex: ").append(toIndentedString(startPageIndex)).append("\n");
    sb.append("    endPageIndex: ").append(toIndentedString(endPageIndex)).append("\n");
    sb.append("    customArea: ").append(toIndentedString(customArea)).append("\n");
    sb.append("    customAreaLeft: ").append(toIndentedString(customAreaLeft)).append("\n");
    sb.append("    customAreaTop: ").append(toIndentedString(customAreaTop)).append("\n");
    sb.append("    customAreaWidth: ").append(toIndentedString(customAreaWidth)).append("\n");
    sb.append("    customAreaHeight: ").append(toIndentedString(customAreaHeight)).append("\n");
    sb.append("    scanArea: ").append(toIndentedString(scanArea)).append("\n");
    sb.append("    barcodeTypesToFind: ").append(toIndentedString(barcodeTypesToFind)).append("\n");
    sb.append("    orientation: ").append(toIndentedString(orientation)).append("\n");
    sb.append("    searchNegative: ").append(toIndentedString(searchNegative)).append("\n");
    sb.append("    requireQuietZones: ").append(toIndentedString(requireQuietZones)).append("\n");
    sb.append("    maxNumberOfBarcodesPerPage: ").append(toIndentedString(maxNumberOfBarcodesPerPage)).append("\n");
    sb.append("    decodingTimeOut: ").append(toIndentedString(decodingTimeOut)).append("\n");
    sb.append("    lastDecodingTimeOutExceeded: ").append(toIndentedString(lastDecodingTimeOutExceeded)).append("\n");
    sb.append("    maxNumberOfBarcodesPerDocument: ").append(toIndentedString(maxNumberOfBarcodesPerDocument)).append("\n");
    sb.append("    allowOrphanedSupplementals: ").append(toIndentedString(allowOrphanedSupplementals)).append("\n");
    sb.append("    minimalDataLength: ").append(toIndentedString(minimalDataLength)).append("\n");
    sb.append("    mediumTrustLevelCompatible: ").append(toIndentedString(mediumTrustLevelCompatible)).append("\n");
    sb.append("    optimizedProcessingOfLargeImages: ").append(toIndentedString(optimizedProcessingOfLargeImages)).append("\n");
    sb.append("    optimizedProcessingOfLargeImagesSizeLimit: ").append(toIndentedString(optimizedProcessingOfLargeImagesSizeLimit)).append("\n");
    sb.append("    removeNoize: ").append(toIndentedString(removeNoize)).append("\n");
    sb.append("    noiseRemovalFilterSize: ").append(toIndentedString(noiseRemovalFilterSize)).append("\n");
    sb.append("    noiseRemovalFilterType: ").append(toIndentedString(noiseRemovalFilterType)).append("\n");
    sb.append("    colorConversionMode: ").append(toIndentedString(colorConversionMode)).append("\n");
    sb.append("    contrast: ").append(toIndentedString(contrast)).append("\n");
    sb.append("    textEncoding: ").append(toIndentedString(textEncoding)).append("\n");
    sb.append("    textEncodingCodePage: ").append(toIndentedString(textEncodingCodePage)).append("\n");
    sb.append("    textEncodingUseUTF8: ").append(toIndentedString(textEncodingUseUTF8)).append("\n");
    sb.append("    pdfReadingMode: ").append(toIndentedString(pdfReadingMode)).append("\n");
    sb.append("    pdfRenderingResolution: ").append(toIndentedString(pdfRenderingResolution)).append("\n");
    sb.append("    pdfRenderText: ").append(toIndentedString(pdfRenderText)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

