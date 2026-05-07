
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IngestedDatapointsDescriptor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public double? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public double? Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames")]
        public double? Frames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestedDatapointsDescriptor" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="annotations"></param>
        /// <param name="frames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IngestedDatapointsDescriptor(
            double? items,
            double? annotations,
            double? frames)
        {
            this.Items = items;
            this.Annotations = annotations;
            this.Frames = frames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestedDatapointsDescriptor" /> class.
        /// </summary>
        public IngestedDatapointsDescriptor()
        {
        }
    }
}