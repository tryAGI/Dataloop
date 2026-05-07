
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Date range of the resource usage
    /// </summary>
    public sealed partial class InvoiceBilledPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceBilledPeriod" /> class.
        /// </summary>
        /// <param name="endDate"></param>
        /// <param name="startDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvoiceBilledPeriod(
            global::System.DateTime endDate,
            global::System.DateTime startDate)
        {
            this.EndDate = endDate;
            this.StartDate = startDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceBilledPeriod" /> class.
        /// </summary>
        public InvoiceBilledPeriod()
        {
        }
    }
}