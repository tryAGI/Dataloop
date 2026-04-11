
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APISubscription
    {
        /// <summary>
        /// Unique identifier for the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Url for the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Plan Plan { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Latest update date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.BillingPeriodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.BillingPeriod Period { get; set; }

        /// <summary>
        /// Subscription start time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// Subscription expiration time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.BillingStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.BillingStatus Status { get; set; }

        /// <summary>
        /// Subscription scope type and id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APISubscriptionScope Scope { get; set; }

        /// <summary>
        /// DL account Id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountId { get; set; }

        /// <summary>
        /// Whether the subscription will auto renew when its current quota expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenewal")]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// Whether the subscription is an addon or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addon")]
        public bool? Addon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paymentDriverId")]
        public string? PaymentDriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paymentMethodId")]
        public string? PaymentMethodId { get; set; }

        /// <summary>
        /// External subscription id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalSubscriptionId")]
        public string? ExternalSubscriptionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APISubscription" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the subscription
        /// </param>
        /// <param name="url">
        /// Url for the subscription
        /// </param>
        /// <param name="plan"></param>
        /// <param name="createdAt">
        /// Creation date
        /// </param>
        /// <param name="period"></param>
        /// <param name="startTime">
        /// Subscription start time
        /// </param>
        /// <param name="endTime">
        /// Subscription expiration time
        /// </param>
        /// <param name="status"></param>
        /// <param name="scope">
        /// Subscription scope type and id
        /// </param>
        /// <param name="accountId">
        /// DL account Id
        /// </param>
        /// <param name="updatedAt">
        /// Latest update date
        /// </param>
        /// <param name="autoRenewal">
        /// Whether the subscription will auto renew when its current quota expires
        /// </param>
        /// <param name="addon">
        /// Whether the subscription is an addon or not
        /// </param>
        /// <param name="paymentDriverId"></param>
        /// <param name="paymentMethodId"></param>
        /// <param name="externalSubscriptionId">
        /// External subscription id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APISubscription(
            string id,
            string url,
            global::Dataloop.Plan plan,
            global::System.DateTime createdAt,
            global::Dataloop.BillingPeriod period,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::Dataloop.BillingStatus status,
            global::Dataloop.APISubscriptionScope scope,
            string accountId,
            global::System.DateTime? updatedAt,
            bool? autoRenewal,
            bool? addon,
            string? paymentDriverId,
            string? paymentMethodId,
            string? externalSubscriptionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Period = period;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Status = status;
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.AccountId = accountId ?? throw new global::System.ArgumentNullException(nameof(accountId));
            this.AutoRenewal = autoRenewal;
            this.Addon = addon;
            this.PaymentDriverId = paymentDriverId;
            this.PaymentMethodId = paymentMethodId;
            this.ExternalSubscriptionId = externalSubscriptionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APISubscription" /> class.
        /// </summary>
        public APISubscription()
        {
        }
    }
}