using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Bytescout.Api.Model {

  /// <summary>
  /// Representation of PDF signing request data.
  /// </summary>
  [DataContract]
  public class PdfSignRequestModel {
    /// <summary>
    /// File name for the generated result.
    /// </summary>
    /// <value>File name for the generated result.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// URL of the source PDF file.
    /// </summary>
    /// <value>URL of the source PDF file.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Image signatures to add.
    /// </summary>
    /// <value>Image signatures to add.</value>
    [DataMember(Name="images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "images")]
    public List<PdfSignRequestModelImages> Images { get; set; }

    /// <summary>
    /// Annotation (textual) signatures to add.
    /// </summary>
    /// <value>Annotation (textual) signatures to add.</value>
    [DataMember(Name="annotations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "annotations")]
    public List<PdfSignRequestModelAnnotations> Annotations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PdfSignRequestModel {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Images: ").Append(Images).Append("\n");
      sb.Append("  Annotations: ").Append(Annotations).Append("\n");
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
