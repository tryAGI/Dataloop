
#nullable enable

namespace Dataloop
{
    public partial class AnnotationsClient
    {
        partial void PrepareUpdateAnnotationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string annotationId,
            ref bool? system,
            ref bool? replace,
            global::Dataloop.UpdateAnnotationRequest request);
        partial void PrepareUpdateAnnotationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string annotationId,
            bool? system,
            bool? replace,
            global::Dataloop.UpdateAnnotationRequest request);
        partial void ProcessUpdateAnnotationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateAnnotationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update an item's annotation
        /// </summary>
        /// <param name="annotationId"></param>
        /// <param name="system"></param>
        /// <param name="replace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update an existing annotation. For example, you may change the annotation's label and then use the update method.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must have an item that has been annotated. You must have the role of an *owner* or<br/>
        /// # *developer* or be assigned a task that includes that item as an *annotation manager* or *annotator*.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.annotation.Annotation annotations: Annotation object<br/>
        /// # :param bool system_metadata: bool - True, if you want to change metadata system<br/>
        /// # <br/>
        /// # :return: True if successful or error if unsuccessful<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # annotations = item.annotations.update(annotation='annotation')<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APIAnnotation> UpdateAnnotationAsync(
            string annotationId,

            global::Dataloop.UpdateAnnotationRequest request,
            bool? system = default,
            bool? replace = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateAnnotationArguments(
                httpClient: HttpClient,
                annotationId: ref annotationId,
                system: ref system,
                replace: ref replace,
                request: request);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/annotations/{annotationId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("system", system?.ToString().ToLowerInvariant())
                .AddOptionalParameter("replace", replace?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateAnnotationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                annotationId: annotationId,
                system: system,
                replace: replace,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateAnnotationResponse(
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
                ProcessUpdateAnnotationResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.APIAnnotation.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Dataloop.APIAnnotation.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Update an item's annotation
        /// </summary>
        /// <param name="annotationId"></param>
        /// <param name="system"></param>
        /// <param name="replace"></param>
        /// <param name="creator"></param>
        /// <param name="type"></param>
        /// <param name="label"></param>
        /// <param name="coordinates"></param>
        /// <param name="attributes"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APIAnnotation> UpdateAnnotationAsync(
            string annotationId,
            string creator,
            global::Dataloop.AnnotationType type,
            string label,
            bool? system = default,
            bool? replace = default,
            object? coordinates = default,
            global::System.Collections.Generic.IList<string>? attributes = default,
            global::Dataloop.APIMetadata? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.UpdateAnnotationRequest
            {
                Creator = creator,
                Type = type,
                Label = label,
                Coordinates = coordinates,
                Attributes = attributes,
                Metadata = metadata,
            };

            return await UpdateAnnotationAsync(
                annotationId: annotationId,
                system: system,
                replace: replace,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}