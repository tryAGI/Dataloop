
#nullable enable

namespace Dataloop
{
    public partial class ServicesClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_GetLogsSecurityRequirement0 =
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
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_GetLogsSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_GetLogsSecurityRequirement0,
            };
        partial void PrepareGetLogsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string verbose,
            global::Dataloop.LogQuery request);
        partial void PrepareGetLogsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string verbose,
            global::Dataloop.LogQuery request);
        partial void ProcessGetLogsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetLogsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get logs for pipelines.
        /// </summary>
        /// <param name="verbose"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get service logs.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a package.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.service.Service service: service object<br/>
        /// # :param int size: size<br/>
        /// # :param dict checkpoint: the information from the lst point checked in the service<br/>
        /// # :param str start: iso format time<br/>
        /// # :param str end: iso format time<br/>
        /// # :param bool follow: if true, keep stream future logs<br/>
        /// # :param str text: text<br/>
        /// # :param str execution_id: execution id<br/>
        /// # :param str function_name: function name<br/>
        /// # :param str replica_id: replica id<br/>
        /// # :param bool system: system<br/>
        /// # :param bool view: if true, print out all the logs<br/>
        /// # :param bool until_completed: wait until completed<br/>
        /// # :param str log_level: the log level to display dl.LoggingLevel<br/>
        /// # :param str model_id: model id<br/>
        /// # :param str model_operation: model operation action<br/>
        /// # :param str project_id: project id<br/>
        /// # :return: ServiceLog entity<br/>
        /// # :rtype: ServiceLog<br/>
        /// # <br/>
        /// # <br/>
        /// # service_logs = package.services.log(service='service_entity')<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.ServiceLogsPage> GetLogsAsync(
            string verbose,

            global::Dataloop.LogQuery request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGetLogsArguments(
                httpClient: HttpClient,
                verbose: ref verbose,
                request: request);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetLogsSecurityRequirements,
                operationName: "GetLogsAsync");

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: "/services/logs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("verbose", verbose) 
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetLogsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                verbose: verbose,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetLogsResponse(
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
                ProcessGetLogsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.ServiceLogsPage.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dataloop.ServiceLogsPage.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Get logs for pipelines.
        /// </summary>
        /// <param name="verbose"></param>
        /// <param name="serviceId"></param>
        /// <param name="follow"></param>
        /// <param name="size"></param>
        /// <param name="checkpoint"></param>
        /// <param name="direction"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="executionId"></param>
        /// <param name="functionName"></param>
        /// <param name="replicaId"></param>
        /// <param name="text"></param>
        /// <param name="logLevel"></param>
        /// <param name="pipelineId"></param>
        /// <param name="nodeId"></param>
        /// <param name="pipelineExecutionId"></param>
        /// <param name="system"></param>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="modelOperation"></param>
        /// <param name="includeServiceLevel"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.ServiceLogsPage> GetLogsAsync(
            string verbose,
            string? serviceId = default,
            bool? follow = default,
            double? size = default,
            string? checkpoint = default,
            global::Dataloop.LogsListDirection? direction = default,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? executionId = default,
            string? functionName = default,
            string? replicaId = default,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? text = default,
            global::Dataloop.ServiceLogLevel? logLevel = default,
            string? pipelineId = default,
            string? nodeId = default,
            string? pipelineExecutionId = default,
            bool? system = default,
            global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? projectId = default,
            string? modelId = default,
            string? modelOperation = default,
            bool? includeServiceLevel = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.LogQuery
            {
                ServiceId = serviceId,
                Follow = follow,
                Size = size,
                Checkpoint = checkpoint,
                Direction = direction,
                Start = start,
                End = end,
                ExecutionId = executionId,
                FunctionName = functionName,
                ReplicaId = replicaId,
                Text = text,
                LogLevel = logLevel,
                PipelineId = pipelineId,
                NodeId = nodeId,
                PipelineExecutionId = pipelineExecutionId,
                System = system,
                ProjectId = projectId,
                ModelId = modelId,
                ModelOperation = modelOperation,
                IncludeServiceLevel = includeServiceLevel,
            };

            return await GetLogsAsync(
                verbose: verbose,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}