
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DQLResourceQuerySign
    {
        /// <summary>
        /// expiration in seconds<br/>
        /// Default Value: 1 hour from now
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exp")]
        public double? Exp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DQLResourceQuerySign" /> class.
        /// </summary>
        /// <param name="exp">
        /// expiration in seconds<br/>
        /// Default Value: 1 hour from now
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DQLResourceQuerySign(
            double? exp)
        {
            this.Exp = exp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DQLResourceQuerySign" /> class.
        /// </summary>
        public DQLResourceQuerySign()
        {
        }
    }
}