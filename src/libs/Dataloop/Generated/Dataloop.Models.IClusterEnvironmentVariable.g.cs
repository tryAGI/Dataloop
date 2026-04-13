
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IClusterEnvironmentVariable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueFrom")]
        public global::Dataloop.IClusterEnvironmentVariableValueFrom? ValueFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterEnvironmentVariable" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="valueFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IClusterEnvironmentVariable(
            string name,
            string? value,
            global::Dataloop.IClusterEnvironmentVariableValueFrom? valueFrom)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
            this.ValueFrom = valueFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterEnvironmentVariable" /> class.
        /// </summary>
        public IClusterEnvironmentVariable()
        {
        }
    }
}