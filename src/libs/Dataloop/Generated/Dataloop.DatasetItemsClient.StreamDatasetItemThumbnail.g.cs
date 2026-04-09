
#nullable enable

namespace Dataloop
{
    public partial class DatasetItemsClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_StreamDatasetItemThumbnailSecurityRequirement0 =
            new global::Dataloop.EndPointSecurityRequirement
            {
                Authorizations = new global::Dataloop.EndPointAuthorizationRequirement[]
                {                    new global::Dataloop.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_StreamDatasetItemThumbnailSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_StreamDatasetItemThumbnailSecurityRequirement0,
            };
        partial void PrepareStreamDatasetItemThumbnailArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref double? width,
            ref double? height,
            ref bool? annotations,
            ref bool? annotationsV2,
            ref string? queryHash,
            ref string datasetId);
        partial void PrepareStreamDatasetItemThumbnailRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            double? width,
            double? height,
            bool? annotations,
            bool? annotationsV2,
            string? queryHash,
            string datasetId);
        partial void ProcessStreamDatasetItemThumbnailResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="annotations"></param>
        /// <param name="annotationsV2"></param>
        /// <param name="queryHash"></param>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        public async global::System.Threading.Tasks.Task StreamDatasetItemThumbnailAsync(
            string id,
            string datasetId,
            double? width = default,
            double? height = default,
            bool? annotations = default,
            bool? annotationsV2 = default,
            string? queryHash = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareStreamDatasetItemThumbnailArguments(
                httpClient: HttpClient,
                id: ref id,
                width: ref width,
                height: ref height,
                annotations: ref annotations,
                annotationsV2: ref annotationsV2,
                queryHash: ref queryHash,
                datasetId: ref datasetId);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_StreamDatasetItemThumbnailSecurityRequirements,
                operationName: "StreamDatasetItemThumbnailAsync");

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/datasets/{datasetId}/items/{id}/thumbnail",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("width", width?.ToString())
                .AddOptionalParameter("height", height?.ToString())
                .AddOptionalParameter("annotations", annotations?.ToString().ToLowerInvariant())
                .AddOptionalParameter("annotationsV2", annotationsV2?.ToString().ToLowerInvariant())
                .AddOptionalParameter("queryHash", queryHash) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareStreamDatasetItemThumbnailRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                width: width,
                height: height,
                annotations: annotations,
                annotationsV2: annotationsV2,
                queryHash: queryHash,
                datasetId: datasetId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessStreamDatasetItemThumbnailResponse(
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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
    }
}