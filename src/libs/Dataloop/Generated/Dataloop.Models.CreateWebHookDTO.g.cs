
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebHookDTO
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
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpMethod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.CreateWebHookDTOHttpMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.CreateWebHookDTOHttpMethod HttpMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hookUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebHookDTO" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="project"></param>
        /// <param name="httpMethod"></param>
        /// <param name="hookUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebHookDTO(
            string name,
            string project,
            global::Dataloop.CreateWebHookDTOHttpMethod httpMethod,
            string hookUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.HttpMethod = httpMethod;
            this.HookUrl = hookUrl ?? throw new global::System.ArgumentNullException(nameof(hookUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebHookDTO" /> class.
        /// </summary>
        public CreateWebHookDTO()
        {
        }
    }
}