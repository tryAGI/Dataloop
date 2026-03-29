
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PoseCoordinates
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instanceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstanceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PoseCoordinates" /> class.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="instanceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PoseCoordinates(
            string templateId,
            string instanceId)
        {
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.InstanceId = instanceId ?? throw new global::System.ArgumentNullException(nameof(instanceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PoseCoordinates" /> class.
        /// </summary>
        public PoseCoordinates()
        {
        }
    }
}