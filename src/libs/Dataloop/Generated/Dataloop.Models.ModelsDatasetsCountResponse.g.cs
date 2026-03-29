
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsDatasetsCountResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DatasetsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsDatasetsCountResponse" /> class.
        /// </summary>
        /// <param name="datasetsCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsDatasetsCountResponse(
            double datasetsCount)
        {
            this.DatasetsCount = datasetsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsDatasetsCountResponse" /> class.
        /// </summary>
        public ModelsDatasetsCountResponse()
        {
        }
    }
}