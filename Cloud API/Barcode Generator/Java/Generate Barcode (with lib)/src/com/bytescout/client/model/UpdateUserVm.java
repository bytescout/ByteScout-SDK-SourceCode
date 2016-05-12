package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class UpdateUserVm   {
  
  private Double credits = null;


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
   * Available credits for a user. Users use it for getting features of the service.
   **/
  public UpdateUserVm credits(Double credits) {
    this.credits = credits;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Available credits for a user. Users use it for getting features of the service.")
  @JsonProperty("credits")
  public Double getCredits() {
    return credits;
  }
  public void setCredits(Double credits) {
    this.credits = credits;
  }

  
  /**
   * Permissions of a user. Without them he will not be able to use features of the service.\r\n            ['PDFExtractor', 'HTMLToPDF', 'BarcodeReader', 'Barcode', 'PDFRenderer', 'PDFToHTML', 'Spreadsheet']
   **/
  public UpdateUserVm permissions(List<PermissionsEnum> permissions) {
    this.permissions = permissions;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Permissions of a user. Without them he will not be able to use features of the service.\r\n            ['PDFExtractor', 'HTMLToPDF', 'BarcodeReader', 'Barcode', 'PDFRenderer', 'PDFToHTML', 'Spreadsheet']")
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
    UpdateUserVm updateUserVm = (UpdateUserVm) o;
    return Objects.equals(this.credits, updateUserVm.credits) &&
        Objects.equals(this.permissions, updateUserVm.permissions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(credits, permissions);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UpdateUserVm {\n");
    
    sb.append("    credits: ").append(toIndentedString(credits)).append("\n");
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

