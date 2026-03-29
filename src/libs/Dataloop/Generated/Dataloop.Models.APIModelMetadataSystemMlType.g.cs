
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIModelMetadataSystemMlType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? SubType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.NodeMlTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.NodeMlType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIModelMetadataSystemMlType" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="subType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIModelMetadataSystemMlType(
            global::Dataloop.NodeMlType type,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? subType)
        {
            this.SubType = subType;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIModelMetadataSystemMlType" /> class.
        /// </summary>
        public APIModelMetadataSystemMlType()
        {
        }
    }
}