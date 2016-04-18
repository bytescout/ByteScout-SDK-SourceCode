package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class CreateUserVm   {
  
  private String apiKey = null;


  public enum PermissionsEnum {
    PDFEXTRACTOR("PDFExtractor"),
    HTMLTOPDF("HTMLToPDF"),
    BARCODEREADER("BarcodeReader"),
    BARCODE("Barcode"),
    PDFRENDERER("PDFRenderer"),
    PDFTOHTML("PDFToHTML"),
    SPREADSHEET("Spreadsheet");

    private String value;

    PermissionsEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private List<PermissionsEnum> permissions = new ArrayList<PermissionsEnum>();

  
  /**
   * ApiKey of a new user which will be used for access to the service.
   **/
  public CreateUserVm apiKey(String apiKey) {
    this.apiKey = apiKey;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "ApiKey of a new user which will be used for access to the service.")
  @JsonProperty("apiKey")
  public String getApiKey() {
    return apiKey;
  }
  public void setApiKey(String apiKey) {
    this.apiKey = apiKey;
  }

  
  /**
   * Permissions of a new user. Without them he will not be able to use features of the service.\r\n            ['PDFExtractor', 'HTMLToPDF', 'BarcodeReader', 'Barcode', 'PDFRenderer', 'PDFToHTML', 'Spreadsheet']
   **/
  public CreateUserVm permissions(List<PermissionsEnum> permissions) {
    this.permissions = permissions;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Permissions of a new user. Without them he will not be able to use features of the service.\r\n            ['PDFExtractor', 'HTMLToPDF', 'BarcodeReader', 'Barcode', 'PDFRenderer', 'PDFToHTML', 'Spreadsheet']")
  @JsonProperty("permissions")
  public List<PermissionsEnum> getPermissions() {
    return permissions;
  }
  public void setPermissions(List<PermissionsEnum> permissions) {
    this.permissions = permissions;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CreateUserVm createUserVm = (CreateUserVm) o;
    return Objects.equals(this.apiKey, createUserVm.apiKey) &&
        Objects.equals(this.permissions, createUserVm.permissions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(apiKey, permissions);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CreateUserVm {\n");
    
    sb.append("    apiKey: ").append(toIndentedString(apiKey)).append("\n");
    sb.append("    permissions: ").append(toIndentedString(permissions)).append("\n");
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

