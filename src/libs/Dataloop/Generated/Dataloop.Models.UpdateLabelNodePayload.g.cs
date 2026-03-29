
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateLabelNodePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public bool? System { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayData")]
        public global::Dataloop.LabelDisplayData? DisplayData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLabelNodePayload" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tag"></param>
        /// <param name="displayLabel"></param>
        /// <param name="color"></param>
        /// <param name="system"></param>
        /// <param name="displayData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateLabelNodePayload(
            string id,
            string? tag,
            string? displayLabel,
            string? color,
            bool? system,
            global::Dataloop.LabelDisplayData? displayData)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Tag = tag;
            this.DisplayLabel = displayLabel;
            this.Color = color;
            this.System = system;
            this.DisplayData = displayData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLabelNodePayload" /> class.
        /// </summary>
        public UpdateLabelNodePayload()
        {
        }
    }
}