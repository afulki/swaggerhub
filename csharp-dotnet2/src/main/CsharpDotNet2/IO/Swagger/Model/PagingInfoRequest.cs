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
  public class PagingInfoRequest {
    /// <summary>
    /// Gets or Sets Cookie
    /// </summary>
    [DataMember(Name="cookie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cookie")]
    public string Cookie { get; set; }

    /// <summary>
    /// Gets or Sets PageNumber
    /// </summary>
    [DataMember(Name="pageNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageNumber")]
    public int? PageNumber { get; set; }

    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [DataMember(Name="pageSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageSize")]
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets Sort
    /// </summary>
    [DataMember(Name="sort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort")]
    public ArrayOfSortInformation Sort { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PagingInfoRequest {\n");
      sb.Append("  Cookie: ").Append(Cookie).Append("\n");
      sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
      sb.Append("  PageSize: ").Append(PageSize).Append("\n");
      sb.Append("  Sort: ").Append(Sort).Append("\n");
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
