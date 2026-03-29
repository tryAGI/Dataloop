
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Construct a type with a set of properties K of type T
    /// </summary>
    public sealed partial class RecordMLSplitListKeysNumber
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train")]
        public double? Train { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test")]
        public double? Test { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation")]
        public double? Validation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordMLSplitListKeysNumber" /> class.
        /// </summary>
        /// <param name="train"></param>
        /// <param name="test"></param>
        /// <param name="validation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordMLSplitListKeysNumber(
            double? train,
            double? test,
            double? validation)
        {
            this.Train = train;
            this.Test = test;
            this.Validation = validation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordMLSplitListKeysNumber" /> class.
        /// </summary>
        public RecordMLSplitListKeysNumber()
        {
        }
    }
}