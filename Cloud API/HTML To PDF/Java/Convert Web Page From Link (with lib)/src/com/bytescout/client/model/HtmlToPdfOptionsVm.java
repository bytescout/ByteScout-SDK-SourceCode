package com.bytescout.client.model;

import java.util.Objects;
import com.bytescout.client.model.MarginSettingsVm;
import com.bytescout.client.model.PageSizeVm;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class HtmlToPdfOptionsVm   {
  
  private String title = null;


  public enum OrientationEnum {
    PORTRAIT("portrait"),
    LANDSCAPE("landscape");

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
  private PageSizeVm pageSize = null;
  private MarginSettingsVm margins = null;
  private Boolean printBackground = null;
  private String headerHTML = null;
  private String footerHTML = null;
  private String templateData = null;

  
  /**
   * Title of a PDF file.
   **/
  public HtmlToPdfOptionsVm title(String title) {
    this.title = title;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Title of a PDF file.")
  @JsonProperty("title")
  public String getTitle() {
    return title;
  }
  public void setTitle(String title) {
    this.title = title;
  }

  
  /**
   * Orientation of pages of a PDF file.\r\n            Default value: Portrait
   **/
  public HtmlToPdfOptionsVm orientation(OrientationEnum orientation) {
    this.orientation = orientation;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Orientation of pages of a PDF file.\r\n            Default value: Portrait")
  @JsonProperty("orientation")
  public OrientationEnum getOrientation() {
    return orientation;
  }
  public void setOrientation(OrientationEnum orientation) {
    this.orientation = orientation;
  }

  
  /**
   * Size of pages of a PDF file.\r\n            Default value: A4.
   **/
  public HtmlToPdfOptionsVm pageSize(PageSizeVm pageSize) {
    this.pageSize = pageSize;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Size of pages of a PDF file.\r\n            Default value: A4.")
  @JsonProperty("pageSize")
  public PageSizeVm getPageSize() {
    return pageSize;
  }
  public void setPageSize(PageSizeVm pageSize) {
    this.pageSize = pageSize;
  }

  
  /**
   * Margin of pages of a PDF file.
   **/
  public HtmlToPdfOptionsVm margins(MarginSettingsVm margins) {
    this.margins = margins;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Margin of pages of a PDF file.")
  @JsonProperty("margins")
  public MarginSettingsVm getMargins() {
    return margins;
  }
  public void setMargins(MarginSettingsVm margins) {
    this.margins = margins;
  }

  
  /**
   * Define print background of a page or not.\r\n            Default value: true
   **/
  public HtmlToPdfOptionsVm printBackground(Boolean printBackground) {
    this.printBackground = printBackground;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Define print background of a page or not.\r\n            Default value: true")
  @JsonProperty("printBackground")
  public Boolean getPrintBackground() {
    return printBackground;
  }
  public void setPrintBackground(Boolean printBackground) {
    this.printBackground = printBackground;
  }

  
  /**
   * HTML code which will be inserted in header of pages.\r\n            Default value: null
   **/
  public HtmlToPdfOptionsVm headerHTML(String headerHTML) {
    this.headerHTML = headerHTML;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "HTML code which will be inserted in header of pages.\r\n            Default value: null")
  @JsonProperty("headerHTML")
  public String getHeaderHTML() {
    return headerHTML;
  }
  public void setHeaderHTML(String headerHTML) {
    this.headerHTML = headerHTML;
  }

  
  /**
   * HTML code which will be inserted in footer of pages.\r\n            Default value: null
   **/
  public HtmlToPdfOptionsVm footerHTML(String footerHTML) {
    this.footerHTML = footerHTML;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "HTML code which will be inserted in footer of pages.\r\n            Default value: null")
  @JsonProperty("footerHTML")
  public String getFooterHTML() {
    return footerHTML;
  }
  public void setFooterHTML(String footerHTML) {
    this.footerHTML = footerHTML;
  }

  
  /**
   * String of JSON data which will be used for generation PDF file from template
   **/
  public HtmlToPdfOptionsVm templateData(String templateData) {
    this.templateData = templateData;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "String of JSON data which will be used for generation PDF file from template")
  @JsonProperty("templateData")
  public String getTemplateData() {
    return templateData;
  }
  public void setTemplateData(String templateData) {
    this.templateData = templateData;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    HtmlToPdfOptionsVm htmlToPdfOptionsVm = (HtmlToPdfOptionsVm) o;
    return Objects.equals(this.title, htmlToPdfOptionsVm.title) &&
        Objects.equals(this.orientation, htmlToPdfOptionsVm.orientation) &&
        Objects.equals(this.pageSize, htmlToPdfOptionsVm.pageSize) &&
        Objects.equals(this.margins, htmlToPdfOptionsVm.margins) &&
        Objects.equals(this.printBackground, htmlToPdfOptionsVm.printBackground) &&
        Objects.equals(this.headerHTML, htmlToPdfOptionsVm.headerHTML) &&
        Objects.equals(this.footerHTML, htmlToPdfOptionsVm.footerHTML) &&
        Objects.equals(this.templateData, htmlToPdfOptionsVm.templateData);
  }

  @Override
  public int hashCode() {
    return Objects.hash(title, orientation, pageSize, margins, printBackground, headerHTML, footerHTML, templateData);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class HtmlToPdfOptionsVm {\n");
    
    sb.append("    title: ").append(toIndentedString(title)).append("\n");
    sb.append("    orientation: ").append(toIndentedString(orientation)).append("\n");
    sb.append("    pageSize: ").append(toIndentedString(pageSize)).append("\n");
    sb.append("    margins: ").append(toIndentedString(margins)).append("\n");
    sb.append("    printBackground: ").append(toIndentedString(printBackground)).append("\n");
    sb.append("    headerHTML: ").append(toIndentedString(headerHTML)).append("\n");
    sb.append("    footerHTML: ").append(toIndentedString(footerHTML)).append("\n");
    sb.append("    templateData: ").append(toIndentedString(templateData)).append("\n");
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

