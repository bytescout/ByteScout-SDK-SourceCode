using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Bytescout.Api.Model {

  /// <summary>
  /// Representation of barcode reading results.
  /// </summary>
  [DataContract]
  public class BarcodeReaderResponseModel {
    /// <summary>
    /// Error status.
    /// </summary>
    /// <value>Error status.</value>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public bool? Error { get; set; }

    /// <summary>
    /// Status code.
    /// </summary>
    /// <value>Status code.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// File name.
    /// </summary>
    /// <value>File name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Detected barcodes.
    /// </summary>
    /// <value>Detected barcodes.</value>
    [DataMember(Name="barcodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "barcodes")]
    public List<BarcodeReaderResponseModelBarcodes> Barcodes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BarcodeReaderResponseModel {\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Barcodes: ").Append(Barcodes).Append("\n");
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
