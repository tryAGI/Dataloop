#nullable enable

namespace Dataloop
{
    public partial interface IWebHooksClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIWebHook> UpdateWebHookAsync(
            string id,

            global::Dataloop.UpdateWebHookDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="project"></param>
        /// <param name="httpMethod"></param>
        /// <param name="hookUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIWebHook> UpdateWebHookAsync(
            string id,
            string? name = default,
            string? project = default,
            global::Dataloop.UpdateWebHookDTOHttpMethod? httpMethod = default,
            string? hookUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}