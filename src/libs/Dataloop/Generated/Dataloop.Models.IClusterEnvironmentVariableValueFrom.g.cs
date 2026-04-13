
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IClusterEnvironmentVariableValueFrom
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configMapKeyRef")]
        public global::Dataloop.IClusterEnvironmentVariableValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretKeyRef")]
        public global::Dataloop.IClusterEnvironmentVariableValueFromSecretKeyRef? SecretKeyRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldRef")]
        public global::Dataloop.IClusterEnvironmentVariableValueFromFieldRef? FieldRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterEnvironmentVariableValueFrom" /> class.
        /// </summary>
        /// <param name="configMapKeyRef"></param>
        /// <param name="secretKeyRef"></param>
        /// <param name="fieldRef"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IClusterEnvironmentVariableValueFrom(
            global::Dataloop.IClusterEnvironmentVariableValueFromConfigMapKeyRef? configMapKeyRef,
            global::Dataloop.IClusterEnvironmentVariableValueFromSecretKeyRef? secretKeyRef,
            global::Dataloop.IClusterEnvironmentVariableValueFromFieldRef? fieldRef)
        {
            this.ConfigMapKeyRef = configMapKeyRef;
            this.SecretKeyRef = secretKeyRef;
            this.FieldRef = fieldRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IClusterEnvironmentVariableValueFrom" /> class.
        /// </summary>
        public IClusterEnvironmentVariableValueFrom()
        {
        }
    }
}