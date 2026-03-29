
#nullable enable

namespace Dataloop
{
    public partial class DatasetsClient
    {
        partial void PrepareExportDatasetAsZipArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            global::Dataloop.ExportDatasetOptions request);
        partial void PrepareExportDatasetAsZipRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            global::Dataloop.ExportDatasetOptions request);
        partial void ProcessExportDatasetAsZipResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExportDatasetAsZipResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> ExportDatasetAsZipAsync(
            string id,

            global::Dataloop.ExportDatasetOptions request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareExportDatasetAsZipArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/datasets/{id}/export",
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
            PrepareExportDatasetAsZipRequest(
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
            ProcessExportDatasetAsZipResponse(
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
                ProcessExportDatasetAsZipResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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

                    var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeItemVectors"></param>
        /// <param name="includeAnnotationVectors"></param>
        /// <param name="itemsVectorQuery"></param>
        /// <param name="annotationsVectorQuery"></param>
        /// <param name="itemsQuery"></param>
        /// <param name="annotationsQuery"></param>
        /// <param name="featureSetsQuery"></param>
        /// <param name="annotations">
        /// annotations export options
        /// </param>
        /// <param name="exportVersion">
        /// `V2` - exported items will have original extension in filename, `V1` - no original extension in filenames
        /// </param>
        /// <param name="exportType"></param>
        /// <param name="zipJson">
        /// This flag is only honoured when exportType is 'json'. If zipJson is set to true the final json file is minified and zipped to reduce size
        /// </param>
        /// <param name="datasetLock">
        /// Determines whether the dataset should be locked during export.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="datasetReadonlyInitialState">
        /// Intial state of the dataset readonly
        /// </param>
        /// <param name="lockTimeoutSec">
        /// Determines the timeout seconds for dataset Lock*
        /// </param>
        /// <param name="summary">
        /// Determines whether summary file should be added to export<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ExportDatasetAsZipAsync(
            string id,
            bool? includeItemVectors = default,
            bool? includeAnnotationVectors = default,
            global::Dataloop.DQLResourceQuery? itemsVectorQuery = default,
            global::Dataloop.DQLResourceQuery? annotationsVectorQuery = default,
            global::Dataloop.DQLResourceQuery? itemsQuery = default,
            global::Dataloop.DQLResourceQuery? annotationsQuery = default,
            global::Dataloop.DQLResourceQuery? featureSetsQuery = default,
            global::Dataloop.ExportDatasetOptionsAnnotations? annotations = default,
            global::Dataloop.ExportDatasetOptionsExportVersion? exportVersion = default,
            global::Dataloop.ExportType? exportType = default,
            bool? zipJson = default,
            bool? datasetLock = default,
            bool? datasetReadonlyInitialState = default,
            double? lockTimeoutSec = default,
            bool? summary = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.ExportDatasetOptions
            {
                IncludeItemVectors = includeItemVectors,
                IncludeAnnotationVectors = includeAnnotationVectors,
                ItemsVectorQuery = itemsVectorQuery,
                AnnotationsVectorQuery = annotationsVectorQuery,
                ItemsQuery = itemsQuery,
                AnnotationsQuery = annotationsQuery,
                FeatureSetsQuery = featureSetsQuery,
                Annotations = annotations,
                ExportVersion = exportVersion,
                ExportType = exportType,
                ZipJson = zipJson,
                DatasetLock = datasetLock,
                DatasetReadonlyInitialState = datasetReadonlyInitialState,
                LockTimeoutSec = lockTimeoutSec,
                Summary = summary,
            };

            return await ExportDatasetAsZipAsync(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}