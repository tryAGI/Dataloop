
#nullable enable

namespace Dataloop
{
    public partial class ExecutionsClient
    {
        partial void PrepareCreateExecutionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string serviceId,
            ref bool waitUntilExecutionIsFinished,
            global::Dataloop.CreateExecutionRequest request);
        partial void PrepareCreateExecutionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string serviceId,
            bool waitUntilExecutionIsFinished,
            global::Dataloop.CreateExecutionRequest request);
        partial void ProcessCreateExecutionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateExecutionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Execute a function on an existing service.
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="waitUntilExecutionIsFinished"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Execute a function on an existing service<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a service.<br/>
        /// # <br/>
        /// # :param str service_id: service id to execute on<br/>
        /// # :param filters: Filters entity for a filtering before execute<br/>
        /// # :param str function_name: function name to run<br/>
        /// # :param List[FunctionIO] or dict execution_inputs: input dictionary or list of FunctionIO entities, that represent the extra inputs of the function<br/>
        /// # :param bool wait: wait until create task finish<br/>
        /// # :return: execution object<br/>
        /// # :rtype: dtlpy.entities.execution.Execution<br/>
        /// # <br/>
        /// # <br/>
        /// # command = service.executions.create_batch(<br/>
        /// # execution_inputs=dl.FunctionIO(type=dl.PackageInputType.STRING, value='test', name='string'),<br/>
        /// # filters=dl.Filters(field='dir', values='/test'),<br/>
        /// # function_name='run')<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.APICommand>> CreateExecutionAsync(
            string serviceId,
            bool waitUntilExecutionIsFinished,

            global::Dataloop.CreateExecutionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateExecutionArguments(
                httpClient: HttpClient,
                serviceId: ref serviceId,
                waitUntilExecutionIsFinished: ref waitUntilExecutionIsFinished,
                request: request);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/executions/{serviceId}",
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
            PrepareCreateExecutionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                serviceId: serviceId,
                waitUntilExecutionIsFinished: waitUntilExecutionIsFinished,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateExecutionResponse(
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
                ProcessCreateExecutionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.APICommand>.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.APICommand>.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Execute a function on an existing service.
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="waitUntilExecutionIsFinished"></param>
        /// <param name="mode"></param>
        /// <param name="pipeline"></param>
        /// <param name="projectId"></param>
        /// <param name="input"></param>
        /// <param name="functionName"></param>
        /// <param name="batch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.APICommand>> CreateExecutionAsync(
            string serviceId,
            bool waitUntilExecutionIsFinished,
            string projectId,
            global::Dataloop.Dictionary input,
            string functionName,
            global::Dataloop.ExecutionMode? mode = default,
            global::Dataloop.IPipelineExecution? pipeline = default,
            global::Dataloop.ExecuteOptionsBatch? batch = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.CreateExecutionRequest
            {
                Mode = mode,
                Pipeline = pipeline,
                ProjectId = projectId,
                Input = input,
                FunctionName = functionName,
                Batch = batch,
            };

            return await CreateExecutionAsync(
                serviceId: serviceId,
                waitUntilExecutionIsFinished: waitUntilExecutionIsFinished,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}