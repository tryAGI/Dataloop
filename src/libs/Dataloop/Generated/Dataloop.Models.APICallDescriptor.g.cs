
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APICallDescriptor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APICallSourceDescriptor Ui { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APICallSourceDescriptor Sdk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APICallSourceDescriptor System { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.APICallSourceDescriptor Other { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Sum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APICallDescriptor" /> class.
        /// </summary>
        /// <param name="ui"></param>
        /// <param name="sdk"></param>
        /// <param name="system"></param>
        /// <param name="other"></param>
        /// <param name="sum"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APICallDescriptor(
            global::Dataloop.APICallSourceDescriptor ui,
            global::Dataloop.APICallSourceDescriptor sdk,
            global::Dataloop.APICallSourceDescriptor system,
            global::Dataloop.APICallSourceDescriptor other,
            double sum)
        {
            this.Ui = ui ?? throw new global::System.ArgumentNullException(nameof(ui));
            this.Sdk = sdk ?? throw new global::System.ArgumentNullException(nameof(sdk));
            this.System = system ?? throw new global::System.ArgumentNullException(nameof(system));
            this.Other = other ?? throw new global::System.ArgumentNullException(nameof(other));
            this.Sum = sum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APICallDescriptor" /> class.
        /// </summary>
        public APICallDescriptor()
        {
        }
    }
}