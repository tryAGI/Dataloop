#nullable enable

namespace Dataloop
{
    public partial interface IAssignmentsClient
    {
        /// <summary>
        /// Redistribute Assignment to annotators
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// assignment = task.assignments.redistribute(workload=dl.Workload([dl.WorkloadUnit(assignee_id="annotator1@dataloop.ai", load=50),<br/>
        /// dl.WorkloadUnit(assignee_id="annotator2@dataloop.ai", load=50)]))<br/>
        /// # <br/>
        /// # Redistribute an assignment.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner*, *developer*, or *annotation manager* who has been assigned as *owner* of the annotation task.<br/>
        /// # <br/>
        /// # <br/>
        /// # :param dtlpy.entities.assignment.Workload workload: list of WorkloadUnit objects. Customize distribution (percentage) between the task assignees. For example: [dl.WorkloadUnit(annotator@hi.com, 80), dl.WorkloadUnit(annotator2@hi.com, 20)]<br/>
        /// # :param dtlpy.entities.assignment.Assignment assignment: assignment object<br/>
        /// # :param str assignment_id: the Id of the assignment<br/>
        /// # :param dtlpy.entities.task.Task task: the task object that include the assignment<br/>
        /// # :param str task_id: the Id of the task that include the assignment<br/>
        /// # :param bool wait: wait until redistribute assignment finish<br/>
        /// # :return: Assignment object<br/>
        /// # :rtype: dtlpy.entities.assignment.Assignment assignment<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>> RedistributeAssignmentAsync(
            string id,

            global::Dataloop.RedistributeAssignmentPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Redistribute Assignment to annotators
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workload"></param>
        /// <param name="selectNotAnnotatedOnly"></param>
        /// <param name="asynced"></param>
        /// <param name="isSudoCtx"></param>
        /// <param name="allowToSkipAssignments"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>> RedistributeAssignmentAsync(
            string id,
            global::System.Collections.Generic.IList<global::Dataloop.AssignmentWorkload> workload,
            bool? selectNotAnnotatedOnly = default,
            bool? asynced = default,
            bool? isSudoCtx = default,
            bool? allowToSkipAssignments = default,
            string? query = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}