
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterQueryInputReferences
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.FilterQueryInputReferencesRef> Refs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterQueryInputReferences" /> class.
        /// </summary>
        /// <param name="refs"></param>
        /// <param name="operation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterQueryInputReferences(
            global::System.Collections.Generic.IList<global::Dataloop.FilterQueryInputReferencesRef> refs,
            string operation)
        {
            this.Refs = refs ?? throw new global::System.ArgumentNullException(nameof(refs));
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterQueryInputReferences" /> class.
        /// </summary>
        public FilterQueryInputReferences()
        {
        }
    }
}