
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIExecutionPatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceVersion")]
        public string? ServiceVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIExecutionPatch" /> class.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="serviceVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIExecutionPatch(
            double? duration,
            string? serviceVersion)
        {
            this.Duration = duration;
            this.ServiceVersion = serviceVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIExecutionPatch" /> class.
        /// </summary>
        public APIExecutionPatch()
        {
        }
    }
}