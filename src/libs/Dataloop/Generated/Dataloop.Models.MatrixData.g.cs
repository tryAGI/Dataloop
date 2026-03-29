
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MatrixData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matrix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Matrix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixData" /> class.
        /// </summary>
        /// <param name="matrix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatrixData(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> matrix)
        {
            this.Matrix = matrix ?? throw new global::System.ArgumentNullException(nameof(matrix));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixData" /> class.
        /// </summary>
        public MatrixData()
        {
        }
    }
}