
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APISubscription
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
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Plan Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.BillingStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.BillingStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APISubscriptionScope Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenewal")]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// 
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
        /// 
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
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="plan"></param>
        /// <param name="createdAt"></param>
        /// <param name="period"></param>
        /// <param name="startTime"></param>
        /// <param name="status"></param>
        /// <param name="scope"></param>
        /// <param name="accountId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="endTime"></param>
        /// <param name="autoRenewal"></param>
        /// <param name="addon"></param>
        /// <param name="paymentDriverId"></param>
        /// <param name="paymentMethodId"></param>
        /// <param name="externalSubscriptionId"></param>
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
            global::Dataloop.BillingStatus status,
            global::Dataloop.APISubscriptionScope scope,
            string accountId,
            global::System.DateTime? updatedAt,
            global::System.DateTime? endTime,
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