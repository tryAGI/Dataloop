
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIUsageEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public string? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgName")]
        public string? OrgName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        public string? Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountName")]
        public string? AccountName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uiHours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.UIHours UiHours { get; set; }

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
        public required global::Dataloop.StorageDescriptor Storage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faasUsage")]
        public global::Dataloop.FaasUsageDescriptor? FaasUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalFaasUsage")]
        public global::Dataloop.FaasUsageDescriptor? ExternalFaasUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ItemsCount Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyframes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Keyframes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingestedDatapoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IngestedDatapointsDescriptor IngestedDatapoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIUsageEntry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="project"></param>
        /// <param name="date"></param>
        /// <param name="uiHours"></param>
        /// <param name="apiCalls"></param>
        /// <param name="storage"></param>
        /// <param name="items"></param>
        /// <param name="annotations"></param>
        /// <param name="keyframes"></param>
        /// <param name="ingestedDatapoints"></param>
        /// <param name="projectName"></param>
        /// <param name="org"></param>
        /// <param name="orgName"></param>
        /// <param name="account"></param>
        /// <param name="accountName"></param>
        /// <param name="faasUsage"></param>
        /// <param name="externalFaasUsage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIUsageEntry(
            string id,
            string url,
            string project,
            global::System.DateTime date,
            global::Dataloop.UIHours uiHours,
            global::Dataloop.APICallDescriptor apiCalls,
            global::Dataloop.StorageDescriptor storage,
            global::Dataloop.ItemsCount items,
            double annotations,
            double keyframes,
            global::Dataloop.IngestedDatapointsDescriptor ingestedDatapoints,
            string? projectName,
            string? org,
            string? orgName,
            string? account,
            string? accountName,
            global::Dataloop.FaasUsageDescriptor? faasUsage,
            global::Dataloop.FaasUsageDescriptor? externalFaasUsage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.ProjectName = projectName;
            this.Org = org;
            this.OrgName = orgName;
            this.Account = account;
            this.AccountName = accountName;
            this.Date = date;
            this.UiHours = uiHours ?? throw new global::System.ArgumentNullException(nameof(uiHours));
            this.ApiCalls = apiCalls ?? throw new global::System.ArgumentNullException(nameof(apiCalls));
            this.Storage = storage ?? throw new global::System.ArgumentNullException(nameof(storage));
            this.FaasUsage = faasUsage;
            this.ExternalFaasUsage = externalFaasUsage;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Annotations = annotations;
            this.Keyframes = keyframes;
            this.IngestedDatapoints = ingestedDatapoints ?? throw new global::System.ArgumentNullException(nameof(ingestedDatapoints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIUsageEntry" /> class.
        /// </summary>
        public APIUsageEntry()
        {
        }
    }
}