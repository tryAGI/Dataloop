
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IAppGeneralSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoUpdate")]
        public bool? AutoUpdate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IAppGeneralSettings" /> class.
        /// </summary>
        /// <param name="autoUpdate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IAppGeneralSettings(
            bool? autoUpdate)
        {
            this.AutoUpdate = autoUpdate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IAppGeneralSettings" /> class.
        /// </summary>
        public IAppGeneralSettings()
        {
        }
    }
}