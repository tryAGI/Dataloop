
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextSearch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Functions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextSearch" /> class.
        /// </summary>
        /// <param name="functions"></param>
        /// <param name="projectName"></param>
        /// <param name="orgName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextSearch(
            string functions,
            string projectName,
            string orgName)
        {
            this.Functions = functions ?? throw new global::System.ArgumentNullException(nameof(functions));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.OrgName = orgName ?? throw new global::System.ArgumentNullException(nameof(orgName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextSearch" /> class.
        /// </summary>
        public TextSearch()
        {
        }
    }
}