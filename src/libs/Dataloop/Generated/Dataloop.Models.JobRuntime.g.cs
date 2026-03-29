
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobRuntime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public double? Concurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("singleAgent")]
        public bool? SingleAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DataloopPodTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DataloopPodType PodType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preemptible")]
        public bool? Preemptible { get; set; }

        /// <summary>
        /// GPU fraction for Run:ai (0.25, 0.5, 1). When &lt; 1 with useFractionalGpu, uses fractional GPU sharing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpuFraction")]
        public double? GpuFraction { get; set; }

        /// <summary>
        /// Number of GPU devices to apply fraction across (Run:ai gpu-fraction-num-devices). Default 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpuFractionNumDevices")]
        public double? GpuFractionNumDevices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobRuntime" /> class.
        /// </summary>
        /// <param name="podType"></param>
        /// <param name="image"></param>
        /// <param name="concurrency"></param>
        /// <param name="singleAgent"></param>
        /// <param name="preemptible"></param>
        /// <param name="gpuFraction">
        /// GPU fraction for Run:ai (0.25, 0.5, 1). When &lt; 1 with useFractionalGpu, uses fractional GPU sharing
        /// </param>
        /// <param name="gpuFractionNumDevices">
        /// Number of GPU devices to apply fraction across (Run:ai gpu-fraction-num-devices). Default 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobRuntime(
            global::Dataloop.DataloopPodType podType,
            string image,
            double? concurrency,
            bool? singleAgent,
            bool? preemptible,
            double? gpuFraction,
            double? gpuFractionNumDevices)
        {
            this.Concurrency = concurrency;
            this.SingleAgent = singleAgent;
            this.PodType = podType;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Preemptible = preemptible;
            this.GpuFraction = gpuFraction;
            this.GpuFractionNumDevices = gpuFractionNumDevices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobRuntime" /> class.
        /// </summary>
        public JobRuntime()
        {
        }
    }
}