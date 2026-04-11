
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompositionStatusDescriptor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Running { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Failed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Pending { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StandBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositionStatusDescriptor" /> class.
        /// </summary>
        /// <param name="running"></param>
        /// <param name="failed"></param>
        /// <param name="pending"></param>
        /// <param name="standBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompositionStatusDescriptor(
            double running,
            double failed,
            double pending,
            double standBy)
        {
            this.Running = running;
            this.Failed = failed;
            this.Pending = pending;
            this.StandBy = standBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositionStatusDescriptor" /> class.
        /// </summary>
        public CompositionStatusDescriptor()
        {
        }
    }
}