
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWebHookDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpMethod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.UpdateWebHookDTOHttpMethodJsonConverter))]
        public global::Dataloop.UpdateWebHookDTOHttpMethod? HttpMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hookUrl")]
        public string? HookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebHookDTO" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="project"></param>
        /// <param name="httpMethod"></param>
        /// <param name="hookUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWebHookDTO(
            string? name,
            string? project,
            global::Dataloop.UpdateWebHookDTOHttpMethod? httpMethod,
            string? hookUrl)
        {
            this.Name = name;
            this.Project = project;
            this.HttpMethod = httpMethod;
            this.HookUrl = hookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebHookDTO" /> class.
        /// </summary>
        public UpdateWebHookDTO()
        {
        }
    }
}