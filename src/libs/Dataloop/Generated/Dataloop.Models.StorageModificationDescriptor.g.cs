
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StorageModificationDescriptor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.StorageModificationSourceDescriptor Ui { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.StorageModificationSourceDescriptor Sdk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.StorageModificationSourceDescriptor System { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.StorageModificationSourceDescriptor Other { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unknown")]
        public global::Dataloop.StorageModificationSourceDescriptor? Unknown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.StorageModificationSourceDescriptor Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageModificationDescriptor" /> class.
        /// </summary>
        /// <param name="ui"></param>
        /// <param name="sdk"></param>
        /// <param name="system"></param>
        /// <param name="other"></param>
        /// <param name="total"></param>
        /// <param name="unknown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageModificationDescriptor(
            global::Dataloop.StorageModificationSourceDescriptor ui,
            global::Dataloop.StorageModificationSourceDescriptor sdk,
            global::Dataloop.StorageModificationSourceDescriptor system,
            global::Dataloop.StorageModificationSourceDescriptor other,
            global::Dataloop.StorageModificationSourceDescriptor total,
            global::Dataloop.StorageModificationSourceDescriptor? unknown)
        {
            this.Ui = ui ?? throw new global::System.ArgumentNullException(nameof(ui));
            this.Sdk = sdk ?? throw new global::System.ArgumentNullException(nameof(sdk));
            this.System = system ?? throw new global::System.ArgumentNullException(nameof(system));
            this.Other = other ?? throw new global::System.ArgumentNullException(nameof(other));
            this.Unknown = unknown;
            this.Total = total ?? throw new global::System.ArgumentNullException(nameof(total));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageModificationDescriptor" /> class.
        /// </summary>
        public StorageModificationDescriptor()
        {
        }
    }
}