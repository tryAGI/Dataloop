
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelOperationMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.IList<string>? Datasets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("services")]
        public global::System.Collections.Generic.IList<string>? Services { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executions")]
        public global::System.Collections.Generic.IList<string>? Executions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelOperationMetadata" /> class.
        /// </summary>
        /// <param name="datasets"></param>
        /// <param name="services"></param>
        /// <param name="executions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelOperationMetadata(
            global::System.Collections.Generic.IList<string>? datasets,
            global::System.Collections.Generic.IList<string>? services,
            global::System.Collections.Generic.IList<string>? executions)
        {
            this.Datasets = datasets;
            this.Services = services;
            this.Executions = executions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelOperationMetadata" /> class.
        /// </summary>
        public ModelOperationMetadata()
        {
        }
    }
}