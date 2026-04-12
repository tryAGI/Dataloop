#nullable enable

namespace Dataloop
{
    public partial interface IDataloopClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # List service executions<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a service.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.filters.Filters filters: dl.Filters entity to filters items<br/>
        /// # :return: Paged entity<br/>
        /// # :rtype: dtlpy.entities.paged_entities.PagedEntities<br/>
        /// # <br/>
        /// # <br/>
        /// # service.executions.list()<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task CreateQueryFaasAsync(
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}