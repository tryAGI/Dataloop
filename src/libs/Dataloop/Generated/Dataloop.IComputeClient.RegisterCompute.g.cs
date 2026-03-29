#nullable enable

namespace Dataloop
{
    public partial interface IComputeClient
    {
        /// <summary>
        /// Add Driver Compute.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICompute> RegisterComputeAsync(

            global::Dataloop.ICompute request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Driver Compute.
        /// </summary>
        /// <param name="id">
        /// A class representation of the BSON ObjectId type.
        /// </param>
        /// <param name="name"></param>
        /// <param name="context"></param>
        /// <param name="sharedContexts"></param>
        /// <param name="global"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="orgIds"></param>
        /// <param name="type"></param>
        /// <param name="metadata"></param>
        /// <param name="status"></param>
        /// <param name="archived"></param>
        /// <param name="settings"></param>
        /// <param name="defaultNamespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICompute> RegisterComputeAsync(
            string id,
            string name,
            global::Dataloop.IComputeContext context,
            global::System.Collections.Generic.IList<global::Dataloop.IComputeContext> sharedContexts,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<string> orgIds,
            global::Dataloop.EComputeStatus status,
            bool? global = default,
            global::Dataloop.EComputeType type = default,
            global::Dataloop.ComputeMetadata? metadata = default,
            bool? archived = default,
            global::Dataloop.IComputeSettings? settings = default,
            string? defaultNamespace = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}