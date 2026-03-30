#nullable enable

namespace Dataloop
{
    public partial interface IOntologiesClient
    {
        /// <summary>
        /// Delete an Ontology
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Delete Ontology from the platform.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param ontology_id: ontology id<br/>
        /// # :return: True if success<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # recipe.ontologies.delete(ontology_id='ontology_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task DeleteOntologyAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}