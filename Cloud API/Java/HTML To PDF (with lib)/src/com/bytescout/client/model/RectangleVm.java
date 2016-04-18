package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class RectangleVm   {
  
  private Integer x = null;
  private Integer y = null;
  private Integer width = null;
  private Integer height = null;

  
  /**
   **/
  public RectangleVm x(Integer x) {
    this.x = x;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("x")
  public Integer getX() {
    return x;
  }
  public void setX(Integer x) {
    this.x = x;
  }

  
  /**
   **/
  public RectangleVm y(Integer y) {
    this.y = y;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("y")
  public Integer getY() {
    return y;
  }
  public void setY(Integer y) {
    this.y = y;
  }

  
  /**
   **/
  public RectangleVm width(Integer width) {
    this.width = width;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("width")
  public Integer getWidth() {
    return width;
  }
  public void setWidth(Integer width) {
    this.width = width;
  }

  
  /**
   **/
  public RectangleVm height(Integer height) {
    this.height = height;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("height")
  public Integer getHeight() {
    return height;
  }
  public void setHeight(Integer height) {
    this.height = height;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RectangleVm rectangleVm = (RectangleVm) o;
    return Objects.equals(this.x, rectangleVm.x) &&
        Objects.equals(this.y, rectangleVm.y) &&
        Objects.equals(this.width, rectangleVm.width) &&
        Objects.equals(this.height, rectangleVm.height);
  }

  @Override
  public int hashCode() {
    return Objects.hash(x, y, width, height);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RectangleVm {\n");
    
    sb.append("    x: ").append(toIndentedString(x)).append("\n");
    sb.append("    y: ").append(toIndentedString(y)).append("\n");
    sb.append("    width: ").append(toIndentedString(width)).append("\n");
    sb.append("    height: ").append(toIndentedString(height)).append("\n");
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

