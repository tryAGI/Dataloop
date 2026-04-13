
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DriverTolerationConditions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("and")]
        public global::System.Collections.Generic.IList<global::Dataloop.DriverCondition>? And { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("or")]
        public global::System.Collections.Generic.IList<global::Dataloop.DriverCondition>? Or { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DriverTolerationConditions" /> class.
        /// </summary>
        /// <param name="and"></param>
        /// <param name="or"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DriverTolerationConditions(
            global::System.Collections.Generic.IList<global::Dataloop.DriverCondition>? and,
            global::System.Collections.Generic.IList<global::Dataloop.DriverCondition>? or)
        {
            this.And = and;
            this.Or = or;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriverTolerationConditions" /> class.
        /// </summary>
        public DriverTolerationConditions()
        {
        }
    }
}