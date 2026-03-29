
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReferenceQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.ReferenceQueryOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ReferenceQueryOperation Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.ReferenceQueryRef> Refs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public double? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceQuery" /> class.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="refs"></param>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferenceQuery(
            global::Dataloop.ReferenceQueryOperation operation,
            global::System.Collections.Generic.IList<global::Dataloop.ReferenceQueryRef> refs,
            double? index)
        {
            this.Operation = operation;
            this.Refs = refs ?? throw new global::System.ArgumentNullException(nameof(refs));
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceQuery" /> class.
        /// </summary>
        public ReferenceQuery()
        {
        }
    }
}