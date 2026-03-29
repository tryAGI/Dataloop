
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIModelMetadataSubsets
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train")]
        public global::Dataloop.Dictionary? Train { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation")]
        public global::Dataloop.Dictionary? Validation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIModelMetadataSubsets" /> class.
        /// </summary>
        /// <param name="train"></param>
        /// <param name="validation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIModelMetadataSubsets(
            global::Dataloop.Dictionary? train,
            global::Dataloop.Dictionary? validation)
        {
            this.Train = train;
            this.Validation = validation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIModelMetadataSubsets" /> class.
        /// </summary>
        public APIModelMetadataSubsets()
        {
        }
    }
}