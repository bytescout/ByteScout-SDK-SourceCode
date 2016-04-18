package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class GetListUsersVm   {
  
  private Integer pageIndex = null;
  private Integer pageSize = null;

  
  /**
   * Index of page of Users.
   **/
  public GetListUsersVm pageIndex(Integer pageIndex) {
    this.pageIndex = pageIndex;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Index of page of Users.")
  @JsonProperty("pageIndex")
  public Integer getPageIndex() {
    return pageIndex;
  }
  public void setPageIndex(Integer pageIndex) {
    this.pageIndex = pageIndex;
  }

  
  /**
   * Size of page of Users.
   **/
  public GetListUsersVm pageSize(Integer pageSize) {
    this.pageSize = pageSize;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Size of page of Users.")
  @JsonProperty("pageSize")
  public Integer getPageSize() {
    return pageSize;
  }
  public void setPageSize(Integer pageSize) {
    this.pageSize = pageSize;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GetListUsersVm getListUsersVm = (GetListUsersVm) o;
    return Objects.equals(this.pageIndex, getListUsersVm.pageIndex) &&
        Objects.equals(this.pageSize, getListUsersVm.pageSize);
  }

  @Override
  public int hashCode() {
    return Objects.hash(pageIndex, pageSize);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GetListUsersVm {\n");
    
    sb.append("    pageIndex: ").append(toIndentedString(pageIndex)).append("\n");
    sb.append("    pageSize: ").append(toIndentedString(pageSize)).append("\n");
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

