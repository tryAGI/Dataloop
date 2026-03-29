
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IComputeAuthentication
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IComputeAuthenticationIntegration Integration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputeAuthentication" /> class.
        /// </summary>
        /// <param name="integration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IComputeAuthentication(
            global::Dataloop.IComputeAuthenticationIntegration integration)
        {
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputeAuthentication" /> class.
        /// </summary>
        public IComputeAuthentication()
        {
        }
    }
}