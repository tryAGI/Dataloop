
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Represents an ssh key file Authentication mechanism
    /// </summary>
    public sealed partial class KeyFileAuthentication
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filepath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filepath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyFileAuthentication" /> class.
        /// </summary>
        /// <param name="filepath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyFileAuthentication(
            string filepath)
        {
            this.Filepath = filepath ?? throw new global::System.ArgumentNullException(nameof(filepath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyFileAuthentication" /> class.
        /// </summary>
        public KeyFileAuthentication()
        {
        }
    }
}