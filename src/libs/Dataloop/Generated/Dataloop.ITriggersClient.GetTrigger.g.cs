#nullable enable

namespace Dataloop
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Get trigger by id.<br/>
        /// Supply query parameters to filter the list.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// service.triggers.get(trigger_id='trigger_id')<br/>
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
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APITrigger> GetTriggerAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}