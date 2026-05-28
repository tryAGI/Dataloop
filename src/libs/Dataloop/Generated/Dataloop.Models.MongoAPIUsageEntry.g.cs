
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MongoAPIUsageEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public string? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCalls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APICallDescriptor ApiCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.MongoStorageDescriptor Storage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MongoAPIUsageEntry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="project"></param>
        /// <param name="date"></param>
        /// <param name="apiCalls"></param>
        /// <param name="storage"></param>
        /// <param name="org"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MongoAPIUsageEntry(
            string id,
            string project,
            global::System.DateTime date,
            global::Dataloop.APICallDescriptor apiCalls,
            global::Dataloop.MongoStorageDescriptor storage,
            string? org)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Org = org;
            this.Date = date;
            this.ApiCalls = apiCalls ?? throw new global::System.ArgumentNullException(nameof(apiCalls));
            this.Storage = storage ?? throw new global::System.ArgumentNullException(nameof(storage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MongoAPIUsageEntry" /> class.
        /// </summary>
        public MongoAPIUsageEntry()
        {
        }

    }
}