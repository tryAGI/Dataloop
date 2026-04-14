
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IComputeContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputeContext" /> class.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IComputeContext(
            string org,
            string? project)
        {
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IComputeContext" /> class.
        /// </summary>
        public IComputeContext()
        {
        }
    }
}