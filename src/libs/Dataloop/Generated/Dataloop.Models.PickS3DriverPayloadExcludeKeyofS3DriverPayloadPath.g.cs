
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DriverTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DriverType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.DriverMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authz")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AuthZBlockDriverContext Authz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketName")]
        public string? BucketName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storageClass")]
        public string? StorageClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowExternalDelete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowExternalDelete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowExternalModification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowExternalModification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.IntegrationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>))]
        public global::Dataloop.AnyOf<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>? Authentication { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="creator"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="authz"></param>
        /// <param name="allowExternalDelete"></param>
        /// <param name="allowExternalModification"></param>
        /// <param name="integrationId"></param>
        /// <param name="integrationType"></param>
        /// <param name="metadata"></param>
        /// <param name="region"></param>
        /// <param name="bucketName"></param>
        /// <param name="storageClass"></param>
        /// <param name="endpoint"></param>
        /// <param name="authentication"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath(
            global::Dataloop.DriverType type,
            string creator,
            global::System.DateTime createdAt,
            string id,
            string name,
            global::Dataloop.AuthZBlockDriverContext authz,
            bool allowExternalDelete,
            bool allowExternalModification,
            string integrationId,
            global::Dataloop.IntegrationType integrationType,
            global::Dataloop.DriverMetadata? metadata,
            string? region,
            string? bucketName,
            string? storageClass,
            string? endpoint,
            global::Dataloop.AnyOf<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>? authentication)
        {
            this.Type = type;
            this.Metadata = metadata;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Authz = authz ?? throw new global::System.ArgumentNullException(nameof(authz));
            this.Region = region;
            this.BucketName = bucketName;
            this.StorageClass = storageClass;
            this.Endpoint = endpoint;
            this.AllowExternalDelete = allowExternalDelete;
            this.AllowExternalModification = allowExternalModification;
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.IntegrationType = integrationType;
            this.Authentication = authentication;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath" /> class.
        /// </summary>
        public PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath()
        {
        }
    }
}