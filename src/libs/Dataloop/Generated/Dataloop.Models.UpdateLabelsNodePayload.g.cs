
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateLabelsNodePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labelsNode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayload> LabelsNode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upsert")]
        public bool? Upsert { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLabelsNodePayload" /> class.
        /// </summary>
        /// <param name="labelsNode"></param>
        /// <param name="upsert"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateLabelsNodePayload(
            global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayload> labelsNode,
            bool? upsert)
        {
            this.LabelsNode = labelsNode ?? throw new global::System.ArgumentNullException(nameof(labelsNode));
            this.Upsert = upsert;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLabelsNodePayload" /> class.
        /// </summary>
        public UpdateLabelsNodePayload()
        {
        }
    }
}