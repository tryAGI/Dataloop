
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewsComponentsPatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineTemplates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.PreviewsComponentsPatchPipelineTemplate> PipelineTemplates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewsComponentsPatch" /> class.
        /// </summary>
        /// <param name="pipelineTemplates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewsComponentsPatch(
            global::System.Collections.Generic.IList<global::Dataloop.PreviewsComponentsPatchPipelineTemplate> pipelineTemplates)
        {
            this.PipelineTemplates = pipelineTemplates ?? throw new global::System.ArgumentNullException(nameof(pipelineTemplates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewsComponentsPatch" /> class.
        /// </summary>
        public PreviewsComponentsPatch()
        {
        }
    }
}