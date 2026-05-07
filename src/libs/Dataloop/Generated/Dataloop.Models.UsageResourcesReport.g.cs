
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageResourcesReport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.BillingResourceKey> Resources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResourcesReport" /> class.
        /// </summary>
        /// <param name="planName"></param>
        /// <param name="planKey"></param>
        /// <param name="resources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageResourcesReport(
            string planName,
            string planKey,
            global::System.Collections.Generic.IList<global::Dataloop.BillingResourceKey> resources)
        {
            this.PlanName = planName ?? throw new global::System.ArgumentNullException(nameof(planName));
            this.PlanKey = planKey ?? throw new global::System.ArgumentNullException(nameof(planKey));
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResourcesReport" /> class.
        /// </summary>
        public UsageResourcesReport()
        {
        }
    }
}