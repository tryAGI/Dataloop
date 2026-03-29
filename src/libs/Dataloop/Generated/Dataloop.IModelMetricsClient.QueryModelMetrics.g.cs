#nullable enable

namespace Dataloop
{
    public partial interface IModelMetricsClient
    {
        /// <summary>
        /// Query Model Metrics<br/>
        /// Supply the query requested to query Metrics
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPISetting> QueryModelMetricsAsync(

            global::Dataloop.QueryModel request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Model Metrics<br/>
        /// Supply the query requested to query Metrics
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="filter"></param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPISetting> QueryModelMetricsAsync(
            global::Dataloop.QueryResource? resource = default,
            object? filter = default,
            object? sort = default,
            double? page = default,
            double? pageSize = default,
            global::Dataloop.ModelOperationTypes? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}