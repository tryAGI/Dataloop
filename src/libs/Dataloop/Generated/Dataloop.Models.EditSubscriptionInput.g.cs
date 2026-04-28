
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditSubscriptionInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenewal")]
        public bool? AutoRenewal { get; set; }

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
        /// Initializes a new instance of the <see cref="EditSubscriptionInput" /> class.
        /// </summary>
        /// <param name="autoRenewal"></param>
        /// <param name="paymentDriverId"></param>
        /// <param name="paymentMethodId"></param>
        /// <param name="externalSubscriptionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditSubscriptionInput(
            bool? autoRenewal,
            string? paymentDriverId,
            string? paymentMethodId,
            string? externalSubscriptionId)
        {
            this.AutoRenewal = autoRenewal;
            this.PaymentDriverId = paymentDriverId;
            this.PaymentMethodId = paymentMethodId;
            this.ExternalSubscriptionId = externalSubscriptionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditSubscriptionInput" /> class.
        /// </summary>
        public EditSubscriptionInput()
        {
        }
    }
}