#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update dataset properties
        /// </summary>
        /// <param name="id"></param>
        /// <param name="system"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update dataset field.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.dataset.Dataset dataset: dataset object<br/>
        /// # :param bool system_metadata: True, if you want to change metadata system<br/>
        /// # :param dict patch: Specific patch request<br/>
        /// # :return: Dataset object<br/>
        /// # :rtype: dtlpy.entities.dataset.Dataset<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset = project.datasets.update(dataset='dataset_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDataset> PatchDatasetAsync(
            string id,

            global::Dataloop.PartialAPIDatasetPayload request,
            bool? system = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update dataset properties
        /// </summary>
        /// <param name="id"></param>
        /// <param name="system"></param>
        /// <param name="requestId"></param>
        /// <param name="name"></param>
        /// <param name="creator"></param>
        /// <param name="projects"></param>
        /// <param name="driver"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDataset> PatchDatasetAsync(
            string id,
            bool? system = default,
            string? requestId = default,
            string? name = default,
            string? creator = default,
            global::System.Collections.Generic.IList<string>? projects = default,
            string? driver = default,
            global::Dataloop.APIMetadata? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}