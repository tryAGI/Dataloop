
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetRequest
    {
        /// <summary>
        /// Dataset name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// list of project ids related to the created dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Projects { get; set; }

        /// <summary>
        /// Driver type of an existing driver or new driver configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CreateDatasetRequestDriverJsonConverter))]
        public global::Dataloop.CreateDatasetRequestDriver? Driver { get; set; }

        /// <summary>
        /// Driver id of an existing external driver
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

        /// <summary>
        /// Share options, only user or all project members with the right role (default is project)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CreateDatasetRequestAccessLevelJsonConverter))]
        public global::Dataloop.CreateDatasetRequestAccessLevel? AccessLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createDefaultRecipe")]
        public bool? CreateDefaultRecipe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationOptions")]
        public global::Dataloop.ExpirationOptions? ExpirationOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexDriver")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.IndexDriverJsonConverter))]
        public global::Dataloop.IndexDriver? IndexDriver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.DatasetMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Dataset name
        /// </param>
        /// <param name="projects">
        /// list of project ids related to the created dataset
        /// </param>
        /// <param name="driver">
        /// Driver type of an existing driver or new driver configuration
        /// </param>
        /// <param name="driverId">
        /// Driver id of an existing external driver
        /// </param>
        /// <param name="accessLevel">
        /// Share options, only user or all project members with the right role (default is project)
        /// </param>
        /// <param name="createDefaultRecipe"></param>
        /// <param name="expirationOptions"></param>
        /// <param name="indexDriver"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetRequest(
            string name,
            global::System.Collections.Generic.IList<string> projects,
            global::Dataloop.CreateDatasetRequestDriver? driver,
            string? driverId,
            global::Dataloop.CreateDatasetRequestAccessLevel? accessLevel,
            bool? createDefaultRecipe,
            global::Dataloop.ExpirationOptions? expirationOptions,
            global::Dataloop.IndexDriver? indexDriver,
            global::Dataloop.DatasetMetadata? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.Driver = driver;
            this.DriverId = driverId;
            this.AccessLevel = accessLevel;
            this.CreateDefaultRecipe = createDefaultRecipe;
            this.ExpirationOptions = expirationOptions;
            this.IndexDriver = indexDriver;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetRequest" /> class.
        /// </summary>
        public CreateDatasetRequest()
        {
        }
    }
}