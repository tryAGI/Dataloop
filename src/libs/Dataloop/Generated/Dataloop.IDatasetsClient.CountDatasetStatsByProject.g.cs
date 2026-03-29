#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Endpoint for counting dataset stats by project ID<br/>
        /// Supports both mongo and S2 datasets
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> CountDatasetStatsByProjectAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}