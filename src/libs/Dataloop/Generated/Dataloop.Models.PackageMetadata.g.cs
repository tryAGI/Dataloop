
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PackageMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Dataloop.Dictionary? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public global::Dataloop.Dictionary? System { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageMetadata" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="system"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PackageMetadata(
            global::Dataloop.Dictionary? user,
            global::Dataloop.Dictionary? system)
        {
            this.User = user;
            this.System = system;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageMetadata" /> class.
        /// </summary>
        public PackageMetadata()
        {
        }
    }
}