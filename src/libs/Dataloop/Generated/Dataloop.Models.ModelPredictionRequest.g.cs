
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPredictionRequest
    {
        /// <summary>
        /// Service Configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Dataloop.ModelPredictionRequestConfig? Config { get; set; }

        /// <summary>
        /// Predict input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ModelPredictionRequestInput Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPredictionRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Predict input
        /// </param>
        /// <param name="config">
        /// Service Configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPredictionRequest(
            global::Dataloop.ModelPredictionRequestInput input,
            global::Dataloop.ModelPredictionRequestConfig? config)
        {
            this.Config = config;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPredictionRequest" /> class.
        /// </summary>
        public ModelPredictionRequest()
        {
        }
    }
}