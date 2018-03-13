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
  public class RequestHeader {
    /// <summary>
    /// Gets or Sets ExternalReferenceId
    /// </summary>
    [DataMember(Name="externalReferenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalReferenceId")]
    public string ExternalReferenceId { get; set; }

    /// <summary>
    /// Gets or Sets ApplicationId
    /// </summary>
    [DataMember(Name="applicationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationId")]
    public string ApplicationId { get; set; }

    /// <summary>
    /// Gets or Sets Requestor
    /// </summary>
    [DataMember(Name="requestor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestor")]
    public UserIdentity Requestor { get; set; }

    /// <summary>
    /// Gets or Sets PagingInfo
    /// </summary>
    [DataMember(Name="pagingInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pagingInfo")]
    public PagingInfoRequest PagingInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RequestHeader {\n");
      sb.Append("  ExternalReferenceId: ").Append(ExternalReferenceId).Append("\n");
      sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
      sb.Append("  Requestor: ").Append(Requestor).Append("\n");
      sb.Append("  PagingInfo: ").Append(PagingInfo).Append("\n");
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
