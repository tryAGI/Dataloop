
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureWebhookEventSubscription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenew")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoRenew { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("term")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AzureWebhookEventSubscriptionTerm Term { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saasSubscriptionStatus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SaasSubscriptionStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsTest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFreeTrial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFreeTrial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionMode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedCustomerOperations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedCustomerOperations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaser")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AzureWebhookEventSubscriptionPurchaser Purchaser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beneficiary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AzureWebhookEventSubscriptionBeneficiary Beneficiary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OfferId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publisherId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublisherId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureWebhookEventSubscription" /> class.
        /// </summary>
        /// <param name="lastModified"></param>
        /// <param name="autoRenew"></param>
        /// <param name="term"></param>
        /// <param name="saasSubscriptionStatus"></param>
        /// <param name="sandboxType"></param>
        /// <param name="isTest"></param>
        /// <param name="isFreeTrial"></param>
        /// <param name="sessionMode"></param>
        /// <param name="allowedCustomerOperations"></param>
        /// <param name="purchaser"></param>
        /// <param name="beneficiary"></param>
        /// <param name="planId"></param>
        /// <param name="offerId"></param>
        /// <param name="publisherId"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="created"></param>
        /// <param name="quantity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureWebhookEventSubscription(
            global::System.DateTime lastModified,
            bool autoRenew,
            global::Dataloop.AzureWebhookEventSubscriptionTerm term,
            string saasSubscriptionStatus,
            string sandboxType,
            bool isTest,
            bool isFreeTrial,
            string sessionMode,
            global::System.Collections.Generic.IList<string> allowedCustomerOperations,
            global::Dataloop.AzureWebhookEventSubscriptionPurchaser purchaser,
            global::Dataloop.AzureWebhookEventSubscriptionBeneficiary beneficiary,
            string planId,
            string offerId,
            string publisherId,
            string name,
            string id,
            global::System.DateTime? created,
            double? quantity)
        {
            this.LastModified = lastModified;
            this.Created = created;
            this.AutoRenew = autoRenew;
            this.Term = term ?? throw new global::System.ArgumentNullException(nameof(term));
            this.SaasSubscriptionStatus = saasSubscriptionStatus ?? throw new global::System.ArgumentNullException(nameof(saasSubscriptionStatus));
            this.SandboxType = sandboxType ?? throw new global::System.ArgumentNullException(nameof(sandboxType));
            this.IsTest = isTest;
            this.IsFreeTrial = isFreeTrial;
            this.SessionMode = sessionMode ?? throw new global::System.ArgumentNullException(nameof(sessionMode));
            this.AllowedCustomerOperations = allowedCustomerOperations ?? throw new global::System.ArgumentNullException(nameof(allowedCustomerOperations));
            this.Purchaser = purchaser ?? throw new global::System.ArgumentNullException(nameof(purchaser));
            this.Beneficiary = beneficiary ?? throw new global::System.ArgumentNullException(nameof(beneficiary));
            this.Quantity = quantity;
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.OfferId = offerId ?? throw new global::System.ArgumentNullException(nameof(offerId));
            this.PublisherId = publisherId ?? throw new global::System.ArgumentNullException(nameof(publisherId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureWebhookEventSubscription" /> class.
        /// </summary>
        public AzureWebhookEventSubscription()
        {
        }
    }
}