
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChildrenCommandsProgress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Failed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aborted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Aborted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Dataloop.CommandError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildrenCommandsProgress" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="failed"></param>
        /// <param name="aborted"></param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChildrenCommandsProgress(
            double success,
            double failed,
            double aborted,
            global::System.Collections.Generic.IList<global::Dataloop.CommandError>? errors)
        {
            this.Success = success;
            this.Failed = failed;
            this.Aborted = aborted;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildrenCommandsProgress" /> class.
        /// </summary>
        public ChildrenCommandsProgress()
        {
        }
    }
}