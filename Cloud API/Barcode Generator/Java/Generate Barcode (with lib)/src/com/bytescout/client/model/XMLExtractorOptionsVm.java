package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class XMLExtractorOptionsVm   {
  
  private Integer startPageIndex = null;
  private Integer endPageIndex = null;
  private Double xCoordinateToleranceFactor = null;
  private Double yCoordinateToleranceFactor = null;
  private Integer tableXMinIntersectionRequiredInPercents = null;
  private Integer tableYMinIntersectionRequiredInPercents = null;
  private Boolean rtlTextAutoDetectionEnabled = null;
  private Boolean extractInvisibleText = null;
  private Boolean extractShadowLikeText = null;
  private Boolean unwrap = null;
  private Boolean removeHyphenation = null;
  private Boolean autoAlignColumnsToHeader = null;
  private Boolean preserveFormattingOnTextExtraction = null;
  private Boolean detectLinesInsteadOfParagraphs = null;
  private Boolean trimSpaces = null;
  private Boolean extractColumnByColumn = null;
  private Float detectNewColumnBySpacesRatio = null;


  public enum OcrModeEnum {
    OFF("off"),
    AUTO("auto"),
    TEXTFROMIMAGESANDVECTORSANDFONTS("textFromImagesAndVectorsAndFonts"),
    TEXTFROMIMAGESANDVECTORSANDREPAIREDFONTS("textFromImagesAndVectorsAndRepairedFonts"),
    TEXTFROMREPAIREDFONTSONLY("textFromRepairedFontsOnly"),
    TEXTFROMIMAGESANDREPAIREDFONTS("textFromImagesAndRepairedFonts"),
    TEXTFROMIMAGESANDFONTS("textFromImagesAndFonts"),
    TEXTFROMIMAGESONLY("textFromImagesOnly"),
    TEXTFROMVECTORSONLY("textFromVectorsOnly"),
    TEXTFROMIMAGESANDVECTORSONLY("textFromImagesAndVectorsOnly");

    private String value;

    OcrModeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private OcrModeEnum ocrMode = null;


  public enum LineGroupingModeEnum {
    NONE("none"),
    GROUPBYROWS("groupByRows"),
    GROUPBYCOLUMNS("groupByColumns");

    private String value;

    LineGroupingModeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private LineGroupingModeEnum lineGroupingMode = null;


  public enum ColumnDetectionModeEnum {
    CONTENTGROUPSANDBORDERS("contentGroupsAndBorders"),
    CONTENTGROUPS("contentGroups"),
    BORDERS("borders"),
    BORDEREDTABLES("borderedTables");

    private String value;

    ColumnDetectionModeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private ColumnDetectionModeEnum columnDetectionMode = null;


  public enum OcrCacheModeEnum {
    OFF("off"),
    WHOLEPAGE("wholePage");

    private String value;

    OcrCacheModeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private OcrCacheModeEnum ocrCacheMode = null;
  private String ocrLanguage = null;
  private Float ocrResolution = null;
  private Integer textEncodingCodePage = null;
  private Boolean considerFontNames = null;
  private Boolean considerFontSizes = null;
  private Boolean considerFontColors = null;
  private Boolean considerVerticalBorders = null;
  private String password = null;
  private Boolean checkPermissions = null;


  public enum ExtractionAreaUsageModeEnum {
    USEALLINTERSECTINGOBJECTS("useAllIntersectingObjects"),
    USEOBJECTSCOMPETELYINSIDEAREAONLY("useObjectsCompetelyInsideAreaOnly");

    private String value;

    ExtractionAreaUsageModeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private ExtractionAreaUsageModeEnum extractionAreaUsageMode = null;

  
  /**
   * Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages
   **/
  public XMLExtractorOptionsVm startPageIndex(Integer startPageIndex) {
    this.startPageIndex = startPageIndex;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages")
  @JsonProperty("startPageIndex")
  public Integer getStartPageIndex() {
    return startPageIndex;
  }
  public void setStartPageIndex(Integer startPageIndex) {
    this.startPageIndex = startPageIndex;
  }

  
  /**
   * Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages
   **/
  public XMLExtractorOptionsVm endPageIndex(Integer endPageIndex) {
    this.endPageIndex = endPageIndex;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Index of a page (zero-based) on which extracting of data will be finished.\r\n            Default value: all pages")
  @JsonProperty("endPageIndex")
  public Integer getEndPageIndex() {
    return endPageIndex;
  }
  public void setEndPageIndex(Integer endPageIndex) {
    this.endPageIndex = endPageIndex;
  }

  
  /**
   * Default value: 20
   **/
  public XMLExtractorOptionsVm xCoordinateToleranceFactor(Double xCoordinateToleranceFactor) {
    this.xCoordinateToleranceFactor = xCoordinateToleranceFactor;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 20")
  @JsonProperty("xCoordinateToleranceFactor")
  public Double getXCoordinateToleranceFactor() {
    return xCoordinateToleranceFactor;
  }
  public void setXCoordinateToleranceFactor(Double xCoordinateToleranceFactor) {
    this.xCoordinateToleranceFactor = xCoordinateToleranceFactor;
  }

  
  /**
   * Default value: 30
   **/
  public XMLExtractorOptionsVm yCoordinateToleranceFactor(Double yCoordinateToleranceFactor) {
    this.yCoordinateToleranceFactor = yCoordinateToleranceFactor;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 30")
  @JsonProperty("yCoordinateToleranceFactor")
  public Double getYCoordinateToleranceFactor() {
    return yCoordinateToleranceFactor;
  }
  public void setYCoordinateToleranceFactor(Double yCoordinateToleranceFactor) {
    this.yCoordinateToleranceFactor = yCoordinateToleranceFactor;
  }

  
  /**
   * Default value: 49
   **/
  public XMLExtractorOptionsVm tableXMinIntersectionRequiredInPercents(Integer tableXMinIntersectionRequiredInPercents) {
    this.tableXMinIntersectionRequiredInPercents = tableXMinIntersectionRequiredInPercents;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 49")
  @JsonProperty("tableXMinIntersectionRequiredInPercents")
  public Integer getTableXMinIntersectionRequiredInPercents() {
    return tableXMinIntersectionRequiredInPercents;
  }
  public void setTableXMinIntersectionRequiredInPercents(Integer tableXMinIntersectionRequiredInPercents) {
    this.tableXMinIntersectionRequiredInPercents = tableXMinIntersectionRequiredInPercents;
  }

  
  /**
   * Default value: 50
   **/
  public XMLExtractorOptionsVm tableYMinIntersectionRequiredInPercents(Integer tableYMinIntersectionRequiredInPercents) {
    this.tableYMinIntersectionRequiredInPercents = tableYMinIntersectionRequiredInPercents;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 50")
  @JsonProperty("tableYMinIntersectionRequiredInPercents")
  public Integer getTableYMinIntersectionRequiredInPercents() {
    return tableYMinIntersectionRequiredInPercents;
  }
  public void setTableYMinIntersectionRequiredInPercents(Integer tableYMinIntersectionRequiredInPercents) {
    this.tableYMinIntersectionRequiredInPercents = tableYMinIntersectionRequiredInPercents;
  }

  
  /**
   * Default value: False
   **/
  public XMLExtractorOptionsVm rtlTextAutoDetectionEnabled(Boolean rtlTextAutoDetectionEnabled) {
    this.rtlTextAutoDetectionEnabled = rtlTextAutoDetectionEnabled;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("rtlTextAutoDetectionEnabled")
  public Boolean getRtlTextAutoDetectionEnabled() {
    return rtlTextAutoDetectionEnabled;
  }
  public void setRtlTextAutoDetectionEnabled(Boolean rtlTextAutoDetectionEnabled) {
    this.rtlTextAutoDetectionEnabled = rtlTextAutoDetectionEnabled;
  }

  
  /**
   * Default value: True
   **/
  public XMLExtractorOptionsVm extractInvisibleText(Boolean extractInvisibleText) {
    this.extractInvisibleText = extractInvisibleText;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("extractInvisibleText")
  public Boolean getExtractInvisibleText() {
    return extractInvisibleText;
  }
  public void setExtractInvisibleText(Boolean extractInvisibleText) {
    this.extractInvisibleText = extractInvisibleText;
  }

  
  /**
   * Default value: True
   **/
  public XMLExtractorOptionsVm extractShadowLikeText(Boolean extractShadowLikeText) {
    this.extractShadowLikeText = extractShadowLikeText;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("extractShadowLikeText")
  public Boolean getExtractShadowLikeText() {
    return extractShadowLikeText;
  }
  public void setExtractShadowLikeText(Boolean extractShadowLikeText) {
    this.extractShadowLikeText = extractShadowLikeText;
  }

  
  /**
   * Default value: False
   **/
  public XMLExtractorOptionsVm unwrap(Boolean unwrap) {
    this.unwrap = unwrap;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("unwrap")
  public Boolean getUnwrap() {
    return unwrap;
  }
  public void setUnwrap(Boolean unwrap) {
    this.unwrap = unwrap;
  }

  
  /**
   * Default value: True
   **/
  public XMLExtractorOptionsVm removeHyphenation(Boolean removeHyphenation) {
    this.removeHyphenation = removeHyphenation;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("removeHyphenation")
  public Boolean getRemoveHyphenation() {
    return removeHyphenation;
  }
  public void setRemoveHyphenation(Boolean removeHyphenation) {
    this.removeHyphenation = removeHyphenation;
  }

  
  /**
   * Default value: True
   **/
  public XMLExtractorOptionsVm autoAlignColumnsToHeader(Boolean autoAlignColumnsToHeader) {
    this.autoAlignColumnsToHeader = autoAlignColumnsToHeader;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("autoAlignColumnsToHeader")
  public Boolean getAutoAlignColumnsToHeader() {
    return autoAlignColumnsToHeader;
  }
  public void setAutoAlignColumnsToHeader(Boolean autoAlignColumnsToHeader) {
    this.autoAlignColumnsToHeader = autoAlignColumnsToHeader;
  }

  
  /**
   * Value indicating whether to preserve the text formatting on the extraction.\r\n            Default value: True
   **/
  public XMLExtractorOptionsVm preserveFormattingOnTextExtraction(Boolean preserveFormattingOnTextExtraction) {
    this.preserveFormattingOnTextExtraction = preserveFormattingOnTextExtraction;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Value indicating whether to preserve the text formatting on the extraction.\r\n            Default value: True")
  @JsonProperty("preserveFormattingOnTextExtraction")
  public Boolean getPreserveFormattingOnTextExtraction() {
    return preserveFormattingOnTextExtraction;
  }
  public void setPreserveFormattingOnTextExtraction(Boolean preserveFormattingOnTextExtraction) {
    this.preserveFormattingOnTextExtraction = preserveFormattingOnTextExtraction;
  }

  
  /**
   * Default value: True
   **/
  public XMLExtractorOptionsVm detectLinesInsteadOfParagraphs(Boolean detectLinesInsteadOfParagraphs) {
    this.detectLinesInsteadOfParagraphs = detectLinesInsteadOfParagraphs;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("detectLinesInsteadOfParagraphs")
  public Boolean getDetectLinesInsteadOfParagraphs() {
    return detectLinesInsteadOfParagraphs;
  }
  public void setDetectLinesInsteadOfParagraphs(Boolean detectLinesInsteadOfParagraphs) {
    this.detectLinesInsteadOfParagraphs = detectLinesInsteadOfParagraphs;
  }

  
  /**
   * Default value: True
   **/
  public XMLExtractorOptionsVm trimSpaces(Boolean trimSpaces) {
    this.trimSpaces = trimSpaces;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("trimSpaces")
  public Boolean getTrimSpaces() {
    return trimSpaces;
  }
  public void setTrimSpaces(Boolean trimSpaces) {
    this.trimSpaces = trimSpaces;
  }

  
  /**
   * Default value: False
   **/
  public XMLExtractorOptionsVm extractColumnByColumn(Boolean extractColumnByColumn) {
    this.extractColumnByColumn = extractColumnByColumn;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("extractColumnByColumn")
  public Boolean getExtractColumnByColumn() {
    return extractColumnByColumn;
  }
  public void setExtractColumnByColumn(Boolean extractColumnByColumn) {
    this.extractColumnByColumn = extractColumnByColumn;
  }

  
  /**
   * Space ratio between words.\r\n            Default value: 1
   **/
  public XMLExtractorOptionsVm detectNewColumnBySpacesRatio(Float detectNewColumnBySpacesRatio) {
    this.detectNewColumnBySpacesRatio = detectNewColumnBySpacesRatio;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Space ratio between words.\r\n            Default value: 1")
  @JsonProperty("detectNewColumnBySpacesRatio")
  public Float getDetectNewColumnBySpacesRatio() {
    return detectNewColumnBySpacesRatio;
  }
  public void setDetectNewColumnBySpacesRatio(Float detectNewColumnBySpacesRatio) {
    this.detectNewColumnBySpacesRatio = detectNewColumnBySpacesRatio;
  }

  
  /**
   * Default value: Off
   **/
  public XMLExtractorOptionsVm ocrMode(OcrModeEnum ocrMode) {
    this.ocrMode = ocrMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Off")
  @JsonProperty("ocrMode")
  public OcrModeEnum getOcrMode() {
    return ocrMode;
  }
  public void setOcrMode(OcrModeEnum ocrMode) {
    this.ocrMode = ocrMode;
  }

  
  /**
   * Default value: None
   **/
  public XMLExtractorOptionsVm lineGroupingMode(LineGroupingModeEnum lineGroupingMode) {
    this.lineGroupingMode = lineGroupingMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: None")
  @JsonProperty("lineGroupingMode")
  public LineGroupingModeEnum getLineGroupingMode() {
    return lineGroupingMode;
  }
  public void setLineGroupingMode(LineGroupingModeEnum lineGroupingMode) {
    this.lineGroupingMode = lineGroupingMode;
  }

  
  /**
   * Default value: ContentGroupsAndBorders
   **/
  public XMLExtractorOptionsVm columnDetectionMode(ColumnDetectionModeEnum columnDetectionMode) {
    this.columnDetectionMode = columnDetectionMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: ContentGroupsAndBorders")
  @JsonProperty("columnDetectionMode")
  public ColumnDetectionModeEnum getColumnDetectionMode() {
    return columnDetectionMode;
  }
  public void setColumnDetectionMode(ColumnDetectionModeEnum columnDetectionMode) {
    this.columnDetectionMode = columnDetectionMode;
  }

  
  /**
   * Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off
   **/
  public XMLExtractorOptionsVm ocrCacheMode(OcrCacheModeEnum ocrCacheMode) {
    this.ocrCacheMode = ocrCacheMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off")
  @JsonProperty("ocrCacheMode")
  public OcrCacheModeEnum getOcrCacheMode() {
    return ocrCacheMode;
  }
  public void setOcrCacheMode(OcrCacheModeEnum ocrCacheMode) {
    this.ocrCacheMode = ocrCacheMode;
  }

  
  /**
   * Default value: eng
   **/
  public XMLExtractorOptionsVm ocrLanguage(String ocrLanguage) {
    this.ocrLanguage = ocrLanguage;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: eng")
  @JsonProperty("ocrLanguage")
  public String getOcrLanguage() {
    return ocrLanguage;
  }
  public void setOcrLanguage(String ocrLanguage) {
    this.ocrLanguage = ocrLanguage;
  }

  
  /**
   * Default value: 300
   **/
  public XMLExtractorOptionsVm ocrResolution(Float ocrResolution) {
    this.ocrResolution = ocrResolution;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 300")
  @JsonProperty("ocrResolution")
  public Float getOcrResolution() {
    return ocrResolution;
  }
  public void setOcrResolution(Float ocrResolution) {
    this.ocrResolution = ocrResolution;
  }

  
  /**
   * Default value: 1252
   **/
  public XMLExtractorOptionsVm textEncodingCodePage(Integer textEncodingCodePage) {
    this.textEncodingCodePage = textEncodingCodePage;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 1252")
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
  public XMLExtractorOptionsVm considerFontNames(Boolean considerFontNames) {
    this.considerFontNames = considerFontNames;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("considerFontNames")
  public Boolean getConsiderFontNames() {
    return considerFontNames;
  }
  public void setConsiderFontNames(Boolean considerFontNames) {
    this.considerFontNames = considerFontNames;
  }

  
  /**
   * Default value: False
   **/
  public XMLExtractorOptionsVm considerFontSizes(Boolean considerFontSizes) {
    this.considerFontSizes = considerFontSizes;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("considerFontSizes")
  public Boolean getConsiderFontSizes() {
    return considerFontSizes;
  }
  public void setConsiderFontSizes(Boolean considerFontSizes) {
    this.considerFontSizes = considerFontSizes;
  }

  
  /**
   * Default value: False
   **/
  public XMLExtractorOptionsVm considerFontColors(Boolean considerFontColors) {
    this.considerFontColors = considerFontColors;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("considerFontColors")
  public Boolean getConsiderFontColors() {
    return considerFontColors;
  }
  public void setConsiderFontColors(Boolean considerFontColors) {
    this.considerFontColors = considerFontColors;
  }

  
  /**
   * Default value: True
   **/
  public XMLExtractorOptionsVm considerVerticalBorders(Boolean considerVerticalBorders) {
    this.considerVerticalBorders = considerVerticalBorders;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("considerVerticalBorders")
  public Boolean getConsiderVerticalBorders() {
    return considerVerticalBorders;
  }
  public void setConsiderVerticalBorders(Boolean considerVerticalBorders) {
    this.considerVerticalBorders = considerVerticalBorders;
  }

  
  /**
   * Default value:
   **/
  public XMLExtractorOptionsVm password(String password) {
    this.password = password;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value:")
  @JsonProperty("password")
  public String getPassword() {
    return password;
  }
  public void setPassword(String password) {
    this.password = password;
  }

  
  /**
   * Default value: True
   **/
  public XMLExtractorOptionsVm checkPermissions(Boolean checkPermissions) {
    this.checkPermissions = checkPermissions;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("checkPermissions")
  public Boolean getCheckPermissions() {
    return checkPermissions;
  }
  public void setCheckPermissions(Boolean checkPermissions) {
    this.checkPermissions = checkPermissions;
  }

  
  /**
   * Default value: UseAllIntersectingObjects
   **/
  public XMLExtractorOptionsVm extractionAreaUsageMode(ExtractionAreaUsageModeEnum extractionAreaUsageMode) {
    this.extractionAreaUsageMode = extractionAreaUsageMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: UseAllIntersectingObjects")
  @JsonProperty("extractionAreaUsageMode")
  public ExtractionAreaUsageModeEnum getExtractionAreaUsageMode() {
    return extractionAreaUsageMode;
  }
  public void setExtractionAreaUsageMode(ExtractionAreaUsageModeEnum extractionAreaUsageMode) {
    this.extractionAreaUsageMode = extractionAreaUsageMode;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    XMLExtractorOptionsVm xMLExtractorOptionsVm = (XMLExtractorOptionsVm) o;
    return Objects.equals(this.startPageIndex, xMLExtractorOptionsVm.startPageIndex) &&
        Objects.equals(this.endPageIndex, xMLExtractorOptionsVm.endPageIndex) &&
        Objects.equals(this.xCoordinateToleranceFactor, xMLExtractorOptionsVm.xCoordinateToleranceFactor) &&
        Objects.equals(this.yCoordinateToleranceFactor, xMLExtractorOptionsVm.yCoordinateToleranceFactor) &&
        Objects.equals(this.tableXMinIntersectionRequiredInPercents, xMLExtractorOptionsVm.tableXMinIntersectionRequiredInPercents) &&
        Objects.equals(this.tableYMinIntersectionRequiredInPercents, xMLExtractorOptionsVm.tableYMinIntersectionRequiredInPercents) &&
        Objects.equals(this.rtlTextAutoDetectionEnabled, xMLExtractorOptionsVm.rtlTextAutoDetectionEnabled) &&
        Objects.equals(this.extractInvisibleText, xMLExtractorOptionsVm.extractInvisibleText) &&
        Objects.equals(this.extractShadowLikeText, xMLExtractorOptionsVm.extractShadowLikeText) &&
        Objects.equals(this.unwrap, xMLExtractorOptionsVm.unwrap) &&
        Objects.equals(this.removeHyphenation, xMLExtractorOptionsVm.removeHyphenation) &&
        Objects.equals(this.autoAlignColumnsToHeader, xMLExtractorOptionsVm.autoAlignColumnsToHeader) &&
        Objects.equals(this.preserveFormattingOnTextExtraction, xMLExtractorOptionsVm.preserveFormattingOnTextExtraction) &&
        Objects.equals(this.detectLinesInsteadOfParagraphs, xMLExtractorOptionsVm.detectLinesInsteadOfParagraphs) &&
        Objects.equals(this.trimSpaces, xMLExtractorOptionsVm.trimSpaces) &&
        Objects.equals(this.extractColumnByColumn, xMLExtractorOptionsVm.extractColumnByColumn) &&
        Objects.equals(this.detectNewColumnBySpacesRatio, xMLExtractorOptionsVm.detectNewColumnBySpacesRatio) &&
        Objects.equals(this.ocrMode, xMLExtractorOptionsVm.ocrMode) &&
        Objects.equals(this.lineGroupingMode, xMLExtractorOptionsVm.lineGroupingMode) &&
        Objects.equals(this.columnDetectionMode, xMLExtractorOptionsVm.columnDetectionMode) &&
        Objects.equals(this.ocrCacheMode, xMLExtractorOptionsVm.ocrCacheMode) &&
        Objects.equals(this.ocrLanguage, xMLExtractorOptionsVm.ocrLanguage) &&
        Objects.equals(this.ocrResolution, xMLExtractorOptionsVm.ocrResolution) &&
        Objects.equals(this.textEncodingCodePage, xMLExtractorOptionsVm.textEncodingCodePage) &&
        Objects.equals(this.considerFontNames, xMLExtractorOptionsVm.considerFontNames) &&
        Objects.equals(this.considerFontSizes, xMLExtractorOptionsVm.considerFontSizes) &&
        Objects.equals(this.considerFontColors, xMLExtractorOptionsVm.considerFontColors) &&
        Objects.equals(this.considerVerticalBorders, xMLExtractorOptionsVm.considerVerticalBorders) &&
        Objects.equals(this.password, xMLExtractorOptionsVm.password) &&
        Objects.equals(this.checkPermissions, xMLExtractorOptionsVm.checkPermissions) &&
        Objects.equals(this.extractionAreaUsageMode, xMLExtractorOptionsVm.extractionAreaUsageMode);
  }

  @Override
  public int hashCode() {
    return Objects.hash(startPageIndex, endPageIndex, xCoordinateToleranceFactor, yCoordinateToleranceFactor, tableXMinIntersectionRequiredInPercents, tableYMinIntersectionRequiredInPercents, rtlTextAutoDetectionEnabled, extractInvisibleText, extractShadowLikeText, unwrap, removeHyphenation, autoAlignColumnsToHeader, preserveFormattingOnTextExtraction, detectLinesInsteadOfParagraphs, trimSpaces, extractColumnByColumn, detectNewColumnBySpacesRatio, ocrMode, lineGroupingMode, columnDetectionMode, ocrCacheMode, ocrLanguage, ocrResolution, textEncodingCodePage, considerFontNames, considerFontSizes, considerFontColors, considerVerticalBorders, password, checkPermissions, extractionAreaUsageMode);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class XMLExtractorOptionsVm {\n");
    
    sb.append("    startPageIndex: ").append(toIndentedString(startPageIndex)).append("\n");
    sb.append("    endPageIndex: ").append(toIndentedString(endPageIndex)).append("\n");
    sb.append("    xCoordinateToleranceFactor: ").append(toIndentedString(xCoordinateToleranceFactor)).append("\n");
    sb.append("    yCoordinateToleranceFactor: ").append(toIndentedString(yCoordinateToleranceFactor)).append("\n");
    sb.append("    tableXMinIntersectionRequiredInPercents: ").append(toIndentedString(tableXMinIntersectionRequiredInPercents)).append("\n");
    sb.append("    tableYMinIntersectionRequiredInPercents: ").append(toIndentedString(tableYMinIntersectionRequiredInPercents)).append("\n");
    sb.append("    rtlTextAutoDetectionEnabled: ").append(toIndentedString(rtlTextAutoDetectionEnabled)).append("\n");
    sb.append("    extractInvisibleText: ").append(toIndentedString(extractInvisibleText)).append("\n");
    sb.append("    extractShadowLikeText: ").append(toIndentedString(extractShadowLikeText)).append("\n");
    sb.append("    unwrap: ").append(toIndentedString(unwrap)).append("\n");
    sb.append("    removeHyphenation: ").append(toIndentedString(removeHyphenation)).append("\n");
    sb.append("    autoAlignColumnsToHeader: ").append(toIndentedString(autoAlignColumnsToHeader)).append("\n");
    sb.append("    preserveFormattingOnTextExtraction: ").append(toIndentedString(preserveFormattingOnTextExtraction)).append("\n");
    sb.append("    detectLinesInsteadOfParagraphs: ").append(toIndentedString(detectLinesInsteadOfParagraphs)).append("\n");
    sb.append("    trimSpaces: ").append(toIndentedString(trimSpaces)).append("\n");
    sb.append("    extractColumnByColumn: ").append(toIndentedString(extractColumnByColumn)).append("\n");
    sb.append("    detectNewColumnBySpacesRatio: ").append(toIndentedString(detectNewColumnBySpacesRatio)).append("\n");
    sb.append("    ocrMode: ").append(toIndentedString(ocrMode)).append("\n");
    sb.append("    lineGroupingMode: ").append(toIndentedString(lineGroupingMode)).append("\n");
    sb.append("    columnDetectionMode: ").append(toIndentedString(columnDetectionMode)).append("\n");
    sb.append("    ocrCacheMode: ").append(toIndentedString(ocrCacheMode)).append("\n");
    sb.append("    ocrLanguage: ").append(toIndentedString(ocrLanguage)).append("\n");
    sb.append("    ocrResolution: ").append(toIndentedString(ocrResolution)).append("\n");
    sb.append("    textEncodingCodePage: ").append(toIndentedString(textEncodingCodePage)).append("\n");
    sb.append("    considerFontNames: ").append(toIndentedString(considerFontNames)).append("\n");
    sb.append("    considerFontSizes: ").append(toIndentedString(considerFontSizes)).append("\n");
    sb.append("    considerFontColors: ").append(toIndentedString(considerFontColors)).append("\n");
    sb.append("    considerVerticalBorders: ").append(toIndentedString(considerVerticalBorders)).append("\n");
    sb.append("    password: ").append(toIndentedString(password)).append("\n");
    sb.append("    checkPermissions: ").append(toIndentedString(checkPermissions)).append("\n");
    sb.append("    extractionAreaUsageMode: ").append(toIndentedString(extractionAreaUsageMode)).append("\n");
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

