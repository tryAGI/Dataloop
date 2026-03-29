
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckStorageDriversIntegrationByIntegrationIdRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckStorageDriversIntegrationByIntegrationIdRequest" /> class.
        /// </summary>
        /// <param name="integrationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckStorageDriversIntegrationByIntegrationIdRequest(
            string integrationId)
        {
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckStorageDriversIntegrationByIntegrationIdRequest" /> class.
        /// </summary>
        public CheckStorageDriversIntegrationByIntegrationIdRequest()
        {
        }
    }
}