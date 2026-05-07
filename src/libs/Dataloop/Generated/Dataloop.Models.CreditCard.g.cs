
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditCard
    {
        /// <summary>
        /// Card brand. Can be `amex`, `diners`, `discover`, `jcb`, `mastercard`, `unionpay`, `visa`, or `unknown`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brand")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Brand { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country of the card. You could use this attribute to get a sense of the international breakdown of cards you've collected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// A high-level description of the type of cards issued in this range. (For internal use only and not typically available in standard API requests.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exp_month")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the card's expiration year.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exp_year")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpYear { get; set; }

        /// <summary>
        /// Uniquely identifies this particular card number. You can use this attribute to check whether two customers who've signed up with you are using the same card number, for example. For payment methods that tokenize card information (Apple Pay, Google Pay), the tokenized number might be provided instead of the underlying card number.<br/>
        /// *Starting May 1, 2021, card fingerprint in India for Connect will change to allow two fingerprints for the same card --- one for India and one for the rest of the world.*
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fingerprint")]
        public string? Fingerprint { get; set; }

        /// <summary>
        /// Card funding type. Can be `credit`, `debit`, `prepaid`, or `unknown`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("funding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Funding { get; set; }

        /// <summary>
        /// The last four digits of the card.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last4")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Last4 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCard" /> class.
        /// </summary>
        /// <param name="brand">
        /// Card brand. Can be `amex`, `diners`, `discover`, `jcb`, `mastercard`, `unionpay`, `visa`, or `unknown`.
        /// </param>
        /// <param name="expMonth">
        /// Two-digit number representing the card's expiration month.
        /// </param>
        /// <param name="expYear">
        /// Four-digit number representing the card's expiration year.
        /// </param>
        /// <param name="funding">
        /// Card funding type. Can be `credit`, `debit`, `prepaid`, or `unknown`.
        /// </param>
        /// <param name="last4">
        /// The last four digits of the card.
        /// </param>
        /// <param name="country">
        /// Two-letter ISO code representing the country of the card. You could use this attribute to get a sense of the international breakdown of cards you've collected.
        /// </param>
        /// <param name="description">
        /// A high-level description of the type of cards issued in this range. (For internal use only and not typically available in standard API requests.)
        /// </param>
        /// <param name="fingerprint">
        /// Uniquely identifies this particular card number. You can use this attribute to check whether two customers who've signed up with you are using the same card number, for example. For payment methods that tokenize card information (Apple Pay, Google Pay), the tokenized number might be provided instead of the underlying card number.<br/>
        /// *Starting May 1, 2021, card fingerprint in India for Connect will change to allow two fingerprints for the same card --- one for India and one for the rest of the world.*
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditCard(
            string brand,
            double expMonth,
            double expYear,
            string funding,
            string last4,
            string? country,
            string? description,
            string? fingerprint)
        {
            this.Brand = brand ?? throw new global::System.ArgumentNullException(nameof(brand));
            this.Country = country;
            this.Description = description;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Fingerprint = fingerprint;
            this.Funding = funding ?? throw new global::System.ArgumentNullException(nameof(funding));
            this.Last4 = last4 ?? throw new global::System.ArgumentNullException(nameof(last4));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCard" /> class.
        /// </summary>
        public CreditCard()
        {
        }
    }
}