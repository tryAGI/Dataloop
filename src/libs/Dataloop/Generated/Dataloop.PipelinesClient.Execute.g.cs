
#nullable enable

namespace Dataloop
{
    public partial class PipelinesClient
    {
        partial void PrepareExecuteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineId,
            global::Dataloop.ExecuteOptions request);
        partial void PrepareExecuteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineId,
            global::Dataloop.ExecuteOptions request);
        partial void ProcessExecuteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExecuteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Execute a pipeline and return the pipeline execution as an object - or command in case batch is defined on the body.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create batch executions of a pipeline.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param pipeline_id: pipeline id<br/>
        /// # :param filters: Filters entity for a filtering before execute<br/>
        /// # :param execution_inputs: list of the dl.FunctionIO or dict of pipeline input - example {'item': 'item_id'}, that represent the extra inputs of the function<br/>
        /// # :param bool wait: wait until create task finish<br/>
        /// # :return: entities.PipelineExecution object<br/>
        /// # :rtype: dtlpy.entities.pipeline_execution.PipelineExecution<br/>
        /// # <br/>
        /// # <br/>
        /// # command = pipeline.pipeline_executions.create_batch(<br/>
        /// # execution_inputs=dl.FunctionIO(type=dl.PackageInputType.STRING, value='test', name='string'),<br/>
        /// # filters=dl.Filters(field='dir', values='/test'))<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>> ExecuteAsync(
            string pipelineId,

            global::Dataloop.ExecuteOptions request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareExecuteArguments(
                httpClient: HttpClient,
                pipelineId: ref pipelineId,
                request: request);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/pipelines/{pipelineId}/execute",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareExecuteRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineId: pipelineId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessExecuteResponse(
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
                ProcessExecuteResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Execute a pipeline and return the pipeline execution as an object - or command in case batch is defined on the body.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="batch"></param>
        /// <param name="pipeline"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>> ExecuteAsync(
            string pipelineId,
            global::Dataloop.ExecuteOptionsBatch batch,
            global::Dataloop.ExecutePipelinePayload pipeline,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.ExecuteOptions
            {
                Batch = batch,
                Pipeline = pipeline,
            };

            return await ExecuteAsync(
                pipelineId: pipelineId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}