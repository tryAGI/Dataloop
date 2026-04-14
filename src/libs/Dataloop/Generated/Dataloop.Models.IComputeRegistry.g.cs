
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IComputeRegistry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faasFolder")]
        public string? FaasFolder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bootstrapFolder")]
        public string? BootstrapFolder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputeRegistry" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="faasFolder"></param>
        /// <param name="bootstrapFolder"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IComputeRegistry(
            string domain,
            string? faasFolder,
            string? bootstrapFolder)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.FaasFolder = faasFolder;
            this.BootstrapFolder = bootstrapFolder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputeRegistry" /> class.
        /// </summary>
        public IComputeRegistry()
        {
        }
    }
}