#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationTasksClient
    {
        /// <summary>
        /// Create a new Task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// dataset.tasks.create(task= 'task_entity',<br/>
        /// due_date = datetime.datetime(day= 1, month= 1, year= 2029).timestamp(),<br/>
        /// assignee_ids =[ 'annotator1@dataloop.ai', 'annotator2@dataloop.ai'])<br/>
        /// # <br/>
        /// # Create a new Task (Annotation or QA).<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner*, *developer*, or *annotation manager* who has been assigned to be *owner* of the annotation task.<br/>
        /// # <br/>
        /// # :param str task_name: the name of the task<br/>
        /// # :param float due_date: date by which the task should be finished; for example, due_date=datetime.datetime(day=1, month=1, year=2029).timestamp()<br/>
        /// # :param list assignee_ids: list the task assignees (contributors) that should be working on the task. Provide a list of users' emails<br/>
        /// # :param List[WorkloadUnit] List[WorkloadUnit] workload: list of WorkloadUnit objects. Customize distribution (percentage) between the task assignees. For example: [dl.WorkloadUnit(annotator@hi.com, 80), dl.WorkloadUnit(annotator2@hi.com, 20)]<br/>
        /// # :param entities.Dataset dataset: dataset object, the dataset that refer to the task<br/>
        /// # :param str task_owner: task owner. Provide user email<br/>
        /// # :param str task_type: task type "annotation" or "qa"<br/>
        /// # :param str task_parent_id: optional if type is qa - parent annotation task id<br/>
        /// # :param str project_id: the Id of the project where task will be created<br/>
        /// # :param str recipe_id: recipe id for the task<br/>
        /// # :param list assignments_ids: assignments ids to the task<br/>
        /// # :param dict metadata: metadata for the task<br/>
        /// # :param entities.Filters filters: dl.Filters entity to filter items for the task<br/>
        /// # :param List[entities.Item] items: list of items (item Id or objects) to insert to the task<br/>
        /// # :param dict DQL query: filter items for the task<br/>
        /// # :param list available_actions: list of available actions (statuses) that will be available for the task items; The default statuses are: "completed" and "discard"<br/>
        /// # :param bool wait: wait until create task finish<br/>
        /// # :param entities.Filters check_if_exist: dl.Filters check if task exist according to filter<br/>
        /// # :param int limit: the limit items that the task can include<br/>
        /// # :param int  batch_size: Pulling batch size (items), use with pulling allocation method. Restrictions - Min 3, max 100<br/>
        /// # :param int max_batch_workload: max_batch_workload: Max items in assignment, use with pulling allocation method. Restrictions - Min batchSize + 2, max batchSize * 2<br/>
        /// # :param list allowed_assignees: list the task assignees (contributors) that should be working on the task. Provide a list of users' emails<br/>
        /// # :param entities.TaskPriority priority: priority of the task options in entities.TaskPriority<br/>
        /// # :param entities.ConsensusTaskType consensus_task_type: consensus_task_type of the task options in entities.ConsensusTaskType<br/>
        /// # :param int consensus_percentage: percentage of items to be copied to multiple annotators (consensus items)<br/>
        /// # :param int consensus_assignees: the number of different annotators per item (number of copies per item)<br/>
        /// # :param bool scoring: create a scoring app in project<br/>
        /// # :return: Task object<br/>
        /// # :rtype: dtlpy.entities.task.Task<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>> CreateAnnotationTaskAsync(

            global::Dataloop.TaskPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new Task
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="recipeId"></param>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="taskOwner"></param>
        /// <param name="dueDate"></param>
        /// <param name="query"></param>
        /// <param name="status"></param>
        /// <param name="assignmentIds"></param>
        /// <param name="spec"></param>
        /// <param name="workload"></param>
        /// <param name="limit"></param>
        /// <param name="percentage"></param>
        /// <param name="asynced"></param>
        /// <param name="emptyTask"></param>
        /// <param name="checkIfExist"></param>
        /// <param name="availableActions"></param>
        /// <param name="disableWebm"></param>
        /// <param name="metadata"></param>
        /// <param name="priority"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>> CreateAnnotationTaskAsync(
            string datasetId,
            string recipeId,
            string projectId,
            string name,
            string taskOwner,
            string query,
            global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec> spec,
            double? dueDate = default,
            string? status = default,
            global::System.Collections.Generic.IList<string>? assignmentIds = default,
            global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? workload = default,
            double? limit = default,
            bool? percentage = default,
            bool? asynced = default,
            bool? emptyTask = default,
            global::Dataloop.TaskPayloadCheckIfExist? checkIfExist = default,
            global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? availableActions = default,
            bool? disableWebm = default,
            global::Dataloop.TaskMetadata? metadata = default,
            double? priority = default,
            global::Dataloop.PickDescriptionContent? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}