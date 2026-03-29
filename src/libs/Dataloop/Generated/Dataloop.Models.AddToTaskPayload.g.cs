
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddToTaskPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload")]
        public global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? Workload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentage")]
        public bool? Percentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asynced")]
        public bool? Asynced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableWebm")]
        public bool? DisableWebm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<string>? Groups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddToTaskPayload" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="workload"></param>
        /// <param name="limit"></param>
        /// <param name="percentage"></param>
        /// <param name="asynced"></param>
        /// <param name="disableWebm"></param>
        /// <param name="groups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddToTaskPayload(
            string query,
            global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? workload,
            double? limit,
            bool? percentage,
            bool? asynced,
            bool? disableWebm,
            global::System.Collections.Generic.IList<string>? groups)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Workload = workload;
            this.Limit = limit;
            this.Percentage = percentage;
            this.Asynced = asynced;
            this.DisableWebm = disableWebm;
            this.Groups = groups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddToTaskPayload" /> class.
        /// </summary>
        public AddToTaskPayload()
        {
        }
    }
}