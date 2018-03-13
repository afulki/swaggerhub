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
  public class PagingInfoResponse {
    /// <summary>
    /// Gets or Sets Cookie
    /// </summary>
    [DataMember(Name="cookie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cookie")]
    public string Cookie { get; set; }

    /// <summary>
    /// Gets or Sets Expires
    /// </summary>
    [DataMember(Name="expires", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires")]
    public DateTime? Expires { get; set; }

    /// <summary>
    /// Gets or Sets IsLastPage
    /// </summary>
    [DataMember(Name="isLastPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isLastPage")]
    public bool? IsLastPage { get; set; }

    /// <summary>
    /// Gets or Sets TotalNumberOfPages
    /// </summary>
    [DataMember(Name="totalNumberOfPages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalNumberOfPages")]
    public int? TotalNumberOfPages { get; set; }

    /// <summary>
    /// Gets or Sets CurrentPageNumber
    /// </summary>
    [DataMember(Name="currentPageNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentPageNumber")]
    public int? CurrentPageNumber { get; set; }

    /// <summary>
    /// Gets or Sets RowsInCurrentPage
    /// </summary>
    [DataMember(Name="rowsInCurrentPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rowsInCurrentPage")]
    public int? RowsInCurrentPage { get; set; }

    /// <summary>
    /// Gets or Sets TotalRowsAvailable
    /// </summary>
    [DataMember(Name="totalRowsAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalRowsAvailable")]
    public int? TotalRowsAvailable { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PagingInfoResponse {\n");
      sb.Append("  Cookie: ").Append(Cookie).Append("\n");
      sb.Append("  Expires: ").Append(Expires).Append("\n");
      sb.Append("  IsLastPage: ").Append(IsLastPage).Append("\n");
      sb.Append("  TotalNumberOfPages: ").Append(TotalNumberOfPages).Append("\n");
      sb.Append("  CurrentPageNumber: ").Append(CurrentPageNumber).Append("\n");
      sb.Append("  RowsInCurrentPage: ").Append(RowsInCurrentPage).Append("\n");
      sb.Append("  TotalRowsAvailable: ").Append(TotalRowsAvailable).Append("\n");
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
