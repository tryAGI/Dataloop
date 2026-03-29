
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCountersForProjectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors")]
        public global::System.Collections.Generic.IList<string>? Contributors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCountersForProjectRequest" /> class.
        /// </summary>
        /// <param name="contributors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCountersForProjectRequest(
            global::System.Collections.Generic.IList<string>? contributors)
        {
            this.Contributors = contributors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCountersForProjectRequest" /> class.
        /// </summary>
        public GetCountersForProjectRequest()
        {
        }
    }
}