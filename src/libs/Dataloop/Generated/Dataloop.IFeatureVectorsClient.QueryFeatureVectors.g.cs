#nullable enable

namespace Dataloop
{
    public partial interface IFeatureVectorsClient
    {
        /// <summary>
        /// Query feature vectors via common DQL filter, sort, limit etc.<br/>
        /// Querying supports joins on items and annotations, sorting only available by "eu_dist" field.<br/>
        /// The route also could calculate euclid distance using $euclid operator, for details see examples.<br/>
        /// Lowest role to successfully query Feature vector is Annotation manager, all below will got thrown 403.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIFeatureVector> QueryFeatureVectorsAsync(

            global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery> request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query feature vectors via common DQL filter, sort, limit etc.<br/>
        /// Querying supports joins on items and annotations, sorting only available by "eu_dist" field.<br/>
        /// The route also could calculate euclid distance using $euclid operator, for details see examples.<br/>
        /// Lowest role to successfully query Feature vector is Annotation manager, all below will got thrown 403.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIFeatureVector> QueryFeatureVectorsAsync(
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}