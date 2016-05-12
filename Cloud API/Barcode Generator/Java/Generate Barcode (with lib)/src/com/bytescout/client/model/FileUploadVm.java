package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class FileUploadVm   {
  
  private String fileName = null;
  private String buffer = null;

  
  /**
   **/
  public FileUploadVm fileName(String fileName) {
    this.fileName = fileName;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("fileName")
  public String getFileName() {
    return fileName;
  }
  public void setFileName(String fileName) {
    this.fileName = fileName;
  }

  
  /**
   **/
  public FileUploadVm buffer(String buffer) {
    this.buffer = buffer;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("buffer")
  public String getBuffer() {
    return buffer;
  }
  public void setBuffer(String buffer) {
    this.buffer = buffer;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FileUploadVm fileUploadVm = (FileUploadVm) o;
    return Objects.equals(this.fileName, fileUploadVm.fileName) &&
        Objects.equals(this.buffer, fileUploadVm.buffer);
  }

  @Override
  public int hashCode() {
    return Objects.hash(fileName, buffer);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FileUploadVm {\n");
    
    sb.append("    fileName: ").append(toIndentedString(fileName)).append("\n");
    sb.append("    buffer: ").append(toIndentedString(buffer)).append("\n");
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

