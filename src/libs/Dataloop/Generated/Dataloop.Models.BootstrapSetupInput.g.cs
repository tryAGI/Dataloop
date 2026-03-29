
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BootstrapSetupInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createMongoIndexes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CreateMongoIndexes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createDefaultStorageDrivers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CreateDefaultStorageDrivers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setupCloneQueues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SetupCloneQueues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setupDefaultFeatureFlags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SetupDefaultFeatureFlags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setupS2")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.S2SetupOptions>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<bool?, global::Dataloop.S2SetupOptions> SetupS2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BootstrapSetupInput" /> class.
        /// </summary>
        /// <param name="createMongoIndexes"></param>
        /// <param name="createDefaultStorageDrivers"></param>
        /// <param name="setupCloneQueues"></param>
        /// <param name="setupDefaultFeatureFlags"></param>
        /// <param name="setupS2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BootstrapSetupInput(
            bool createMongoIndexes,
            bool createDefaultStorageDrivers,
            bool setupCloneQueues,
            bool setupDefaultFeatureFlags,
            global::Dataloop.AnyOf<bool?, global::Dataloop.S2SetupOptions> setupS2)
        {
            this.CreateMongoIndexes = createMongoIndexes;
            this.CreateDefaultStorageDrivers = createDefaultStorageDrivers;
            this.SetupCloneQueues = setupCloneQueues;
            this.SetupDefaultFeatureFlags = setupDefaultFeatureFlags;
            this.SetupS2 = setupS2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BootstrapSetupInput" /> class.
        /// </summary>
        public BootstrapSetupInput()
        {
        }
    }
}