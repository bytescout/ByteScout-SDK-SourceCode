package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class CSVExtractorOptionsVm   {
  
  private Integer startPageIndex = null;
  private Integer endPageIndex = null;
  private String csvSeparatorSymbol = null;
  private String csvQuotaionSymbol = null;
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
  public CSVExtractorOptionsVm startPageIndex(Integer startPageIndex) {
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
  public CSVExtractorOptionsVm endPageIndex(Integer endPageIndex) {
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
   * Default value: ,
   **/
  public CSVExtractorOptionsVm csvSeparatorSymbol(String csvSeparatorSymbol) {
    this.csvSeparatorSymbol = csvSeparatorSymbol;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: ,")
  @JsonProperty("csvSeparatorSymbol")
  public String getCsvSeparatorSymbol() {
    return csvSeparatorSymbol;
  }
  public void setCsvSeparatorSymbol(String csvSeparatorSymbol) {
    this.csvSeparatorSymbol = csvSeparatorSymbol;
  }

  
  /**
   * Default value: \"
   **/
  public CSVExtractorOptionsVm csvQuotaionSymbol(String csvQuotaionSymbol) {
    this.csvQuotaionSymbol = csvQuotaionSymbol;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: \"")
  @JsonProperty("csvQuotaionSymbol")
  public String getCsvQuotaionSymbol() {
    return csvQuotaionSymbol;
  }
  public void setCsvQuotaionSymbol(String csvQuotaionSymbol) {
    this.csvQuotaionSymbol = csvQuotaionSymbol;
  }

  
  /**
   * Default value: 20
   **/
  public CSVExtractorOptionsVm xCoordinateToleranceFactor(Double xCoordinateToleranceFactor) {
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
  public CSVExtractorOptionsVm yCoordinateToleranceFactor(Double yCoordinateToleranceFactor) {
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
  public CSVExtractorOptionsVm tableXMinIntersectionRequiredInPercents(Integer tableXMinIntersectionRequiredInPercents) {
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
  public CSVExtractorOptionsVm tableYMinIntersectionRequiredInPercents(Integer tableYMinIntersectionRequiredInPercents) {
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
  public CSVExtractorOptionsVm rtlTextAutoDetectionEnabled(Boolean rtlTextAutoDetectionEnabled) {
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
  public CSVExtractorOptionsVm extractInvisibleText(Boolean extractInvisibleText) {
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
  public CSVExtractorOptionsVm extractShadowLikeText(Boolean extractShadowLikeText) {
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
  public CSVExtractorOptionsVm unwrap(Boolean unwrap) {
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
  public CSVExtractorOptionsVm removeHyphenation(Boolean removeHyphenation) {
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
  public CSVExtractorOptionsVm autoAlignColumnsToHeader(Boolean autoAlignColumnsToHeader) {
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
  public CSVExtractorOptionsVm preserveFormattingOnTextExtraction(Boolean preserveFormattingOnTextExtraction) {
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
  public CSVExtractorOptionsVm detectLinesInsteadOfParagraphs(Boolean detectLinesInsteadOfParagraphs) {
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
  public CSVExtractorOptionsVm trimSpaces(Boolean trimSpaces) {
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
  public CSVExtractorOptionsVm extractColumnByColumn(Boolean extractColumnByColumn) {
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
  public CSVExtractorOptionsVm detectNewColumnBySpacesRatio(Float detectNewColumnBySpacesRatio) {
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
   * Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off
   **/
  public CSVExtractorOptionsVm ocrMode(OcrModeEnum ocrMode) {
    this.ocrMode = ocrMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Recognize text on embedded images using Optical Character Recognition (OCR). Set the language using OCRLanguage property.\r\n            Default value: Off")
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
  public CSVExtractorOptionsVm lineGroupingMode(LineGroupingModeEnum lineGroupingMode) {
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
  public CSVExtractorOptionsVm columnDetectionMode(ColumnDetectionModeEnum columnDetectionMode) {
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
   * Default value: Off
   **/
  public CSVExtractorOptionsVm ocrCacheMode(OcrCacheModeEnum ocrCacheMode) {
    this.ocrCacheMode = ocrCacheMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Off")
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
  public CSVExtractorOptionsVm ocrLanguage(String ocrLanguage) {
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
  public CSVExtractorOptionsVm ocrResolution(Float ocrResolution) {
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
  public CSVExtractorOptionsVm textEncodingCodePage(Integer textEncodingCodePage) {
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
  public CSVExtractorOptionsVm considerFontNames(Boolean considerFontNames) {
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
  public CSVExtractorOptionsVm considerFontSizes(Boolean considerFontSizes) {
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
  public CSVExtractorOptionsVm considerFontColors(Boolean considerFontColors) {
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
  public CSVExtractorOptionsVm considerVerticalBorders(Boolean considerVerticalBorders) {
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
  public CSVExtractorOptionsVm password(String password) {
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
  public CSVExtractorOptionsVm checkPermissions(Boolean checkPermissions) {
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
  public CSVExtractorOptionsVm extractionAreaUsageMode(ExtractionAreaUsageModeEnum extractionAreaUsageMode) {
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
    CSVExtractorOptionsVm cSVExtractorOptionsVm = (CSVExtractorOptionsVm) o;
    return Objects.equals(this.startPageIndex, cSVExtractorOptionsVm.startPageIndex) &&
        Objects.equals(this.endPageIndex, cSVExtractorOptionsVm.endPageIndex) &&
        Objects.equals(this.csvSeparatorSymbol, cSVExtractorOptionsVm.csvSeparatorSymbol) &&
        Objects.equals(this.csvQuotaionSymbol, cSVExtractorOptionsVm.csvQuotaionSymbol) &&
        Objects.equals(this.xCoordinateToleranceFactor, cSVExtractorOptionsVm.xCoordinateToleranceFactor) &&
        Objects.equals(this.yCoordinateToleranceFactor, cSVExtractorOptionsVm.yCoordinateToleranceFactor) &&
        Objects.equals(this.tableXMinIntersectionRequiredInPercents, cSVExtractorOptionsVm.tableXMinIntersectionRequiredInPercents) &&
        Objects.equals(this.tableYMinIntersectionRequiredInPercents, cSVExtractorOptionsVm.tableYMinIntersectionRequiredInPercents) &&
        Objects.equals(this.rtlTextAutoDetectionEnabled, cSVExtractorOptionsVm.rtlTextAutoDetectionEnabled) &&
        Objects.equals(this.extractInvisibleText, cSVExtractorOptionsVm.extractInvisibleText) &&
        Objects.equals(this.extractShadowLikeText, cSVExtractorOptionsVm.extractShadowLikeText) &&
        Objects.equals(this.unwrap, cSVExtractorOptionsVm.unwrap) &&
        Objects.equals(this.removeHyphenation, cSVExtractorOptionsVm.removeHyphenation) &&
        Objects.equals(this.autoAlignColumnsToHeader, cSVExtractorOptionsVm.autoAlignColumnsToHeader) &&
        Objects.equals(this.preserveFormattingOnTextExtraction, cSVExtractorOptionsVm.preserveFormattingOnTextExtraction) &&
        Objects.equals(this.detectLinesInsteadOfParagraphs, cSVExtractorOptionsVm.detectLinesInsteadOfParagraphs) &&
        Objects.equals(this.trimSpaces, cSVExtractorOptionsVm.trimSpaces) &&
        Objects.equals(this.extractColumnByColumn, cSVExtractorOptionsVm.extractColumnByColumn) &&
        Objects.equals(this.detectNewColumnBySpacesRatio, cSVExtractorOptionsVm.detectNewColumnBySpacesRatio) &&
        Objects.equals(this.ocrMode, cSVExtractorOptionsVm.ocrMode) &&
        Objects.equals(this.lineGroupingMode, cSVExtractorOptionsVm.lineGroupingMode) &&
        Objects.equals(this.columnDetectionMode, cSVExtractorOptionsVm.columnDetectionMode) &&
        Objects.equals(this.ocrCacheMode, cSVExtractorOptionsVm.ocrCacheMode) &&
        Objects.equals(this.ocrLanguage, cSVExtractorOptionsVm.ocrLanguage) &&
        Objects.equals(this.ocrResolution, cSVExtractorOptionsVm.ocrResolution) &&
        Objects.equals(this.textEncodingCodePage, cSVExtractorOptionsVm.textEncodingCodePage) &&
        Objects.equals(this.considerFontNames, cSVExtractorOptionsVm.considerFontNames) &&
        Objects.equals(this.considerFontSizes, cSVExtractorOptionsVm.considerFontSizes) &&
        Objects.equals(this.considerFontColors, cSVExtractorOptionsVm.considerFontColors) &&
        Objects.equals(this.considerVerticalBorders, cSVExtractorOptionsVm.considerVerticalBorders) &&
        Objects.equals(this.password, cSVExtractorOptionsVm.password) &&
        Objects.equals(this.checkPermissions, cSVExtractorOptionsVm.checkPermissions) &&
        Objects.equals(this.extractionAreaUsageMode, cSVExtractorOptionsVm.extractionAreaUsageMode);
  }

  @Override
  public int hashCode() {
    return Objects.hash(startPageIndex, endPageIndex, csvSeparatorSymbol, csvQuotaionSymbol, xCoordinateToleranceFactor, yCoordinateToleranceFactor, tableXMinIntersectionRequiredInPercents, tableYMinIntersectionRequiredInPercents, rtlTextAutoDetectionEnabled, extractInvisibleText, extractShadowLikeText, unwrap, removeHyphenation, autoAlignColumnsToHeader, preserveFormattingOnTextExtraction, detectLinesInsteadOfParagraphs, trimSpaces, extractColumnByColumn, detectNewColumnBySpacesRatio, ocrMode, lineGroupingMode, columnDetectionMode, ocrCacheMode, ocrLanguage, ocrResolution, textEncodingCodePage, considerFontNames, considerFontSizes, considerFontColors, considerVerticalBorders, password, checkPermissions, extractionAreaUsageMode);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CSVExtractorOptionsVm {\n");
    
    sb.append("    startPageIndex: ").append(toIndentedString(startPageIndex)).append("\n");
    sb.append("    endPageIndex: ").append(toIndentedString(endPageIndex)).append("\n");
    sb.append("    csvSeparatorSymbol: ").append(toIndentedString(csvSeparatorSymbol)).append("\n");
    sb.append("    csvQuotaionSymbol: ").append(toIndentedString(csvQuotaionSymbol)).append("\n");
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

