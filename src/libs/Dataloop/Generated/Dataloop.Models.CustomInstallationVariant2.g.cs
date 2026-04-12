
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomInstallationVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codebase")]
        public global::Dataloop.Codebase? Codebase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("components")]
        public global::Dataloop.DpkComponents? Components { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomInstallationVariant2" /> class.
        /// </summary>
        /// <param name="codebase"></param>
        /// <param name="components"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomInstallationVariant2(
            global::Dataloop.Codebase? codebase,
            global::Dataloop.DpkComponents? components)
        {
            this.Codebase = codebase;
            this.Components = components;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomInstallationVariant2" /> class.
        /// </summary>
        public CustomInstallationVariant2()
        {
        }
    }
}