
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// - driverIds array and new integration values
    /// </summary>
    public sealed partial class MigrateDriversIntegrationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newIntegrationType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewIntegrationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newIntegrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewIntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DriverIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateDriversIntegrationRequest" /> class.
        /// </summary>
        /// <param name="newIntegrationType"></param>
        /// <param name="newIntegrationId"></param>
        /// <param name="driverIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MigrateDriversIntegrationRequest(
            string newIntegrationType,
            string newIntegrationId,
            global::System.Collections.Generic.IList<string> driverIds)
        {
            this.NewIntegrationType = newIntegrationType ?? throw new global::System.ArgumentNullException(nameof(newIntegrationType));
            this.NewIntegrationId = newIntegrationId ?? throw new global::System.ArgumentNullException(nameof(newIntegrationId));
            this.DriverIds = driverIds ?? throw new global::System.ArgumentNullException(nameof(driverIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateDriversIntegrationRequest" /> class.
        /// </summary>
        public MigrateDriversIntegrationRequest()
        {
        }
    }
}