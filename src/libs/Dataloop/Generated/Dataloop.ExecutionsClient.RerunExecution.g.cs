
#nullable enable

namespace Dataloop
{
    public partial class ExecutionsClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_RerunExecutionSecurityRequirement0 =
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
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_RerunExecutionSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_RerunExecutionSecurityRequirement0,
            };
        partial void PrepareRerunExecutionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string executionId,
            ref bool waitUntilExecutionIsFinished);
        partial void PrepareRerunExecutionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string executionId,
            bool waitUntilExecutionIsFinished);
        partial void ProcessRerunExecutionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRerunExecutionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Rerun execution.
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="waitUntilExecutionIsFinished"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Rerun execution<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a service.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.execution.Execution execution:<br/>
        /// # :param bool sync: wait for the execution to finish<br/>
        /// # :return: Execution object<br/>
        /// # :rtype: dtlpy.entities.execution.Execution<br/>
        /// # <br/>
        /// # <br/>
        /// # service.executions.rerun(execution='execution_entity')<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.PiperSettingsCommands>> RerunExecutionAsync(
            string executionId,
            bool waitUntilExecutionIsFinished,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRerunExecutionArguments(
                httpClient: HttpClient,
                executionId: ref executionId,
                waitUntilExecutionIsFinished: ref waitUntilExecutionIsFinished);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RerunExecutionSecurityRequirements,
                operationName: "RerunExecutionAsync");

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/executions/{executionId}/rerun",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("waitUntilExecutionIsFinished", waitUntilExecutionIsFinished.ToString().ToLowerInvariant()) 
                ;
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRerunExecutionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                executionId: executionId,
                waitUntilExecutionIsFinished: waitUntilExecutionIsFinished);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRerunExecutionResponse(
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
                ProcessRerunExecutionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.PiperSettingsCommands>.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.PiperSettingsCommands>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}