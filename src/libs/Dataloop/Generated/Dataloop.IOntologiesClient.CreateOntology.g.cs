#nullable enable

namespace Dataloop
{
    public partial interface IOntologiesClient
    {
        /// <summary>
        /// Create a new Ontology
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// recipe.ontologies.create(labels='labels_entity',<br/>
        /// title='new_ontology',<br/>
        /// project_ids='project_ids')<br/>
        /// # <br/>
        /// # Create a new ontology.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param labels: recipe tags<br/>
        /// # :param str title: ontology title, name<br/>
        /// # :param list project_ids: recipe project/s<br/>
        /// # :param list attributes: recipe attributes<br/>
        /// # :return: Ontology object<br/>
        /// # :rtype: dtlpy.entities.ontology.Ontology<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>> CreateOntologyAsync(

            global::Dataloop.AnyOf<global::Dataloop.CreateOntologyPayloadV2, global::Dataloop.CreateOntologyPayload> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new Ontology
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>> CreateOntologyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}