
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DBBillingAccount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("companyName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompanyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("companyPhone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompanyPhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingContact")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingContact { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Address Address { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("taxData")]
        public global::Dataloop.TaxData? TaxData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Creator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DBBillingAccount" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="companyName"></param>
        /// <param name="companyPhone"></param>
        /// <param name="billingContact"></param>
        /// <param name="accountId"></param>
        /// <param name="recipients"></param>
        /// <param name="address"></param>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="updatedAt"></param>
        /// <param name="taxData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DBBillingAccount(
            string id,
            string companyName,
            string companyPhone,
            string billingContact,
            string accountId,
            global::System.Collections.Generic.IList<string> recipients,
            global::Dataloop.Address address,
            global::System.DateTime createdAt,
            string creator,
            global::System.DateTime? updatedAt,
            global::Dataloop.TaxData? taxData)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CompanyName = companyName ?? throw new global::System.ArgumentNullException(nameof(companyName));
            this.CompanyPhone = companyPhone ?? throw new global::System.ArgumentNullException(nameof(companyPhone));
            this.BillingContact = billingContact ?? throw new global::System.ArgumentNullException(nameof(billingContact));
            this.AccountId = accountId ?? throw new global::System.ArgumentNullException(nameof(accountId));
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TaxData = taxData;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DBBillingAccount" /> class.
        /// </summary>
        public DBBillingAccount()
        {
        }
    }
}