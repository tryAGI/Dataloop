
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ICompositionDatasetOntology
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.DpkDatasetOntologyTypeJsonConverter))]
        public global::Dataloop.DpkDatasetOntologyType? From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionDatasetOntology" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="from"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ICompositionDatasetOntology(
            string? value,
            global::Dataloop.DpkDatasetOntologyType? from)
        {
            this.Value = value;
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionDatasetOntology" /> class.
        /// </summary>
        public ICompositionDatasetOntology()
        {
        }
    }
}