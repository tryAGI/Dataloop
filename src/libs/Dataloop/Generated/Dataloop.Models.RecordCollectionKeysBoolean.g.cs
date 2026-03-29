
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Construct a type with a set of properties K of type T
    /// </summary>
    public sealed partial class RecordCollectionKeysBoolean
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c0")]
        public bool? C0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c1")]
        public bool? C1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c2")]
        public bool? C2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c3")]
        public bool? C3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c4")]
        public bool? C4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c5")]
        public bool? C5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c6")]
        public bool? C6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c7")]
        public bool? C7 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c8")]
        public bool? C8 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c9")]
        public bool? C9 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordCollectionKeysBoolean" /> class.
        /// </summary>
        /// <param name="c0"></param>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <param name="c3"></param>
        /// <param name="c4"></param>
        /// <param name="c5"></param>
        /// <param name="c6"></param>
        /// <param name="c7"></param>
        /// <param name="c8"></param>
        /// <param name="c9"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordCollectionKeysBoolean(
            bool? c0,
            bool? c1,
            bool? c2,
            bool? c3,
            bool? c4,
            bool? c5,
            bool? c6,
            bool? c7,
            bool? c8,
            bool? c9)
        {
            this.C0 = c0;
            this.C1 = c1;
            this.C2 = c2;
            this.C3 = c3;
            this.C4 = c4;
            this.C5 = c5;
            this.C6 = c6;
            this.C7 = c7;
            this.C8 = c8;
            this.C9 = c9;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordCollectionKeysBoolean" /> class.
        /// </summary>
        public RecordCollectionKeysBoolean()
        {
        }
    }
}