
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IHpaControllerConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insecureSkipVerify")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InsecureSkipVerify { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IHpaControllerConfig" /> class.
        /// </summary>
        /// <param name="insecureSkipVerify"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IHpaControllerConfig(
            string insecureSkipVerify)
        {
            this.InsecureSkipVerify = insecureSkipVerify ?? throw new global::System.ArgumentNullException(nameof(insecureSkipVerify));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IHpaControllerConfig" /> class.
        /// </summary>
        public IHpaControllerConfig()
        {
        }
    }
}