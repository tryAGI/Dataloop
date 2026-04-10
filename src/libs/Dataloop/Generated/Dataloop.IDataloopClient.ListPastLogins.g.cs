#nullable enable

namespace Dataloop
{
    public partial interface IDataloopClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPILogin> ListPastLoginsAsync(

            global::Dataloop.LoginsLogQuery request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="groupId"></param>
        /// <param name="orgRole"></param>
        /// <param name="userId"></param>
        /// <param name="toDate"></param>
        /// <param name="fromDate"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPILogin> ListPastLoginsAsync(
            string orgId,
            global::Dataloop.LoginsLogQueryOrder? order = default,
            global::Dataloop.LoginsLogQueryOrderBy? orderBy = default,
            double? page = default,
            double? pageSize = default,
            string? groupId = default,
            global::Dataloop.OrgRole? orgRole = default,
            string? userId = default,
            global::System.DateTime? toDate = default,
            global::System.DateTime? fromDate = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}