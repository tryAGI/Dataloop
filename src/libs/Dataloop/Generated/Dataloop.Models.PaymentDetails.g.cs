
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaymentDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DriverType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chargeDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ChargeDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CurrencyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Currency Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last4")]
        public string? Last4 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDetails" /> class.
        /// </summary>
        /// <param name="driverType"></param>
        /// <param name="driverId"></param>
        /// <param name="chargeDate"></param>
        /// <param name="amount"></param>
        /// <param name="currency"></param>
        /// <param name="description"></param>
        /// <param name="last4"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentDetails(
            string driverType,
            string driverId,
            global::System.DateTime chargeDate,
            double amount,
            global::Dataloop.Currency currency,
            string? description,
            string? last4)
        {
            this.DriverType = driverType ?? throw new global::System.ArgumentNullException(nameof(driverType));
            this.DriverId = driverId ?? throw new global::System.ArgumentNullException(nameof(driverId));
            this.Description = description;
            this.ChargeDate = chargeDate;
            this.Amount = amount;
            this.Currency = currency;
            this.Last4 = last4;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDetails" /> class.
        /// </summary>
        public PaymentDetails()
        {
        }
    }
}