
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.CustomActionTarget> Targets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CustomActionControlsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CustomActionControls Controls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAction" /> class.
        /// </summary>
        /// <param name="targets"></param>
        /// <param name="controls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomAction(
            global::System.Collections.Generic.IList<global::Dataloop.CustomActionTarget> targets,
            global::Dataloop.CustomActionControls controls)
        {
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
            this.Controls = controls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAction" /> class.
        /// </summary>
        public CustomAction()
        {
        }
    }
}