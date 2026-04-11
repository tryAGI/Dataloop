
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Invoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unique identifier for the invoice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id2 { get; set; }

        /// <summary>
        /// DL account ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Account { get; set; }

        /// <summary>
        /// Detailed information about all of the invoice contacts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contacts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.ContactInfo> Contacts { get; set; }

        /// <summary>
        /// Detailing all the billable products included in the invoice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.LineItem> Items { get; set; }

        /// <summary>
        /// Total billed amount
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPrice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalPrice { get; set; }

        /// <summary>
        /// Date range of the resource usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billedPeriod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.InvoiceBilledPeriod BilledPeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.InvoiceStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.InvoiceStatus Status { get; set; }

        /// <summary>
        /// All payments details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.PaymentDetails> Payments { get; set; }

        /// <summary>
        /// When applicable, include a link to a pdf invoice hosted by Stripe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeInvoiceUrl")]
        public string? StripeInvoiceUrl { get; set; }

        /// <summary>
        /// When applicable, include the identifier of a Stripe invoice object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeInvoiceId")]
        public string? StripeInvoiceId { get; set; }

        /// <summary>
        /// When applicable, include the number of a Stripe invoice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeInvoiceNumber")]
        public string? StripeInvoiceNumber { get; set; }

        /// <summary>
        /// When applicable, include the location in which the DL archive stores the Stripe invoice pdf
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdfLocation")]
        public string? PdfLocation { get; set; }

        /// <summary>
        /// Specifies whether a charge is currently in progress
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chargeInProgress")]
        public bool? ChargeInProgress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        /// <param name="id2">
        /// Unique identifier for the invoice
        /// </param>
        /// <param name="account">
        /// DL account ID
        /// </param>
        /// <param name="contacts">
        /// Detailed information about all of the invoice contacts
        /// </param>
        /// <param name="items">
        /// Detailing all the billable products included in the invoice
        /// </param>
        /// <param name="totalPrice">
        /// Total billed amount
        /// </param>
        /// <param name="billedPeriod">
        /// Date range of the resource usage
        /// </param>
        /// <param name="status"></param>
        /// <param name="payments">
        /// All payments details
        /// </param>
        /// <param name="id"></param>
        /// <param name="stripeInvoiceUrl">
        /// When applicable, include a link to a pdf invoice hosted by Stripe
        /// </param>
        /// <param name="stripeInvoiceId">
        /// When applicable, include the identifier of a Stripe invoice object
        /// </param>
        /// <param name="stripeInvoiceNumber">
        /// When applicable, include the number of a Stripe invoice
        /// </param>
        /// <param name="pdfLocation">
        /// When applicable, include the location in which the DL archive stores the Stripe invoice pdf
        /// </param>
        /// <param name="chargeInProgress">
        /// Specifies whether a charge is currently in progress
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Invoice(
            string id2,
            string account,
            global::System.Collections.Generic.IList<global::Dataloop.ContactInfo> contacts,
            global::System.Collections.Generic.IList<global::Dataloop.LineItem> items,
            double totalPrice,
            global::Dataloop.InvoiceBilledPeriod billedPeriod,
            global::Dataloop.InvoiceStatus status,
            global::System.Collections.Generic.IList<global::Dataloop.PaymentDetails> payments,
            string? id,
            string? stripeInvoiceUrl,
            string? stripeInvoiceId,
            string? stripeInvoiceNumber,
            string? pdfLocation,
            bool? chargeInProgress)
        {
            this.Id = id;
            this.Id2 = id2 ?? throw new global::System.ArgumentNullException(nameof(id2));
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.Contacts = contacts ?? throw new global::System.ArgumentNullException(nameof(contacts));
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.TotalPrice = totalPrice;
            this.BilledPeriod = billedPeriod ?? throw new global::System.ArgumentNullException(nameof(billedPeriod));
            this.Status = status;
            this.Payments = payments ?? throw new global::System.ArgumentNullException(nameof(payments));
            this.StripeInvoiceUrl = stripeInvoiceUrl;
            this.StripeInvoiceId = stripeInvoiceId;
            this.StripeInvoiceNumber = stripeInvoiceNumber;
            this.PdfLocation = pdfLocation;
            this.ChargeInProgress = chargeInProgress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        public Invoice()
        {
        }
    }
}