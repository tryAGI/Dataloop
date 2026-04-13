
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivitiesDescriptor2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Dataloop.ActivitiesDescriptorFunctions2> Functions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APIService Service { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesDescriptor2" /> class.
        /// </summary>
        /// <param name="functions"></param>
        /// <param name="service"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivitiesDescriptor2(
            global::System.Collections.Generic.Dictionary<string, global::Dataloop.ActivitiesDescriptorFunctions2> functions,
            global::Dataloop.APIService service)
        {
            this.Functions = functions ?? throw new global::System.ArgumentNullException(nameof(functions));
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesDescriptor2" /> class.
        /// </summary>
        public ActivitiesDescriptor2()
        {
        }
    }
}