
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetDirectoryTree
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APIDatasetDirectoryItem Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        public global::System.Collections.Generic.IList<global::Dataloop.DatasetDirectoryTree>? Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetDirectoryTree" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="children"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetDirectoryTree(
            global::Dataloop.APIDatasetDirectoryItem value,
            global::System.Collections.Generic.IList<global::Dataloop.DatasetDirectoryTree>? children)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Children = children;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetDirectoryTree" /> class.
        /// </summary>
        public DatasetDirectoryTree()
        {
        }
    }
}