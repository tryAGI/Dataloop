
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PushProgressRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// package revision
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageRevision")]
        public string? PackageRevision { get; set; }

        /// <summary>
        /// service version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceVersion")]
        public string? ServiceVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Dataloop.Dictionary? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// percent work done
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentComplete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PercentComplete { get; set; }

        /// <summary>
        /// message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ExecutionStatusNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ExecutionStatusName Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PushProgressRequest" /> class.
        /// </summary>
        /// <param name="percentComplete">
        /// percent work done
        /// </param>
        /// <param name="message">
        /// message
        /// </param>
        /// <param name="status"></param>
        /// <param name="timestamp"></param>
        /// <param name="duration"></param>
        /// <param name="packageRevision">
        /// package revision
        /// </param>
        /// <param name="serviceVersion">
        /// service version
        /// </param>
        /// <param name="output"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PushProgressRequest(
            double percentComplete,
            string message,
            global::Dataloop.ExecutionStatusName status,
            global::System.DateTime timestamp,
            double? duration,
            string? packageRevision,
            string? serviceVersion,
            global::Dataloop.Dictionary? output,
            string? error)
        {
            this.Duration = duration;
            this.PackageRevision = packageRevision;
            this.ServiceVersion = serviceVersion;
            this.Output = output;
            this.Error = error;
            this.PercentComplete = percentComplete;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Status = status;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushProgressRequest" /> class.
        /// </summary>
        public PushProgressRequest()
        {
        }
    }
}