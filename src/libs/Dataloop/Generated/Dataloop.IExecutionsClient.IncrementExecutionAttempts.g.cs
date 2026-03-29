#nullable enable

namespace Dataloop
{
    public partial interface IExecutionsClient
    {
        /// <summary>
        /// Increment the number of attempts that an execution is allowed to attempt to run a service that is not responding.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<double> IncrementExecutionAttemptsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}