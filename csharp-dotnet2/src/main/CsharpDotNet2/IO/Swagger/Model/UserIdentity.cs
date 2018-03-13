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
  public class UserIdentity {
    /// <summary>
    /// Gets or Sets Identity
    /// </summary>
    [DataMember(Name="identity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identity")]
    public string Identity { get; set; }

    /// <summary>
    /// Gets or Sets IdentityType
    /// </summary>
    [DataMember(Name="identityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identityType")]
    public IdentityType IdentityType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserIdentity {\n");
      sb.Append("  Identity: ").Append(Identity).Append("\n");
      sb.Append("  IdentityType: ").Append(IdentityType).Append("\n");
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
