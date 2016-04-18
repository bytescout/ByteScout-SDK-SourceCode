package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class PageSizeVm   {
  
  private Double width = null;
  private Double height = null;


  public enum UnitEnum {
    INCHES("inches"),
    MILLIMETERS("millimeters"),
    CENTIMETERS("centimeters");

    private String value;

    UnitEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private UnitEnum unit = null;

  
  /**
   **/
  public PageSizeVm width(Double width) {
    this.width = width;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("width")
  public Double getWidth() {
    return width;
  }
  public void setWidth(Double width) {
    this.width = width;
  }

  
  /**
   **/
  public PageSizeVm height(Double height) {
    this.height = height;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("height")
  public Double getHeight() {
    return height;
  }
  public void setHeight(Double height) {
    this.height = height;
  }

  
  /**
   * Default value: Millimeters
   **/
  public PageSizeVm unit(UnitEnum unit) {
    this.unit = unit;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Millimeters")
  @JsonProperty("unit")
  public UnitEnum getUnit() {
    return unit;
  }
  public void setUnit(UnitEnum unit) {
    this.unit = unit;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PageSizeVm pageSizeVm = (PageSizeVm) o;
    return Objects.equals(this.width, pageSizeVm.width) &&
        Objects.equals(this.height, pageSizeVm.height) &&
        Objects.equals(this.unit, pageSizeVm.unit);
  }

  @Override
  public int hashCode() {
    return Objects.hash(width, height, unit);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PageSizeVm {\n");
    
    sb.append("    width: ").append(toIndentedString(width)).append("\n");
    sb.append("    height: ").append(toIndentedString(height)).append("\n");
    sb.append("    unit: ").append(toIndentedString(unit)).append("\n");
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

