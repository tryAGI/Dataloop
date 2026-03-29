
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APIApiKey Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Jwt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyResponse" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="jwt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyResponse(
            global::Dataloop.APIApiKey key,
            string jwt)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Jwt = jwt ?? throw new global::System.ArgumentNullException(nameof(jwt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyResponse" /> class.
        /// </summary>
        public CreateApiKeyResponse()
        {
        }
    }
}