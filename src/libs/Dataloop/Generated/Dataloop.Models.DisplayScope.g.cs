
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DisplayScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.UiBindingResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.UiBindingResource Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.UiBindingPanelJsonConverter))]
        public global::Dataloop.UiBindingPanel? Panel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayScope" /> class.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="filter"></param>
        /// <param name="panel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DisplayScope(
            global::Dataloop.UiBindingResource resource,
            global::Dataloop.Dictionary filter,
            global::Dataloop.UiBindingPanel? panel)
        {
            this.Resource = resource;
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Panel = panel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayScope" /> class.
        /// </summary>
        public DisplayScope()
        {
        }
    }
}