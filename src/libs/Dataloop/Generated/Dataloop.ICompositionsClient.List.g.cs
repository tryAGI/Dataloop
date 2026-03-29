#nullable enable

namespace Dataloop
{
    public partial interface ICompositionsClient
    {
        /// <summary>
        /// Retrieves Composition.<br/>
        /// Supply query parameters to filter the list.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIComposition> ListAsync(
            string filter,
            string sort,
            double page,
            double pageSize,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}