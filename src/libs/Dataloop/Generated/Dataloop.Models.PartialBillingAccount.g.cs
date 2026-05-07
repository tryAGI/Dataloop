
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartialBillingAccount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("companyName")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("companyPhone")]
        public string? CompanyPhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingContact")]
        public string? BillingContact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        public global::System.Collections.Generic.IList<string>? Recipients { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Address Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taxData")]
        public global::Dataloop.PartialBillingAccountTaxData? TaxData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialBillingAccount" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="address"></param>
        /// <param name="companyName"></param>
        /// <param name="companyPhone"></param>
        /// <param name="billingContact"></param>
        /// <param name="recipients"></param>
        /// <param name="taxData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialBillingAccount(
            string accountId,
            global::Dataloop.Address address,
            string? companyName,
            string? companyPhone,
            string? billingContact,
            global::System.Collections.Generic.IList<string>? recipients,
            global::Dataloop.PartialBillingAccountTaxData? taxData)
        {
            this.CompanyName = companyName;
            this.CompanyPhone = companyPhone;
            this.BillingContact = billingContact;
            this.AccountId = accountId ?? throw new global::System.ArgumentNullException(nameof(accountId));
            this.Recipients = recipients;
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.TaxData = taxData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialBillingAccount" /> class.
        /// </summary>
        public PartialBillingAccount()
        {
        }
    }
}