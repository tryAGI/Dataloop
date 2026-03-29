
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreParametersScore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Dataloop.ScoreParametersScoreContext? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ScoreTypeJsonConverter))]
        public global::Dataloop.ScoreType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreParametersScore" /> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreParametersScore(
            global::Dataloop.ScoreParametersScoreContext? context,
            global::Dataloop.ScoreType? type)
        {
            this.Context = context;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreParametersScore" /> class.
        /// </summary>
        public ScoreParametersScore()
        {
        }
    }
}