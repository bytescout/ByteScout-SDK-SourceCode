package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class BarCodeSizeVm   {
  
  private Float height = null;
  private Float width = null;


  public enum UnitOfMeasureEnum {
    PIXEL("pixel"),
    POINT("point"),
    INCH("inch"),
    DOCUMENT("document"),
    MILLIMETER("millimeter"),
    CENTIMETER("centimeter"),
    TWIP("twip");

    private String value;

    UnitOfMeasureEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private UnitOfMeasureEnum unitOfMeasure = null;

  
  /**
   * Height of area
   **/
  public BarCodeSizeVm height(Float height) {
    this.height = height;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Height of area")
  @JsonProperty("height")
  public Float getHeight() {
    return height;
  }
  public void setHeight(Float height) {
    this.height = height;
  }

  
  /**
   * Width of area
   **/
  public BarCodeSizeVm width(Float width) {
    this.width = width;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Width of area")
  @JsonProperty("width")
  public Float getWidth() {
    return width;
  }
  public void setWidth(Float width) {
    this.width = width;
  }

  
  /**
   * Unit of measure.\r\n            Default value: Pixel
   **/
  public BarCodeSizeVm unitOfMeasure(UnitOfMeasureEnum unitOfMeasure) {
    this.unitOfMeasure = unitOfMeasure;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Unit of measure.\r\n            Default value: Pixel")
  @JsonProperty("unitOfMeasure")
  public UnitOfMeasureEnum getUnitOfMeasure() {
    return unitOfMeasure;
  }
  public void setUnitOfMeasure(UnitOfMeasureEnum unitOfMeasure) {
    this.unitOfMeasure = unitOfMeasure;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BarCodeSizeVm barCodeSizeVm = (BarCodeSizeVm) o;
    return Objects.equals(this.height, barCodeSizeVm.height) &&
        Objects.equals(this.width, barCodeSizeVm.width) &&
        Objects.equals(this.unitOfMeasure, barCodeSizeVm.unitOfMeasure);
  }

  @Override
  public int hashCode() {
    return Objects.hash(height, width, unitOfMeasure);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BarCodeSizeVm {\n");
    
    sb.append("    height: ").append(toIndentedString(height)).append("\n");
    sb.append("    width: ").append(toIndentedString(width)).append("\n");
    sb.append("    unitOfMeasure: ").append(toIndentedString(unitOfMeasure)).append("\n");
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

