
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBotPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnCredentials")]
        public bool? ReturnCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBotPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="returnCredentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBotPayload(
            string? name,
            bool? returnCredentials)
        {
            this.Name = name;
            this.ReturnCredentials = returnCredentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBotPayload" /> class.
        /// </summary>
        public CreateBotPayload()
        {
        }
    }
}