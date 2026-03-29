
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLabelPayloadTreeV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CreateLabelPayloadV1 Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayloadTreeV1> Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLabelPayloadTreeV1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="children"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLabelPayloadTreeV1(
            global::Dataloop.CreateLabelPayloadV1 value,
            global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayloadTreeV1> children)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLabelPayloadTreeV1" /> class.
        /// </summary>
        public CreateLabelPayloadTreeV1()
        {
        }
    }
}