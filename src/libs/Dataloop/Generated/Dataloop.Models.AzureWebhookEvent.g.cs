
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureWebhookEvent
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
        [global::System.Text.Json.Serialization.JsonPropertyName("activityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActivityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publisherId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublisherId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OfferId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeStamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime TimeStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AzureWebhookEventActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AzureWebhookEventAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operationRequestSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.AzureWebhookEventOperationRequestSource?>))]
        public global::Dataloop.AnyOf<string, global::Dataloop.AzureWebhookEventOperationRequestSource?>? OperationRequestSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AzureWebhookEventSubscription Subscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseToken")]
        public string? PurchaseToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorStatusCode")]
        public string? ErrorStatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operationRequestedSource")]
        public string? OperationRequestedSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureWebhookEvent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="activityId"></param>
        /// <param name="publisherId"></param>
        /// <param name="offerId"></param>
        /// <param name="planId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="timeStamp"></param>
        /// <param name="action"></param>
        /// <param name="status"></param>
        /// <param name="subscription"></param>
        /// <param name="quantity"></param>
        /// <param name="operationRequestSource"></param>
        /// <param name="purchaseToken"></param>
        /// <param name="errorMessage"></param>
        /// <param name="errorStatusCode"></param>
        /// <param name="operationRequestedSource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureWebhookEvent(
            string id,
            string activityId,
            string publisherId,
            string offerId,
            string planId,
            string subscriptionId,
            global::System.DateTime timeStamp,
            global::Dataloop.AzureWebhookEventAction action,
            string status,
            global::Dataloop.AzureWebhookEventSubscription subscription,
            double? quantity,
            global::Dataloop.AnyOf<string, global::Dataloop.AzureWebhookEventOperationRequestSource?>? operationRequestSource,
            string? purchaseToken,
            string? errorMessage,
            string? errorStatusCode,
            string? operationRequestedSource)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ActivityId = activityId ?? throw new global::System.ArgumentNullException(nameof(activityId));
            this.PublisherId = publisherId ?? throw new global::System.ArgumentNullException(nameof(publisherId));
            this.OfferId = offerId ?? throw new global::System.ArgumentNullException(nameof(offerId));
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.Quantity = quantity;
            this.SubscriptionId = subscriptionId ?? throw new global::System.ArgumentNullException(nameof(subscriptionId));
            this.TimeStamp = timeStamp;
            this.Action = action;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.OperationRequestSource = operationRequestSource;
            this.Subscription = subscription ?? throw new global::System.ArgumentNullException(nameof(subscription));
            this.PurchaseToken = purchaseToken;
            this.ErrorMessage = errorMessage;
            this.ErrorStatusCode = errorStatusCode;
            this.OperationRequestedSource = operationRequestedSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureWebhookEvent" /> class.
        /// </summary>
        public AzureWebhookEvent()
        {
        }
    }
}