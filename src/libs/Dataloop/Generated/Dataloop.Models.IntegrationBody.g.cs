
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.IList<global::Dataloop.IntegrationMetadataBody>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Dataloop.IntegrationBodyCredentials? Credentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// Initializes a new instance of the <see cref="IntegrationBody" /> class.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="metadata"></param>
        /// <param name="credentials"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationBody(
            string integrationId,
            global::System.Collections.Generic.IList<global::Dataloop.IntegrationMetadataBody>? metadata,
            global::Dataloop.IntegrationBodyCredentials? credentials,
            string? name)
        {
            this.Metadata = metadata;
            this.Credentials = credentials;
            this.Name = name;
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationBody" /> class.
        /// </summary>
        public IntegrationBody()
        {
        }
    }
}