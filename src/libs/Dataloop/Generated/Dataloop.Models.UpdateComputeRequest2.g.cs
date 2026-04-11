
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateComputeRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipValidation")]
        public bool? SkipValidation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runBootstrap")]
        public bool? RunBootstrap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComputeRequest2" /> class.
        /// </summary>
        /// <param name="skipValidation"></param>
        /// <param name="runBootstrap"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateComputeRequest2(
            bool? skipValidation,
            bool? runBootstrap)
        {
            this.SkipValidation = skipValidation;
            this.RunBootstrap = runBootstrap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComputeRequest2" /> class.
        /// </summary>
        public UpdateComputeRequest2()
        {
        }
    }
}