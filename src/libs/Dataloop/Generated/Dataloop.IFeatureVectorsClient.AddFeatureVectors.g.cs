#nullable enable

namespace Dataloop
{
    public partial interface IFeatureVectorsClient
    {
        /// <summary>
        /// Add new feature vector/s
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create a new Feature vector<br/>
        /// # <br/>
        /// # :param immutable value: actual vector - immutable (list of floats [1,2,3]) or list of lists of floats<br/>
        /// # :param str project_id: the id of the project where feature will be created<br/>
        /// # :param str feature_set_id: ref to a featureSet this vector is a part of<br/>
        /// # :param entity: the entity the featureVector is linked to (item, annotation, etc) or list of entities<br/>
        /// # :param str version: version of the featureSet generator<br/>
        /// # :param str parent_id: optional: parent FeatureSet id - used when FeatureVector is a subFeature<br/>
        /// # :param str org_id: the id of the org where featureVector will be created<br/>
        /// # :return: Feature vector:<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIFeatureVector>> AddFeatureVectorsAsync(

            global::Dataloop.AnyOf<global::Dataloop.FeatureVector, global::System.Collections.Generic.IList<global::Dataloop.FeatureVector>> request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add new feature vector/s
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIFeatureVector>> AddFeatureVectorsAsync(
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}