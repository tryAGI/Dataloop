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
        /// # Get Trigger object<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a service.<br/>
        /// # <br/>
        /// # :param str trigger_id: trigger id<br/>
        /// # :param str  trigger_name: trigger name<br/>
        /// # :return: Trigger entity<br/>
        /// # :rtype: dtlpy.entities.trigger.Trigger<br/>
        /// # <br/>
        /// # <br/>
        /// # service.triggers.get(trigger_id='trigger_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task GetTriggersByIdAsync(
            string id,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}