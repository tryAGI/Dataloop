
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JoinQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.JoinQueryOn On { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinQuery" /> class.
        /// </summary>
        /// <param name="on"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JoinQuery(
            global::Dataloop.JoinQueryOn on)
        {
            this.On = on ?? throw new global::System.ArgumentNullException(nameof(on));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinQuery" /> class.
        /// </summary>
        public JoinQuery()
        {
        }
    }
}