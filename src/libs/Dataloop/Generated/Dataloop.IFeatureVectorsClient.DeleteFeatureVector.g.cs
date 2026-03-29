#nullable enable

namespace Dataloop
{
    public partial interface IFeatureVectorsClient
    {
        /// <summary>
        /// Delete a feature vector by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Delete feature vector<br/>
        /// # <br/>
        /// # :param str feature_id: feature id to delete<br/>
        /// # :return: success<br/>
        /// # :rtype: bool<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task DeleteFeatureVectorAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}