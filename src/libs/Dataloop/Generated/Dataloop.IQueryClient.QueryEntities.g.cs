#nullable enable

namespace Dataloop
{
    public partial interface IQueryClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
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
        global::System.Threading.Tasks.Task<string> QueryEntitiesAsync(

            global::Dataloop.QueryEntitiesRequest request,
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
        global::System.Threading.Tasks.Task<string> QueryEntitiesAsync(
            double pageSize,
            double page,
            object sort,
            object filter,
            string resource,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}