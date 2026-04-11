
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PiperSettingsCommandsRetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nonRetryableError")]
        public bool? NonRetryableError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Attempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxRetries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxRetries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PiperSettingsCommandsRetry" /> class.
        /// </summary>
        /// <param name="attempts"></param>
        /// <param name="maxRetries"></param>
        /// <param name="nonRetryableError"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PiperSettingsCommandsRetry(
            double attempts,
            double maxRetries,
            bool? nonRetryableError)
        {
            this.NonRetryableError = nonRetryableError;
            this.Attempts = attempts;
            this.MaxRetries = maxRetries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiperSettingsCommandsRetry" /> class.
        /// </summary>
        public PiperSettingsCommandsRetry()
        {
        }
    }
}