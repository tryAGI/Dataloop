#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Delete Service.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="force"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Delete Service object<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a package.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: service_id, service_name.<br/>
        /// # <br/>
        /// # :param force:<br/>
        /// # :param str service_name: by name<br/>
        /// # :param str service_id: by id<br/>
        /// # :return: True<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # is_deleted = package.services.delete(service_id='service_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> DeleteServiceAsync(
            string id,
            bool? force = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}