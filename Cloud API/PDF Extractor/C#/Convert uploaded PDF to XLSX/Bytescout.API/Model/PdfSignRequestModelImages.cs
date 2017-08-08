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
  public class PdfSignRequestModelImages {
    /// <summary>
    /// URL of the signature image.
    /// </summary>
    /// <value>URL of the signature image.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// X coordinate of the signature in PDF Points (1/72 in.).
    /// </summary>
    /// <value>X coordinate of the signature in PDF Points (1/72 in.).</value>
    [DataMember(Name="x", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "x")]
    public double? X { get; set; }

    /// <summary>
    /// Y coordinate of the signature in PDF Points (1/72 in.).
    /// </summary>
    /// <value>Y coordinate of the signature in PDF Points (1/72 in.).</value>
    [DataMember(Name="y", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "y")]
    public double? Y { get; set; }

    /// <summary>
    /// Width of the signature in PDF Points (1/72 in.).
    /// </summary>
    /// <value>Width of the signature in PDF Points (1/72 in.).</value>
    [DataMember(Name="width", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "width")]
    public double? Width { get; set; }

    /// <summary>
    /// Height of the signature in PDF Points (1/72 in.).
    /// </summary>
    /// <value>Height of the signature in PDF Points (1/72 in.).</value>
    [DataMember(Name="height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "height")]
    public double? Height { get; set; }

    /// <summary>
    /// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
    /// </summary>
    /// <value>Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.</value>
    [DataMember(Name="pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pages")]
    public string Pages { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PdfSignRequestModelImages {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  X: ").Append(X).Append("\n");
      sb.Append("  Y: ").Append(Y).Append("\n");
      sb.Append("  Width: ").Append(Width).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
      sb.Append("  Pages: ").Append(Pages).Append("\n");
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
