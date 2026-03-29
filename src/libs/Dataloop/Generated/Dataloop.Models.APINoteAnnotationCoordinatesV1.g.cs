
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APINoteAnnotationCoordinatesV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("box")]
        public global::System.Collections.Generic.IList<object>? Box { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CoordinatesNote Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APINoteAnnotationCoordinatesV1" /> class.
        /// </summary>
        /// <param name="note"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="box"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APINoteAnnotationCoordinatesV1(
            global::Dataloop.CoordinatesNote note,
            global::System.DateTime updatedAt,
            string updatedBy,
            global::System.Collections.Generic.IList<object>? box)
        {
            this.Box = box;
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy ?? throw new global::System.ArgumentNullException(nameof(updatedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APINoteAnnotationCoordinatesV1" /> class.
        /// </summary>
        public APINoteAnnotationCoordinatesV1()
        {
        }
    }
}