
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialJob
    {
        /// <summary>
        /// A class representation of the BSON ObjectId type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        public string? OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Dataloop.JobMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public global::Dataloop.JobRuntime? Runtime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Dataloop.JobStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot")]
        public string? Bot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageRevision")]
        public string? PackageRevision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdkVersion")]
        public string? SdkVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageId")]
        public string? PackageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialJob" /> class.
        /// </summary>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="driverId"></param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="metadata"></param>
        /// <param name="runtime"></param>
        /// <param name="status"></param>
        /// <param name="bot"></param>
        /// <param name="packageRevision"></param>
        /// <param name="sdkVersion"></param>
        /// <param name="packageId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialJob(
            string? id,
            string? driverId,
            string? orgId,
            string? projectId,
            global::Dataloop.JobMetadata? metadata,
            global::Dataloop.JobRuntime? runtime,
            global::Dataloop.JobStatus? status,
            string? bot,
            string? packageRevision,
            string? sdkVersion,
            string? packageId)
        {
            this.Id = id;
            this.DriverId = driverId;
            this.OrgId = orgId;
            this.ProjectId = projectId;
            this.Metadata = metadata;
            this.Runtime = runtime;
            this.Status = status;
            this.Bot = bot;
            this.PackageRevision = packageRevision;
            this.SdkVersion = sdkVersion;
            this.PackageId = packageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialJob" /> class.
        /// </summary>
        public PartialJob()
        {
        }
    }
}