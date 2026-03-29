
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecipeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mlGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MlGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mlTask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MlTask { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeType" /> class.
        /// </summary>
        /// <param name="dataType"></param>
        /// <param name="mlGroup"></param>
        /// <param name="mlTask"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecipeType(
            string dataType,
            string mlGroup,
            global::System.Collections.Generic.IList<string> mlTask)
        {
            this.DataType = dataType ?? throw new global::System.ArgumentNullException(nameof(dataType));
            this.MlGroup = mlGroup ?? throw new global::System.ArgumentNullException(nameof(mlGroup));
            this.MlTask = mlTask ?? throw new global::System.ArgumentNullException(nameof(mlTask));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeType" /> class.
        /// </summary>
        public RecipeType()
        {
        }
    }
}