#nullable enable

namespace Dataloop
{
    public partial interface IFeatureVectorsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.AggregateProjectVectorsCountResultItem>> AggregateFeatureVectorsInProjectByFeaturSetsAndDatasetsAsync(

            global::Dataloop.AggregateProjectVectorsCountInput request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="datasetIds"></param>
        /// <param name="vectorsQuery"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.AggregateProjectVectorsCountResultItem>> AggregateFeatureVectorsInProjectByFeaturSetsAndDatasetsAsync(
            string projectId,
            global::System.Collections.Generic.IList<string>? datasetIds = default,
            global::Dataloop.DQLResourceQuery? vectorsQuery = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}