
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivitiesDescriptorFunctions2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slot")]
        public global::Dataloop.UiSlot? Slot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.APIExecution> Executions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("func")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.DLFunction Func { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesDescriptorFunctions2" /> class.
        /// </summary>
        /// <param name="executions"></param>
        /// <param name="func"></param>
        /// <param name="slot"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivitiesDescriptorFunctions2(
            global::System.Collections.Generic.IList<global::Dataloop.APIExecution> executions,
            global::Dataloop.DLFunction func,
            global::Dataloop.UiSlot? slot)
        {
            this.Slot = slot;
            this.Executions = executions ?? throw new global::System.ArgumentNullException(nameof(executions));
            this.Func = func ?? throw new global::System.ArgumentNullException(nameof(func));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesDescriptorFunctions2" /> class.
        /// </summary>
        public ActivitiesDescriptorFunctions2()
        {
        }
    }
}