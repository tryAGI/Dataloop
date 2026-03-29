
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JoinQueryOn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forigen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Forigen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("local")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Local { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.QueryResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.QueryResource Resource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinQueryOn" /> class.
        /// </summary>
        /// <param name="forigen"></param>
        /// <param name="local"></param>
        /// <param name="resource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JoinQueryOn(
            string forigen,
            string local,
            global::Dataloop.QueryResource resource)
        {
            this.Forigen = forigen ?? throw new global::System.ArgumentNullException(nameof(forigen));
            this.Local = local ?? throw new global::System.ArgumentNullException(nameof(local));
            this.Resource = resource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinQueryOn" /> class.
        /// </summary>
        public JoinQueryOn()
        {
        }
    }
}