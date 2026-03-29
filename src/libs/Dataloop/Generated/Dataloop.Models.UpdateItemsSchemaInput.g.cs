
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateItemsSchemaInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemaKeys")]
        public global::Dataloop.UpdateItemsSchemaInputSchemaKeys? SchemaKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unsearchablePaths")]
        public global::Dataloop.UpdateItemsSchemaInputUnsearchablePaths? UnsearchablePaths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexingOptions")]
        public global::Dataloop.UpdateItemsSchemaInputIndexingOptions? IndexingOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateItemsSchemaInput" /> class.
        /// </summary>
        /// <param name="schemaKeys"></param>
        /// <param name="unsearchablePaths"></param>
        /// <param name="indexingOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateItemsSchemaInput(
            global::Dataloop.UpdateItemsSchemaInputSchemaKeys? schemaKeys,
            global::Dataloop.UpdateItemsSchemaInputUnsearchablePaths? unsearchablePaths,
            global::Dataloop.UpdateItemsSchemaInputIndexingOptions? indexingOptions)
        {
            this.SchemaKeys = schemaKeys;
            this.UnsearchablePaths = unsearchablePaths;
            this.IndexingOptions = indexingOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateItemsSchemaInput" /> class.
        /// </summary>
        public UpdateItemsSchemaInput()
        {
        }
    }
}