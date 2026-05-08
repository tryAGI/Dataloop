
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDriversIntegrationResultError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DriverId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDriversIntegrationResultError" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="driverId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDriversIntegrationResultError(
            string error,
            string driverId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.DriverId = driverId ?? throw new global::System.ArgumentNullException(nameof(driverId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDriversIntegrationResultError" /> class.
        /// </summary>
        public UpdateDriversIntegrationResultError()
        {
        }
    }
}