package com.bytescout.client.model;

import java.util.Objects;
import com.bytescout.client.model.BarCodeSizeVm;
import com.bytescout.client.model.MarginsVm;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class BarcodeOptionsVm   {
  


  public enum OutputFileTypeEnum {
    PNG("png"),
    BMP("bmp"),
    JPEG("jpeg");

    private String value;

    OutputFileTypeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private OutputFileTypeEnum outputFileType = null;
  private Boolean tiffUse1BitFormat = null;
  private Boolean produceMonochromeImages = null;
  private String additionalCaption = null;
  private Boolean addChecksum = null;
  private Boolean addChecksumToCaption = null;
  private String caption = null;
  private Boolean drawCaption = null;
  private Boolean drawCaptionFor2DBarcodes = null;
  private Boolean drawQuietZones = null;


  public enum SymbologyEnum {
    CODE128("code128"),
    CODE39("code39"),
    POSTNET("postnet"),
    UPCA("upca"),
    EAN8("ean8"),
    ISBN("isbn"),
    CODABAR("codabar"),
    I2OF5("i2of5"),
    CODE93("code93"),
    EAN13("ean13"),
    JAN13("jan13"),
    BOOKLAND("bookland"),
    UPCE("upce"),
    PDF417("pdf417"),
    PDF417TRUNCATED("pdf417Truncated"),
    DATAMATRIX("dataMatrix"),
    QRCODE("qrCode"),
    AZTEC("aztec"),
    PLANET("planet"),
    EAN128("ean128"),
    GS1_128("gs1_128"),
    USPSSACKLABEL("uspsSackLabel"),
    USPSTRAYLABEL("uspsTrayLabel"),
    DEUTSCHEPOSTIDENTCODE("deutschePostIdentcode"),
    DEUTSCHEPOSTLEITCODE("deutschePostLeitcode"),
    NUMLY("numly"),
    PZN("pzn"),
    OPTICALPRODUCT("opticalProduct"),
    SWISSPOSTPARCEL("swissPostParcel"),
    ROYALMAIL("royalMail"),
    DUTCHKIX("dutchKix"),
    SINGAPOREPOSTALCODE("singaporePostalCode"),
    EAN2("ean2"),
    EAN5("ean5"),
    EAN14("ean14"),
    MACROPDF417("macroPDF417"),
    MICROPDF417("microPDF417"),
    GS1_DATAMATRIX("gs1_DataMatrix"),
    TELEPEN("telepen"),
    INTELLIGENTMAIL("intelligentMail"),
    GS1_DATABAR_OMNIDIRECTIONAL("gs1_DataBar_Omnidirectional"),
    GS1_DATABAR_TRUNCATED("gs1_DataBar_Truncated"),
    GS1_DATABAR_STACKED("gs1_DataBar_Stacked"),
    GS1_DATABAR_STACKED_OMNIDIRECTIONAL("gs1_DataBar_Stacked_Omnidirectional"),
    GS1_DATABAR_LIMITED("gs1_DataBar_Limited"),
    GS1_DATABAR_EXPANDED("gs1_DataBar_Expanded"),
    GS1_DATABAR_EXPANDED_STACKED("gs1_DataBar_Expanded_Stacked"),
    MAXICODE("maxiCode"),
    PLESSEY("plessey"),
    MSI("msi"),
    ITF14("itf14"),
    GTIN12("gtin12"),
    GTIN8("gtin8"),
    GTIN13("gtin13"),
    GTIN14("gtin14");

    private String value;

    SymbologyEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private SymbologyEnum symbology = null;
  private String supplementValue = null;
  private String additionalCaptionFont = null;
  private Integer barHeight = null;
  private String captionFont = null;
  private Integer narrowBarWidth = null;
  private Integer wideToNarrowRatio = null;


  public enum AdditionalCaptionPositionEnum {
    ABOVE("above"),
    BELOW("below"),
    BEFORE("before"),
    AFTER("after");

    private String value;

    AdditionalCaptionPositionEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private AdditionalCaptionPositionEnum additionalCaptionPosition = null;


  public enum AngleEnum {
    DEGREES0("degrees0"),
    DEGREES90("degrees90"),
    DEGREES180("degrees180"),
    DEGREES270("degrees270");

    private String value;

    AngleEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private AngleEnum angle = null;
  private String backColor = null;


  public enum CaptionPositionEnum {
    ABOVE("above"),
    BELOW("below"),
    BEFORE("before"),
    AFTER("after");

    private String value;

    CaptionPositionEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private CaptionPositionEnum captionPosition = null;
  private String foreColor = null;
  private MarginsVm margins = null;


  public enum SmoothingModeEnum {
    DEFAULT("default"),
    HIGHSPEED("highSpeed"),
    HIGHQUALITY("highQuality"),
    NONE("none"),
    ANTIALIAS("antiAlias"),
    INVALID("invalid");

    private String value;

    SmoothingModeEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private SmoothingModeEnum smoothingMode = null;


  public enum RenderingHintEnum {
    SYSTEMDEFAULT("systemDefault"),
    SINGLEBITPERPIXELGRIDFIT("singleBitPerPixelGridFit"),
    SINGLEBITPERPIXEL("singleBitPerPixel"),
    ANTIALIASGRIDFIT("antiAliasGridFit"),
    ANTIALIAS("antiAlias"),
    CLEARTYPEGRIDFIT("clearTypeGridFit");

    private String value;

    RenderingHintEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private RenderingHintEnum renderingHint = null;
  private Float resolutionX = null;
  private Float resolutionY = null;
  private Boolean cutUnusedSpace = null;
  private Boolean preserveMinReadableSize = null;
  private BarCodeSizeVm size = null;

  
  /**
   * File format in which barcode will be generated.\r\n            Default value: PNG file
   **/
  public BarcodeOptionsVm outputFileType(OutputFileTypeEnum outputFileType) {
    this.outputFileType = outputFileType;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "File format in which barcode will be generated.\r\n            Default value: PNG file")
  @JsonProperty("outputFileType")
  public OutputFileTypeEnum getOutputFileType() {
    return outputFileType;
  }
  public void setOutputFileType(OutputFileTypeEnum outputFileType) {
    this.outputFileType = outputFileType;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeOptionsVm tiffUse1BitFormat(Boolean tiffUse1BitFormat) {
    this.tiffUse1BitFormat = tiffUse1BitFormat;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("tiffUse1BitFormat")
  public Boolean getTiffUse1BitFormat() {
    return tiffUse1BitFormat;
  }
  public void setTiffUse1BitFormat(Boolean tiffUse1BitFormat) {
    this.tiffUse1BitFormat = tiffUse1BitFormat;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeOptionsVm produceMonochromeImages(Boolean produceMonochromeImages) {
    this.produceMonochromeImages = produceMonochromeImages;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("produceMonochromeImages")
  public Boolean getProduceMonochromeImages() {
    return produceMonochromeImages;
  }
  public void setProduceMonochromeImages(Boolean produceMonochromeImages) {
    this.produceMonochromeImages = produceMonochromeImages;
  }

  
  /**
   * Default value:
   **/
  public BarcodeOptionsVm additionalCaption(String additionalCaption) {
    this.additionalCaption = additionalCaption;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value:")
  @JsonProperty("additionalCaption")
  public String getAdditionalCaption() {
    return additionalCaption;
  }
  public void setAdditionalCaption(String additionalCaption) {
    this.additionalCaption = additionalCaption;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeOptionsVm addChecksum(Boolean addChecksum) {
    this.addChecksum = addChecksum;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("addChecksum")
  public Boolean getAddChecksum() {
    return addChecksum;
  }
  public void setAddChecksum(Boolean addChecksum) {
    this.addChecksum = addChecksum;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeOptionsVm addChecksumToCaption(Boolean addChecksumToCaption) {
    this.addChecksumToCaption = addChecksumToCaption;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("addChecksumToCaption")
  public Boolean getAddChecksumToCaption() {
    return addChecksumToCaption;
  }
  public void setAddChecksumToCaption(Boolean addChecksumToCaption) {
    this.addChecksumToCaption = addChecksumToCaption;
  }

  
  /**
   * 
   **/
  public BarcodeOptionsVm caption(String caption) {
    this.caption = caption;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("caption")
  public String getCaption() {
    return caption;
  }
  public void setCaption(String caption) {
    this.caption = caption;
  }

  
  /**
   * Default value: True
   **/
  public BarcodeOptionsVm drawCaption(Boolean drawCaption) {
    this.drawCaption = drawCaption;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("drawCaption")
  public Boolean getDrawCaption() {
    return drawCaption;
  }
  public void setDrawCaption(Boolean drawCaption) {
    this.drawCaption = drawCaption;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeOptionsVm drawCaptionFor2DBarcodes(Boolean drawCaptionFor2DBarcodes) {
    this.drawCaptionFor2DBarcodes = drawCaptionFor2DBarcodes;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("drawCaptionFor2DBarcodes")
  public Boolean getDrawCaptionFor2DBarcodes() {
    return drawCaptionFor2DBarcodes;
  }
  public void setDrawCaptionFor2DBarcodes(Boolean drawCaptionFor2DBarcodes) {
    this.drawCaptionFor2DBarcodes = drawCaptionFor2DBarcodes;
  }

  
  /**
   * Default value: True
   **/
  public BarcodeOptionsVm drawQuietZones(Boolean drawQuietZones) {
    this.drawQuietZones = drawQuietZones;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("drawQuietZones")
  public Boolean getDrawQuietZones() {
    return drawQuietZones;
  }
  public void setDrawQuietZones(Boolean drawQuietZones) {
    this.drawQuietZones = drawQuietZones;
  }

  
  /**
   * Default value: Code39
   **/
  public BarcodeOptionsVm symbology(SymbologyEnum symbology) {
    this.symbology = symbology;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Code39")
  @JsonProperty("symbology")
  public SymbologyEnum getSymbology() {
    return symbology;
  }
  public void setSymbology(SymbologyEnum symbology) {
    this.symbology = symbology;
  }

  
  /**
   * Default value:
   **/
  public BarcodeOptionsVm supplementValue(String supplementValue) {
    this.supplementValue = supplementValue;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value:")
  @JsonProperty("supplementValue")
  public String getSupplementValue() {
    return supplementValue;
  }
  public void setSupplementValue(String supplementValue) {
    this.supplementValue = supplementValue;
  }

  
  /**
   * Default value: Arial, 12
   **/
  public BarcodeOptionsVm additionalCaptionFont(String additionalCaptionFont) {
    this.additionalCaptionFont = additionalCaptionFont;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Arial, 12")
  @JsonProperty("additionalCaptionFont")
  public String getAdditionalCaptionFont() {
    return additionalCaptionFont;
  }
  public void setAdditionalCaptionFont(String additionalCaptionFont) {
    this.additionalCaptionFont = additionalCaptionFont;
  }

  
  /**
   * Default value: 50
   **/
  public BarcodeOptionsVm barHeight(Integer barHeight) {
    this.barHeight = barHeight;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 50")
  @JsonProperty("barHeight")
  public Integer getBarHeight() {
    return barHeight;
  }
  public void setBarHeight(Integer barHeight) {
    this.barHeight = barHeight;
  }

  
  /**
   * Default value: Arial, 12
   **/
  public BarcodeOptionsVm captionFont(String captionFont) {
    this.captionFont = captionFont;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Arial, 12")
  @JsonProperty("captionFont")
  public String getCaptionFont() {
    return captionFont;
  }
  public void setCaptionFont(String captionFont) {
    this.captionFont = captionFont;
  }

  
  /**
   * Default value: 3
   **/
  public BarcodeOptionsVm narrowBarWidth(Integer narrowBarWidth) {
    this.narrowBarWidth = narrowBarWidth;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 3")
  @JsonProperty("narrowBarWidth")
  public Integer getNarrowBarWidth() {
    return narrowBarWidth;
  }
  public void setNarrowBarWidth(Integer narrowBarWidth) {
    this.narrowBarWidth = narrowBarWidth;
  }

  
  /**
   * Default value: 3
   **/
  public BarcodeOptionsVm wideToNarrowRatio(Integer wideToNarrowRatio) {
    this.wideToNarrowRatio = wideToNarrowRatio;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 3")
  @JsonProperty("wideToNarrowRatio")
  public Integer getWideToNarrowRatio() {
    return wideToNarrowRatio;
  }
  public void setWideToNarrowRatio(Integer wideToNarrowRatio) {
    this.wideToNarrowRatio = wideToNarrowRatio;
  }

  
  /**
   * Default value: Above
   **/
  public BarcodeOptionsVm additionalCaptionPosition(AdditionalCaptionPositionEnum additionalCaptionPosition) {
    this.additionalCaptionPosition = additionalCaptionPosition;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Above")
  @JsonProperty("additionalCaptionPosition")
  public AdditionalCaptionPositionEnum getAdditionalCaptionPosition() {
    return additionalCaptionPosition;
  }
  public void setAdditionalCaptionPosition(AdditionalCaptionPositionEnum additionalCaptionPosition) {
    this.additionalCaptionPosition = additionalCaptionPosition;
  }

  
  /**
   * Default value: Degrees0
   **/
  public BarcodeOptionsVm angle(AngleEnum angle) {
    this.angle = angle;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Degrees0")
  @JsonProperty("angle")
  public AngleEnum getAngle() {
    return angle;
  }
  public void setAngle(AngleEnum angle) {
    this.angle = angle;
  }

  
  /**
   * Default value: Color [White]
   **/
  public BarcodeOptionsVm backColor(String backColor) {
    this.backColor = backColor;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Color [White]")
  @JsonProperty("backColor")
  public String getBackColor() {
    return backColor;
  }
  public void setBackColor(String backColor) {
    this.backColor = backColor;
  }

  
  /**
   * Default value: Below
   **/
  public BarcodeOptionsVm captionPosition(CaptionPositionEnum captionPosition) {
    this.captionPosition = captionPosition;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Below")
  @JsonProperty("captionPosition")
  public CaptionPositionEnum getCaptionPosition() {
    return captionPosition;
  }
  public void setCaptionPosition(CaptionPositionEnum captionPosition) {
    this.captionPosition = captionPosition;
  }

  
  /**
   * Default value: Color [Black]
   **/
  public BarcodeOptionsVm foreColor(String foreColor) {
    this.foreColor = foreColor;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Color [Black]")
  @JsonProperty("foreColor")
  public String getForeColor() {
    return foreColor;
  }
  public void setForeColor(String foreColor) {
    this.foreColor = foreColor;
  }

  
  /**
   * Default value: [10;10;10;10]
   **/
  public BarcodeOptionsVm margins(MarginsVm margins) {
    this.margins = margins;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: [10;10;10;10]")
  @JsonProperty("margins")
  public MarginsVm getMargins() {
    return margins;
  }
  public void setMargins(MarginsVm margins) {
    this.margins = margins;
  }

  
  /**
   * Default value: Default
   **/
  public BarcodeOptionsVm smoothingMode(SmoothingModeEnum smoothingMode) {
    this.smoothingMode = smoothingMode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: Default")
  @JsonProperty("smoothingMode")
  public SmoothingModeEnum getSmoothingMode() {
    return smoothingMode;
  }
  public void setSmoothingMode(SmoothingModeEnum smoothingMode) {
    this.smoothingMode = smoothingMode;
  }

  
  /**
   * Default value: SystemDefault
   **/
  public BarcodeOptionsVm renderingHint(RenderingHintEnum renderingHint) {
    this.renderingHint = renderingHint;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: SystemDefault")
  @JsonProperty("renderingHint")
  public RenderingHintEnum getRenderingHint() {
    return renderingHint;
  }
  public void setRenderingHint(RenderingHintEnum renderingHint) {
    this.renderingHint = renderingHint;
  }

  
  /**
   * Default value: 96
   **/
  public BarcodeOptionsVm resolutionX(Float resolutionX) {
    this.resolutionX = resolutionX;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 96")
  @JsonProperty("resolutionX")
  public Float getResolutionX() {
    return resolutionX;
  }
  public void setResolutionX(Float resolutionX) {
    this.resolutionX = resolutionX;
  }

  
  /**
   * Default value: 96
   **/
  public BarcodeOptionsVm resolutionY(Float resolutionY) {
    this.resolutionY = resolutionY;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: 96")
  @JsonProperty("resolutionY")
  public Float getResolutionY() {
    return resolutionY;
  }
  public void setResolutionY(Float resolutionY) {
    this.resolutionY = resolutionY;
  }

  
  /**
   * Default value: False
   **/
  public BarcodeOptionsVm cutUnusedSpace(Boolean cutUnusedSpace) {
    this.cutUnusedSpace = cutUnusedSpace;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: False")
  @JsonProperty("cutUnusedSpace")
  public Boolean getCutUnusedSpace() {
    return cutUnusedSpace;
  }
  public void setCutUnusedSpace(Boolean cutUnusedSpace) {
    this.cutUnusedSpace = cutUnusedSpace;
  }

  
  /**
   * Default value: True
   **/
  public BarcodeOptionsVm preserveMinReadableSize(Boolean preserveMinReadableSize) {
    this.preserveMinReadableSize = preserveMinReadableSize;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "Default value: True")
  @JsonProperty("preserveMinReadableSize")
  public Boolean getPreserveMinReadableSize() {
    return preserveMinReadableSize;
  }
  public void setPreserveMinReadableSize(Boolean preserveMinReadableSize) {
    this.preserveMinReadableSize = preserveMinReadableSize;
  }

  
  /**
   * The size of area specified in units in which barcode will be generated.
   **/
  public BarcodeOptionsVm size(BarCodeSizeVm size) {
    this.size = size;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "The size of area specified in units in which barcode will be generated.")
  @JsonProperty("size")
  public BarCodeSizeVm getSize() {
    return size;
  }
  public void setSize(BarCodeSizeVm size) {
    this.size = size;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BarcodeOptionsVm barcodeOptionsVm = (BarcodeOptionsVm) o;
    return Objects.equals(this.outputFileType, barcodeOptionsVm.outputFileType) &&
        Objects.equals(this.tiffUse1BitFormat, barcodeOptionsVm.tiffUse1BitFormat) &&
        Objects.equals(this.produceMonochromeImages, barcodeOptionsVm.produceMonochromeImages) &&
        Objects.equals(this.additionalCaption, barcodeOptionsVm.additionalCaption) &&
        Objects.equals(this.addChecksum, barcodeOptionsVm.addChecksum) &&
        Objects.equals(this.addChecksumToCaption, barcodeOptionsVm.addChecksumToCaption) &&
        Objects.equals(this.caption, barcodeOptionsVm.caption) &&
        Objects.equals(this.drawCaption, barcodeOptionsVm.drawCaption) &&
        Objects.equals(this.drawCaptionFor2DBarcodes, barcodeOptionsVm.drawCaptionFor2DBarcodes) &&
        Objects.equals(this.drawQuietZones, barcodeOptionsVm.drawQuietZones) &&
        Objects.equals(this.symbology, barcodeOptionsVm.symbology) &&
        Objects.equals(this.supplementValue, barcodeOptionsVm.supplementValue) &&
        Objects.equals(this.additionalCaptionFont, barcodeOptionsVm.additionalCaptionFont) &&
        Objects.equals(this.barHeight, barcodeOptionsVm.barHeight) &&
        Objects.equals(this.captionFont, barcodeOptionsVm.captionFont) &&
        Objects.equals(this.narrowBarWidth, barcodeOptionsVm.narrowBarWidth) &&
        Objects.equals(this.wideToNarrowRatio, barcodeOptionsVm.wideToNarrowRatio) &&
        Objects.equals(this.additionalCaptionPosition, barcodeOptionsVm.additionalCaptionPosition) &&
        Objects.equals(this.angle, barcodeOptionsVm.angle) &&
        Objects.equals(this.backColor, barcodeOptionsVm.backColor) &&
        Objects.equals(this.captionPosition, barcodeOptionsVm.captionPosition) &&
        Objects.equals(this.foreColor, barcodeOptionsVm.foreColor) &&
        Objects.equals(this.margins, barcodeOptionsVm.margins) &&
        Objects.equals(this.smoothingMode, barcodeOptionsVm.smoothingMode) &&
        Objects.equals(this.renderingHint, barcodeOptionsVm.renderingHint) &&
        Objects.equals(this.resolutionX, barcodeOptionsVm.resolutionX) &&
        Objects.equals(this.resolutionY, barcodeOptionsVm.resolutionY) &&
        Objects.equals(this.cutUnusedSpace, barcodeOptionsVm.cutUnusedSpace) &&
        Objects.equals(this.preserveMinReadableSize, barcodeOptionsVm.preserveMinReadableSize) &&
        Objects.equals(this.size, barcodeOptionsVm.size);
  }

  @Override
  public int hashCode() {
    return Objects.hash(outputFileType, tiffUse1BitFormat, produceMonochromeImages, additionalCaption, addChecksum, addChecksumToCaption, caption, drawCaption, drawCaptionFor2DBarcodes, drawQuietZones, symbology, supplementValue, additionalCaptionFont, barHeight, captionFont, narrowBarWidth, wideToNarrowRatio, additionalCaptionPosition, angle, backColor, captionPosition, foreColor, margins, smoothingMode, renderingHint, resolutionX, resolutionY, cutUnusedSpace, preserveMinReadableSize, size);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BarcodeOptionsVm {\n");
    
    sb.append("    outputFileType: ").append(toIndentedString(outputFileType)).append("\n");
    sb.append("    tiffUse1BitFormat: ").append(toIndentedString(tiffUse1BitFormat)).append("\n");
    sb.append("    produceMonochromeImages: ").append(toIndentedString(produceMonochromeImages)).append("\n");
    sb.append("    additionalCaption: ").append(toIndentedString(additionalCaption)).append("\n");
    sb.append("    addChecksum: ").append(toIndentedString(addChecksum)).append("\n");
    sb.append("    addChecksumToCaption: ").append(toIndentedString(addChecksumToCaption)).append("\n");
    sb.append("    caption: ").append(toIndentedString(caption)).append("\n");
    sb.append("    drawCaption: ").append(toIndentedString(drawCaption)).append("\n");
    sb.append("    drawCaptionFor2DBarcodes: ").append(toIndentedString(drawCaptionFor2DBarcodes)).append("\n");
    sb.append("    drawQuietZones: ").append(toIndentedString(drawQuietZones)).append("\n");
    sb.append("    symbology: ").append(toIndentedString(symbology)).append("\n");
    sb.append("    supplementValue: ").append(toIndentedString(supplementValue)).append("\n");
    sb.append("    additionalCaptionFont: ").append(toIndentedString(additionalCaptionFont)).append("\n");
    sb.append("    barHeight: ").append(toIndentedString(barHeight)).append("\n");
    sb.append("    captionFont: ").append(toIndentedString(captionFont)).append("\n");
    sb.append("    narrowBarWidth: ").append(toIndentedString(narrowBarWidth)).append("\n");
    sb.append("    wideToNarrowRatio: ").append(toIndentedString(wideToNarrowRatio)).append("\n");
    sb.append("    additionalCaptionPosition: ").append(toIndentedString(additionalCaptionPosition)).append("\n");
    sb.append("    angle: ").append(toIndentedString(angle)).append("\n");
    sb.append("    backColor: ").append(toIndentedString(backColor)).append("\n");
    sb.append("    captionPosition: ").append(toIndentedString(captionPosition)).append("\n");
    sb.append("    foreColor: ").append(toIndentedString(foreColor)).append("\n");
    sb.append("    margins: ").append(toIndentedString(margins)).append("\n");
    sb.append("    smoothingMode: ").append(toIndentedString(smoothingMode)).append("\n");
    sb.append("    renderingHint: ").append(toIndentedString(renderingHint)).append("\n");
    sb.append("    resolutionX: ").append(toIndentedString(resolutionX)).append("\n");
    sb.append("    resolutionY: ").append(toIndentedString(resolutionY)).append("\n");
    sb.append("    cutUnusedSpace: ").append(toIndentedString(cutUnusedSpace)).append("\n");
    sb.append("    preserveMinReadableSize: ").append(toIndentedString(preserveMinReadableSize)).append("\n");
    sb.append("    size: ").append(toIndentedString(size)).append("\n");
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

