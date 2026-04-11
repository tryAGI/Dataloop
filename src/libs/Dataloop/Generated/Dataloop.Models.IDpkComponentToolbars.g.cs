
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IDpkComponentToolbars
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mandatory")]
        public bool? Mandatory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::Dataloop.Dictionary? Conditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoke")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Dictionary Invoke { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentToolbars" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="invoke"></param>
        /// <param name="name"></param>
        /// <param name="mandatory"></param>
        /// <param name="conditions"></param>
        /// <param name="location"></param>
        /// <param name="icon"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IDpkComponentToolbars(
            string displayName,
            global::Dataloop.Dictionary invoke,
            string? name,
            bool? mandatory,
            global::Dataloop.Dictionary? conditions,
            string? location,
            string? icon)
        {
            this.Name = name;
            this.Mandatory = mandatory;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Conditions = conditions;
            this.Invoke = invoke ?? throw new global::System.ArgumentNullException(nameof(invoke));
            this.Location = location;
            this.Icon = icon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IDpkComponentToolbars" /> class.
        /// </summary>
        public IDpkComponentToolbars()
        {
        }
    }
}