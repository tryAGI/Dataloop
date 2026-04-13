
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HttpContext
    {
        /// <summary>
        /// Http Request Id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Requesting user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// Client used for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Client { get; set; }

        /// <summary>
        /// Given request from a Dataloop FaaS service - service identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointId")]
        public string? EndpointId { get; set; }

        /// <summary>
        /// Expiration time of the Http Request JWT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwtExp")]
        public double? JwtExp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpContext" /> class.
        /// </summary>
        /// <param name="id">
        /// Http Request Id
        /// </param>
        /// <param name="user">
        /// Requesting user
        /// </param>
        /// <param name="client">
        /// Client used for the request
        /// </param>
        /// <param name="endpointId">
        /// Given request from a Dataloop FaaS service - service identifier
        /// </param>
        /// <param name="jwtExp">
        /// Expiration time of the Http Request JWT
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HttpContext(
            string id,
            string user,
            string client,
            string? endpointId,
            double? jwtExp)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Client = client ?? throw new global::System.ArgumentNullException(nameof(client));
            this.EndpointId = endpointId;
            this.JwtExp = jwtExp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpContext" /> class.
        /// </summary>
        public HttpContext()
        {
        }
    }
}