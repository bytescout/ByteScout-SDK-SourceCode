package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class InfoExtractorOptionsVm   {
  
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
   **/
  public InfoExtractorOptionsVm password(String password) {
    this.password = password;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
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
  public InfoExtractorOptionsVm checkPermissions(Boolean checkPermissions) {
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
  public InfoExtractorOptionsVm extractionAreaUsageMode(ExtractionAreaUsageModeEnum extractionAreaUsageMode) {
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
    InfoExtractorOptionsVm infoExtractorOptionsVm = (InfoExtractorOptionsVm) o;
    return Objects.equals(this.password, infoExtractorOptionsVm.password) &&
        Objects.equals(this.checkPermissions, infoExtractorOptionsVm.checkPermissions) &&
        Objects.equals(this.extractionAreaUsageMode, infoExtractorOptionsVm.extractionAreaUsageMode);
  }

  @Override
  public int hashCode() {
    return Objects.hash(password, checkPermissions, extractionAreaUsageMode);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InfoExtractorOptionsVm {\n");
    
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

