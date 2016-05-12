package com.bytescout.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-04-13T18:55:29.062+06:00")
public class BarcodeTypeSelector   {
  
  private Boolean ean8 = null;
  private Boolean gtin8 = null;
  private Boolean ean13 = null;
  private Boolean gtin13 = null;
  private Boolean upce = null;
  private Boolean upca = null;
  private Boolean gtin12 = null;
  private Boolean interleaved2of5 = null;
  private Boolean circulari2of5 = null;
  private Boolean itf14 = null;
  private Boolean gtin14 = null;
  private Boolean code39 = null;
  private Boolean code39Extended = null;
  private Boolean code39Mod43 = null;
  private Boolean code39Mod43Extended = null;
  private Boolean pzn = null;
  private Boolean upu = null;
  private Boolean code128 = null;
  private Boolean ean2 = null;
  private Boolean ean5 = null;
  private Boolean gs1 = null;
  private Boolean codabar = null;
  private Boolean trioptic = null;
  private Boolean patchCode = null;
  private Boolean gs1DataBarOmnidirectional = null;
  private Boolean gs1DataBarExpanded = null;
  private Boolean gs1DataBarLimited = null;
  private Boolean gs1DataBarStacked = null;
  private Boolean gs1DataBarExpandedStacked = null;
  private Boolean pdf417 = null;
  private Boolean dataMatrix = null;
  private Boolean qrCode = null;
  private Boolean aztec = null;
  private Boolean maxiCode = null;
  private Boolean micr = null;
  private Boolean intelligentMail = null;
  private Boolean royalMail = null;
  private Boolean royalMailKIX = null;
  private Boolean australianPostCode = null;
  private Boolean codablockF = null;
  private Boolean code16K = null;
  private Boolean postNet = null;
  private Boolean microPDF = null;
  private Boolean code93 = null;
  private Boolean msi = null;
  private Boolean pharmacode = null;
  private Boolean segment = null;
  private Boolean circle = null;
  private Boolean oval = null;
  private Boolean checkbox = null;
  private Boolean horizontalLine = null;
  private Boolean verticalLine = null;
  private Boolean underlinedField = null;
  private Boolean all1D = null;
  private Boolean all2D = null;
  private Boolean allOMRElements = null;
  private Boolean all = null;

  
  /**
   **/
  public BarcodeTypeSelector ean8(Boolean ean8) {
    this.ean8 = ean8;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("ean8")
  public Boolean getEan8() {
    return ean8;
  }
  public void setEan8(Boolean ean8) {
    this.ean8 = ean8;
  }

  
  /**
   **/
  public BarcodeTypeSelector gtin8(Boolean gtin8) {
    this.gtin8 = gtin8;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("gtin8")
  public Boolean getGtin8() {
    return gtin8;
  }
  public void setGtin8(Boolean gtin8) {
    this.gtin8 = gtin8;
  }

  
  /**
   **/
  public BarcodeTypeSelector ean13(Boolean ean13) {
    this.ean13 = ean13;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("ean13")
  public Boolean getEan13() {
    return ean13;
  }
  public void setEan13(Boolean ean13) {
    this.ean13 = ean13;
  }

  
  /**
   **/
  public BarcodeTypeSelector gtin13(Boolean gtin13) {
    this.gtin13 = gtin13;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("gtin13")
  public Boolean getGtin13() {
    return gtin13;
  }
  public void setGtin13(Boolean gtin13) {
    this.gtin13 = gtin13;
  }

  
  /**
   **/
  public BarcodeTypeSelector upce(Boolean upce) {
    this.upce = upce;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("upce")
  public Boolean getUpce() {
    return upce;
  }
  public void setUpce(Boolean upce) {
    this.upce = upce;
  }

  
  /**
   **/
  public BarcodeTypeSelector upca(Boolean upca) {
    this.upca = upca;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("upca")
  public Boolean getUpca() {
    return upca;
  }
  public void setUpca(Boolean upca) {
    this.upca = upca;
  }

  
  /**
   **/
  public BarcodeTypeSelector gtin12(Boolean gtin12) {
    this.gtin12 = gtin12;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("gtin12")
  public Boolean getGtin12() {
    return gtin12;
  }
  public void setGtin12(Boolean gtin12) {
    this.gtin12 = gtin12;
  }

  
  /**
   **/
  public BarcodeTypeSelector interleaved2of5(Boolean interleaved2of5) {
    this.interleaved2of5 = interleaved2of5;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("interleaved2of5")
  public Boolean getInterleaved2of5() {
    return interleaved2of5;
  }
  public void setInterleaved2of5(Boolean interleaved2of5) {
    this.interleaved2of5 = interleaved2of5;
  }

  
  /**
   **/
  public BarcodeTypeSelector circulari2of5(Boolean circulari2of5) {
    this.circulari2of5 = circulari2of5;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("circulari2of5")
  public Boolean getCirculari2of5() {
    return circulari2of5;
  }
  public void setCirculari2of5(Boolean circulari2of5) {
    this.circulari2of5 = circulari2of5;
  }

  
  /**
   **/
  public BarcodeTypeSelector itf14(Boolean itf14) {
    this.itf14 = itf14;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("itf14")
  public Boolean getItf14() {
    return itf14;
  }
  public void setItf14(Boolean itf14) {
    this.itf14 = itf14;
  }

  
  /**
   **/
  public BarcodeTypeSelector gtin14(Boolean gtin14) {
    this.gtin14 = gtin14;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("gtin14")
  public Boolean getGtin14() {
    return gtin14;
  }
  public void setGtin14(Boolean gtin14) {
    this.gtin14 = gtin14;
  }

  
  /**
   **/
  public BarcodeTypeSelector code39(Boolean code39) {
    this.code39 = code39;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("code39")
  public Boolean getCode39() {
    return code39;
  }
  public void setCode39(Boolean code39) {
    this.code39 = code39;
  }

  
  /**
   **/
  public BarcodeTypeSelector code39Extended(Boolean code39Extended) {
    this.code39Extended = code39Extended;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("code39Extended")
  public Boolean getCode39Extended() {
    return code39Extended;
  }
  public void setCode39Extended(Boolean code39Extended) {
    this.code39Extended = code39Extended;
  }

  
  /**
   **/
  public BarcodeTypeSelector code39Mod43(Boolean code39Mod43) {
    this.code39Mod43 = code39Mod43;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("code39Mod43")
  public Boolean getCode39Mod43() {
    return code39Mod43;
  }
  public void setCode39Mod43(Boolean code39Mod43) {
    this.code39Mod43 = code39Mod43;
  }

  
  /**
   **/
  public BarcodeTypeSelector code39Mod43Extended(Boolean code39Mod43Extended) {
    this.code39Mod43Extended = code39Mod43Extended;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("code39Mod43Extended")
  public Boolean getCode39Mod43Extended() {
    return code39Mod43Extended;
  }
  public void setCode39Mod43Extended(Boolean code39Mod43Extended) {
    this.code39Mod43Extended = code39Mod43Extended;
  }

  
  /**
   **/
  public BarcodeTypeSelector pzn(Boolean pzn) {
    this.pzn = pzn;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("pzn")
  public Boolean getPzn() {
    return pzn;
  }
  public void setPzn(Boolean pzn) {
    this.pzn = pzn;
  }

  
  /**
   **/
  public BarcodeTypeSelector upu(Boolean upu) {
    this.upu = upu;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("upu")
  public Boolean getUpu() {
    return upu;
  }
  public void setUpu(Boolean upu) {
    this.upu = upu;
  }

  
  /**
   **/
  public BarcodeTypeSelector code128(Boolean code128) {
    this.code128 = code128;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("code128")
  public Boolean getCode128() {
    return code128;
  }
  public void setCode128(Boolean code128) {
    this.code128 = code128;
  }

  
  /**
   **/
  public BarcodeTypeSelector ean2(Boolean ean2) {
    this.ean2 = ean2;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("ean2")
  public Boolean getEan2() {
    return ean2;
  }
  public void setEan2(Boolean ean2) {
    this.ean2 = ean2;
  }

  
  /**
   **/
  public BarcodeTypeSelector ean5(Boolean ean5) {
    this.ean5 = ean5;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("ean5")
  public Boolean getEan5() {
    return ean5;
  }
  public void setEan5(Boolean ean5) {
    this.ean5 = ean5;
  }

  
  /**
   **/
  public BarcodeTypeSelector gs1(Boolean gs1) {
    this.gs1 = gs1;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("gs1")
  public Boolean getGs1() {
    return gs1;
  }
  public void setGs1(Boolean gs1) {
    this.gs1 = gs1;
  }

  
  /**
   **/
  public BarcodeTypeSelector codabar(Boolean codabar) {
    this.codabar = codabar;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("codabar")
  public Boolean getCodabar() {
    return codabar;
  }
  public void setCodabar(Boolean codabar) {
    this.codabar = codabar;
  }

  
  /**
   **/
  public BarcodeTypeSelector trioptic(Boolean trioptic) {
    this.trioptic = trioptic;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("trioptic")
  public Boolean getTrioptic() {
    return trioptic;
  }
  public void setTrioptic(Boolean trioptic) {
    this.trioptic = trioptic;
  }

  
  /**
   **/
  public BarcodeTypeSelector patchCode(Boolean patchCode) {
    this.patchCode = patchCode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("patchCode")
  public Boolean getPatchCode() {
    return patchCode;
  }
  public void setPatchCode(Boolean patchCode) {
    this.patchCode = patchCode;
  }

  
  /**
   **/
  public BarcodeTypeSelector gs1DataBarOmnidirectional(Boolean gs1DataBarOmnidirectional) {
    this.gs1DataBarOmnidirectional = gs1DataBarOmnidirectional;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("gs1DataBarOmnidirectional")
  public Boolean getGs1DataBarOmnidirectional() {
    return gs1DataBarOmnidirectional;
  }
  public void setGs1DataBarOmnidirectional(Boolean gs1DataBarOmnidirectional) {
    this.gs1DataBarOmnidirectional = gs1DataBarOmnidirectional;
  }

  
  /**
   **/
  public BarcodeTypeSelector gs1DataBarExpanded(Boolean gs1DataBarExpanded) {
    this.gs1DataBarExpanded = gs1DataBarExpanded;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("gs1DataBarExpanded")
  public Boolean getGs1DataBarExpanded() {
    return gs1DataBarExpanded;
  }
  public void setGs1DataBarExpanded(Boolean gs1DataBarExpanded) {
    this.gs1DataBarExpanded = gs1DataBarExpanded;
  }

  
  /**
   **/
  public BarcodeTypeSelector gs1DataBarLimited(Boolean gs1DataBarLimited) {
    this.gs1DataBarLimited = gs1DataBarLimited;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("gs1DataBarLimited")
  public Boolean getGs1DataBarLimited() {
    return gs1DataBarLimited;
  }
  public void setGs1DataBarLimited(Boolean gs1DataBarLimited) {
    this.gs1DataBarLimited = gs1DataBarLimited;
  }

  
  /**
   **/
  public BarcodeTypeSelector gs1DataBarStacked(Boolean gs1DataBarStacked) {
    this.gs1DataBarStacked = gs1DataBarStacked;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("gs1DataBarStacked")
  public Boolean getGs1DataBarStacked() {
    return gs1DataBarStacked;
  }
  public void setGs1DataBarStacked(Boolean gs1DataBarStacked) {
    this.gs1DataBarStacked = gs1DataBarStacked;
  }

  
  /**
   **/
  public BarcodeTypeSelector gs1DataBarExpandedStacked(Boolean gs1DataBarExpandedStacked) {
    this.gs1DataBarExpandedStacked = gs1DataBarExpandedStacked;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("gs1DataBarExpandedStacked")
  public Boolean getGs1DataBarExpandedStacked() {
    return gs1DataBarExpandedStacked;
  }
  public void setGs1DataBarExpandedStacked(Boolean gs1DataBarExpandedStacked) {
    this.gs1DataBarExpandedStacked = gs1DataBarExpandedStacked;
  }

  
  /**
   **/
  public BarcodeTypeSelector pdf417(Boolean pdf417) {
    this.pdf417 = pdf417;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("pdf417")
  public Boolean getPdf417() {
    return pdf417;
  }
  public void setPdf417(Boolean pdf417) {
    this.pdf417 = pdf417;
  }

  
  /**
   **/
  public BarcodeTypeSelector dataMatrix(Boolean dataMatrix) {
    this.dataMatrix = dataMatrix;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("dataMatrix")
  public Boolean getDataMatrix() {
    return dataMatrix;
  }
  public void setDataMatrix(Boolean dataMatrix) {
    this.dataMatrix = dataMatrix;
  }

  
  /**
   **/
  public BarcodeTypeSelector qrCode(Boolean qrCode) {
    this.qrCode = qrCode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("qrCode")
  public Boolean getQrCode() {
    return qrCode;
  }
  public void setQrCode(Boolean qrCode) {
    this.qrCode = qrCode;
  }

  
  /**
   **/
  public BarcodeTypeSelector aztec(Boolean aztec) {
    this.aztec = aztec;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("aztec")
  public Boolean getAztec() {
    return aztec;
  }
  public void setAztec(Boolean aztec) {
    this.aztec = aztec;
  }

  
  /**
   **/
  public BarcodeTypeSelector maxiCode(Boolean maxiCode) {
    this.maxiCode = maxiCode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("maxiCode")
  public Boolean getMaxiCode() {
    return maxiCode;
  }
  public void setMaxiCode(Boolean maxiCode) {
    this.maxiCode = maxiCode;
  }

  
  /**
   **/
  public BarcodeTypeSelector micr(Boolean micr) {
    this.micr = micr;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("micr")
  public Boolean getMicr() {
    return micr;
  }
  public void setMicr(Boolean micr) {
    this.micr = micr;
  }

  
  /**
   **/
  public BarcodeTypeSelector intelligentMail(Boolean intelligentMail) {
    this.intelligentMail = intelligentMail;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("intelligentMail")
  public Boolean getIntelligentMail() {
    return intelligentMail;
  }
  public void setIntelligentMail(Boolean intelligentMail) {
    this.intelligentMail = intelligentMail;
  }

  
  /**
   **/
  public BarcodeTypeSelector royalMail(Boolean royalMail) {
    this.royalMail = royalMail;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("royalMail")
  public Boolean getRoyalMail() {
    return royalMail;
  }
  public void setRoyalMail(Boolean royalMail) {
    this.royalMail = royalMail;
  }

  
  /**
   **/
  public BarcodeTypeSelector royalMailKIX(Boolean royalMailKIX) {
    this.royalMailKIX = royalMailKIX;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("royalMailKIX")
  public Boolean getRoyalMailKIX() {
    return royalMailKIX;
  }
  public void setRoyalMailKIX(Boolean royalMailKIX) {
    this.royalMailKIX = royalMailKIX;
  }

  
  /**
   **/
  public BarcodeTypeSelector australianPostCode(Boolean australianPostCode) {
    this.australianPostCode = australianPostCode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("australianPostCode")
  public Boolean getAustralianPostCode() {
    return australianPostCode;
  }
  public void setAustralianPostCode(Boolean australianPostCode) {
    this.australianPostCode = australianPostCode;
  }

  
  /**
   **/
  public BarcodeTypeSelector codablockF(Boolean codablockF) {
    this.codablockF = codablockF;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("codablockF")
  public Boolean getCodablockF() {
    return codablockF;
  }
  public void setCodablockF(Boolean codablockF) {
    this.codablockF = codablockF;
  }

  
  /**
   **/
  public BarcodeTypeSelector code16K(Boolean code16K) {
    this.code16K = code16K;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("code16K")
  public Boolean getCode16K() {
    return code16K;
  }
  public void setCode16K(Boolean code16K) {
    this.code16K = code16K;
  }

  
  /**
   **/
  public BarcodeTypeSelector postNet(Boolean postNet) {
    this.postNet = postNet;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("postNet")
  public Boolean getPostNet() {
    return postNet;
  }
  public void setPostNet(Boolean postNet) {
    this.postNet = postNet;
  }

  
  /**
   **/
  public BarcodeTypeSelector microPDF(Boolean microPDF) {
    this.microPDF = microPDF;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("microPDF")
  public Boolean getMicroPDF() {
    return microPDF;
  }
  public void setMicroPDF(Boolean microPDF) {
    this.microPDF = microPDF;
  }

  
  /**
   **/
  public BarcodeTypeSelector code93(Boolean code93) {
    this.code93 = code93;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("code93")
  public Boolean getCode93() {
    return code93;
  }
  public void setCode93(Boolean code93) {
    this.code93 = code93;
  }

  
  /**
   **/
  public BarcodeTypeSelector msi(Boolean msi) {
    this.msi = msi;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("msi")
  public Boolean getMsi() {
    return msi;
  }
  public void setMsi(Boolean msi) {
    this.msi = msi;
  }

  
  /**
   **/
  public BarcodeTypeSelector pharmacode(Boolean pharmacode) {
    this.pharmacode = pharmacode;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("pharmacode")
  public Boolean getPharmacode() {
    return pharmacode;
  }
  public void setPharmacode(Boolean pharmacode) {
    this.pharmacode = pharmacode;
  }

  
  /**
   **/
  public BarcodeTypeSelector segment(Boolean segment) {
    this.segment = segment;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("segment")
  public Boolean getSegment() {
    return segment;
  }
  public void setSegment(Boolean segment) {
    this.segment = segment;
  }

  
  /**
   **/
  public BarcodeTypeSelector circle(Boolean circle) {
    this.circle = circle;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("circle")
  public Boolean getCircle() {
    return circle;
  }
  public void setCircle(Boolean circle) {
    this.circle = circle;
  }

  
  /**
   **/
  public BarcodeTypeSelector oval(Boolean oval) {
    this.oval = oval;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("oval")
  public Boolean getOval() {
    return oval;
  }
  public void setOval(Boolean oval) {
    this.oval = oval;
  }

  
  /**
   **/
  public BarcodeTypeSelector checkbox(Boolean checkbox) {
    this.checkbox = checkbox;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("checkbox")
  public Boolean getCheckbox() {
    return checkbox;
  }
  public void setCheckbox(Boolean checkbox) {
    this.checkbox = checkbox;
  }

  
  /**
   **/
  public BarcodeTypeSelector horizontalLine(Boolean horizontalLine) {
    this.horizontalLine = horizontalLine;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("horizontalLine")
  public Boolean getHorizontalLine() {
    return horizontalLine;
  }
  public void setHorizontalLine(Boolean horizontalLine) {
    this.horizontalLine = horizontalLine;
  }

  
  /**
   **/
  public BarcodeTypeSelector verticalLine(Boolean verticalLine) {
    this.verticalLine = verticalLine;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("verticalLine")
  public Boolean getVerticalLine() {
    return verticalLine;
  }
  public void setVerticalLine(Boolean verticalLine) {
    this.verticalLine = verticalLine;
  }

  
  /**
   **/
  public BarcodeTypeSelector underlinedField(Boolean underlinedField) {
    this.underlinedField = underlinedField;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("underlinedField")
  public Boolean getUnderlinedField() {
    return underlinedField;
  }
  public void setUnderlinedField(Boolean underlinedField) {
    this.underlinedField = underlinedField;
  }

  
  /**
   **/
  public BarcodeTypeSelector all1D(Boolean all1D) {
    this.all1D = all1D;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("all1D")
  public Boolean getAll1D() {
    return all1D;
  }
  public void setAll1D(Boolean all1D) {
    this.all1D = all1D;
  }

  
  /**
   **/
  public BarcodeTypeSelector all2D(Boolean all2D) {
    this.all2D = all2D;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("all2D")
  public Boolean getAll2D() {
    return all2D;
  }
  public void setAll2D(Boolean all2D) {
    this.all2D = all2D;
  }

  
  /**
   **/
  public BarcodeTypeSelector allOMRElements(Boolean allOMRElements) {
    this.allOMRElements = allOMRElements;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("allOMRElements")
  public Boolean getAllOMRElements() {
    return allOMRElements;
  }
  public void setAllOMRElements(Boolean allOMRElements) {
    this.allOMRElements = allOMRElements;
  }

  
  /**
   **/
  public BarcodeTypeSelector all(Boolean all) {
    this.all = all;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("all")
  public Boolean getAll() {
    return all;
  }
  public void setAll(Boolean all) {
    this.all = all;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BarcodeTypeSelector barcodeTypeSelector = (BarcodeTypeSelector) o;
    return Objects.equals(this.ean8, barcodeTypeSelector.ean8) &&
        Objects.equals(this.gtin8, barcodeTypeSelector.gtin8) &&
        Objects.equals(this.ean13, barcodeTypeSelector.ean13) &&
        Objects.equals(this.gtin13, barcodeTypeSelector.gtin13) &&
        Objects.equals(this.upce, barcodeTypeSelector.upce) &&
        Objects.equals(this.upca, barcodeTypeSelector.upca) &&
        Objects.equals(this.gtin12, barcodeTypeSelector.gtin12) &&
        Objects.equals(this.interleaved2of5, barcodeTypeSelector.interleaved2of5) &&
        Objects.equals(this.circulari2of5, barcodeTypeSelector.circulari2of5) &&
        Objects.equals(this.itf14, barcodeTypeSelector.itf14) &&
        Objects.equals(this.gtin14, barcodeTypeSelector.gtin14) &&
        Objects.equals(this.code39, barcodeTypeSelector.code39) &&
        Objects.equals(this.code39Extended, barcodeTypeSelector.code39Extended) &&
        Objects.equals(this.code39Mod43, barcodeTypeSelector.code39Mod43) &&
        Objects.equals(this.code39Mod43Extended, barcodeTypeSelector.code39Mod43Extended) &&
        Objects.equals(this.pzn, barcodeTypeSelector.pzn) &&
        Objects.equals(this.upu, barcodeTypeSelector.upu) &&
        Objects.equals(this.code128, barcodeTypeSelector.code128) &&
        Objects.equals(this.ean2, barcodeTypeSelector.ean2) &&
        Objects.equals(this.ean5, barcodeTypeSelector.ean5) &&
        Objects.equals(this.gs1, barcodeTypeSelector.gs1) &&
        Objects.equals(this.codabar, barcodeTypeSelector.codabar) &&
        Objects.equals(this.trioptic, barcodeTypeSelector.trioptic) &&
        Objects.equals(this.patchCode, barcodeTypeSelector.patchCode) &&
        Objects.equals(this.gs1DataBarOmnidirectional, barcodeTypeSelector.gs1DataBarOmnidirectional) &&
        Objects.equals(this.gs1DataBarExpanded, barcodeTypeSelector.gs1DataBarExpanded) &&
        Objects.equals(this.gs1DataBarLimited, barcodeTypeSelector.gs1DataBarLimited) &&
        Objects.equals(this.gs1DataBarStacked, barcodeTypeSelector.gs1DataBarStacked) &&
        Objects.equals(this.gs1DataBarExpandedStacked, barcodeTypeSelector.gs1DataBarExpandedStacked) &&
        Objects.equals(this.pdf417, barcodeTypeSelector.pdf417) &&
        Objects.equals(this.dataMatrix, barcodeTypeSelector.dataMatrix) &&
        Objects.equals(this.qrCode, barcodeTypeSelector.qrCode) &&
        Objects.equals(this.aztec, barcodeTypeSelector.aztec) &&
        Objects.equals(this.maxiCode, barcodeTypeSelector.maxiCode) &&
        Objects.equals(this.micr, barcodeTypeSelector.micr) &&
        Objects.equals(this.intelligentMail, barcodeTypeSelector.intelligentMail) &&
        Objects.equals(this.royalMail, barcodeTypeSelector.royalMail) &&
        Objects.equals(this.royalMailKIX, barcodeTypeSelector.royalMailKIX) &&
        Objects.equals(this.australianPostCode, barcodeTypeSelector.australianPostCode) &&
        Objects.equals(this.codablockF, barcodeTypeSelector.codablockF) &&
        Objects.equals(this.code16K, barcodeTypeSelector.code16K) &&
        Objects.equals(this.postNet, barcodeTypeSelector.postNet) &&
        Objects.equals(this.microPDF, barcodeTypeSelector.microPDF) &&
        Objects.equals(this.code93, barcodeTypeSelector.code93) &&
        Objects.equals(this.msi, barcodeTypeSelector.msi) &&
        Objects.equals(this.pharmacode, barcodeTypeSelector.pharmacode) &&
        Objects.equals(this.segment, barcodeTypeSelector.segment) &&
        Objects.equals(this.circle, barcodeTypeSelector.circle) &&
        Objects.equals(this.oval, barcodeTypeSelector.oval) &&
        Objects.equals(this.checkbox, barcodeTypeSelector.checkbox) &&
        Objects.equals(this.horizontalLine, barcodeTypeSelector.horizontalLine) &&
        Objects.equals(this.verticalLine, barcodeTypeSelector.verticalLine) &&
        Objects.equals(this.underlinedField, barcodeTypeSelector.underlinedField) &&
        Objects.equals(this.all1D, barcodeTypeSelector.all1D) &&
        Objects.equals(this.all2D, barcodeTypeSelector.all2D) &&
        Objects.equals(this.allOMRElements, barcodeTypeSelector.allOMRElements) &&
        Objects.equals(this.all, barcodeTypeSelector.all);
  }

  @Override
  public int hashCode() {
    return Objects.hash(ean8, gtin8, ean13, gtin13, upce, upca, gtin12, interleaved2of5, circulari2of5, itf14, gtin14, code39, code39Extended, code39Mod43, code39Mod43Extended, pzn, upu, code128, ean2, ean5, gs1, codabar, trioptic, patchCode, gs1DataBarOmnidirectional, gs1DataBarExpanded, gs1DataBarLimited, gs1DataBarStacked, gs1DataBarExpandedStacked, pdf417, dataMatrix, qrCode, aztec, maxiCode, micr, intelligentMail, royalMail, royalMailKIX, australianPostCode, codablockF, code16K, postNet, microPDF, code93, msi, pharmacode, segment, circle, oval, checkbox, horizontalLine, verticalLine, underlinedField, all1D, all2D, allOMRElements, all);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BarcodeTypeSelector {\n");
    
    sb.append("    ean8: ").append(toIndentedString(ean8)).append("\n");
    sb.append("    gtin8: ").append(toIndentedString(gtin8)).append("\n");
    sb.append("    ean13: ").append(toIndentedString(ean13)).append("\n");
    sb.append("    gtin13: ").append(toIndentedString(gtin13)).append("\n");
    sb.append("    upce: ").append(toIndentedString(upce)).append("\n");
    sb.append("    upca: ").append(toIndentedString(upca)).append("\n");
    sb.append("    gtin12: ").append(toIndentedString(gtin12)).append("\n");
    sb.append("    interleaved2of5: ").append(toIndentedString(interleaved2of5)).append("\n");
    sb.append("    circulari2of5: ").append(toIndentedString(circulari2of5)).append("\n");
    sb.append("    itf14: ").append(toIndentedString(itf14)).append("\n");
    sb.append("    gtin14: ").append(toIndentedString(gtin14)).append("\n");
    sb.append("    code39: ").append(toIndentedString(code39)).append("\n");
    sb.append("    code39Extended: ").append(toIndentedString(code39Extended)).append("\n");
    sb.append("    code39Mod43: ").append(toIndentedString(code39Mod43)).append("\n");
    sb.append("    code39Mod43Extended: ").append(toIndentedString(code39Mod43Extended)).append("\n");
    sb.append("    pzn: ").append(toIndentedString(pzn)).append("\n");
    sb.append("    upu: ").append(toIndentedString(upu)).append("\n");
    sb.append("    code128: ").append(toIndentedString(code128)).append("\n");
    sb.append("    ean2: ").append(toIndentedString(ean2)).append("\n");
    sb.append("    ean5: ").append(toIndentedString(ean5)).append("\n");
    sb.append("    gs1: ").append(toIndentedString(gs1)).append("\n");
    sb.append("    codabar: ").append(toIndentedString(codabar)).append("\n");
    sb.append("    trioptic: ").append(toIndentedString(trioptic)).append("\n");
    sb.append("    patchCode: ").append(toIndentedString(patchCode)).append("\n");
    sb.append("    gs1DataBarOmnidirectional: ").append(toIndentedString(gs1DataBarOmnidirectional)).append("\n");
    sb.append("    gs1DataBarExpanded: ").append(toIndentedString(gs1DataBarExpanded)).append("\n");
    sb.append("    gs1DataBarLimited: ").append(toIndentedString(gs1DataBarLimited)).append("\n");
    sb.append("    gs1DataBarStacked: ").append(toIndentedString(gs1DataBarStacked)).append("\n");
    sb.append("    gs1DataBarExpandedStacked: ").append(toIndentedString(gs1DataBarExpandedStacked)).append("\n");
    sb.append("    pdf417: ").append(toIndentedString(pdf417)).append("\n");
    sb.append("    dataMatrix: ").append(toIndentedString(dataMatrix)).append("\n");
    sb.append("    qrCode: ").append(toIndentedString(qrCode)).append("\n");
    sb.append("    aztec: ").append(toIndentedString(aztec)).append("\n");
    sb.append("    maxiCode: ").append(toIndentedString(maxiCode)).append("\n");
    sb.append("    micr: ").append(toIndentedString(micr)).append("\n");
    sb.append("    intelligentMail: ").append(toIndentedString(intelligentMail)).append("\n");
    sb.append("    royalMail: ").append(toIndentedString(royalMail)).append("\n");
    sb.append("    royalMailKIX: ").append(toIndentedString(royalMailKIX)).append("\n");
    sb.append("    australianPostCode: ").append(toIndentedString(australianPostCode)).append("\n");
    sb.append("    codablockF: ").append(toIndentedString(codablockF)).append("\n");
    sb.append("    code16K: ").append(toIndentedString(code16K)).append("\n");
    sb.append("    postNet: ").append(toIndentedString(postNet)).append("\n");
    sb.append("    microPDF: ").append(toIndentedString(microPDF)).append("\n");
    sb.append("    code93: ").append(toIndentedString(code93)).append("\n");
    sb.append("    msi: ").append(toIndentedString(msi)).append("\n");
    sb.append("    pharmacode: ").append(toIndentedString(pharmacode)).append("\n");
    sb.append("    segment: ").append(toIndentedString(segment)).append("\n");
    sb.append("    circle: ").append(toIndentedString(circle)).append("\n");
    sb.append("    oval: ").append(toIndentedString(oval)).append("\n");
    sb.append("    checkbox: ").append(toIndentedString(checkbox)).append("\n");
    sb.append("    horizontalLine: ").append(toIndentedString(horizontalLine)).append("\n");
    sb.append("    verticalLine: ").append(toIndentedString(verticalLine)).append("\n");
    sb.append("    underlinedField: ").append(toIndentedString(underlinedField)).append("\n");
    sb.append("    all1D: ").append(toIndentedString(all1D)).append("\n");
    sb.append("    all2D: ").append(toIndentedString(all2D)).append("\n");
    sb.append("    allOMRElements: ").append(toIndentedString(allOMRElements)).append("\n");
    sb.append("    all: ").append(toIndentedString(all)).append("\n");
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

