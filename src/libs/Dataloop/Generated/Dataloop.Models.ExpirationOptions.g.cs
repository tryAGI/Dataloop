
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpirationOptions
    {
        /// <summary>
        /// Specifies the number of days after which each item becomes expired and should be deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemMaxDays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ItemMaxDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpirationOptions" /> class.
        /// </summary>
        /// <param name="itemMaxDays">
        /// Specifies the number of days after which each item becomes expired and should be deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpirationOptions(
            double itemMaxDays)
        {
            this.ItemMaxDays = itemMaxDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpirationOptions" /> class.
        /// </summary>
        public ExpirationOptions()
        {
        }
    }
}