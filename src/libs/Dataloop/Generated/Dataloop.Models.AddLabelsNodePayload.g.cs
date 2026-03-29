
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddLabelsNodePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labelsNode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayload> LabelsNode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddLabelsNodePayload" /> class.
        /// </summary>
        /// <param name="labelsNode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddLabelsNodePayload(
            global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayload> labelsNode)
        {
            this.LabelsNode = labelsNode ?? throw new global::System.ArgumentNullException(nameof(labelsNode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddLabelsNodePayload" /> class.
        /// </summary>
        public AddLabelsNodePayload()
        {
        }
    }
}