
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// annotations export options
    /// </summary>
    public sealed partial class ExportDatasetOptionsAnnotations
    {
        /// <summary>
        /// given an export by filter - determine if to filter out annotations<br/>
        /// Default Value: false (export will filter out items, but not annotations)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Filter { get; set; }

        /// <summary>
        /// determine if semantic annotations should exported as png files<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convertSemantic")]
        public bool? ConvertSemantic { get; set; }

        /// <summary>
        /// determine if export should contain annotations<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Include { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportDatasetOptionsAnnotations" /> class.
        /// </summary>
        /// <param name="include">
        /// determine if export should contain annotations<br/>
        /// Default Value: true
        /// </param>
        /// <param name="convertSemantic">
        /// determine if semantic annotations should exported as png files<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportDatasetOptionsAnnotations(
            bool include,
            bool? convertSemantic)
        {
            this.ConvertSemantic = convertSemantic;
            this.Include = include;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportDatasetOptionsAnnotations" /> class.
        /// </summary>
        public ExportDatasetOptionsAnnotations()
        {
        }
    }
}