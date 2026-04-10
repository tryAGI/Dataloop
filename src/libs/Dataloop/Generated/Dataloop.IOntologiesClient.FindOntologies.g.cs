#nullable enable

namespace Dataloop
{
    public partial interface IOntologiesClient
    {
        /// <summary>
        /// Find ontologies by query
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="system"></param>
        /// <param name="ids"></param>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIOntologyCursor> FindOntologiesAsync(
            global::System.Collections.Generic.IList<string>? projects = default,
            bool? system = default,
            global::System.Collections.Generic.IList<string>? ids = default,
            double? pageOffset = default,
            double? pageSize = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}