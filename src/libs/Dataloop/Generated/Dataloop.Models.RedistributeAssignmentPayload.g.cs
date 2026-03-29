
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RedistributeAssignmentPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.AssignmentWorkload> Workload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectNotAnnotatedOnly")]
        public bool? SelectNotAnnotatedOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asynced")]
        public bool? Asynced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSudoCtx")]
        public bool? IsSudoCtx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowToSkipAssignments")]
        public bool? AllowToSkipAssignments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedistributeAssignmentPayload" /> class.
        /// </summary>
        /// <param name="workload"></param>
        /// <param name="selectNotAnnotatedOnly"></param>
        /// <param name="asynced"></param>
        /// <param name="isSudoCtx"></param>
        /// <param name="allowToSkipAssignments"></param>
        /// <param name="query"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedistributeAssignmentPayload(
            global::System.Collections.Generic.IList<global::Dataloop.AssignmentWorkload> workload,
            bool? selectNotAnnotatedOnly,
            bool? asynced,
            bool? isSudoCtx,
            bool? allowToSkipAssignments,
            string? query)
        {
            this.Workload = workload ?? throw new global::System.ArgumentNullException(nameof(workload));
            this.SelectNotAnnotatedOnly = selectNotAnnotatedOnly;
            this.Asynced = asynced;
            this.IsSudoCtx = isSudoCtx;
            this.AllowToSkipAssignments = allowToSkipAssignments;
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedistributeAssignmentPayload" /> class.
        /// </summary>
        public RedistributeAssignmentPayload()
        {
        }
    }
}