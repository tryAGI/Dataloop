#nullable enable

namespace Dataloop
{
    public partial interface IFeatureSetsClient
    {
        /// <summary>
        /// Add a new feature set
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create a new Feature Set<br/>
        /// # <br/>
        /// # :param str name: the Feature name<br/>
        /// # :param int size: the length of a single vector in the set<br/>
        /// # :param str set_type: string of the feature type: 2d, 3d, modelFC, TSNE,PCA,FFT<br/>
        /// # :param entity_type: the entity that feature vector is linked to. Use the enum dl.FeatureEntityType<br/>
        /// # :param str project_id: the ID of the project where feature set will be created<br/>
        /// # :param str org_id: the ID of the org where feature set will be created<br/>
        /// # :return: Feature Set object<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIFeatureSet>> AddFeatureSetsAsync(

            global::Dataloop.AnyOf<global::Dataloop.FeatureSet, global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a new feature set
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIFeatureSet>> AddFeatureSetsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}