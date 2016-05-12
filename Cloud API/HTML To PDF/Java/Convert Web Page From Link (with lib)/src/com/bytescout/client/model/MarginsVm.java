package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class MarginsVm   {
  
  private Float top = null;
  private Float bottom = null;
  private Float left = null;
  private Float right = null;

  
  /**
   * Top margin (in mm)\r\n            Default value: 10
   **/
  public MarginsVm top(Float top) {
    this.top = top;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Top margin (in mm)\r\n            Default value: 10")
  @JsonProperty("top")
  public Float getTop() {
    return top;
  }
  public void setTop(Float top) {
    this.top = top;
  }

  
  /**
   * Bottom margin (in mm)\r\n            Default value: 10
   **/
  public MarginsVm bottom(Float bottom) {
    this.bottom = bottom;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Bottom margin (in mm)\r\n            Default value: 10")
  @JsonProperty("bottom")
  public Float getBottom() {
    return bottom;
  }
  public void setBottom(Float bottom) {
    this.bottom = bottom;
  }

  
  /**
   * Left margin (in mm)\r\n            Default value: 10
   **/
  public MarginsVm left(Float left) {
    this.left = left;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Left margin (in mm)\r\n            Default value: 10")
  @JsonProperty("left")
  public Float getLeft() {
    return left;
  }
  public void setLeft(Float left) {
    this.left = left;
  }

  
  /**
   * Right margin (in mm)\r\n            Default value: 10
   **/
  public MarginsVm right(Float right) {
    this.right = right;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Right margin (in mm)\r\n            Default value: 10")
  @JsonProperty("right")
  public Float getRight() {
    return right;
  }
  public void setRight(Float right) {
    this.right = right;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MarginsVm marginsVm = (MarginsVm) o;
    return Objects.equals(this.top, marginsVm.top) &&
        Objects.equals(this.bottom, marginsVm.bottom) &&
        Objects.equals(this.left, marginsVm.left) &&
        Objects.equals(this.right, marginsVm.right);
  }

  @Override
  public int hashCode() {
    return Objects.hash(top, bottom, left, right);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MarginsVm {\n");
    
    sb.append("    top: ").append(toIndentedString(top)).append("\n");
    sb.append("    bottom: ").append(toIndentedString(bottom)).append("\n");
    sb.append("    left: ").append(toIndentedString(left)).append("\n");
    sb.append("    right: ").append(toIndentedString(right)).append("\n");
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

