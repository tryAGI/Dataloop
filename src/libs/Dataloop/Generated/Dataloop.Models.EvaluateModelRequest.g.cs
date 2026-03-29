
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluateModelRequest
    {
        /// <summary>
        /// Service Configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Dataloop.EvaluateModelRequestConfig? Config { get; set; }

        /// <summary>
        /// Evaluate input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.EvaluateModelRequestInput Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateModelRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Evaluate input
        /// </param>
        /// <param name="config">
        /// Service Configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluateModelRequest(
            global::Dataloop.EvaluateModelRequestInput input,
            global::Dataloop.EvaluateModelRequestConfig? config)
        {
            this.Config = config;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateModelRequest" /> class.
        /// </summary>
        public EvaluateModelRequest()
        {
        }
    }
}