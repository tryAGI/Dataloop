
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaasUsageDescriptor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("services")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.FaasUsageServiceInstanceDescriptor> Services { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("globalServices")]
        public global::System.Collections.Generic.IList<global::Dataloop.FaasGlobalServiceDescriptor>? GlobalServices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaasUsageDescriptor" /> class.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="globalServices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaasUsageDescriptor(
            global::System.Collections.Generic.IList<global::Dataloop.FaasUsageServiceInstanceDescriptor> services,
            global::System.Collections.Generic.IList<global::Dataloop.FaasGlobalServiceDescriptor>? globalServices)
        {
            this.Services = services ?? throw new global::System.ArgumentNullException(nameof(services));
            this.GlobalServices = globalServices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaasUsageDescriptor" /> class.
        /// </summary>
        public FaasUsageDescriptor()
        {
        }
    }
}