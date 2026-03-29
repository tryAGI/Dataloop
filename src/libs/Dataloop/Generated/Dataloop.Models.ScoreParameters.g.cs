
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ScoreParametersScore Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::Dataloop.ScoreParametersOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreParameters" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="options"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreParameters(
            global::Dataloop.ScoreParametersScore score,
            global::Dataloop.ScoreParametersOptions? options)
        {
            this.Score = score ?? throw new global::System.ArgumentNullException(nameof(score));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreParameters" /> class.
        /// </summary>
        public ScoreParameters()
        {
        }
    }
}