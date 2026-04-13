
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DLFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::System.Collections.Generic.IList<global::Dataloop.PackageIO>? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::System.Collections.Generic.IList<global::Dataloop.PackageIO>? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayIcon")]
        public string? DisplayIcon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayScopes")]
        public global::System.Collections.Generic.IList<global::Dataloop.DisplayScope>? DisplayScopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postAction")]
        public global::Dataloop.ExecutionPostAction? PostAction { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computeConfig")]
        public string? ComputeConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DLFunction" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="description"></param>
        /// <param name="displayName"></param>
        /// <param name="displayIcon"></param>
        /// <param name="displayScopes"></param>
        /// <param name="postAction"></param>
        /// <param name="defaultInputs"></param>
        /// <param name="inputOptions"></param>
        /// <param name="computeConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DLFunction(
            string name,
            global::System.Collections.Generic.IList<global::Dataloop.PackageIO>? input,
            global::System.Collections.Generic.IList<global::Dataloop.PackageIO>? output,
            string? description,
            string? displayName,
            string? displayIcon,
            global::System.Collections.Generic.IList<global::Dataloop.DisplayScope>? displayScopes,
            global::Dataloop.ExecutionPostAction? postAction,
            global::System.Collections.Generic.IList<global::Dataloop.DLFunctionDefaultInputSpec>? defaultInputs,
            global::System.Collections.Generic.IList<global::Dataloop.DLFunctionInputOptionsSpec>? inputOptions,
            string? computeConfig)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input;
            this.Output = output;
            this.Description = description;
            this.DisplayName = displayName;
            this.DisplayIcon = displayIcon;
            this.DisplayScopes = displayScopes;
            this.PostAction = postAction;
            this.DefaultInputs = defaultInputs;
            this.InputOptions = inputOptions;
            this.ComputeConfig = computeConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DLFunction" /> class.
        /// </summary>
        public DLFunction()
        {
        }
    }
}