package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class DocumentMergerOptionsVm   {
  
  private Boolean checkPermissions = null;

  
  /**
   * Default value: True
   **/
  public DocumentMergerOptionsVm checkPermissions(Boolean checkPermissions) {
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

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocumentMergerOptionsVm documentMergerOptionsVm = (DocumentMergerOptionsVm) o;
    return Objects.equals(this.checkPermissions, documentMergerOptionsVm.checkPermissions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(checkPermissions);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocumentMergerOptionsVm {\n");
    
    sb.append("    checkPermissions: ").append(toIndentedString(checkPermissions)).append("\n");
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

