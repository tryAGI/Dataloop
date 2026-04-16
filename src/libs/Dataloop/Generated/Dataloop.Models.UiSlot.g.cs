
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UiSlot
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moduleName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModuleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayScopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.DisplayScope> DisplayScopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postAction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ExecutionPostAction PostAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayIcon")]
        public string? DisplayIcon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultInputs")]
        public global::System.Collections.Generic.IList<global::Dataloop.DLFunctionDefaultInputSpec>? DefaultInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputOptions")]
        public global::System.Collections.Generic.IList<global::Dataloop.DLFunctionInputOptionsSpec>? InputOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UiSlot" /> class.
        /// </summary>
        /// <param name="moduleName"></param>
        /// <param name="functionName"></param>
        /// <param name="displayName"></param>
        /// <param name="displayScopes"></param>
        /// <param name="postAction"></param>
        /// <param name="displayIcon"></param>
        /// <param name="defaultInputs"></param>
        /// <param name="inputOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UiSlot(
            string moduleName,
            string functionName,
            string displayName,
            global::System.Collections.Generic.IList<global::Dataloop.DisplayScope> displayScopes,
            global::Dataloop.ExecutionPostAction postAction,
            string? displayIcon,
            global::System.Collections.Generic.IList<global::Dataloop.DLFunctionDefaultInputSpec>? defaultInputs,
            global::System.Collections.Generic.IList<global::Dataloop.DLFunctionInputOptionsSpec>? inputOptions)
        {
            this.ModuleName = moduleName ?? throw new global::System.ArgumentNullException(nameof(moduleName));
            this.FunctionName = functionName ?? throw new global::System.ArgumentNullException(nameof(functionName));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.DisplayScopes = displayScopes ?? throw new global::System.ArgumentNullException(nameof(displayScopes));
            this.PostAction = postAction ?? throw new global::System.ArgumentNullException(nameof(postAction));
            this.DisplayIcon = displayIcon;
            this.DefaultInputs = defaultInputs;
            this.InputOptions = inputOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UiSlot" /> class.
        /// </summary>
        public UiSlot()
        {
        }
    }
}