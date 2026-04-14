
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IRerunCycleOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CycleRerunMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CycleRerunMethod Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startNodeIds")]
        public global::System.Collections.Generic.IList<string>? StartNodeIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IRerunCycleOptions" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="startNodeIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IRerunCycleOptions(
            global::Dataloop.CycleRerunMethod method,
            global::System.Collections.Generic.IList<string>? startNodeIds)
        {
            this.Method = method;
            this.StartNodeIds = startNodeIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IRerunCycleOptions" /> class.
        /// </summary>
        public IRerunCycleOptions()
        {
        }
    }
}