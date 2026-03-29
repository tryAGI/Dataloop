
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// A dictionary is a simple object that can be used to store key-value pairs.
    /// </summary>
    public sealed partial class JssdkDictionary
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}