#nullable enable

namespace Dataloop
{
    public partial interface IOntologiesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIAttributeSection> QueryOntologyAttributesAsync(
            string id,

            global::Dataloop.FilterQueryInput request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="context"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="resource"></param>
        /// <param name="filter"></param>
        /// <param name="join"></param>
        /// <param name="update"></param>
        /// <param name="delete"></param>
        /// <param name="sort"></param>
        /// <param name="systemSpace"></param>
        /// <param name="references"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIAttributeSection> QueryOntologyAttributesAsync(
            string id,
            global::Dataloop.FilterQueryInputContext context,
            double page,
            double pageSize,
            string resource,
            global::Dataloop.Dictionary filter,
            global::Dataloop.Dictionary? join = default,
            global::Dataloop.Dictionary? update = default,
            bool? delete = default,
            global::Dataloop.Dictionary? sort = default,
            bool? systemSpace = default,
            global::Dataloop.FilterQueryInputReferences? references = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}