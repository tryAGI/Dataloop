
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrationSpecVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report")]
        public bool? Report { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fix")]
        public bool? Fix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationSpecVariant2" /> class.
        /// </summary>
        /// <param name="report"></param>
        /// <param name="fix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MigrationSpecVariant2(
            bool? report,
            bool? fix)
        {
            this.Report = report;
            this.Fix = fix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationSpecVariant2" /> class.
        /// </summary>
        public MigrationSpecVariant2()
        {
        }
    }
}