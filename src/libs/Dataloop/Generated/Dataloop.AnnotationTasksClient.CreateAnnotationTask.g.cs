
#nullable enable

namespace Dataloop
{
    public partial class AnnotationTasksClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_CreateAnnotationTaskSecurityRequirement0 =
            new global::Dataloop.EndPointSecurityRequirement
            {
                Authorizations = new global::Dataloop.EndPointAuthorizationRequirement[]
                {                    new global::Dataloop.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_CreateAnnotationTaskSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_CreateAnnotationTaskSecurityRequirement0,
            };
        partial void PrepareCreateAnnotationTaskArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Dataloop.TaskPayload request);
        partial void PrepareCreateAnnotationTaskRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Dataloop.TaskPayload request);
        partial void ProcessCreateAnnotationTaskResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateAnnotationTaskResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a new Task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create a new Task (Annotation or QA).<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner*, *developer*, or *annotation manager* who has been assigned to be *owner* of the annotation task.<br/>
        /// # <br/>
        /// # :param str task_name: the name of the task<br/>
        /// # :param float due_date: date by which the task should be finished; for example, due_date=datetime.datetime(day=1, month=1, year=2029).timestamp()<br/>
        /// # :param list assignee_ids: list the task assignees (contributors) that should be working on the task. Provide a list of users' emails<br/>
        /// # :param List[WorkloadUnit] List[WorkloadUnit] workload: list of WorkloadUnit objects. Customize distribution (percentage) between the task assignees. For example: [dl.WorkloadUnit(annotator@hi.com, 80), dl.WorkloadUnit(annotator2@hi.com, 20)]<br/>
        /// # :param entities.Dataset dataset: dataset object, the dataset that refer to the task<br/>
        /// # :param str task_owner: task owner. Provide user email<br/>
        /// # :param str task_type: task type "annotation" or "qa"<br/>
        /// # :param str task_parent_id: optional if type is qa - parent annotation task id<br/>
        /// # :param str project_id: the Id of the project where task will be created<br/>
        /// # :param str recipe_id: recipe id for the task<br/>
        /// # :param list assignments_ids: assignments ids to the task<br/>
        /// # :param dict metadata: metadata for the task<br/>
        /// # :param entities.Filters filters: dl.Filters entity to filter items for the task<br/>
        /// # :param List[entities.Item] items: list of items (item Id or objects) to insert to the task<br/>
        /// # :param dict DQL query: filter items for the task<br/>
        /// # :param list available_actions: list of available actions (statuses) that will be available for the task items; The default statuses are: "completed" and "discard"<br/>
        /// # :param bool wait: wait until create task finish<br/>
        /// # :param entities.Filters check_if_exist: dl.Filters check if task exist according to filter<br/>
        /// # :param int limit: the limit items that the task can include<br/>
        /// # :param int  batch_size: Pulling batch size (items), use with pulling allocation method. Restrictions - Min 3, max 100<br/>
        /// # :param int max_batch_workload: max_batch_workload: Max items in assignment, use with pulling allocation method. Restrictions - Min batchSize + 2, max batchSize * 2<br/>
        /// # :param list allowed_assignees: list the task assignees (contributors) that should be working on the task. Provide a list of users' emails<br/>
        /// # :param entities.TaskPriority priority: priority of the task options in entities.TaskPriority<br/>
        /// # :param entities.ConsensusTaskType consensus_task_type: consensus_task_type of the task options in entities.ConsensusTaskType<br/>
        /// # :param int consensus_percentage: percentage of items to be copied to multiple annotators (consensus items)<br/>
        /// # :param int consensus_assignees: the number of different annotators per item (number of copies per item)<br/>
        /// # :param bool scoring: create a scoring app in project. Note: Scoring is no longer applied by default for consensus tasks. Set scoring=True to enable it.<br/>
        /// # :param bool enforce_video_conversion: Enforce WEBM conversion on video items for frame-accurate annotations. WEBM Conversion will be executed as a project service and incurs compute costs. Service compute resources can be set according to planned workload.<br/>
        /// # :return: Task object<br/>
        /// # :rtype: dtlpy.entities.task.Task<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset.tasks.create(task= 'task_entity',<br/>
        /// # due_date = datetime.datetime(day= 1, month= 1, year= 2029).timestamp(),<br/>
        /// # assignee_ids =[ 'annotator1@dataloop.ai', 'annotator2@dataloop.ai'],<br/>
        /// # available_actions=[dl.ItemAction("discard"), dl.ItemAction("to-check")])<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>> CreateAnnotationTaskAsync(

            global::Dataloop.TaskPayload request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateAnnotationTaskArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateAnnotationTaskSecurityRequirements,
                operationName: "CreateAnnotationTaskAsync");

            using var __timeoutCancellationTokenSource = global::Dataloop.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Dataloop.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Dataloop.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Dataloop.PathBuilder(
                                path: "/annotationtasks",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Dataloop.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Dataloop.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateAnnotationTaskRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Dataloop.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Dataloop.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAnnotationTask",
                                methodName: "CreateAnnotationTaskAsync",
                                pathTemplate: "\"/annotationtasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Dataloop.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Dataloop.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAnnotationTask",
                                methodName: "CreateAnnotationTaskAsync",
                                pathTemplate: "\"/annotationtasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Dataloop.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Dataloop.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Dataloop.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Dataloop.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAnnotationTask",
                                methodName: "CreateAnnotationTaskAsync",
                                pathTemplate: "\"/annotationtasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Dataloop.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateAnnotationTaskResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Dataloop.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Dataloop.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAnnotationTask",
                                methodName: "CreateAnnotationTaskAsync",
                                pathTemplate: "\"/annotationtasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Dataloop.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Dataloop.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAnnotationTask",
                                methodName: "CreateAnnotationTaskAsync",
                                pathTemplate: "\"/annotationtasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateAnnotationTaskResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Create a new Task
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="recipeId"></param>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="taskOwner"></param>
        /// <param name="dueDate"></param>
        /// <param name="query"></param>
        /// <param name="status"></param>
        /// <param name="assignmentIds"></param>
        /// <param name="spec"></param>
        /// <param name="workload"></param>
        /// <param name="limit"></param>
        /// <param name="percentage"></param>
        /// <param name="asynced"></param>
        /// <param name="emptyTask"></param>
        /// <param name="checkIfExist"></param>
        /// <param name="availableActions"></param>
        /// <param name="disableWebm"></param>
        /// <param name="metadata"></param>
        /// <param name="priority"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>> CreateAnnotationTaskAsync(
            string datasetId,
            string recipeId,
            string projectId,
            string name,
            string taskOwner,
            string query,
            global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec> spec,
            double? dueDate = default,
            string? status = default,
            global::System.Collections.Generic.IList<string>? assignmentIds = default,
            global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? workload = default,
            double? limit = default,
            bool? percentage = default,
            bool? asynced = default,
            bool? emptyTask = default,
            global::Dataloop.TaskPayloadCheckIfExist? checkIfExist = default,
            global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? availableActions = default,
            bool? disableWebm = default,
            global::Dataloop.TaskMetadata? metadata = default,
            double? priority = default,
            global::Dataloop.PickDescriptionContent? description = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.TaskPayload
            {
                DatasetId = datasetId,
                RecipeId = recipeId,
                ProjectId = projectId,
                Name = name,
                TaskOwner = taskOwner,
                DueDate = dueDate,
                Query = query,
                Status = status,
                AssignmentIds = assignmentIds,
                Spec = spec,
                Workload = workload,
                Limit = limit,
                Percentage = percentage,
                Asynced = asynced,
                EmptyTask = emptyTask,
                CheckIfExist = checkIfExist,
                AvailableActions = availableActions,
                DisableWebm = disableWebm,
                Metadata = metadata,
                Priority = priority,
                Description = description,
            };

            return await CreateAnnotationTaskAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}