
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIBillableResource
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
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.BillingResourceKeyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.BillingResourceKey Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiers")]
        public global::System.Collections.Generic.IList<global::Dataloop.RangeOrFeatureTier>? Tiers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overQuota")]
        public global::Dataloop.OverQuota? OverQuota { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayedInInvoice")]
        public bool? DisplayedInInvoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIBillableResource" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="icon"></param>
        /// <param name="price"></param>
        /// <param name="amount"></param>
        /// <param name="unit"></param>
        /// <param name="tiers"></param>
        /// <param name="overQuota"></param>
        /// <param name="displayedInInvoice"></param>
        /// <param name="group"></param>
        /// <param name="tier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIBillableResource(
            string id,
            string url,
            global::Dataloop.BillingResourceKey key,
            string name,
            string type,
            string description,
            string icon,
            double? price,
            double? amount,
            string? unit,
            global::System.Collections.Generic.IList<global::Dataloop.RangeOrFeatureTier>? tiers,
            global::Dataloop.OverQuota? overQuota,
            bool? displayedInInvoice,
            string? group,
            string? tier)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Key = key;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Icon = icon ?? throw new global::System.ArgumentNullException(nameof(icon));
            this.Price = price;
            this.Amount = amount;
            this.Unit = unit;
            this.Tiers = tiers;
            this.OverQuota = overQuota;
            this.DisplayedInInvoice = displayedInInvoice;
            this.Group = group;
            this.Tier = tier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIBillableResource" /> class.
        /// </summary>
        public APIBillableResource()
        {
        }
    }
}