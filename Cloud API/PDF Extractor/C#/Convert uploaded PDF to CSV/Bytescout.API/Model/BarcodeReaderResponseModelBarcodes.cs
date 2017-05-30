using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Bytescout.Api.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BarcodeReaderResponseModelBarcodes {
    /// <summary>
    /// Barcode value.
    /// </summary>
    /// <value>Barcode value.</value>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Value")]
    public string Value { get; set; }

    /// <summary>
    /// Gets or Sets RawData
    /// </summary>
    [DataMember(Name="RawData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RawData")]
    public string RawData { get; set; }

    /// <summary>
    /// Barcode type ID.
    /// </summary>
    /// <value>Barcode type ID.</value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public int? Type { get; set; }

    /// <summary>
    /// Barcode rectangle.
    /// </summary>
    /// <value>Barcode rectangle.</value>
    [DataMember(Name="Rect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Rect")]
    public string Rect { get; set; }

    /// <summary>
    /// Document page containing the barcode.
    /// </summary>
    /// <value>Document page containing the barcode.</value>
    [DataMember(Name="Page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Page")]
    public int? Page { get; set; }

    /// <summary>
    /// Gets or Sets File
    /// </summary>
    [DataMember(Name="File", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "File")]
    public string File { get; set; }

    /// <summary>
    /// Barcode confidence.
    /// </summary>
    /// <value>Barcode confidence.</value>
    [DataMember(Name="Confidence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Confidence")]
    public double? Confidence { get; set; }

    /// <summary>
    /// Barcode type name.
    /// </summary>
    /// <value>Barcode type name.</value>
    [DataMember(Name="TypeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TypeName")]
    public string TypeName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BarcodeReaderResponseModelBarcodes {\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  RawData: ").Append(RawData).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Rect: ").Append(Rect).Append("\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
      sb.Append("  File: ").Append(File).Append("\n");
      sb.Append("  Confidence: ").Append(Confidence).Append("\n");
      sb.Append("  TypeName: ").Append(TypeName).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
