
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IClusterEnvironmentVariableValueFromFieldRef
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterEnvironmentVariableValueFromFieldRef" /> class.
        /// </summary>
        /// <param name="fieldPath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IClusterEnvironmentVariableValueFromFieldRef(
            string fieldPath)
        {
            this.FieldPath = fieldPath ?? throw new global::System.ArgumentNullException(nameof(fieldPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterEnvironmentVariableValueFromFieldRef" /> class.
        /// </summary>
        public IClusterEnvironmentVariableValueFromFieldRef()
        {
        }
    }
}