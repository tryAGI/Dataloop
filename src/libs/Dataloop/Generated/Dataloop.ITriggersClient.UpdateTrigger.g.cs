#nullable enable

namespace Dataloop
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Update trigger.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// service.triggers.update(trigger='trigger_entity')<br/>
        /// # <br/>
        /// # Update trigger<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a service.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.trigger.Trigger trigger: Trigger entity<br/>
        /// # :return: Trigger entity<br/>
        /// # :rtype: dtlpy.entities.trigger.Trigger<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APITrigger> UpdateTriggerAsync(
            string id,

            global::Dataloop.APITrigger request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update trigger.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="url"></param>
        /// <param name="type"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="active"></param>
        /// <param name="metadata"></param>
        /// <param name="updatedBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APITrigger> UpdateTriggerAsync(
            string id,
            string requestId,
            string url,
            global::Dataloop.TriggerType type,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string creator,
            string name,
            string projectId,
            bool active,
            global::Dataloop.EntityReferenceMetadata? metadata = default,
            string? updatedBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}