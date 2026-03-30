
#nullable enable

namespace Dataloop
{
    public partial class DatasetsClient
    {
        partial void PrepareQueryDatasetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            global::Dataloop.DQLResourceQuery request);
        partial void PrepareQueryDatasetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            global::Dataloop.DQLResourceQuery request);
        partial void ProcessQueryDatasetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQueryDatasetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIAnnotationOrAPIDatasetOrAPIDatasetFileItemOrAPIDatasetDirectoryItem> QueryDatasetAsync(
            string id,

            global::Dataloop.DQLResourceQuery request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareQueryDatasetArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/datasets/{id}/query",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareQueryDatasetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessQueryDatasetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessQueryDatasetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.CursorPageAPIAnnotationOrAPIDatasetOrAPIDatasetFileItemOrAPIDatasetDirectoryItem.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Dataloop.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Dataloop.CursorPageAPIAnnotationOrAPIDatasetOrAPIDatasetFileItemOrAPIDatasetDirectoryItem.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Dataloop.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIAnnotationOrAPIDatasetOrAPIDatasetFileItemOrAPIDatasetDirectoryItem> QueryDatasetAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.DQLResourceQuery
            {
                Filter = filter,
                Limit = limit,
                Join = join,
                Intersect = intersect,
                Except = except,
                References = references,
                Sort = sort,
                Select = select,
                Update = update,
                Delete = delete,
                User = user,
                SystemSpace = systemSpace,
                QueryEngine = queryEngine,
                Resource = resource,
                Skip = skip,
                Datasets = datasets,
                Projects = projects,
                Page = page,
                PageSize = pageSize,
                CollectMetrics = collectMetrics,
                CountTotal = countTotal,
                Sign = sign,
            };

            return await QueryDatasetAsync(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}