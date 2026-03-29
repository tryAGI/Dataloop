
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionInput
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
        [global::System.Text.Json.Serialization.JsonPropertyName("endDate")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.BillingScope Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenewal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoRenewal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Account { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planKey")]
        public string? PlanKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public global::Dataloop.Plan? Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionInput" /> class.
        /// </summary>
        /// <param name="period"></param>
        /// <param name="scope"></param>
        /// <param name="autoRenewal"></param>
        /// <param name="account"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="driverId"></param>
        /// <param name="methodId"></param>
        /// <param name="planKey"></param>
        /// <param name="plan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionInput(
            global::Dataloop.BillingPeriod period,
            global::Dataloop.BillingScope scope,
            bool autoRenewal,
            string account,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            string? driverId,
            string? methodId,
            string? planKey,
            global::Dataloop.Plan? plan)
        {
            this.Period = period;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.AutoRenewal = autoRenewal;
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.DriverId = driverId;
            this.MethodId = methodId;
            this.PlanKey = planKey;
            this.Plan = plan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionInput" /> class.
        /// </summary>
        public SubscriptionInput()
        {
        }
    }
}