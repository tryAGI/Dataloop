
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IPostPipeline
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startNodes")]
        public global::System.Collections.Generic.IList<global::Dataloop.IStartNode>? StartNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        public object? Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compositionId")]
        public string? CompositionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Preview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor> Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection> Connections { get; set; }

        /// <summary>
        /// Array of integrations ids - each one will be added to the service deployment as an environment variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IPostPipeline" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="description"></param>
        /// <param name="preview"></param>
        /// <param name="nodes"></param>
        /// <param name="connections"></param>
        /// <param name="secrets">
        /// Array of integrations ids - each one will be added to the service deployment as an environment variable
        /// </param>
        /// <param name="startNodes"></param>
        /// <param name="spec"></param>
        /// <param name="compositionId"></param>
        /// <param name="variables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IPostPipeline(
            string name,
            string projectId,
            string description,
            string preview,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor> nodes,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection> connections,
            global::System.Collections.Generic.IList<string> secrets,
            global::System.Collections.Generic.IList<global::Dataloop.IStartNode>? startNodes,
            object? spec,
            string? compositionId,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>? variables)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.StartNodes = startNodes;
            this.Spec = spec;
            this.CompositionId = compositionId;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Preview = preview ?? throw new global::System.ArgumentNullException(nameof(preview));
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.Connections = connections ?? throw new global::System.ArgumentNullException(nameof(connections));
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPostPipeline" /> class.
        /// </summary>
        public IPostPipeline()
        {
        }
    }
}