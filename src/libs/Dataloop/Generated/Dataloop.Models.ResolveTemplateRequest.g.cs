
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResolveTemplateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend")]
        public bool? Extend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public global::Dataloop.IPipeline? Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateId")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolveTemplateRequest" /> class.
        /// </summary>
        /// <param name="extend"></param>
        /// <param name="template"></param>
        /// <param name="templateId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResolveTemplateRequest(
            bool? extend,
            global::Dataloop.IPipeline? template,
            string? templateId)
        {
            this.Extend = extend;
            this.Template = template;
            this.TemplateId = templateId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolveTemplateRequest" /> class.
        /// </summary>
        public ResolveTemplateRequest()
        {
        }
    }
}