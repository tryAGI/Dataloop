#nullable enable

namespace Dataloop
{
    public partial interface IFeatureSetsClient
    {
        /// <summary>
        /// Get a feature set by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get Feature Set object<br/>
        /// # <br/>
        /// # :param str feature_set_name: name of the feature set<br/>
        /// # :param str feature_set_id: id of the feature set<br/>
        /// # :return: Feature object<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIFeatureSet> GetFeatureSetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}