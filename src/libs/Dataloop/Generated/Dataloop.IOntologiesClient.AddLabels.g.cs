#nullable enable

namespace Dataloop
{
    public partial interface IOntologiesClient
    {
        /// <summary>
        /// Update an existing Ontology
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIOntology> AddLabelsAsync(
            string id,

            global::Dataloop.AddLabelsNodePayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing Ontology
        /// </summary>
        /// <param name="id"></param>
        /// <param name="labelsNode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIOntology> AddLabelsAsync(
            string id,
            global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayload> labelsNode,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}