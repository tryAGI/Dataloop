
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UiHook
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bindTo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BindTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Slots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UiHook" /> class.
        /// </summary>
        /// <param name="bindTo"></param>
        /// <param name="config"></param>
        /// <param name="icon"></param>
        /// <param name="slots"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UiHook(
            string bindTo,
            object config,
            string icon,
            global::System.Collections.Generic.IList<string> slots)
        {
            this.BindTo = bindTo ?? throw new global::System.ArgumentNullException(nameof(bindTo));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Icon = icon ?? throw new global::System.ArgumentNullException(nameof(icon));
            this.Slots = slots ?? throw new global::System.ArgumentNullException(nameof(slots));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UiHook" /> class.
        /// </summary>
        public UiHook()
        {
        }
    }
}