#nullable enable

namespace Dataloop
{
    public partial interface IDpkClient
    {
        /// <summary>
        /// Get the revisions of dpk by name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIDpk> GetRevisionsAsync(
            string name,

            global::Dataloop.QueryString request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the revisions of dpk by name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="sort"></param>
        /// <param name="filter"></param>
        /// <param name="resource"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIDpk> GetRevisionsAsync(
            string name,
            double pageSize,
            double page,
            object sort,
            object filter,
            global::Dataloop.QueryResource resource,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}