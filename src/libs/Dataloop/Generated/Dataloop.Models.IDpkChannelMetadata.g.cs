
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkChannelMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codebase")]
        public global::Dataloop.Codebase? Codebase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkChannelMetadata" /> class.
        /// </summary>
        /// <param name="functionName"></param>
        /// <param name="serviceName"></param>
        /// <param name="codebase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkChannelMetadata(
            string functionName,
            string serviceName,
            global::Dataloop.Codebase? codebase)
        {
            this.Codebase = codebase;
            this.FunctionName = functionName ?? throw new global::System.ArgumentNullException(nameof(functionName));
            this.ServiceName = serviceName ?? throw new global::System.ArgumentNullException(nameof(serviceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkChannelMetadata" /> class.
        /// </summary>
        public IDpkChannelMetadata()
        {
        }
    }
}