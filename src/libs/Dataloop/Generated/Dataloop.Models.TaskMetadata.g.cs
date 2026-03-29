
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>))]
        public global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>? System { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskMetadata" /> class.
        /// </summary>
        /// <param name="system"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskMetadata(
            global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>? system)
        {
            this.System = system;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskMetadata" /> class.
        /// </summary>
        public TaskMetadata()
        {
        }
    }
}