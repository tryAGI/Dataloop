
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IBaseRefAnnotationCoordinates
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.RefAnnotationsRefTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.RefAnnotationsRefType RefType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimetype")]
        public string? Mimetype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IBaseRefAnnotationCoordinates" /> class.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="refType"></param>
        /// <param name="mimetype"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IBaseRefAnnotationCoordinates(
            string @ref,
            global::Dataloop.RefAnnotationsRefType refType,
            string? mimetype)
        {
            this.Ref = @ref;
            this.RefType = refType;
            this.Mimetype = mimetype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IBaseRefAnnotationCoordinates" /> class.
        /// </summary>
        public IBaseRefAnnotationCoordinates()
        {
        }
    }
}