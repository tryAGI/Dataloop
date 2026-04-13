
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IPipelineNodeState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.NodeNamespace Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ENodeStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ENodeStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Attempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.NodeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.NodeType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IPipelineNodeState" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="id"></param>
        /// <param name="namespace"></param>
        /// <param name="status"></param>
        /// <param name="name"></param>
        /// <param name="attempts"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IPipelineNodeState(
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string id,
            global::Dataloop.NodeNamespace @namespace,
            global::Dataloop.ENodeStatus status,
            string name,
            double attempts,
            global::Dataloop.NodeType type)
        {
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Status = status;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Attempts = attempts;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPipelineNodeState" /> class.
        /// </summary>
        public IPipelineNodeState()
        {
        }
    }
}