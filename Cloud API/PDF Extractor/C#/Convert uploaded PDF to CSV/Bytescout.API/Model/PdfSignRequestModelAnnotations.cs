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
  public class PdfSignRequestModelAnnotations {
    /// <summary>
    /// Annotation text.
    /// </summary>
    /// <value>Annotation text.</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

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
    /// Font size.
    /// </summary>
    /// <value>Font size.</value>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public double? Size { get; set; }

    /// <summary>
    /// Font color.
    /// </summary>
    /// <value>Font color.</value>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public string Color { get; set; }

    /// <summary>
    /// Font name.
    /// </summary>
    /// <value>Font name.</value>
    [DataMember(Name="fontName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fontName")]
    public string FontName { get; set; }

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
      sb.Append("class PdfSignRequestModelAnnotations {\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  X: ").Append(X).Append("\n");
      sb.Append("  Y: ").Append(Y).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  FontName: ").Append(FontName).Append("\n");
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
