
#nullable enable

namespace Dataloop
{
    public partial class DatasetItemAnnotationsClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_CreateAnnotationsSecurityRequirement0 =
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
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_CreateAnnotationsSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_CreateAnnotationsSecurityRequirement0,
            };
        partial void PrepareCreateAnnotationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            ref string itemId,
            global::Dataloop.AnyOf<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>> request);
        partial void PrepareCreateAnnotationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            string itemId,
            global::Dataloop.AnyOf<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>> request);
        partial void ProcessCreateAnnotationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateAnnotationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an annotation or annotations for an item
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>> CreateAnnotationsAsync(
            string datasetId,
            string itemId,

            global::Dataloop.AnyOf<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateAnnotationsArguments(
                httpClient: HttpClient,
                datasetId: ref datasetId,
                itemId: ref itemId,
                request: request);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateAnnotationsSecurityRequirements,
                operationName: "CreateAnnotationsAsync");

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/datasets/{datasetId}/items/{itemId}/annotations",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateAnnotationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                datasetId: datasetId,
                itemId: itemId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateAnnotationsResponse(
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
                ProcessCreateAnnotationsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create an annotation or annotations for an item
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>> CreateAnnotationsAsync(
            string datasetId,
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.AnyOf<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>>
            {
            };

            return await CreateAnnotationsAsync(
                datasetId: datasetId,
                itemId: itemId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}