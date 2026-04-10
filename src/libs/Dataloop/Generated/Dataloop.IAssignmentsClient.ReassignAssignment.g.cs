#nullable enable

namespace Dataloop
{
    public partial interface IAssignmentsClient
    {
        /// <summary>
        /// Reassign Assignment to annotator
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Reassign an assignment.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner*, *developer*, or *annotation manager* who has been assigned as *owner* of the annotation task.<br/>
        /// # <br/>
        /// # :param str assignee_id: the email of the user that want to assign the assignment<br/>
        /// # :param dtlpy.entities.assignment.Assignment assignment: assignment object<br/>
        /// # :param assignment_id: the Id of the assignment<br/>
        /// # :param dtlpy.entities.task.Task task: task object<br/>
        /// # :param str task_id: the Id of the task that include the assignment<br/>
        /// # :param bool wait: wait until reassign assignment finish<br/>
        /// # :return: Assignment object<br/>
        /// # :rtype: dtlpy.entities.assignment.Assignment<br/>
        /// # <br/>
        /// # <br/>
        /// # assignment = task.assignments.reassign(assignee_ids='annotator1@dataloop.ai')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APIAssignment>> ReassignAssignmentAsync(
            string id,

            global::Dataloop.ReassignAssignmentPayload request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reassign Assignment to annotator
        /// </summary>
        /// <param name="id"></param>
        /// <param name="annotator"></param>
        /// <param name="asynced"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APIAssignment>> ReassignAssignmentAsync(
            string id,
            string annotator,
            bool? asynced = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}