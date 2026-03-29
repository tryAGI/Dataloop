#nullable enable

namespace Dataloop
{
    public partial interface IAssignmentsClient
    {
        /// <summary>
        /// Update an existing assignment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// assignment = task.assignments.update(assignment='assignment_entity', system_metadata=False)<br/>
        /// # <br/>
        /// # Update an assignment.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner*, *developer*, or *annotation manager* who has been assigned as *owner* of the annotation task.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.assignment.Assignment assignment assignment: assignment entity<br/>
        /// # :param bool system_metadata: True, if you want to change metadata system<br/>
        /// # :return: Assignment object<br/>
        /// # :rtype: dtlpy.entities.assignment.Assignment assignment<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAssignment> UpdateAssignmentAsync(
            string id,

            global::Dataloop.PartialAssignmentPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing assignment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAssignment> UpdateAssignmentAsync(
            string id,
            string? name = default,
            global::Dataloop.Dictionary? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}