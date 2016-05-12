package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class SpreadsheetOptionsVm   {
  
  private String userName = null;


  public enum ConvertTypeEnum {
    CSV("csv"),
    HTML("html"),
    TXT("txt"),
    XLS("xls"),
    XLSX("xlsx"),
    XML("xml"),
    PDF("pdf");

    private String value;

    ConvertTypeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private ConvertTypeEnum convertType = null;
  private Boolean createNavigationLinks = null;
  private Integer sheetIndex = null;
  private String delimiter = null;
  private String quoteSymbol = null;
  private Boolean autoSize = null;
  private String password = null;


  public enum EncodingEnum {
    ASCII("ascii"),
    DEFAULT("default"),
    UNICODE("unicode"),
    BIGENDIANUNICODE("bigEndianUnicode"),
    UTF7("utf7"),
    UTF8("utf8"),
    UTF32("utf32");

    private String value;

    EncodingEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private EncodingEnum encoding = null;

  
  /**
   * Username of Spreadsheet\r\n            Default value: \"Bytescout\"
   **/
  public SpreadsheetOptionsVm userName(String userName) {
    this.userName = userName;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Username of Spreadsheet\r\n            Default value: \"Bytescout\"")
  @JsonProperty("userName")
  public String getUserName() {
    return userName;
  }
  public void setUserName(String userName) {
    this.userName = userName;
  }

  
  /**
   * Save Spreadsheet as
   **/
  public SpreadsheetOptionsVm convertType(ConvertTypeEnum convertType) {
    this.convertType = convertType;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Save Spreadsheet as")
  @JsonProperty("convertType")
  public ConvertTypeEnum getConvertType() {
    return convertType;
  }
  public void setConvertType(ConvertTypeEnum convertType) {
    this.convertType = convertType;
  }

  
  /**
   * Create Navigation Links (for ConvertType = HTML).\r\n            Default value: false
   **/
  public SpreadsheetOptionsVm createNavigationLinks(Boolean createNavigationLinks) {
    this.createNavigationLinks = createNavigationLinks;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Create Navigation Links (for ConvertType = HTML).\r\n            Default value: false")
  @JsonProperty("createNavigationLinks")
  public Boolean getCreateNavigationLinks() {
    return createNavigationLinks;
  }
  public void setCreateNavigationLinks(Boolean createNavigationLinks) {
    this.createNavigationLinks = createNavigationLinks;
  }

  
  /**
   * Index of Sheet in Spreadsheet (for ConvertType = CSV, TXT, XML, PDF).\r\n            Default: 0 (first sheet)
   **/
  public SpreadsheetOptionsVm sheetIndex(Integer sheetIndex) {
    this.sheetIndex = sheetIndex;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Index of Sheet in Spreadsheet (for ConvertType = CSV, TXT, XML, PDF).\r\n            Default: 0 (first sheet)")
  @JsonProperty("sheetIndex")
  public Integer getSheetIndex() {
    return sheetIndex;
  }
  public void setSheetIndex(Integer sheetIndex) {
    this.sheetIndex = sheetIndex;
  }

  
  /**
   * Dilimiter of items.\r\n            Default value: ,
   **/
  public SpreadsheetOptionsVm delimiter(String delimiter) {
    this.delimiter = delimiter;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Dilimiter of items.\r\n            Default value: ,")
  @JsonProperty("delimiter")
  public String getDelimiter() {
    return delimiter;
  }
  public void setDelimiter(String delimiter) {
    this.delimiter = delimiter;
  }

  
  /**
   * Quote of items.\r\n            Default value \"
   **/
  public SpreadsheetOptionsVm quoteSymbol(String quoteSymbol) {
    this.quoteSymbol = quoteSymbol;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Quote of items.\r\n            Default value \"")
  @JsonProperty("quoteSymbol")
  public String getQuoteSymbol() {
    return quoteSymbol;
  }
  public void setQuoteSymbol(String quoteSymbol) {
    this.quoteSymbol = quoteSymbol;
  }

  
  /**
   * Autosize of PDF file (for ConvertType = PDF).\r\n            Default value: true
   **/
  public SpreadsheetOptionsVm autoSize(Boolean autoSize) {
    this.autoSize = autoSize;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Autosize of PDF file (for ConvertType = PDF).\r\n            Default value: true")
  @JsonProperty("autoSize")
  public Boolean getAutoSize() {
    return autoSize;
  }
  public void setAutoSize(Boolean autoSize) {
    this.autoSize = autoSize;
  }

  
  /**
   * Password of Spreadsheet (for ConvertType = XLSX).
   **/
  public SpreadsheetOptionsVm password(String password) {
    this.password = password;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Password of Spreadsheet (for ConvertType = XLSX).")
  @JsonProperty("password")
  public String getPassword() {
    return password;
  }
  public void setPassword(String password) {
    this.password = password;
  }

  
  /**
   * Encoding of XML file (for ConvertType = CSV, XML).\r\n            Default value: Unicode
   **/
  public SpreadsheetOptionsVm encoding(EncodingEnum encoding) {
    this.encoding = encoding;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Encoding of XML file (for ConvertType = CSV, XML).\r\n            Default value: Unicode")
  @JsonProperty("encoding")
  public EncodingEnum getEncoding() {
    return encoding;
  }
  public void setEncoding(EncodingEnum encoding) {
    this.encoding = encoding;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SpreadsheetOptionsVm spreadsheetOptionsVm = (SpreadsheetOptionsVm) o;
    return Objects.equals(this.userName, spreadsheetOptionsVm.userName) &&
        Objects.equals(this.convertType, spreadsheetOptionsVm.convertType) &&
        Objects.equals(this.createNavigationLinks, spreadsheetOptionsVm.createNavigationLinks) &&
        Objects.equals(this.sheetIndex, spreadsheetOptionsVm.sheetIndex) &&
        Objects.equals(this.delimiter, spreadsheetOptionsVm.delimiter) &&
        Objects.equals(this.quoteSymbol, spreadsheetOptionsVm.quoteSymbol) &&
        Objects.equals(this.autoSize, spreadsheetOptionsVm.autoSize) &&
        Objects.equals(this.password, spreadsheetOptionsVm.password) &&
        Objects.equals(this.encoding, spreadsheetOptionsVm.encoding);
  }

  @Override
  public int hashCode() {
    return Objects.hash(userName, convertType, createNavigationLinks, sheetIndex, delimiter, quoteSymbol, autoSize, password, encoding);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SpreadsheetOptionsVm {\n");
    
    sb.append("    userName: ").append(toIndentedString(userName)).append("\n");
    sb.append("    convertType: ").append(toIndentedString(convertType)).append("\n");
    sb.append("    createNavigationLinks: ").append(toIndentedString(createNavigationLinks)).append("\n");
    sb.append("    sheetIndex: ").append(toIndentedString(sheetIndex)).append("\n");
    sb.append("    delimiter: ").append(toIndentedString(delimiter)).append("\n");
    sb.append("    quoteSymbol: ").append(toIndentedString(quoteSymbol)).append("\n");
    sb.append("    autoSize: ").append(toIndentedString(autoSize)).append("\n");
    sb.append("    password: ").append(toIndentedString(password)).append("\n");
    sb.append("    encoding: ").append(toIndentedString(encoding)).append("\n");
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

