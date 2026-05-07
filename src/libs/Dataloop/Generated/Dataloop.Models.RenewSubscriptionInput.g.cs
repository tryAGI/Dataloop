
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RenewSubscriptionInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chargeSubscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ChargeSubscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenewSubscriptionInput" /> class.
        /// </summary>
        /// <param name="chargeSubscription"></param>
        /// <param name="force"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenewSubscriptionInput(
            bool chargeSubscription,
            bool? force)
        {
            this.ChargeSubscription = chargeSubscription;
            this.Force = force;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenewSubscriptionInput" /> class.
        /// </summary>
        public RenewSubscriptionInput()
        {
        }
    }
}