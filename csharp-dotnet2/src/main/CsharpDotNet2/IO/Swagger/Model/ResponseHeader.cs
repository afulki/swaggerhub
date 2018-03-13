using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ResponseHeader {
    /// <summary>
    /// Gets or Sets ExternalReferenceId
    /// </summary>
    [DataMember(Name="externalReferenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalReferenceId")]
    public string ExternalReferenceId { get; set; }

    /// <summary>
    /// Gets or Sets InternalReferenceId
    /// </summary>
    [DataMember(Name="internalReferenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internalReferenceId")]
    public string InternalReferenceId { get; set; }

    /// <summary>
    /// Gets or Sets PagingInfo
    /// </summary>
    [DataMember(Name="pagingInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pagingInfo")]
    public PagingInfoResponse PagingInfo { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    [DataMember(Name="messages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "messages")]
    public List<Message> Messages { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResponseHeader {\n");
      sb.Append("  ExternalReferenceId: ").Append(ExternalReferenceId).Append("\n");
      sb.Append("  InternalReferenceId: ").Append(InternalReferenceId).Append("\n");
      sb.Append("  PagingInfo: ").Append(PagingInfo).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Messages: ").Append(Messages).Append("\n");
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
