
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureWebhookEventSubscriptionTerm
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chargeDuration")]
        public double? ChargeDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termUnit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TermUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureWebhookEventSubscriptionTerm" /> class.
        /// </summary>
        /// <param name="termUnit"></param>
        /// <param name="endDate"></param>
        /// <param name="startDate"></param>
        /// <param name="chargeDuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureWebhookEventSubscriptionTerm(
            string termUnit,
            global::System.DateTime endDate,
            global::System.DateTime startDate,
            double? chargeDuration)
        {
            this.ChargeDuration = chargeDuration;
            this.TermUnit = termUnit ?? throw new global::System.ArgumentNullException(nameof(termUnit));
            this.EndDate = endDate;
            this.StartDate = startDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureWebhookEventSubscriptionTerm" /> class.
        /// </summary>
        public AzureWebhookEventSubscriptionTerm()
        {
        }
    }
}