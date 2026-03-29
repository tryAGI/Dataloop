
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetDeletionInformation
    {
        /// <summary>
        /// User that initiated the mark for deletion request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markedForDeletionBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MarkedForDeletionBy { get; set; }

        /// <summary>
        /// Date that the dataset was marked for deletion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markedForDeletionDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime MarkedForDeletionDate { get; set; }

        /// <summary>
        /// Date that the dataset will actually be deleted on<br/>
        /// Defaults to `30 days` from the issuance of delete command if value is not provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetDeleteDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime TargetDeleteDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetDeletionInformation" /> class.
        /// </summary>
        /// <param name="markedForDeletionBy">
        /// User that initiated the mark for deletion request
        /// </param>
        /// <param name="markedForDeletionDate">
        /// Date that the dataset was marked for deletion
        /// </param>
        /// <param name="targetDeleteDate">
        /// Date that the dataset will actually be deleted on<br/>
        /// Defaults to `30 days` from the issuance of delete command if value is not provided
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetDeletionInformation(
            string markedForDeletionBy,
            global::System.DateTime markedForDeletionDate,
            global::System.DateTime targetDeleteDate)
        {
            this.MarkedForDeletionBy = markedForDeletionBy ?? throw new global::System.ArgumentNullException(nameof(markedForDeletionBy));
            this.MarkedForDeletionDate = markedForDeletionDate;
            this.TargetDeleteDate = targetDeleteDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetDeletionInformation" /> class.
        /// </summary>
        public DatasetDeletionInformation()
        {
        }
    }
}