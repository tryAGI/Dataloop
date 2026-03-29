#nullable enable

namespace Dataloop
{
    public partial interface IFeatureSetsClient
    {
        /// <summary>
        /// List feature sets
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # List Feature Sets<br/>
        /// # <br/>
        /// # :param dtlpy.entities.filters.Filters filters: Filters entity or a dictionary containing filters parameters<br/>
        /// # :return: Paged entity<br/>
        /// # :rtype: dtlpy.entities.paged_entities.PagedEntities<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIFeatureSet> ListFeatureSetsAsync(

            global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List feature sets
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIFeatureSet> ListFeatureSetsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}