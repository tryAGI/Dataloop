
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoscalersDriverZombies
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscalersName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AutoscalersName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ServiceDriver Driver { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoscalersDriverZombies" /> class.
        /// </summary>
        /// <param name="autoscalersName"></param>
        /// <param name="namespace"></param>
        /// <param name="driver"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoscalersDriverZombies(
            global::System.Collections.Generic.IList<string> autoscalersName,
            string @namespace,
            global::Dataloop.ServiceDriver driver)
        {
            this.AutoscalersName = autoscalersName ?? throw new global::System.ArgumentNullException(nameof(autoscalersName));
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Driver = driver ?? throw new global::System.ArgumentNullException(nameof(driver));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoscalersDriverZombies" /> class.
        /// </summary>
        public AutoscalersDriverZombies()
        {
        }
    }
}