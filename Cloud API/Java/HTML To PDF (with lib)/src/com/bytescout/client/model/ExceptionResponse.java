package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class ExceptionResponse   {
  
  private String message = null;
  private String errorId = null;

  
  /**
   **/
  public ExceptionResponse message(String message) {
    this.message = message;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("message")
  public String getMessage() {
    return message;
  }
  public void setMessage(String message) {
    this.message = message;
  }

  
  /**
   **/
  public ExceptionResponse errorId(String errorId) {
    this.errorId = errorId;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("errorId")
  public String getErrorId() {
    return errorId;
  }
  public void setErrorId(String errorId) {
    this.errorId = errorId;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ExceptionResponse exceptionResponse = (ExceptionResponse) o;
    return Objects.equals(this.message, exceptionResponse.message) &&
        Objects.equals(this.errorId, exceptionResponse.errorId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(message, errorId);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ExceptionResponse {\n");
    
    sb.append("    message: ").append(toIndentedString(message)).append("\n");
    sb.append("    errorId: ").append(toIndentedString(errorId)).append("\n");
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

