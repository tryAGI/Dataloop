#nullable enable

namespace Dataloop
{
    public partial interface IFeatureSetsClient
    {
        /// <summary>
        /// Delete a feature set by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Delete feature vector<br/>
        /// # <br/>
        /// # :param str feature_set_id: feature set id to delete<br/>
        /// # :return: success<br/>
        /// # :rtype: bool<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<string> DeleteFeatureSetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}