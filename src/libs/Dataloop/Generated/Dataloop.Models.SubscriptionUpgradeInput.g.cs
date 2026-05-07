
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionUpgradeInput
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenewal")]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanKey { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("methodId")]
        public string? MethodId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpgradeInput" /> class.
        /// </summary>
        /// <param name="period"></param>
        /// <param name="planKey"></param>
        /// <param name="startDate"></param>
        /// <param name="autoRenewal"></param>
        /// <param name="paymentDriverId"></param>
        /// <param name="paymentMethodId"></param>
        /// <param name="driverId"></param>
        /// <param name="methodId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionUpgradeInput(
            global::Dataloop.BillingPeriod period,
            string planKey,
            global::System.DateTime? startDate,
            bool? autoRenewal,
            string? paymentDriverId,
            string? paymentMethodId,
            string? driverId,
            string? methodId)
        {
            this.Period = period;
            this.StartDate = startDate;
            this.AutoRenewal = autoRenewal;
            this.PlanKey = planKey ?? throw new global::System.ArgumentNullException(nameof(planKey));
            this.PaymentDriverId = paymentDriverId;
            this.PaymentMethodId = paymentMethodId;
            this.DriverId = driverId;
            this.MethodId = methodId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpgradeInput" /> class.
        /// </summary>
        public SubscriptionUpgradeInput()
        {
        }
    }
}