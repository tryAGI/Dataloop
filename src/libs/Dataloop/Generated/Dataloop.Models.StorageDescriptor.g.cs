
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StorageDescriptor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalModified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.StorageModificationDescriptor TotalModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPersist")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalPersist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.StorageDatasetDescriptor> Datasets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageDescriptor" /> class.
        /// </summary>
        /// <param name="totalModified"></param>
        /// <param name="totalPersist"></param>
        /// <param name="datasets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageDescriptor(
            global::Dataloop.StorageModificationDescriptor totalModified,
            double totalPersist,
            global::System.Collections.Generic.IList<global::Dataloop.StorageDatasetDescriptor> datasets)
        {
            this.TotalModified = totalModified ?? throw new global::System.ArgumentNullException(nameof(totalModified));
            this.TotalPersist = totalPersist;
            this.Datasets = datasets ?? throw new global::System.ArgumentNullException(nameof(datasets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageDescriptor" /> class.
        /// </summary>
        public StorageDescriptor()
        {
        }
    }
}