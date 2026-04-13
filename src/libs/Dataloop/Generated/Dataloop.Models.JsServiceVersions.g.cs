
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsServiceVersions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtlpy")]
        public string? Dtlpy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner")]
        public string? Runner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy")]
        public string? Proxy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verify")]
        public bool? Verify { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsServiceVersions" /> class.
        /// </summary>
        /// <param name="dtlpy"></param>
        /// <param name="runner"></param>
        /// <param name="proxy"></param>
        /// <param name="verify"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsServiceVersions(
            string? dtlpy,
            string? runner,
            string? proxy,
            bool? verify)
        {
            this.Dtlpy = dtlpy;
            this.Runner = runner;
            this.Proxy = proxy;
            this.Verify = verify;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsServiceVersions" /> class.
        /// </summary>
        public JsServiceVersions()
        {
        }
    }
}