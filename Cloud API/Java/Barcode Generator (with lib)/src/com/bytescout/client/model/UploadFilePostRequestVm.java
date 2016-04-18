package com.bytescout.client.model;

import java.util.Objects;
import com.bytescout.client.model.FileUploadVm;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class UploadFilePostRequestVm   {
  
  private String input = null;


  public enum InputTypeEnum {
    AUTO("auto"),
    VALUE("value"),
    VALUEBASE64("valueBase64"),
    LINK("link"),
    FILEID("fileID");

    private String value;

    InputTypeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private InputTypeEnum inputType = null;
  private Integer storageTime = null;
  private FileUploadVm file = null;

  
  /**
   * Input Data
   **/
  public UploadFilePostRequestVm input(String input) {
    this.input = input;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Input Data")
  @JsonProperty("input")
  public String getInput() {
    return input;
  }
  public void setInput(String input) {
    this.input = input;
  }

  
  /**
   * Type of Input Data
   **/
  public UploadFilePostRequestVm inputType(InputTypeEnum inputType) {
    this.inputType = inputType;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Type of Input Data")
  @JsonProperty("inputType")
  public InputTypeEnum getInputType() {
    return inputType;
  }
  public void setInputType(InputTypeEnum inputType) {
    this.inputType = inputType;
  }

  
  /**
   * Time of storing of a file on server (seconds).\r\n            Default value: 1800
   **/
  public UploadFilePostRequestVm storageTime(Integer storageTime) {
    this.storageTime = storageTime;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Time of storing of a file on server (seconds).\r\n            Default value: 1800")
  @JsonProperty("storageTime")
  public Integer getStorageTime() {
    return storageTime;
  }
  public void setStorageTime(Integer storageTime) {
    this.storageTime = storageTime;
  }

  
  /**
   **/
  public UploadFilePostRequestVm file(FileUploadVm file) {
    this.file = file;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("file")
  public FileUploadVm getFile() {
    return file;
  }
  public void setFile(FileUploadVm file) {
    this.file = file;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UploadFilePostRequestVm uploadFilePostRequestVm = (UploadFilePostRequestVm) o;
    return Objects.equals(this.input, uploadFilePostRequestVm.input) &&
        Objects.equals(this.inputType, uploadFilePostRequestVm.inputType) &&
        Objects.equals(this.storageTime, uploadFilePostRequestVm.storageTime) &&
        Objects.equals(this.file, uploadFilePostRequestVm.file);
  }

  @Override
  public int hashCode() {
    return Objects.hash(input, inputType, storageTime, file);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UploadFilePostRequestVm {\n");
    
    sb.append("    input: ").append(toIndentedString(input)).append("\n");
    sb.append("    inputType: ").append(toIndentedString(inputType)).append("\n");
    sb.append("    storageTime: ").append(toIndentedString(storageTime)).append("\n");
    sb.append("    file: ").append(toIndentedString(file)).append("\n");
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

