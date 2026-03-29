
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RestoreAnnotationsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.RestoreAnnotationsRequestAnnotation> Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAnnotationsRequest" /> class.
        /// </summary>
        /// <param name="annotations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestoreAnnotationsRequest(
            global::System.Collections.Generic.IList<global::Dataloop.RestoreAnnotationsRequestAnnotation> annotations)
        {
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAnnotationsRequest" /> class.
        /// </summary>
        public RestoreAnnotationsRequest()
        {
        }
    }
}