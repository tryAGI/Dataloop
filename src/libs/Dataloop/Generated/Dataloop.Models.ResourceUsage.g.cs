
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Used { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageLog")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.UsageLog> UsageLog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateDepleted")]
        public global::System.DateTime? DateDepleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceUsage" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="used"></param>
        /// <param name="usageLog"></param>
        /// <param name="dateDepleted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceUsage(
            string key,
            double used,
            global::System.Collections.Generic.IList<global::Dataloop.UsageLog> usageLog,
            global::System.DateTime? dateDepleted)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Used = used;
            this.UsageLog = usageLog ?? throw new global::System.ArgumentNullException(nameof(usageLog));
            this.DateDepleted = dateDepleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceUsage" /> class.
        /// </summary>
        public ResourceUsage()
        {
        }
    }
}