
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIToolOptionsV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labelScope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APILabelScopeV2 LabelScope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::Dataloop.Dictionary? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIToolOptionsV2" /> class.
        /// </summary>
        /// <param name="labelScope"></param>
        /// <param name="options"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIToolOptionsV2(
            global::Dataloop.APILabelScopeV2 labelScope,
            global::Dataloop.Dictionary? options)
        {
            this.LabelScope = labelScope ?? throw new global::System.ArgumentNullException(nameof(labelScope));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIToolOptionsV2" /> class.
        /// </summary>
        public APIToolOptionsV2()
        {
        }
    }
}