package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;


@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class PdfRasterRendererOptionsVm   {
  
  private Integer startPageIndex = null;
  private Integer endPageIndex = null;


  public enum TiffCompressionEnum {
    NONE("none"),
    LZW("lzw"),
    CCITT3("ccitt3"),
    CCITT4("ccitt4"),
    JPEG("jpeg"),
    RLE("rle");

    private String value;

    TiffCompressionEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private TiffCompressionEnum tiffCompression = null;
  private Integer pageIndex = null;
  private Float resolution = null;
  private Boolean useEmbeddedFonts = null;
  private Boolean textLayerEnabled = null;
  private Boolean vectorLayerEnabled = null;
  private Boolean imageLayerEnabled = null;
  private Boolean supportJBIGDecoding = null;
  private Integer jpegQuality = null;
  private String password = null;


  public enum TextSmoothingModeEnum {
    HIGHSPEED("highSpeed"),
    HIGHQUALITY("highQuality");

    private String value;

    TextSmoothingModeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private TextSmoothingModeEnum textSmoothingMode = null;


  public enum VectorSmoothingModeEnum {
    HIGHSPEED("highSpeed"),
    HIGHQUALITY("highQuality");

    private String value;

    VectorSmoothingModeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private VectorSmoothingModeEnum vectorSmoothingMode = null;


  public enum ImageInterpolationModeEnum {
    HIGHSPEED("highSpeed"),
    HIGHQUALITY("highQuality");

    private String value;

    ImageInterpolationModeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private ImageInterpolationModeEnum imageInterpolationMode = null;


  public enum RasterOutputFormatEnum {
    BMP("bmp"),
    JPEG("jpeg"),
    PNG("png"),
    TIFF("tiff"),
    GIF("gif");

    private String value;

    RasterOutputFormatEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private RasterOutputFormatEnum rasterOutputFormat = null;

  
  /**
   * Index of a page (zero-based) from which images will be generated (for RasterOutputFormat is TIFF).
   **/
  public PdfRasterRendererOptionsVm startPageIndex(Integer startPageIndex) {
    this.startPageIndex = startPageIndex;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Index of a page (zero-based) from which images will be generated (for RasterOutputFormat is TIFF).")
  @JsonProperty("startPageIndex")
  public Integer getStartPageIndex() {
    return startPageIndex;
  }
  public void setStartPageIndex(Integer startPageIndex) {
    this.startPageIndex = startPageIndex;
  }

  
  /**
   * Index of a page (zero-based) on which generating of images will be finished (for RasterOutputFormat is TIFF).
   **/
  public PdfRasterRendererOptionsVm endPageIndex(Integer endPageIndex) {
    this.endPageIndex = endPageIndex;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Index of a page (zero-based) on which generating of images will be finished (for RasterOutputFormat is TIFF).")
  @JsonProperty("endPageIndex")
  public Integer getEndPageIndex() {
    return endPageIndex;
  }
  public void setEndPageIndex(Integer endPageIndex) {
    this.endPageIndex = endPageIndex;
  }

  
  /**
   * Defines TIFF image compression. (for RasterOutputFormat is TIFF).\r\n            Default value: JPEG
   **/
  public PdfRasterRendererOptionsVm tiffCompression(TiffCompressionEnum tiffCompression) {
    this.tiffCompression = tiffCompression;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Defines TIFF image compression. (for RasterOutputFormat is TIFF).\r\n            Default value: JPEG")
  @JsonProperty("tiffCompression")
  public TiffCompressionEnum getTiffCompression() {
    return tiffCompression;
  }
  public void setTiffCompression(TiffCompressionEnum tiffCompression) {
    this.tiffCompression = tiffCompression;
  }

  
  /**
   * Index of a page (zero-based) from which image will be generated (for RasterOutputFormat is not TIFF).\r\n            Default value: 0 (first page)
   **/
  public PdfRasterRendererOptionsVm pageIndex(Integer pageIndex) {
    this.pageIndex = pageIndex;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Index of a page (zero-based) from which image will be generated (for RasterOutputFormat is not TIFF).\r\n            Default value: 0 (first page)")
  @JsonProperty("pageIndex")
  public Integer getPageIndex() {
    return pageIndex;
  }
  public void setPageIndex(Integer pageIndex) {
    this.pageIndex = pageIndex;
  }

  
  /**
   * Default value: 300
   **/
  public PdfRasterRendererOptionsVm resolution(Float resolution) {
    this.resolution = resolution;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 300")
  @JsonProperty("resolution")
  public Float getResolution() {
    return resolution;
  }
  public void setResolution(Float resolution) {
    this.resolution = resolution;
  }

  
  /**
   * Default value: True
   **/
  public PdfRasterRendererOptionsVm useEmbeddedFonts(Boolean useEmbeddedFonts) {
    this.useEmbeddedFonts = useEmbeddedFonts;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("useEmbeddedFonts")
  public Boolean getUseEmbeddedFonts() {
    return useEmbeddedFonts;
  }
  public void setUseEmbeddedFonts(Boolean useEmbeddedFonts) {
    this.useEmbeddedFonts = useEmbeddedFonts;
  }

  
  /**
   * Default value: True
   **/
  public PdfRasterRendererOptionsVm textLayerEnabled(Boolean textLayerEnabled) {
    this.textLayerEnabled = textLayerEnabled;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("textLayerEnabled")
  public Boolean getTextLayerEnabled() {
    return textLayerEnabled;
  }
  public void setTextLayerEnabled(Boolean textLayerEnabled) {
    this.textLayerEnabled = textLayerEnabled;
  }

  
  /**
   * Default value: True
   **/
  public PdfRasterRendererOptionsVm vectorLayerEnabled(Boolean vectorLayerEnabled) {
    this.vectorLayerEnabled = vectorLayerEnabled;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("vectorLayerEnabled")
  public Boolean getVectorLayerEnabled() {
    return vectorLayerEnabled;
  }
  public void setVectorLayerEnabled(Boolean vectorLayerEnabled) {
    this.vectorLayerEnabled = vectorLayerEnabled;
  }

  
  /**
   * Default value: True
   **/
  public PdfRasterRendererOptionsVm imageLayerEnabled(Boolean imageLayerEnabled) {
    this.imageLayerEnabled = imageLayerEnabled;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("imageLayerEnabled")
  public Boolean getImageLayerEnabled() {
    return imageLayerEnabled;
  }
  public void setImageLayerEnabled(Boolean imageLayerEnabled) {
    this.imageLayerEnabled = imageLayerEnabled;
  }

  
  /**
   * Default value: True
   **/
  public PdfRasterRendererOptionsVm supportJBIGDecoding(Boolean supportJBIGDecoding) {
    this.supportJBIGDecoding = supportJBIGDecoding;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("supportJBIGDecoding")
  public Boolean getSupportJBIGDecoding() {
    return supportJBIGDecoding;
  }
  public void setSupportJBIGDecoding(Boolean supportJBIGDecoding) {
    this.supportJBIGDecoding = supportJBIGDecoding;
  }

  
  /**
   * Default value: 80
   **/
  public PdfRasterRendererOptionsVm jpegQuality(Integer jpegQuality) {
    this.jpegQuality = jpegQuality;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 80")
  @JsonProperty("jpegQuality")
  public Integer getJpegQuality() {
    return jpegQuality;
  }
  public void setJpegQuality(Integer jpegQuality) {
    this.jpegQuality = jpegQuality;
  }

  
  /**
   * Default value: \"\"
   **/
  public PdfRasterRendererOptionsVm password(String password) {
    this.password = password;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: \"\"")
  @JsonProperty("password")
  public String getPassword() {
    return password;
  }
  public void setPassword(String password) {
    this.password = password;
  }

  
  /**
   * Default value: HighQuality
   **/
  public PdfRasterRendererOptionsVm textSmoothingMode(TextSmoothingModeEnum textSmoothingMode) {
    this.textSmoothingMode = textSmoothingMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: HighQuality")
  @JsonProperty("textSmoothingMode")
  public TextSmoothingModeEnum getTextSmoothingMode() {
    return textSmoothingMode;
  }
  public void setTextSmoothingMode(TextSmoothingModeEnum textSmoothingMode) {
    this.textSmoothingMode = textSmoothingMode;
  }

  
  /**
   * Default value: HighQuality
   **/
  public PdfRasterRendererOptionsVm vectorSmoothingMode(VectorSmoothingModeEnum vectorSmoothingMode) {
    this.vectorSmoothingMode = vectorSmoothingMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: HighQuality")
  @JsonProperty("vectorSmoothingMode")
  public VectorSmoothingModeEnum getVectorSmoothingMode() {
    return vectorSmoothingMode;
  }
  public void setVectorSmoothingMode(VectorSmoothingModeEnum vectorSmoothingMode) {
    this.vectorSmoothingMode = vectorSmoothingMode;
  }

  
  /**
   * Default value: HighQuality
   **/
  public PdfRasterRendererOptionsVm imageInterpolationMode(ImageInterpolationModeEnum imageInterpolationMode) {
    this.imageInterpolationMode = imageInterpolationMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: HighQuality")
  @JsonProperty("imageInterpolationMode")
  public ImageInterpolationModeEnum getImageInterpolationMode() {
    return imageInterpolationMode;
  }
  public void setImageInterpolationMode(ImageInterpolationModeEnum imageInterpolationMode) {
    this.imageInterpolationMode = imageInterpolationMode;
  }

  
  /**
   * File format in which page of PDF file will be generated.\r\n            Default value: PNG file
   **/
  public PdfRasterRendererOptionsVm rasterOutputFormat(RasterOutputFormatEnum rasterOutputFormat) {
    this.rasterOutputFormat = rasterOutputFormat;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "File format in which page of PDF file will be generated.\r\n            Default value: PNG file")
  @JsonProperty("rasterOutputFormat")
  public RasterOutputFormatEnum getRasterOutputFormat() {
    return rasterOutputFormat;
  }
  public void setRasterOutputFormat(RasterOutputFormatEnum rasterOutputFormat) {
    this.rasterOutputFormat = rasterOutputFormat;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PdfRasterRendererOptionsVm pdfRasterRendererOptionsVm = (PdfRasterRendererOptionsVm) o;
    return Objects.equals(this.startPageIndex, pdfRasterRendererOptionsVm.startPageIndex) &&
        Objects.equals(this.endPageIndex, pdfRasterRendererOptionsVm.endPageIndex) &&
        Objects.equals(this.tiffCompression, pdfRasterRendererOptionsVm.tiffCompression) &&
        Objects.equals(this.pageIndex, pdfRasterRendererOptionsVm.pageIndex) &&
        Objects.equals(this.resolution, pdfRasterRendererOptionsVm.resolution) &&
        Objects.equals(this.useEmbeddedFonts, pdfRasterRendererOptionsVm.useEmbeddedFonts) &&
        Objects.equals(this.textLayerEnabled, pdfRasterRendererOptionsVm.textLayerEnabled) &&
        Objects.equals(this.vectorLayerEnabled, pdfRasterRendererOptionsVm.vectorLayerEnabled) &&
        Objects.equals(this.imageLayerEnabled, pdfRasterRendererOptionsVm.imageLayerEnabled) &&
        Objects.equals(this.supportJBIGDecoding, pdfRasterRendererOptionsVm.supportJBIGDecoding) &&
        Objects.equals(this.jpegQuality, pdfRasterRendererOptionsVm.jpegQuality) &&
        Objects.equals(this.password, pdfRasterRendererOptionsVm.password) &&
        Objects.equals(this.textSmoothingMode, pdfRasterRendererOptionsVm.textSmoothingMode) &&
        Objects.equals(this.vectorSmoothingMode, pdfRasterRendererOptionsVm.vectorSmoothingMode) &&
        Objects.equals(this.imageInterpolationMode, pdfRasterRendererOptionsVm.imageInterpolationMode) &&
        Objects.equals(this.rasterOutputFormat, pdfRasterRendererOptionsVm.rasterOutputFormat);
  }

  @Override
  public int hashCode() {
    return Objects.hash(startPageIndex, endPageIndex, tiffCompression, pageIndex, resolution, useEmbeddedFonts, textLayerEnabled, vectorLayerEnabled, imageLayerEnabled, supportJBIGDecoding, jpegQuality, password, textSmoothingMode, vectorSmoothingMode, imageInterpolationMode, rasterOutputFormat);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PdfRasterRendererOptionsVm {\n");
    
    sb.append("    startPageIndex: ").append(toIndentedString(startPageIndex)).append("\n");
    sb.append("    endPageIndex: ").append(toIndentedString(endPageIndex)).append("\n");
    sb.append("    tiffCompression: ").append(toIndentedString(tiffCompression)).append("\n");
    sb.append("    pageIndex: ").append(toIndentedString(pageIndex)).append("\n");
    sb.append("    resolution: ").append(toIndentedString(resolution)).append("\n");
    sb.append("    useEmbeddedFonts: ").append(toIndentedString(useEmbeddedFonts)).append("\n");
    sb.append("    textLayerEnabled: ").append(toIndentedString(textLayerEnabled)).append("\n");
    sb.append("    vectorLayerEnabled: ").append(toIndentedString(vectorLayerEnabled)).append("\n");
    sb.append("    imageLayerEnabled: ").append(toIndentedString(imageLayerEnabled)).append("\n");
    sb.append("    supportJBIGDecoding: ").append(toIndentedString(supportJBIGDecoding)).append("\n");
    sb.append("    jpegQuality: ").append(toIndentedString(jpegQuality)).append("\n");
    sb.append("    password: ").append(toIndentedString(password)).append("\n");
    sb.append("    textSmoothingMode: ").append(toIndentedString(textSmoothingMode)).append("\n");
    sb.append("    vectorSmoothingMode: ").append(toIndentedString(vectorSmoothingMode)).append("\n");
    sb.append("    imageInterpolationMode: ").append(toIndentedString(imageInterpolationMode)).append("\n");
    sb.append("    rasterOutputFormat: ").append(toIndentedString(rasterOutputFormat)).append("\n");
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

