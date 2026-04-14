
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceVersions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public string? App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtlpy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dtlpy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceVersions" /> class.
        /// </summary>
        /// <param name="dtlpy"></param>
        /// <param name="app"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceVersions(
            string dtlpy,
            string? app)
        {
            this.App = app;
            this.Dtlpy = dtlpy ?? throw new global::System.ArgumentNullException(nameof(dtlpy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceVersions" /> class.
        /// </summary>
        public ServiceVersions()
        {
        }
    }
}