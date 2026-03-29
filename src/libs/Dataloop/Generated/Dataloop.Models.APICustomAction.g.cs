
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APICustomAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.APICustomActionTarget> Targets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.APICustomActionControlsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APICustomActionControls Controls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APICustomAction" /> class.
        /// </summary>
        /// <param name="targets"></param>
        /// <param name="controls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APICustomAction(
            global::System.Collections.Generic.IList<global::Dataloop.APICustomActionTarget> targets,
            global::Dataloop.APICustomActionControls controls)
        {
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
            this.Controls = controls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APICustomAction" /> class.
        /// </summary>
        public APICustomAction()
        {
        }
    }
}