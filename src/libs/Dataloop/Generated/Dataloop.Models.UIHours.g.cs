
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UIHours
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Sum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UIHours" /> class.
        /// </summary>
        /// <param name="sum"></param>
        /// <param name="roles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UIHours(
            double sum,
            global::System.Collections.Generic.Dictionary<string, double> roles)
        {
            this.Sum = sum;
            this.Roles = roles ?? throw new global::System.ArgumentNullException(nameof(roles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UIHours" /> class.
        /// </summary>
        public UIHours()
        {
        }
    }
}