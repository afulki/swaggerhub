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
  public class ExampleServiceOperationResponse {
    /// <summary>
    /// Gets or Sets Response
    /// </summary>
    [DataMember(Name="response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "response")]
    public int? Response { get; set; }

    /// <summary>
    /// Gets or Sets Khal
    /// </summary>
    [DataMember(Name="khal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "khal")]
    public DateTime? Khal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExampleServiceOperationResponse {\n");
      sb.Append("  Response: ").Append(Response).Append("\n");
      sb.Append("  Khal: ").Append(Khal).Append("\n");
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
