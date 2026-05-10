
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDriversIntegrationResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRequested")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalRequested { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Updated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notFound")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NotFound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.UpdateDriversIntegrationResultError> Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDriversIntegrationResult" /> class.
        /// </summary>
        /// <param name="totalRequested"></param>
        /// <param name="updated"></param>
        /// <param name="notFound"></param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDriversIntegrationResult(
            double totalRequested,
            double updated,
            global::System.Collections.Generic.IList<string> notFound,
            global::System.Collections.Generic.IList<global::Dataloop.UpdateDriversIntegrationResultError> errors)
        {
            this.TotalRequested = totalRequested;
            this.Updated = updated;
            this.NotFound = notFound ?? throw new global::System.ArgumentNullException(nameof(notFound));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDriversIntegrationResult" /> class.
        /// </summary>
        public UpdateDriversIntegrationResult()
        {
        }
    }
}