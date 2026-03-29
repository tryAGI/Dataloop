#nullable enable

namespace Dataloop
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Query the user's projects by name
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIProject>> GetProjectByNameAsync(
            string projectName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}