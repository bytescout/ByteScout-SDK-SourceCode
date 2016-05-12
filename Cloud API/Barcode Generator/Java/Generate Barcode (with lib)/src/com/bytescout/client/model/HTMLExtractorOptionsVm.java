package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class HTMLExtractorOptionsVm   {
  
  private Integer startPageIndex = null;
  private Integer endPageIndex = null;
  private Float detectNewColumnBySpacesRatio = null;
  private Boolean extractInvisibleText = null;
  private Boolean preserveFormattingOnTextExtraction = null;


  public enum ColumnDetectionModeEnum {
    CONTENTGROUPSANDBORDERS("contentGroupsAndBorders"),
    CONTENTGROUPS("contentGroups"),
    BORDERS("borders");

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
  private Boolean detectLinesInsteadOfParagraphs = null;
  private Boolean trimSpaces = null;


  public enum OutputImageFormatEnum {
    PNG("png"),
    BMP("bmp"),
    TIFF("tiff"),
    JPEG("jpeg"),
    GIF("gif"),
    EMF("emf");

    private String value;

    OutputImageFormatEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private OutputImageFormatEnum outputImageFormat = null;


  public enum ExtractionModeEnum {
    PLAINHTML("plainHTML"),
    HTMLWITHCSS("htmlWithCSS");

    private String value;

    ExtractionModeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private ExtractionModeEnum extractionMode = null;
  private Boolean optimizeImages = null;
  private Integer outputPageWidth = null;
  private Boolean highPrecisionTextPositioning = null;
  private Boolean addFontStyleHTMLTagsToText = null;
  private Boolean controlsAsText = null;
  private Boolean detectHyperLinks = null;
  private String password = null;
  private Boolean checkPermissions = null;

  
  /**
   * Index of page (zero-based) of PDF file from which data will be extracted.\r\n            Default value: all pages
   **/
  public HTMLExtractorOptionsVm startPageIndex(Integer startPageIndex) {
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
  public HTMLExtractorOptionsVm endPageIndex(Integer endPageIndex) {
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
   * Default value: 1.2
   **/
  public HTMLExtractorOptionsVm detectNewColumnBySpacesRatio(Float detectNewColumnBySpacesRatio) {
    this.detectNewColumnBySpacesRatio = detectNewColumnBySpacesRatio;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 1.2")
  @JsonProperty("detectNewColumnBySpacesRatio")
  public Float getDetectNewColumnBySpacesRatio() {
    return detectNewColumnBySpacesRatio;
  }
  public void setDetectNewColumnBySpacesRatio(Float detectNewColumnBySpacesRatio) {
    this.detectNewColumnBySpacesRatio = detectNewColumnBySpacesRatio;
  }

  
  /**
   * Default value: True
   **/
  public HTMLExtractorOptionsVm extractInvisibleText(Boolean extractInvisibleText) {
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
  public HTMLExtractorOptionsVm preserveFormattingOnTextExtraction(Boolean preserveFormattingOnTextExtraction) {
    this.preserveFormattingOnTextExtraction = preserveFormattingOnTextExtraction;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("preserveFormattingOnTextExtraction")
  public Boolean getPreserveFormattingOnTextExtraction() {
    return preserveFormattingOnTextExtraction;
  }
  public void setPreserveFormattingOnTextExtraction(Boolean preserveFormattingOnTextExtraction) {
    this.preserveFormattingOnTextExtraction = preserveFormattingOnTextExtraction;
  }

  
  /**
   * Default value: ContentGroupsAndBorders
   **/
  public HTMLExtractorOptionsVm columnDetectionMode(ColumnDetectionModeEnum columnDetectionMode) {
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
   * Default value: None
   **/
  public HTMLExtractorOptionsVm lineGroupingMode(LineGroupingModeEnum lineGroupingMode) {
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
   * Default value: True
   **/
  public HTMLExtractorOptionsVm detectLinesInsteadOfParagraphs(Boolean detectLinesInsteadOfParagraphs) {
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
  public HTMLExtractorOptionsVm trimSpaces(Boolean trimSpaces) {
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
   * Default value: PNG
   **/
  public HTMLExtractorOptionsVm outputImageFormat(OutputImageFormatEnum outputImageFormat) {
    this.outputImageFormat = outputImageFormat;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: PNG")
  @JsonProperty("outputImageFormat")
  public OutputImageFormatEnum getOutputImageFormat() {
    return outputImageFormat;
  }
  public void setOutputImageFormat(OutputImageFormatEnum outputImageFormat) {
    this.outputImageFormat = outputImageFormat;
  }

  
  /**
   * Default value: HTMLWithCSS
   **/
  public HTMLExtractorOptionsVm extractionMode(ExtractionModeEnum extractionMode) {
    this.extractionMode = extractionMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: HTMLWithCSS")
  @JsonProperty("extractionMode")
  public ExtractionModeEnum getExtractionMode() {
    return extractionMode;
  }
  public void setExtractionMode(ExtractionModeEnum extractionMode) {
    this.extractionMode = extractionMode;
  }

  
  /**
   * Default value: True
   **/
  public HTMLExtractorOptionsVm optimizeImages(Boolean optimizeImages) {
    this.optimizeImages = optimizeImages;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("optimizeImages")
  public Boolean getOptimizeImages() {
    return optimizeImages;
  }
  public void setOptimizeImages(Boolean optimizeImages) {
    this.optimizeImages = optimizeImages;
  }

  
  /**
   * Default value: 1024
   **/
  public HTMLExtractorOptionsVm outputPageWidth(Integer outputPageWidth) {
    this.outputPageWidth = outputPageWidth;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 1024")
  @JsonProperty("outputPageWidth")
  public Integer getOutputPageWidth() {
    return outputPageWidth;
  }
  public void setOutputPageWidth(Integer outputPageWidth) {
    this.outputPageWidth = outputPageWidth;
  }

  
  /**
   * Default value: True
   **/
  public HTMLExtractorOptionsVm highPrecisionTextPositioning(Boolean highPrecisionTextPositioning) {
    this.highPrecisionTextPositioning = highPrecisionTextPositioning;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("highPrecisionTextPositioning")
  public Boolean getHighPrecisionTextPositioning() {
    return highPrecisionTextPositioning;
  }
  public void setHighPrecisionTextPositioning(Boolean highPrecisionTextPositioning) {
    this.highPrecisionTextPositioning = highPrecisionTextPositioning;
  }

  
  /**
   * Default value: True
   **/
  public HTMLExtractorOptionsVm addFontStyleHTMLTagsToText(Boolean addFontStyleHTMLTagsToText) {
    this.addFontStyleHTMLTagsToText = addFontStyleHTMLTagsToText;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("addFontStyleHTMLTagsToText")
  public Boolean getAddFontStyleHTMLTagsToText() {
    return addFontStyleHTMLTagsToText;
  }
  public void setAddFontStyleHTMLTagsToText(Boolean addFontStyleHTMLTagsToText) {
    this.addFontStyleHTMLTagsToText = addFontStyleHTMLTagsToText;
  }

  
  /**
   * Default value: False
   **/
  public HTMLExtractorOptionsVm controlsAsText(Boolean controlsAsText) {
    this.controlsAsText = controlsAsText;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("controlsAsText")
  public Boolean getControlsAsText() {
    return controlsAsText;
  }
  public void setControlsAsText(Boolean controlsAsText) {
    this.controlsAsText = controlsAsText;
  }

  
  /**
   * Default value: True
   **/
  public HTMLExtractorOptionsVm detectHyperLinks(Boolean detectHyperLinks) {
    this.detectHyperLinks = detectHyperLinks;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("detectHyperLinks")
  public Boolean getDetectHyperLinks() {
    return detectHyperLinks;
  }
  public void setDetectHyperLinks(Boolean detectHyperLinks) {
    this.detectHyperLinks = detectHyperLinks;
  }

  
  /**
   * Default value: null
   **/
  public HTMLExtractorOptionsVm password(String password) {
    this.password = password;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: null")
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
  public HTMLExtractorOptionsVm checkPermissions(Boolean checkPermissions) {
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

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    HTMLExtractorOptionsVm hTMLExtractorOptionsVm = (HTMLExtractorOptionsVm) o;
    return Objects.equals(this.startPageIndex, hTMLExtractorOptionsVm.startPageIndex) &&
        Objects.equals(this.endPageIndex, hTMLExtractorOptionsVm.endPageIndex) &&
        Objects.equals(this.detectNewColumnBySpacesRatio, hTMLExtractorOptionsVm.detectNewColumnBySpacesRatio) &&
        Objects.equals(this.extractInvisibleText, hTMLExtractorOptionsVm.extractInvisibleText) &&
        Objects.equals(this.preserveFormattingOnTextExtraction, hTMLExtractorOptionsVm.preserveFormattingOnTextExtraction) &&
        Objects.equals(this.columnDetectionMode, hTMLExtractorOptionsVm.columnDetectionMode) &&
        Objects.equals(this.lineGroupingMode, hTMLExtractorOptionsVm.lineGroupingMode) &&
        Objects.equals(this.detectLinesInsteadOfParagraphs, hTMLExtractorOptionsVm.detectLinesInsteadOfParagraphs) &&
        Objects.equals(this.trimSpaces, hTMLExtractorOptionsVm.trimSpaces) &&
        Objects.equals(this.outputImageFormat, hTMLExtractorOptionsVm.outputImageFormat) &&
        Objects.equals(this.extractionMode, hTMLExtractorOptionsVm.extractionMode) &&
        Objects.equals(this.optimizeImages, hTMLExtractorOptionsVm.optimizeImages) &&
        Objects.equals(this.outputPageWidth, hTMLExtractorOptionsVm.outputPageWidth) &&
        Objects.equals(this.highPrecisionTextPositioning, hTMLExtractorOptionsVm.highPrecisionTextPositioning) &&
        Objects.equals(this.addFontStyleHTMLTagsToText, hTMLExtractorOptionsVm.addFontStyleHTMLTagsToText) &&
        Objects.equals(this.controlsAsText, hTMLExtractorOptionsVm.controlsAsText) &&
        Objects.equals(this.detectHyperLinks, hTMLExtractorOptionsVm.detectHyperLinks) &&
        Objects.equals(this.password, hTMLExtractorOptionsVm.password) &&
        Objects.equals(this.checkPermissions, hTMLExtractorOptionsVm.checkPermissions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(startPageIndex, endPageIndex, detectNewColumnBySpacesRatio, extractInvisibleText, preserveFormattingOnTextExtraction, columnDetectionMode, lineGroupingMode, detectLinesInsteadOfParagraphs, trimSpaces, outputImageFormat, extractionMode, optimizeImages, outputPageWidth, highPrecisionTextPositioning, addFontStyleHTMLTagsToText, controlsAsText, detectHyperLinks, password, checkPermissions);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class HTMLExtractorOptionsVm {\n");
    
    sb.append("    startPageIndex: ").append(toIndentedString(startPageIndex)).append("\n");
    sb.append("    endPageIndex: ").append(toIndentedString(endPageIndex)).append("\n");
    sb.append("    detectNewColumnBySpacesRatio: ").append(toIndentedString(detectNewColumnBySpacesRatio)).append("\n");
    sb.append("    extractInvisibleText: ").append(toIndentedString(extractInvisibleText)).append("\n");
    sb.append("    preserveFormattingOnTextExtraction: ").append(toIndentedString(preserveFormattingOnTextExtraction)).append("\n");
    sb.append("    columnDetectionMode: ").append(toIndentedString(columnDetectionMode)).append("\n");
    sb.append("    lineGroupingMode: ").append(toIndentedString(lineGroupingMode)).append("\n");
    sb.append("    detectLinesInsteadOfParagraphs: ").append(toIndentedString(detectLinesInsteadOfParagraphs)).append("\n");
    sb.append("    trimSpaces: ").append(toIndentedString(trimSpaces)).append("\n");
    sb.append("    outputImageFormat: ").append(toIndentedString(outputImageFormat)).append("\n");
    sb.append("    extractionMode: ").append(toIndentedString(extractionMode)).append("\n");
    sb.append("    optimizeImages: ").append(toIndentedString(optimizeImages)).append("\n");
    sb.append("    outputPageWidth: ").append(toIndentedString(outputPageWidth)).append("\n");
    sb.append("    highPrecisionTextPositioning: ").append(toIndentedString(highPrecisionTextPositioning)).append("\n");
    sb.append("    addFontStyleHTMLTagsToText: ").append(toIndentedString(addFontStyleHTMLTagsToText)).append("\n");
    sb.append("    controlsAsText: ").append(toIndentedString(controlsAsText)).append("\n");
    sb.append("    detectHyperLinks: ").append(toIndentedString(detectHyperLinks)).append("\n");
    sb.append("    password: ").append(toIndentedString(password)).append("\n");
    sb.append("    checkPermissions: ").append(toIndentedString(checkPermissions)).append("\n");
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

