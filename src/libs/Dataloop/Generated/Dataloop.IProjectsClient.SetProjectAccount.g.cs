#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Add an account to a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIProject> SetProjectAccountAsync(
            string projectId,

            global::Dataloop.SetProjectAccountRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add an account to a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="account"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIProject> SetProjectAccountAsync(
            string projectId,
            string account,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}