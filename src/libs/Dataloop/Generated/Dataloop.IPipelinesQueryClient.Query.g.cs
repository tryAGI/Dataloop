#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesQueryClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// pipeline_executions = pipeline.pipeline_executions.list()<br/>
        /// # <br/>
        /// # List project pipeline executions.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.filters.Filters filters: Filters entity or a dictionary containing filters parameters<br/>
        /// # :return: Paged entity<br/>
        /// # :rtype: dtlpy.entities.paged_entities.PagedEntities<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageT> QueryAsync(

            global::Dataloop.QueryString request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="sort"></param>
        /// <param name="filter"></param>
        /// <param name="resource"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageT> QueryAsync(
            double pageSize,
            double page,
            object sort,
            object filter,
            global::Dataloop.QueryResource resource,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}