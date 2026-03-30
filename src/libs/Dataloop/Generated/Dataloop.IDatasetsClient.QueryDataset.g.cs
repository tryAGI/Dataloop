#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Detailed information about DQL can be found at https://dataloop.ai/docs/dql
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # List items in a dataset.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.filters.Filters filters: Filters entity or a dictionary containing filters parameters<br/>
        /// # :param int page_offset: start page<br/>
        /// # :param int page_size: page size<br/>
        /// # :return: Pages object<br/>
        /// # :rtype: dtlpy.entities.paged_entities.PagedEntities<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset.items.list(page_offset=0, page_size=100)<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIAnnotationOrAPIDatasetOrAPIDatasetFileItemOrAPIDatasetDirectoryItem> QueryDatasetAsync(
            string id,

            global::Dataloop.DQLResourceQuery request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detailed information about DQL can be found at https://dataloop.ai/docs/dql
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filter"></param>
        /// <param name="limit"></param>
        /// <param name="join"></param>
        /// <param name="intersect"></param>
        /// <param name="except"></param>
        /// <param name="references"></param>
        /// <param name="sort"></param>
        /// <param name="select"></param>
        /// <param name="update"></param>
        /// <param name="delete"></param>
        /// <param name="user"></param>
        /// <param name="systemSpace"></param>
        /// <param name="queryEngine"></param>
        /// <param name="resource"></param>
        /// <param name="skip"></param>
        /// <param name="datasets"></param>
        /// <param name="projects"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="collectMetrics"></param>
        /// <param name="countTotal"></param>
        /// <param name="sign"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIAnnotationOrAPIDatasetOrAPIDatasetFileItemOrAPIDatasetDirectoryItem> QueryDatasetAsync(
            string id,
            global::Dataloop.Dictionary filter,
            double? limit = default,
            global::Dataloop.JoinQuery? join = default,
            global::Dataloop.IntersectQuery? intersect = default,
            global::Dataloop.IntersectQuery? except = default,
            global::Dataloop.ReferenceQuery? references = default,
            global::Dataloop.SortQuery? sort = default,
            global::System.Collections.Generic.Dictionary<string, double>? select = default,
            global::Dataloop.Dictionary? update = default,
            bool? delete = default,
            string? user = default,
            bool? systemSpace = default,
            global::Dataloop.DQLResourceQueryQueryEngine? queryEngine = default,
            global::Dataloop.QueryResource? resource = default,
            double? skip = default,
            global::System.Collections.Generic.IList<string>? datasets = default,
            global::System.Collections.Generic.IList<string>? projects = default,
            double? page = default,
            double? pageSize = default,
            bool? collectMetrics = default,
            bool? countTotal = default,
            global::Dataloop.DQLResourceQuerySign? sign = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}