#nullable enable

namespace Dataloop
{
    public partial interface ICompositionsClient
    {
        /// <summary>
        /// Install existing composition. setting all the entities
        /// </summary>
        /// <param name="compositionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIComposition> InstallAsync(
            string compositionId,

            global::Dataloop.InstallRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Install existing composition. setting all the entities
        /// </summary>
        /// <param name="compositionId"></param>
        /// <param name="resumeOption"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIComposition> InstallAsync(
            string compositionId,
            global::Dataloop.ResumePipelineOption? resumeOption = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}