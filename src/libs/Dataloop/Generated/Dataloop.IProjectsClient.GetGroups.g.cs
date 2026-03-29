#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get all project's groups
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>> GetGroupsAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}