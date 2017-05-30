using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Bytescout.Api.Model {

  /// <summary>
  /// PDF document information
  /// </summary>
  [DataContract]
  public class PdfInfoResponseModelInfo {
    /// <summary>
    /// Count of pages.
    /// </summary>
    /// <value>Count of pages.</value>
    [DataMember(Name="PageCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PageCount")]
    public int? PageCount { get; set; }

    /// <summary>
    /// Document author.
    /// </summary>
    /// <value>Document author.</value>
    [DataMember(Name="Author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Author")]
    public string Author { get; set; }

    /// <summary>
    /// Document title.
    /// </summary>
    /// <value>Document title.</value>
    [DataMember(Name="Title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Title")]
    public string Title { get; set; }

    /// <summary>
    /// Document producer.
    /// </summary>
    /// <value>Document producer.</value>
    [DataMember(Name="Producer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Producer")]
    public string Producer { get; set; }

    /// <summary>
    /// Document subject.
    /// </summary>
    /// <value>Document subject.</value>
    [DataMember(Name="Subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Subject")]
    public string Subject { get; set; }

    /// <summary>
    /// Document creation date.
    /// </summary>
    /// <value>Document creation date.</value>
    [DataMember(Name="CreationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreationDate")]
    public string CreationDate { get; set; }

    /// <summary>
    /// Document bookmarks.
    /// </summary>
    /// <value>Document bookmarks.</value>
    [DataMember(Name="Bookmarks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Bookmarks")]
    public string Bookmarks { get; set; }

    /// <summary>
    /// Document keywords.
    /// </summary>
    /// <value>Document keywords.</value>
    [DataMember(Name="Keywords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Keywords")]
    public string Keywords { get; set; }

    /// <summary>
    /// Document creator.
    /// </summary>
    /// <value>Document creator.</value>
    [DataMember(Name="Creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Creator")]
    public string Creator { get; set; }

    /// <summary>
    /// Count of embedded files.
    /// </summary>
    /// <value>Count of embedded files.</value>
    [DataMember(Name="EmbeddedFileCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmbeddedFileCount")]
    public int? EmbeddedFileCount { get; set; }

    /// <summary>
    /// Document encryption status.
    /// </summary>
    /// <value>Document encryption status.</value>
    [DataMember(Name="Encrypted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Encrypted")]
    public bool? Encrypted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PdfInfoResponseModelInfo {\n");
      sb.Append("  PageCount: ").Append(PageCount).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Producer: ").Append(Producer).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  Bookmarks: ").Append(Bookmarks).Append("\n");
      sb.Append("  Keywords: ").Append(Keywords).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  EmbeddedFileCount: ").Append(EmbeddedFileCount).Append("\n");
      sb.Append("  Encrypted: ").Append(Encrypted).Append("\n");
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
