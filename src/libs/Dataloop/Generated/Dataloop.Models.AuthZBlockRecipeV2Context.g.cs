
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthZBlockRecipeV2Context
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.RecipeV2Context>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeV2Context> Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        public global::System.Collections.Generic.IList<object>? Access { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthZBlockRecipeV2Context" /> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="scope"></param>
        /// <param name="access"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthZBlockRecipeV2Context(
            global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeV2Context> context,
            string? scope,
            global::System.Collections.Generic.IList<object>? access)
        {
            this.Scope = scope;
            this.Context = context;
            this.Access = access;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthZBlockRecipeV2Context" /> class.
        /// </summary>
        public AuthZBlockRecipeV2Context()
        {
        }
    }
}