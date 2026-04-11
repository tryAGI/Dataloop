
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FieldSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.FieldSortFieldJsonConverter))]
        public global::Dataloop.FieldSortField? Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.FieldSortDirectionJsonConverter))]
        public global::Dataloop.FieldSortDirection? Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldSort" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="direction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FieldSort(
            global::Dataloop.FieldSortField? field,
            global::Dataloop.FieldSortDirection? direction)
        {
            this.Field = field;
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldSort" /> class.
        /// </summary>
        public FieldSort()
        {
        }
    }
}