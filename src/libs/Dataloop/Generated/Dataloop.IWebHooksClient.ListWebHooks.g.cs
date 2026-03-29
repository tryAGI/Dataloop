#nullable enable

namespace Dataloop
{
    public partial interface IWebHooksClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.WebHooksPage> ListWebHooksAsync(
            double? pageOffset = default,
            double? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}