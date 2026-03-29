
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResolverPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userCtx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IUserContext UserCtx { get; set; }

        /// <summary>
        /// Specific flags to resolve
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? Flags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolverPayload" /> class.
        /// </summary>
        /// <param name="userCtx"></param>
        /// <param name="flags">
        /// Specific flags to resolve
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResolverPayload(
            global::Dataloop.IUserContext userCtx,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? flags)
        {
            this.UserCtx = userCtx ?? throw new global::System.ArgumentNullException(nameof(userCtx));
            this.Flags = flags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolverPayload" /> class.
        /// </summary>
        public ResolverPayload()
        {
        }
    }
}