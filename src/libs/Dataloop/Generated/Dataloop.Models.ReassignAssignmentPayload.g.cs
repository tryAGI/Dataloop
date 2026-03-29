
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReassignAssignmentPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Annotator { get; set; }

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
        /// Initializes a new instance of the <see cref="ReassignAssignmentPayload" /> class.
        /// </summary>
        /// <param name="annotator"></param>
        /// <param name="asynced"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReassignAssignmentPayload(
            string annotator,
            bool? asynced)
        {
            this.Annotator = annotator ?? throw new global::System.ArgumentNullException(nameof(annotator));
            this.Asynced = asynced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReassignAssignmentPayload" /> class.
        /// </summary>
        public ReassignAssignmentPayload()
        {
        }
    }
}