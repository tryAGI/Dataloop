#nullable enable

namespace Dataloop
{
    public partial interface IServiceDriversClient
    {
        /// <summary>
        /// Create Service Driver.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIServiceDriver> CreateAsync(

            global::Dataloop.APIServiceDriver request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Service Driver.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="context"></param>
        /// <param name="namespace"></param>
        /// <param name="computeId"></param>
        /// <param name="metadata"></param>
        /// <param name="isCacheAvailable"></param>
        /// <param name="archived"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIServiceDriver> CreateAsync(
            string id,
            string url,
            string name,
            global::Dataloop.ServiceDriverType type,
            global::Dataloop.IComputeContext context,
            string computeId,
            bool isCacheAvailable,
            global::System.DateTime? createdAt = default,
            global::System.DateTime? updatedAt = default,
            string? @namespace = default,
            global::Dataloop.ComputeMetadata? metadata = default,
            bool? archived = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}