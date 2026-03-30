#nullable enable

namespace Dataloop
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Create a Trigger. Can create two types: a cron trigger or an event trigger.<br/>
        /// Inputs are different for each type
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create a Trigger. Can create two types: a cron trigger or an event trigger.<br/>
        /// # Inputs are different for each type<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a service.<br/>
        /// # <br/>
        /// # Inputs for all types:<br/>
        /// # <br/>
        /// # :param str service_id: Id of services to be triggered<br/>
        /// # :param str trigger_type: can be cron or event. use enum dl.TriggerType for the full list<br/>
        /// # :param str name: name of the trigger<br/>
        /// # :param str webhook_id: id for webhook to be called<br/>
        /// # :param str  function_name: the function name to be called when triggered (must be defined in the package)<br/>
        /// # :param str  project_id: project id where trigger will work<br/>
        /// # :param bool active: optional - True/False, default = True, if true trigger is active<br/>
        /// # <br/>
        /// # Inputs for event trigger:<br/>
        /// # :param dtlpy.entities.filters.Filters filters: optional - Item/Annotation metadata filters, default = none<br/>
        /// # :param str resource: optional - Dataset/Item/Annotation/ItemStatus, default = Item<br/>
        /// # :param str actions: optional - Created/Updated/Deleted, default = create<br/>
        /// # :param str execution_mode: how many times trigger should be activated; default is "Once". enum dl.TriggerExecutionMode<br/>
        /// # <br/>
        /// # Inputs for cron trigger:<br/>
        /// # :param start_at: iso format date string to start activating the cron trigger<br/>
        /// # :param end_at: iso format date string to end the cron activation<br/>
        /// # :param inputs: dictionary "name":"val" of inputs to the function<br/>
        /// # :param str cron: cron spec specifying when it should run. more information: https://en.wikipedia.org/wiki/Cron<br/>
        /// # :param str pipeline_id: Id of pipeline to be triggered<br/>
        /// # :param pipeline: pipeline entity to be triggered<br/>
        /// # :param str pipeline_node_id: Id of pipeline root node to be triggered<br/>
        /// # :param root_node_namespace: namespace of pipeline root node to be triggered<br/>
        /// # <br/>
        /// # :return: Trigger entity<br/>
        /// # :rtype: dtlpy.entities.trigger.Trigger<br/>
        /// # <br/>
        /// # <br/>
        /// # service.triggers.create(name='triggername',<br/>
        /// # execution_mode=dl.TriggerExecutionMode.ONCE,<br/>
        /// # resource='Item',<br/>
        /// # actions='Created',<br/>
        /// # function_name='run',<br/>
        /// # filters={'$and': [{'hidden': False},<br/>
        /// # {'type': 'file'}]}<br/>
        /// # )<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APITrigger> CreateTriggerAsync(

            global::Dataloop.CreateTriggerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Trigger. Can create two types: a cron trigger or an event trigger.<br/>
        /// Inputs are different for each type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="active"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APITrigger> CreateTriggerAsync(
            global::Dataloop.TriggerType type,
            string name,
            string projectId,
            bool active,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}