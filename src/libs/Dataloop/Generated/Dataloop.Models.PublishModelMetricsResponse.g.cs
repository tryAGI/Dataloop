
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublishModelMetricsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMap")]
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.Error>? ErrorMap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Failed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Succeeded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishModelMetricsResponse" /> class.
        /// </summary>
        /// <param name="failed"></param>
        /// <param name="succeeded"></param>
        /// <param name="errorMap"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishModelMetricsResponse(
            double failed,
            double succeeded,
            global::System.Collections.Generic.Dictionary<string, global::Dataloop.Error>? errorMap)
        {
            this.ErrorMap = errorMap;
            this.Failed = failed;
            this.Succeeded = succeeded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishModelMetricsResponse" /> class.
        /// </summary>
        public PublishModelMetricsResponse()
        {
        }
    }
}