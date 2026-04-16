
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IServiceAppConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCustomServer")]
        public bool? IsCustomServer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IServiceAppConfig" /> class.
        /// </summary>
        /// <param name="isCustomServer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IServiceAppConfig(
            bool? isCustomServer)
        {
            this.IsCustomServer = isCustomServer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IServiceAppConfig" /> class.
        /// </summary>
        public IServiceAppConfig()
        {
        }
    }
}