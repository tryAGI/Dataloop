
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class INodeConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package")]
        public global::Dataloop.INodeConfigPackage? Package { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="INodeConfig" /> class.
        /// </summary>
        /// <param name="package"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public INodeConfig(
            global::Dataloop.INodeConfigPackage? package)
        {
            this.Package = package;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="INodeConfig" /> class.
        /// </summary>
        public INodeConfig()
        {
        }
    }
}