
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIAnnotationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnnotationTypeJsonConverter))]
        public global::Dataloop.AnnotationType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.APIAnnotationCoordinateTypesJsonConverter))]
        public global::Dataloop.APIAnnotationCoordinateTypes? Coordinates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<string>? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.APIMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public global::Dataloop.APIAnnotationRequest? Parent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        public global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>? Children { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("existingChildrenIds")]
        public global::System.Collections.Generic.IList<string>? ExistingChildrenIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.RequestSourceJsonConverter))]
        public global::Dataloop.RequestSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIAnnotationRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="creator"></param>
        /// <param name="type"></param>
        /// <param name="label"></param>
        /// <param name="coordinates"></param>
        /// <param name="attributes"></param>
        /// <param name="metadata"></param>
        /// <param name="parent"></param>
        /// <param name="children"></param>
        /// <param name="existingChildrenIds"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIAnnotationRequest(
            string? id,
            string? creator,
            global::Dataloop.AnnotationType? type,
            string? label,
            global::Dataloop.APIAnnotationCoordinateTypes? coordinates,
            global::System.Collections.Generic.IList<string>? attributes,
            global::Dataloop.APIMetadata? metadata,
            global::Dataloop.APIAnnotationRequest? parent,
            global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>? children,
            global::System.Collections.Generic.IList<string>? existingChildrenIds,
            global::Dataloop.RequestSource? source)
        {
            this.Id = id;
            this.Creator = creator;
            this.Type = type;
            this.Label = label;
            this.Coordinates = coordinates;
            this.Attributes = attributes;
            this.Metadata = metadata;
            this.Parent = parent;
            this.Children = children;
            this.ExistingChildrenIds = existingChildrenIds;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIAnnotationRequest" /> class.
        /// </summary>
        public APIAnnotationRequest()
        {
        }
    }
}