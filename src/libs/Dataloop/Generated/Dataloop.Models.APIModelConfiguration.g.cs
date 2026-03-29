
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIModelConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_to_id_map")]
        public object? LabelToIdMap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIModelConfiguration" /> class.
        /// </summary>
        /// <param name="labelToIdMap"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIModelConfiguration(
            object? labelToIdMap)
        {
            this.LabelToIdMap = labelToIdMap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIModelConfiguration" /> class.
        /// </summary>
        public APIModelConfiguration()
        {
        }
    }
}