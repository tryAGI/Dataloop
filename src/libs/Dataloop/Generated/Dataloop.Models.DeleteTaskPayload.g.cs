
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTaskPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asynced")]
        public bool? Asynced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteWithPipeline")]
        public bool? DeleteWithPipeline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emptyOnly")]
        public bool? EmptyOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTaskPayload" /> class.
        /// </summary>
        /// <param name="asynced"></param>
        /// <param name="deleteWithPipeline"></param>
        /// <param name="emptyOnly"></param>
        /// <param name="force"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTaskPayload(
            bool? asynced,
            bool? deleteWithPipeline,
            bool? emptyOnly,
            bool? force)
        {
            this.Asynced = asynced;
            this.DeleteWithPipeline = deleteWithPipeline;
            this.EmptyOnly = emptyOnly;
            this.Force = force;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTaskPayload" /> class.
        /// </summary>
        public DeleteTaskPayload()
        {
        }
    }
}