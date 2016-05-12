package com.bytescout.client.model;

import java.util.Objects;
import com.bytescout.client.model.DocumentMergerOptionsVm;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class DocumentMergerRequestVm   {
  
  private DocumentMergerOptionsVm properties = null;


  public enum OutputTypeEnum {
    LINK("link"),
    LINKPRIVATE("linkPrivate"),
    CONTENT("content"),
    CONTENTBASE64("contentBase64"),
    FILEID("fileId");

    private String value;

    OutputTypeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private OutputTypeEnum outputType = null;
  private List<String> inputFileIds = new ArrayList<String>();

  
  /**
   **/
  public DocumentMergerRequestVm properties(DocumentMergerOptionsVm properties) {
    this.properties = properties;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("properties")
  public DocumentMergerOptionsVm getProperties() {
    return properties;
  }
  public void setProperties(DocumentMergerOptionsVm properties) {
    this.properties = properties;
  }

  
  /**
   * Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!
   **/
  public DocumentMergerRequestVm outputType(OutputTypeEnum outputType) {
    this.outputType = outputType;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Type in which you want to get result of extracting (optional). Default value: Content. \r\n            IMPORTANT: \r\n            Link type generates public unique link to download, file is removed after default StorageTime(see File API). \r\n            LinkPrivate generates private unique link which should NOT be shared as it can be accessed with your api key only!")
  @JsonProperty("outputType")
  public OutputTypeEnum getOutputType() {
    return outputType;
  }
  public void setOutputType(OutputTypeEnum outputType) {
    this.outputType = outputType;
  }

  
  /**
   **/
  public DocumentMergerRequestVm inputFileIds(List<String> inputFileIds) {
    this.inputFileIds = inputFileIds;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("inputFileIds")
  public List<String> getInputFileIds() {
    return inputFileIds;
  }
  public void setInputFileIds(List<String> inputFileIds) {
    this.inputFileIds = inputFileIds;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocumentMergerRequestVm documentMergerRequestVm = (DocumentMergerRequestVm) o;
    return Objects.equals(this.properties, documentMergerRequestVm.properties) &&
        Objects.equals(this.outputType, documentMergerRequestVm.outputType) &&
        Objects.equals(this.inputFileIds, documentMergerRequestVm.inputFileIds);
  }

  @Override
  public int hashCode() {
    return Objects.hash(properties, outputType, inputFileIds);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocumentMergerRequestVm {\n");
    
    sb.append("    properties: ").append(toIndentedString(properties)).append("\n");
    sb.append("    outputType: ").append(toIndentedString(outputType)).append("\n");
    sb.append("    inputFileIds: ").append(toIndentedString(inputFileIds)).append("\n");
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

