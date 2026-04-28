
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionExtensionInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenewal")]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionExtensionInput" /> class.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="amount"></param>
        /// <param name="autoRenewal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionExtensionInput(
            string resource,
            double amount,
            bool? autoRenewal)
        {
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.Amount = amount;
            this.AutoRenewal = autoRenewal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionExtensionInput" /> class.
        /// </summary>
        public SubscriptionExtensionInput()
        {
        }
    }
}