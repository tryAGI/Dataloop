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
        /// # List project pipeline executions.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.filters.Filters filters: Filters entity or a dictionary containing filters parameters<br/>
        /// # :return: Paged entity<br/>
        /// # :rtype: dtlpy.entities.paged_entities.PagedEntities<br/>
        /// # <br/>
        /// # <br/>
        /// # pipeline_executions = pipeline.pipeline_executions.list()<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task CreatePipelinesQueryAsync(
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}