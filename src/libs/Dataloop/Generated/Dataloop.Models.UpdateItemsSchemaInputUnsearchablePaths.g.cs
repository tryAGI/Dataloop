
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateItemsSchemaInputUnsearchablePaths
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove")]
        public global::System.Collections.Generic.IList<string>? Remove { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add")]
        public global::System.Collections.Generic.IList<string>? Add { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateItemsSchemaInputUnsearchablePaths" /> class.
        /// </summary>
        /// <param name="remove"></param>
        /// <param name="add"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateItemsSchemaInputUnsearchablePaths(
            global::System.Collections.Generic.IList<string>? remove,
            global::System.Collections.Generic.IList<string>? add)
        {
            this.Remove = remove;
            this.Add = add;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateItemsSchemaInputUnsearchablePaths" /> class.
        /// </summary>
        public UpdateItemsSchemaInputUnsearchablePaths()
        {
        }
    }
}