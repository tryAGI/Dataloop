
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Pipeline resume option
    /// </summary>
    public sealed partial class InstallRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resumeOption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ResumePipelineOptionJsonConverter))]
        public global::Dataloop.ResumePipelineOption? ResumeOption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallRequest" /> class.
        /// </summary>
        /// <param name="resumeOption"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InstallRequest(
            global::Dataloop.ResumePipelineOption? resumeOption)
        {
            this.ResumeOption = resumeOption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallRequest" /> class.
        /// </summary>
        public InstallRequest()
        {
        }
    }
}