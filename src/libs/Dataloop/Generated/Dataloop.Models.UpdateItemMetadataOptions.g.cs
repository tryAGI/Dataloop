
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateItemMetadataOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.UpdateItemMetadataOptionsUpdate Update { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemSpace")]
        public bool? SystemSpace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateItemMetadataOptions" /> class.
        /// </summary>
        /// <param name="update"></param>
        /// <param name="systemSpace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateItemMetadataOptions(
            global::Dataloop.UpdateItemMetadataOptionsUpdate update,
            bool? systemSpace)
        {
            this.Update = update ?? throw new global::System.ArgumentNullException(nameof(update));
            this.SystemSpace = systemSpace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateItemMetadataOptions" /> class.
        /// </summary>
        public UpdateItemMetadataOptions()
        {
        }
    }
}