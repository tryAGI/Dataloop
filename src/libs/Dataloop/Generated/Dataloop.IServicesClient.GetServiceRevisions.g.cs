#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Get service revisions by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// service_revision = package.services.revisions(service_id='service_id')<br/>
        /// # <br/>
        /// # Get service revisions history.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a package.<br/>
        /// # <br/>
        /// # You must provide at leats ONE of the following params: service, service_id<br/>
        /// # <br/>
        /// # :param dtlpy.entities.service.Service service: Service entity<br/>
        /// # :param str service_id: service id<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIService>> GetServiceRevisionsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}