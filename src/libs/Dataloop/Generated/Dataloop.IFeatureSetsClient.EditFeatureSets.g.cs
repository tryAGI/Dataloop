#nullable enable

namespace Dataloop
{
    public partial interface IFeatureSetsClient
    {
        /// <summary>
        /// Update a feature set by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIFeatureSet> EditFeatureSetsAsync(
            string id,

            global::Dataloop.PartialFeatureSet request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a feature set by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="type"></param>
        /// <param name="entityType"></param>
        /// <param name="project"></param>
        /// <param name="org"></param>
        /// <param name="modelId"></param>
        /// <param name="creator"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="name"></param>
        /// <param name="size"></param>
        /// <param name="authz"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIFeatureSet> EditFeatureSetsAsync(
            string id,
            string? requestId = default,
            string? type = default,
            global::Dataloop.FeatureSetEntityType? entityType = default,
            string? project = default,
            string? org = default,
            string? modelId = default,
            string? creator = default,
            global::System.DateTime? createdAt = default,
            global::System.DateTime? updatedAt = default,
            string? updatedBy = default,
            string? name = default,
            double? size = default,
            global::Dataloop.AuthZBlockDatasetContext? authz = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}