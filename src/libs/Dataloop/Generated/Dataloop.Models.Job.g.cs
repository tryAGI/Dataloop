
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Job
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DriverId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.JobMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.JobRuntime Runtime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.JobStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageRevision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageRevision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdkVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SdkVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="driverId"></param>
        /// <param name="metadata"></param>
        /// <param name="runtime"></param>
        /// <param name="status"></param>
        /// <param name="bot"></param>
        /// <param name="packageRevision"></param>
        /// <param name="sdkVersion"></param>
        /// <param name="packageId"></param>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Job(
            string driverId,
            global::Dataloop.JobMetadata metadata,
            global::Dataloop.JobRuntime runtime,
            global::Dataloop.JobStatus status,
            string bot,
            string packageRevision,
            string sdkVersion,
            string packageId,
            string? id,
            string? orgId,
            string? projectId)
        {
            this.Id = id;
            this.DriverId = driverId ?? throw new global::System.ArgumentNullException(nameof(driverId));
            this.OrgId = orgId;
            this.ProjectId = projectId;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Runtime = runtime ?? throw new global::System.ArgumentNullException(nameof(runtime));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Bot = bot ?? throw new global::System.ArgumentNullException(nameof(bot));
            this.PackageRevision = packageRevision ?? throw new global::System.ArgumentNullException(nameof(packageRevision));
            this.SdkVersion = sdkVersion ?? throw new global::System.ArgumentNullException(nameof(sdkVersion));
            this.PackageId = packageId ?? throw new global::System.ArgumentNullException(nameof(packageId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        public Job()
        {
        }
    }
}