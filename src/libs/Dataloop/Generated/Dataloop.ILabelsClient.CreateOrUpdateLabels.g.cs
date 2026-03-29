#nullable enable

namespace Dataloop
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ontologyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APILabelTreeNodeV2>> CreateOrUpdateLabelsAsync(
            string ontologyId,

            global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayload> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}