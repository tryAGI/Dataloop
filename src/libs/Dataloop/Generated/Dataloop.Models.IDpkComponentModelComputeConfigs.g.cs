
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkComponentModelComputeConfigs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed")]
        public string? Embed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Evaluate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predict")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Predict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Train { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentModelComputeConfigs" /> class.
        /// </summary>
        /// <param name="default"></param>
        /// <param name="evaluate"></param>
        /// <param name="predict"></param>
        /// <param name="train"></param>
        /// <param name="embed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkComponentModelComputeConfigs(
            string @default,
            string evaluate,
            string predict,
            string train,
            string? embed)
        {
            this.Default = @default ?? throw new global::System.ArgumentNullException(nameof(@default));
            this.Embed = embed;
            this.Evaluate = evaluate ?? throw new global::System.ArgumentNullException(nameof(evaluate));
            this.Predict = predict ?? throw new global::System.ArgumentNullException(nameof(predict));
            this.Train = train ?? throw new global::System.ArgumentNullException(nameof(train));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentModelComputeConfigs" /> class.
        /// </summary>
        public IDpkComponentModelComputeConfigs()
        {
        }
    }
}