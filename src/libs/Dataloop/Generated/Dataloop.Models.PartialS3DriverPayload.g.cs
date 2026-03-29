
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialS3DriverPayload
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

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
        public bool? AllowExternalDelete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowExternalModification")]
        public bool? AllowExternalModification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        public string? IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.IntegrationTypeJsonConverter))]
        public global::Dataloop.IntegrationType? IntegrationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DriverTypeJsonConverter))]
        public global::Dataloop.DriverType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>))]
        public global::Dataloop.AnyOf<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>? Authentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authz")]
        public global::Dataloop.AuthZBlockDriverContext? Authz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.DriverMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialS3DriverPayload" /> class.
        /// </summary>
        /// <param name="region"></param>
        /// <param name="bucketName"></param>
        /// <param name="path"></param>
        /// <param name="storageClass"></param>
        /// <param name="endpoint"></param>
        /// <param name="allowExternalDelete"></param>
        /// <param name="allowExternalModification"></param>
        /// <param name="integrationId"></param>
        /// <param name="integrationType"></param>
        /// <param name="type"></param>
        /// <param name="creator"></param>
        /// <param name="authentication"></param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="name"></param>
        /// <param name="authz"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialS3DriverPayload(
            string? region,
            string? bucketName,
            string? path,
            string? storageClass,
            string? endpoint,
            bool? allowExternalDelete,
            bool? allowExternalModification,
            string? integrationId,
            global::Dataloop.IntegrationType? integrationType,
            global::Dataloop.DriverType? type,
            string? creator,
            global::Dataloop.AnyOf<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>? authentication,
            string? id,
            global::System.DateTime? createdAt,
            string? name,
            global::Dataloop.AuthZBlockDriverContext? authz,
            global::Dataloop.DriverMetadata? metadata)
        {
            this.Region = region;
            this.BucketName = bucketName;
            this.Path = path;
            this.StorageClass = storageClass;
            this.Endpoint = endpoint;
            this.AllowExternalDelete = allowExternalDelete;
            this.AllowExternalModification = allowExternalModification;
            this.IntegrationId = integrationId;
            this.IntegrationType = integrationType;
            this.Type = type;
            this.Creator = creator;
            this.Authentication = authentication;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Name = name;
            this.Authz = authz;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialS3DriverPayload" /> class.
        /// </summary>
        public PartialS3DriverPayload()
        {
        }
    }
}