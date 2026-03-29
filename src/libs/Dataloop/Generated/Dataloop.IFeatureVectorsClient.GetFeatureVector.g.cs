#nullable enable

namespace Dataloop
{
    public partial interface IFeatureVectorsClient
    {
        /// <summary>
        /// Get a feature vector by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get Feature object<br/>
        /// # <br/>
        /// # :param str feature_id: feature id<br/>
        /// # :return: Feature object<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIFeatureVector> GetFeatureVectorAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}