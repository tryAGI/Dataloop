
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Run:ai configuration for GPU workload scheduling (scheduler, fractional GPU)
    /// </summary>
    public sealed partial class IRunAiConfig
    {
        /// <summary>
        /// When true, GPU workloads on this compute use Run:ai scheduler
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Run:ai project name template, e.g. "dataloop-{{orgId}}" or "{{namespace}}"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectNameTemplate")]
        public string? ProjectNameTemplate { get; set; }

        /// <summary>
        /// Run:ai project name (resolved per org/namespace when passed to workload)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// GPU fraction for workloads (0.25, 0.5, 1). null = full GPU
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultGpuFraction")]
        public double? DefaultGpuFraction { get; set; }

        /// <summary>
        /// Use fractional GPU for GPU pod types when fraction &lt; 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useFractionalGpu")]
        public bool? UseFractionalGpu { get; set; }

        /// <summary>
        /// Default number of GPU devices to apply fraction across (Run:ai gpu-fraction-num-devices). Default 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultGpuFractionNumDevices")]
        public double? DefaultGpuFractionNumDevices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IRunAiConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// When true, GPU workloads on this compute use Run:ai scheduler
        /// </param>
        /// <param name="projectNameTemplate">
        /// Run:ai project name template, e.g. "dataloop-{{orgId}}" or "{{namespace}}"
        /// </param>
        /// <param name="projectName">
        /// Run:ai project name (resolved per org/namespace when passed to workload)
        /// </param>
        /// <param name="defaultGpuFraction">
        /// GPU fraction for workloads (0.25, 0.5, 1). null = full GPU
        /// </param>
        /// <param name="useFractionalGpu">
        /// Use fractional GPU for GPU pod types when fraction &lt; 1
        /// </param>
        /// <param name="defaultGpuFractionNumDevices">
        /// Default number of GPU devices to apply fraction across (Run:ai gpu-fraction-num-devices). Default 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IRunAiConfig(
            bool enabled,
            string? projectNameTemplate,
            string? projectName,
            double? defaultGpuFraction,
            bool? useFractionalGpu,
            double? defaultGpuFractionNumDevices)
        {
            this.Enabled = enabled;
            this.ProjectNameTemplate = projectNameTemplate;
            this.ProjectName = projectName;
            this.DefaultGpuFraction = defaultGpuFraction;
            this.UseFractionalGpu = useFractionalGpu;
            this.DefaultGpuFractionNumDevices = defaultGpuFractionNumDevices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IRunAiConfig" /> class.
        /// </summary>
        public IRunAiConfig()
        {
        }
    }
}