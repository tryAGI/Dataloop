
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelJoinMap2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelJoinMap2" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="ids"></param>
        /// <param name="modelName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelJoinMap2(
            global::System.Collections.Generic.IList<object> items,
            global::System.Collections.Generic.IList<string> ids,
            string modelName)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelJoinMap2" /> class.
        /// </summary>
        public ModelJoinMap2()
        {
        }
    }
}