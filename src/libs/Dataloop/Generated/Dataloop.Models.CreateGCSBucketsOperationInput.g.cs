
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGCSBucketsOperationInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waitToCompletion")]
        public global::Dataloop.Boolean? WaitToCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketCreationWaitTimeS")]
        public double? BucketCreationWaitTimeS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGCSBucketsOperationInput" /> class.
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="waitToCompletion"></param>
        /// <param name="bucketCreationWaitTimeS"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGCSBucketsOperationInput(
            global::System.Collections.Generic.IList<string> projects,
            global::Dataloop.Boolean? waitToCompletion,
            double? bucketCreationWaitTimeS)
        {
            this.WaitToCompletion = waitToCompletion;
            this.BucketCreationWaitTimeS = bucketCreationWaitTimeS;
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGCSBucketsOperationInput" /> class.
        /// </summary>
        public CreateGCSBucketsOperationInput()
        {
        }
    }
}