#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Pause service.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="force"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// success = package.services.pause(service_id='service_id')<br/>
        /// # <br/>
        /// # Pause service.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a package.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: service_id, service_name<br/>
        /// # <br/>
        /// # :param str service_name: service name<br/>
        /// # :param str service_id: service id<br/>
        /// # :param bool force: optional - terminate old replicas immediately<br/>
        /// # :return: True if success<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIService, string>> StopServiceAsync(
            string id,
            string? force = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}