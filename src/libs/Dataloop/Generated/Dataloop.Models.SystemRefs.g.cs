
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemRefs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refs")]
        public global::System.Collections.Generic.IList<global::Dataloop.EntityReference>? Refs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::Dataloop.Dictionary? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemRefs" /> class.
        /// </summary>
        /// <param name="refs"></param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemRefs(
            global::System.Collections.Generic.IList<global::Dataloop.EntityReference>? refs,
            global::Dataloop.Dictionary? errors)
        {
            this.Refs = refs;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemRefs" /> class.
        /// </summary>
        public SystemRefs()
        {
        }
    }
}