
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickAPIDpkDependencies
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkDependency>? Dependencies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickAPIDpkDependencies" /> class.
        /// </summary>
        /// <param name="dependencies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickAPIDpkDependencies(
            global::System.Collections.Generic.IList<global::Dataloop.IDpkDependency>? dependencies)
        {
            this.Dependencies = dependencies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickAPIDpkDependencies" /> class.
        /// </summary>
        public PickAPIDpkDependencies()
        {
        }
    }
}