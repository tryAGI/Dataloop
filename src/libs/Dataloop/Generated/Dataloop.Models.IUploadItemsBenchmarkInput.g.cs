
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IUploadItemsBenchmarkInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexDrivers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.IndexDriver> IndexDrivers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ItemsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IUploadItemsBenchmarkInput" /> class.
        /// </summary>
        /// <param name="indexDrivers"></param>
        /// <param name="itemsCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IUploadItemsBenchmarkInput(
            global::System.Collections.Generic.IList<global::Dataloop.IndexDriver> indexDrivers,
            double itemsCount)
        {
            this.IndexDrivers = indexDrivers ?? throw new global::System.ArgumentNullException(nameof(indexDrivers));
            this.ItemsCount = itemsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IUploadItemsBenchmarkInput" /> class.
        /// </summary>
        public IUploadItemsBenchmarkInput()
        {
        }
    }
}