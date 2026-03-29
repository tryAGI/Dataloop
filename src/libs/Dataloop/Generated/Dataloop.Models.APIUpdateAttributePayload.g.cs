
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIUpdateAttributePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::Dataloop.APIUpdateAttributePayloadScope? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<string>? Values { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        public object? Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIUpdateAttributePayload" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="scope"></param>
        /// <param name="values"></param>
        /// <param name="range"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIUpdateAttributePayload(
            string? key,
            global::Dataloop.APIUpdateAttributePayloadScope? scope,
            global::System.Collections.Generic.IList<string>? values,
            object? range)
        {
            this.Key = key;
            this.Scope = scope;
            this.Values = values;
            this.Range = range;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIUpdateAttributePayload" /> class.
        /// </summary>
        public APIUpdateAttributePayload()
        {
        }
    }
}