
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelineNodeCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineNodeCategory" /> class.
        /// </summary>
        /// <param name="color"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineNodeCategory(
            string color)
        {
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineNodeCategory" /> class.
        /// </summary>
        public PipelineNodeCategory()
        {
        }
    }
}