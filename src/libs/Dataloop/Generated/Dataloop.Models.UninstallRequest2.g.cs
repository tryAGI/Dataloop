
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UninstallRequest2
    {
        /// <summary>
        /// Boolean value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public bool? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UninstallRequest2" /> class.
        /// </summary>
        /// <param name="value">
        /// Boolean value
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UninstallRequest2(
            bool? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UninstallRequest2" /> class.
        /// </summary>
        public UninstallRequest2()
        {
        }
    }
}