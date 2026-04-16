
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelineConnection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.PipelineNodeSource Src { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tgt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.PipelineNodeTarget Tgt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineConnection" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="tgt"></param>
        /// <param name="condition"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineConnection(
            global::Dataloop.PipelineNodeSource src,
            global::Dataloop.PipelineNodeTarget tgt,
            string condition,
            string? action)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Tgt = tgt ?? throw new global::System.ArgumentNullException(nameof(tgt));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineConnection" /> class.
        /// </summary>
        public PipelineConnection()
        {
        }
    }
}