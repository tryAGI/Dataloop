
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceDriver
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateRegistry")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.PrivateRegistry PrivateRegistry { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDriver" /> class.
        /// </summary>
        /// <param name="privateRegistry"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceDriver(
            global::Dataloop.PrivateRegistry privateRegistry)
        {
            this.PrivateRegistry = privateRegistry ?? throw new global::System.ArgumentNullException(nameof(privateRegistry));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDriver" /> class.
        /// </summary>
        public ServiceDriver()
        {
        }
    }
}