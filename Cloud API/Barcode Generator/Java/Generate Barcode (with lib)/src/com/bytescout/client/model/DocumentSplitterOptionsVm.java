package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class DocumentSplitterOptionsVm   {
  
  private Boolean optimizeSplittedDocuments = null;
  private Boolean checkPermissions = null;
  private String ranges = null;

  
  /**
   * Default value: False
   **/
  public DocumentSplitterOptionsVm optimizeSplittedDocuments(Boolean optimizeSplittedDocuments) {
    this.optimizeSplittedDocuments = optimizeSplittedDocuments;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("optimizeSplittedDocuments")
  public Boolean getOptimizeSplittedDocuments() {
    return optimizeSplittedDocuments;
  }
  public void setOptimizeSplittedDocuments(Boolean optimizeSplittedDocuments) {
    this.optimizeSplittedDocuments = optimizeSplittedDocuments;
  }

  
  /**
   * Default value: True
   **/
  public DocumentSplitterOptionsVm checkPermissions(Boolean checkPermissions) {
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
   * Comma-separated list of page ranges in form \"1-4,5,7,8-15,16-\". Page numbers are 1-based. Ending \"-\" means \"to the last page\". (required)
   **/
  public DocumentSplitterOptionsVm ranges(String ranges) {
    this.ranges = ranges;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Comma-separated list of page ranges in form \"1-4,5,7,8-15,16-\". Page numbers are 1-based. Ending \"-\" means \"to the last page\". (required)")
  @JsonProperty("ranges")
  public String getRanges() {
    return ranges;
  }
  public void setRanges(String ranges) {
    this.ranges = ranges;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocumentSplitterOptionsVm documentSplitterOptionsVm = (DocumentSplitterOptionsVm) o;
    return Objects.equals(this.optimizeSplittedDocuments, documentSplitterOptionsVm.optimizeSplittedDocuments) &&
        Objects.equals(this.checkPermissions, documentSplitterOptionsVm.checkPermissions) &&
        Objects.equals(this.ranges, documentSplitterOptionsVm.ranges);
  }

  @Override
  public int hashCode() {
    return Objects.hash(optimizeSplittedDocuments, checkPermissions, ranges);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocumentSplitterOptionsVm {\n");
    
    sb.append("    optimizeSplittedDocuments: ").append(toIndentedString(optimizeSplittedDocuments)).append("\n");
    sb.append("    checkPermissions: ").append(toIndentedString(checkPermissions)).append("\n");
    sb.append("    ranges: ").append(toIndentedString(ranges)).append("\n");
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

