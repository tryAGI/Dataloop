
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialMsNumberbytes3Anumber
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ms")]
        public double? Ms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public double? Bytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialMsNumberbytes3Anumber" /> class.
        /// </summary>
        /// <param name="ms"></param>
        /// <param name="bytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialMsNumberbytes3Anumber(
            double? ms,
            double? bytes)
        {
            this.Ms = ms;
            this.Bytes = bytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialMsNumberbytes3Anumber" /> class.
        /// </summary>
        public PartialMsNumberbytes3Anumber()
        {
        }
    }
}