
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StorageDatasetDescriptor
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
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.StorageModificationDescriptor Modified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageDatasetDescriptor" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="modified"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageDatasetDescriptor(
            string id,
            global::Dataloop.StorageModificationDescriptor modified)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Modified = modified ?? throw new global::System.ArgumentNullException(nameof(modified));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageDatasetDescriptor" /> class.
        /// </summary>
        public StorageDatasetDescriptor()
        {
        }
    }
}