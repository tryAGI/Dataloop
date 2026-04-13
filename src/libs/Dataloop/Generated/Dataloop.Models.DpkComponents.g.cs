
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DpkComponents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentIntegrations>? Integrations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentDataset>? Datasets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineTemplates")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkPipelineTemplate>? PipelineTemplates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineNodes")]
        public global::System.Collections.Generic.IList<global::Dataloop.IPipelineNode>? PipelineNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computeConfigs")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComputeConfigs>? ComputeConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkChannel>? Channels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolbars")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentToolbars>? Toolbars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("services")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentService>? Services { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentTrigger>? Triggers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modules")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentModule>? Modules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentModel>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panels")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentPanel>? Panels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DpkComponents" /> class.
        /// </summary>
        /// <param name="integrations"></param>
        /// <param name="datasets"></param>
        /// <param name="pipelineTemplates"></param>
        /// <param name="pipelineNodes"></param>
        /// <param name="computeConfigs"></param>
        /// <param name="channels"></param>
        /// <param name="toolbars"></param>
        /// <param name="services"></param>
        /// <param name="triggers"></param>
        /// <param name="modules"></param>
        /// <param name="models"></param>
        /// <param name="panels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DpkComponents(
            global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentIntegrations>? integrations,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentDataset>? datasets,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkPipelineTemplate>? pipelineTemplates,
            global::System.Collections.Generic.IList<global::Dataloop.IPipelineNode>? pipelineNodes,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkComputeConfigs>? computeConfigs,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkChannel>? channels,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentToolbars>? toolbars,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentService>? services,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentTrigger>? triggers,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentModule>? modules,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentModel>? models,
            global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentPanel>? panels)
        {
            this.Integrations = integrations;
            this.Datasets = datasets;
            this.PipelineTemplates = pipelineTemplates;
            this.PipelineNodes = pipelineNodes;
            this.ComputeConfigs = computeConfigs;
            this.Channels = channels;
            this.Toolbars = toolbars;
            this.Services = services;
            this.Triggers = triggers;
            this.Modules = modules;
            this.Models = models;
            this.Panels = panels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpkComponents" /> class.
        /// </summary>
        public DpkComponents()
        {
        }
    }
}