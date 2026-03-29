
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignmentStatusPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ItemRefOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ItemRefOperation Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnLastStatus")]
        public bool? ReturnLastStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asynced")]
        public bool? Asynced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentStatusPayload" /> class.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="status"></param>
        /// <param name="returnLastStatus"></param>
        /// <param name="asynced"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignmentStatusPayload(
            global::Dataloop.ItemRefOperation operation,
            string? status,
            bool? returnLastStatus,
            bool? asynced)
        {
            this.Operation = operation;
            this.Status = status;
            this.ReturnLastStatus = returnLastStatus;
            this.Asynced = asynced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentStatusPayload" /> class.
        /// </summary>
        public AssignmentStatusPayload()
        {
        }
    }
}