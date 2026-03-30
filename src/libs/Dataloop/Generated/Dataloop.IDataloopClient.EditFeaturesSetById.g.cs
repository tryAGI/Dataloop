#nullable enable

namespace Dataloop
{
    public partial interface IDataloopClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update a Feature Set<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.FeatureSet feature_set: FeatureSet object<br/>
        /// # :return: FeatureSet<br/>
        /// # :rtype: dtlpy.entities.FeatureSet<br/>
        /// # <br/>
        /// # <br/>
        /// # dl.feature_sets.update(feature_set='feature_set')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task EditFeaturesSetByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}