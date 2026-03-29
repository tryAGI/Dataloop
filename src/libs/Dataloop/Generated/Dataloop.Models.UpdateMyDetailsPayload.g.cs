
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMyDetailsPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cookieApproval")]
        public double? CookieApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interest")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.UserInterestTypeJsonConverter))]
        public global::Dataloop.UserInterestType? Interest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public string? Org { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMyDetailsPayload" /> class.
        /// </summary>
        /// <param name="cookieApproval"></param>
        /// <param name="interest"></param>
        /// <param name="timezone"></param>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="org"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMyDetailsPayload(
            double? cookieApproval,
            global::Dataloop.UserInterestType? interest,
            string? timezone,
            string? lastName,
            string? firstName,
            string? org)
        {
            this.CookieApproval = cookieApproval;
            this.Interest = interest;
            this.Timezone = timezone;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Org = org;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMyDetailsPayload" /> class.
        /// </summary>
        public UpdateMyDetailsPayload()
        {
        }
    }
}