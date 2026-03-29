#nullable enable

namespace Dataloop
{
    public partial interface IWebHooksClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIWebHook> CreateWebHookAsync(

            global::Dataloop.CreateWebHookDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="project"></param>
        /// <param name="httpMethod"></param>
        /// <param name="hookUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIWebHook> CreateWebHookAsync(
            string name,
            string project,
            global::Dataloop.CreateWebHookDTOHttpMethod httpMethod,
            string hookUrl,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}