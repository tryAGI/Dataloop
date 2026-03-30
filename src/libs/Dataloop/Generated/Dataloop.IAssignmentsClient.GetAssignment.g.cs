#nullable enable

namespace Dataloop
{
    public partial interface IAssignmentsClient
    {
        /// <summary>
        /// Get a specific assignment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get Assignment object to use it in your code.<br/>
        /// # <br/>
        /// # :param str assignment_name: optional - search by name<br/>
        /// # :param str assignment_id: optional - search by id<br/>
        /// # :return: Assignment object<br/>
        /// # :rtype: dtlpy.entities.assignment.Assignment<br/>
        /// # <br/>
        /// # <br/>
        /// # assignment = task.assignments.get(assignment_id='assignment_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAssignment> GetAssignmentAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}