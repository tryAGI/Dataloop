
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IStorageDriverConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.IStorage> Storages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IStorageDriverConfig" /> class.
        /// </summary>
        /// <param name="storages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IStorageDriverConfig(
            global::System.Collections.Generic.IList<global::Dataloop.IStorage> storages)
        {
            this.Storages = storages ?? throw new global::System.ArgumentNullException(nameof(storages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IStorageDriverConfig" /> class.
        /// </summary>
        public IStorageDriverConfig()
        {
        }
    }
}