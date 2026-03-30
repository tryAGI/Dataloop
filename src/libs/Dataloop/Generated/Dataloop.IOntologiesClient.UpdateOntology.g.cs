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
        /// <remarks>
        /// # <br/>
        /// # Update the Ontology metadata.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.ontology.Ontology ontology: Ontology object<br/>
        /// # :param bool system_metadata: bool - True, if you want to change metadata system<br/>
        /// # :return: Ontology object<br/>
        /// # :rtype: dtlpy.entities.ontology.Ontology<br/>
        /// # <br/>
        /// # <br/>
        /// # recipe.ontologies.delete(ontology='ontology_entity')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>> UpdateOntologyAsync(
            string id,

            global::Dataloop.APIOntologyConfigurationV2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing Ontology
        /// </summary>
        /// <param name="id"></param>
        /// <param name="creator"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>> UpdateOntologyAsync(
            string id,
            string? creator = default,
            global::Dataloop.APIMetadata? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}