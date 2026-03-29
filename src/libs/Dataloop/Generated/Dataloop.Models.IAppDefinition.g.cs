
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IAppDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("componentName")]
        public string? ComponentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpkName")]
        public string? DpkName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpkVersion")]
        public string? DpkVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpkId")]
        public string? DpkId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IAppDefinition" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="componentName"></param>
        /// <param name="dpkName"></param>
        /// <param name="dpkVersion"></param>
        /// <param name="dpkId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IAppDefinition(
            string id,
            string? componentName,
            string? dpkName,
            string? dpkVersion,
            string? dpkId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ComponentName = componentName;
            this.DpkName = dpkName;
            this.DpkVersion = dpkVersion;
            this.DpkId = dpkId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IAppDefinition" /> class.
        /// </summary>
        public IAppDefinition()
        {
        }
    }
}