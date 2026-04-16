#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesTemplatesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APITemplateQuery> QueryAsync(

            global::Dataloop.TemplateQuery request,
            string? projectId = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="global"></param>
        /// <param name="org"></param>
        /// <param name="project"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APITemplateQuery> QueryAsync(
            global::Dataloop.QueryStringTemplate global,
            global::Dataloop.QueryStringTemplate org,
            global::Dataloop.QueryStringTemplate project,
            string? projectId = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}