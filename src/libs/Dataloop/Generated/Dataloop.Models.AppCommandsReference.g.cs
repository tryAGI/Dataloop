
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppCommandsReference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update")]
        public string? Update { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uninstall")]
        public string? Uninstall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("install")]
        public string? Install { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCommandsReference" /> class.
        /// </summary>
        /// <param name="update"></param>
        /// <param name="uninstall"></param>
        /// <param name="install"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCommandsReference(
            string? update,
            string? uninstall,
            string? install)
        {
            this.Update = update;
            this.Uninstall = uninstall;
            this.Install = install;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCommandsReference" /> class.
        /// </summary>
        public AppCommandsReference()
        {
        }
    }
}