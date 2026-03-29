
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLabelPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayLabel")]
        public string? DisplayLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<string>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLabelPayload" /> class.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="displayLabel"></param>
        /// <param name="color"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLabelPayload(
            string tag,
            string? displayLabel,
            string? color,
            global::System.Collections.Generic.IList<string>? attributes)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.DisplayLabel = displayLabel;
            this.Color = color;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLabelPayload" /> class.
        /// </summary>
        public CreateLabelPayload()
        {
        }
    }
}