
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APILabelDisplayData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayImage")]
        public global::Dataloop.APILabelDisplayImage? DisplayImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APILabelDisplayData" /> class.
        /// </summary>
        /// <param name="displayImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APILabelDisplayData(
            global::Dataloop.APILabelDisplayImage? displayImage)
        {
            this.DisplayImage = displayImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APILabelDisplayData" /> class.
        /// </summary>
        public APILabelDisplayData()
        {
        }
    }
}