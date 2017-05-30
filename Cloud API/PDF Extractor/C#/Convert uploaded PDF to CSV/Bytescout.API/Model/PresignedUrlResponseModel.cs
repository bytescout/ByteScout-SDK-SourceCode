using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Bytescout.Api.Model {

  /// <summary>
  /// Representation of API response with the presigned URL for binary data upload.
  /// </summary>
  [DataContract]
  public class PresignedUrlResponseModel {
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
    /// URL of the uploaded file for later use with other API methods.
    /// </summary>
    /// <value>URL of the uploaded file for later use with other API methods.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Presigned URL to use for binary data upload.
    /// </summary>
    /// <value>Presigned URL to use for binary data upload.</value>
    [DataMember(Name="presignedUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "presignedUrl")]
    public string PresignedUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PresignedUrlResponseModel {\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  PresignedUrl: ").Append(PresignedUrl).Append("\n");
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
