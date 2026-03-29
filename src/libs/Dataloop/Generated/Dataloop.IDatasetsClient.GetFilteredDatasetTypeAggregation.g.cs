#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> GetFilteredDatasetTypeAggregationAsync(
            string id,

            global::Dataloop.GetFilteredDatasetTypeAggregationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="assignmentId"></param>
        /// <param name="taskId"></param>
        /// <param name="creators"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> GetFilteredDatasetTypeAggregationAsync(
            string id,
            string? assignmentId = default,
            string? taskId = default,
            global::System.Collections.Generic.IList<string>? creators = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}