#nullable enable

namespace Dataloop
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="org"></param>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPISubscription> ListSubscriptionsAsync(
            string? account = default,
            string? org = default,
            double? pageOffset = default,
            double? pageSize = default,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}