
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IInvoke
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputOptions")]
        public global::Dataloop.Dictionary? InputOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IInvoke" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="namespace"></param>
        /// <param name="source"></param>
        /// <param name="inputOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IInvoke(
            string type,
            string @namespace,
            string? source,
            global::Dataloop.Dictionary? inputOptions)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Source = source;
            this.InputOptions = inputOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IInvoke" /> class.
        /// </summary>
        public IInvoke()
        {
        }
    }
}