
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Type for composing EditItem object
    /// </summary>
    public sealed partial class EditItemsStressInput
    {
        /// <summary>
        /// name of the dataset to be used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// projectId to be used for testing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// number of items each client will edit<br/>
        /// Default Value: 1000, in composeStressTestEditItems()
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsPerClient")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ItemsPerClient { get; set; }

        /// <summary>
        /// number of concurrent clients<br/>
        /// Default Value: 1, in in composeStressTestEditItems()
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Clients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditItemsStressInput" /> class.
        /// </summary>
        /// <param name="datasetName">
        /// name of the dataset to be used
        /// </param>
        /// <param name="projectId">
        /// projectId to be used for testing
        /// </param>
        /// <param name="itemsPerClient">
        /// number of items each client will edit<br/>
        /// Default Value: 1000, in composeStressTestEditItems()
        /// </param>
        /// <param name="clients">
        /// number of concurrent clients<br/>
        /// Default Value: 1, in in composeStressTestEditItems()
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditItemsStressInput(
            string datasetName,
            string projectId,
            double itemsPerClient,
            double clients)
        {
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ItemsPerClient = itemsPerClient;
            this.Clients = clients;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditItemsStressInput" /> class.
        /// </summary>
        public EditItemsStressInput()
        {
        }
    }
}