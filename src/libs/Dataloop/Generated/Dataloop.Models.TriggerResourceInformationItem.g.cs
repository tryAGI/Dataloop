
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TriggerResourceInformationItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TriggerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerActions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TriggerActions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageModuleName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageModuleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageFunctionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageFunctionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageFunctionDescription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageFunctionDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerResourceInformationItem" /> class.
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="serviceName"></param>
        /// <param name="triggerId"></param>
        /// <param name="triggerActions"></param>
        /// <param name="packageModuleName"></param>
        /// <param name="packageFunctionName"></param>
        /// <param name="packageFunctionDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerResourceInformationItem(
            string serviceId,
            string serviceName,
            string triggerId,
            global::System.Collections.Generic.IList<string> triggerActions,
            string packageModuleName,
            string packageFunctionName,
            string packageFunctionDescription)
        {
            this.ServiceId = serviceId ?? throw new global::System.ArgumentNullException(nameof(serviceId));
            this.ServiceName = serviceName ?? throw new global::System.ArgumentNullException(nameof(serviceName));
            this.TriggerId = triggerId ?? throw new global::System.ArgumentNullException(nameof(triggerId));
            this.TriggerActions = triggerActions ?? throw new global::System.ArgumentNullException(nameof(triggerActions));
            this.PackageModuleName = packageModuleName ?? throw new global::System.ArgumentNullException(nameof(packageModuleName));
            this.PackageFunctionName = packageFunctionName ?? throw new global::System.ArgumentNullException(nameof(packageFunctionName));
            this.PackageFunctionDescription = packageFunctionDescription ?? throw new global::System.ArgumentNullException(nameof(packageFunctionDescription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerResourceInformationItem" /> class.
        /// </summary>
        public TriggerResourceInformationItem()
        {
        }
    }
}