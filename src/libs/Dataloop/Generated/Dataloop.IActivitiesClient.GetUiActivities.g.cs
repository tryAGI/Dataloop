#nullable enable

namespace Dataloop
{
    public partial interface IActivitiesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::Dataloop.ActivitiesDescriptor2>> GetUiActivitiesAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}