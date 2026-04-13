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
        /// # Get service status.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a package.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: service_id, service_name<br/>
        /// # <br/>
        /// # :param str service_name: service name<br/>
        /// # :param str service_id: service id<br/>
        /// # :return: status json<br/>
        /// # :rtype: dict<br/>
        /// # <br/>
        /// # <br/>
        /// # status_json = package.services.status(service_id='service_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task CreateServicesByIdStatusAsync(
            string id,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}