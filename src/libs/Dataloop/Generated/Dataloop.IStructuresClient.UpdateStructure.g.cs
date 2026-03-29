#nullable enable

namespace Dataloop
{
    public partial interface IStructuresClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ontologyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIStructure> UpdateStructureAsync(
            string id,
            string ontologyId,

            global::Dataloop.APIUpdateStructurePayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ontologyId"></param>
        /// <param name="order"></param>
        /// <param name="arcs"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIStructure> UpdateStructureAsync(
            string id,
            string ontologyId,
            global::System.Collections.Generic.IList<string>? order = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? arcs = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}