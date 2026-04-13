
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetDefaultRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DriverName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateExistingServices")]
        public bool? UpdateExistingServices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDefaultRequest" /> class.
        /// </summary>
        /// <param name="driverName"></param>
        /// <param name="organizationId"></param>
        /// <param name="updateExistingServices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetDefaultRequest(
            string driverName,
            string organizationId,
            bool? updateExistingServices)
        {
            this.DriverName = driverName ?? throw new global::System.ArgumentNullException(nameof(driverName));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.UpdateExistingServices = updateExistingServices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDefaultRequest" /> class.
        /// </summary>
        public SetDefaultRequest()
        {
        }
    }
}