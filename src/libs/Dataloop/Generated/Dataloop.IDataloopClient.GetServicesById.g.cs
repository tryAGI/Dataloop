#nullable enable

namespace Dataloop
{
    public partial interface IDataloopClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get service to use in your code.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a package.<br/>
        /// # <br/>
        /// # :param str service_name: optional - search by name<br/>
        /// # :param str service_id: optional - search by id<br/>
        /// # :param bool checkout: if true, checkout (switch) to service<br/>
        /// # :param fetch: optional - fetch entity from platform, default taken from cookie<br/>
        /// # :return: Service object<br/>
        /// # :rtype: dtlpy.entities.service.Service<br/>
        /// # <br/>
        /// # <br/>
        /// # service = package.services.get(service_id='service_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task GetServicesByIdAsync(
            string id,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}