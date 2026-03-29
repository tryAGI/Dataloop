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
        global::System.Threading.Tasks.Task<global::Dataloop.APIOntology> UpdateLabelsAsync(
            string id,

            global::Dataloop.UpdateLabelsNodePayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing Ontology
        /// </summary>
        /// <param name="id"></param>
        /// <param name="labelsNode"></param>
        /// <param name="upsert"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIOntology> UpdateLabelsAsync(
            string id,
            global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayload> labelsNode,
            bool? upsert = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}