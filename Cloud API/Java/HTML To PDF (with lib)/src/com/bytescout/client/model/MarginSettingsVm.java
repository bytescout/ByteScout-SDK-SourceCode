package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class MarginSettingsVm   {
  
  private Double bottom = null;
  private Double left = null;
  private Double right = null;
  private Double top = null;


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
  public MarginSettingsVm bottom(Double bottom) {
    this.bottom = bottom;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("bottom")
  public Double getBottom() {
    return bottom;
  }
  public void setBottom(Double bottom) {
    this.bottom = bottom;
  }

  
  /**
   **/
  public MarginSettingsVm left(Double left) {
    this.left = left;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("left")
  public Double getLeft() {
    return left;
  }
  public void setLeft(Double left) {
    this.left = left;
  }

  
  /**
   **/
  public MarginSettingsVm right(Double right) {
    this.right = right;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("right")
  public Double getRight() {
    return right;
  }
  public void setRight(Double right) {
    this.right = right;
  }

  
  /**
   **/
  public MarginSettingsVm top(Double top) {
    this.top = top;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("top")
  public Double getTop() {
    return top;
  }
  public void setTop(Double top) {
    this.top = top;
  }

  
  /**
   * Default value: Millimeters
   **/
  public MarginSettingsVm unit(UnitEnum unit) {
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
    MarginSettingsVm marginSettingsVm = (MarginSettingsVm) o;
    return Objects.equals(this.bottom, marginSettingsVm.bottom) &&
        Objects.equals(this.left, marginSettingsVm.left) &&
        Objects.equals(this.right, marginSettingsVm.right) &&
        Objects.equals(this.top, marginSettingsVm.top) &&
        Objects.equals(this.unit, marginSettingsVm.unit);
  }

  @Override
  public int hashCode() {
    return Objects.hash(bottom, left, right, top, unit);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MarginSettingsVm {\n");
    
    sb.append("    bottom: ").append(toIndentedString(bottom)).append("\n");
    sb.append("    left: ").append(toIndentedString(left)).append("\n");
    sb.append("    right: ").append(toIndentedString(right)).append("\n");
    sb.append("    top: ").append(toIndentedString(top)).append("\n");
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

