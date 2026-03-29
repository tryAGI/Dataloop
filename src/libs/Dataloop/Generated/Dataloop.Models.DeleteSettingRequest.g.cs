
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteSettingRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSettingRequest" /> class.
        /// </summary>
        /// <param name="force"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteSettingRequest(
            bool? force)
        {
            this.Force = force;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSettingRequest" /> class.
        /// </summary>
        public DeleteSettingRequest()
        {
        }
    }
}