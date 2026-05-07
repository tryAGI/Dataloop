
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureWebhookEventSubscriptionPurchaser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("puid")]
        public string? Puid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmailId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureWebhookEventSubscriptionPurchaser" /> class.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="objectId"></param>
        /// <param name="emailId"></param>
        /// <param name="puid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureWebhookEventSubscriptionPurchaser(
            string tenantId,
            string objectId,
            string emailId,
            string? puid)
        {
            this.Puid = puid;
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.EmailId = emailId ?? throw new global::System.ArgumentNullException(nameof(emailId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureWebhookEventSubscriptionPurchaser" /> class.
        /// </summary>
        public AzureWebhookEventSubscriptionPurchaser()
        {
        }
    }
}