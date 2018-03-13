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
  public class ExampleServiceOperationInput {
    /// <summary>
    /// Gets or Sets TrRequestHeader
    /// </summary>
    [DataMember(Name="trRequestHeader", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trRequestHeader")]
    public RequestHeader TrRequestHeader { get; set; }

    /// <summary>
    /// Gets or Sets ExampleServiceOperationRequest
    /// </summary>
    [DataMember(Name="ExampleServiceOperationRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExampleServiceOperationRequest")]
    public ExampleServiceOperationRequest ExampleServiceOperationRequest { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExampleServiceOperationInput {\n");
      sb.Append("  TrRequestHeader: ").Append(TrRequestHeader).Append("\n");
      sb.Append("  ExampleServiceOperationRequest: ").Append(ExampleServiceOperationRequest).Append("\n");
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
