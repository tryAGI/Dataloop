
#nullable enable

namespace Dataloop
{
    public partial class AssignmentsClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_RedistributeAssignmentSecurityRequirement0 =
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
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_RedistributeAssignmentSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_RedistributeAssignmentSecurityRequirement0,
            };
        partial void PrepareRedistributeAssignmentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            global::Dataloop.RedistributeAssignmentPayload request);
        partial void PrepareRedistributeAssignmentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            global::Dataloop.RedistributeAssignmentPayload request);
        partial void ProcessRedistributeAssignmentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRedistributeAssignmentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Redistribute Assignment to annotators
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Redistribute an assignment.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner*, *developer*, or *annotation manager* who has been assigned as *owner* of the annotation task.<br/>
        /// # <br/>
        /// # <br/>
        /// # :param dtlpy.entities.assignment.Workload workload: list of WorkloadUnit objects. Customize distribution (percentage) between the task assignees. For example: [dl.WorkloadUnit(annotator@hi.com, 80), dl.WorkloadUnit(annotator2@hi.com, 20)]<br/>
        /// # :param dtlpy.entities.assignment.Assignment assignment: assignment object<br/>
        /// # :param str assignment_id: the Id of the assignment<br/>
        /// # :param dtlpy.entities.task.Task task: the task object that include the assignment<br/>
        /// # :param str task_id: the Id of the task that include the assignment<br/>
        /// # :param bool wait: wait until redistribute assignment finish<br/>
        /// # :return: Assignment object<br/>
        /// # :rtype: dtlpy.entities.assignment.Assignment assignment<br/>
        /// # <br/>
        /// # assignment = task.assignments.redistribute(workload=dl.Workload([dl.WorkloadUnit(assignee_id="annotator1@dataloop.ai", load=50),<br/>
        /// # dl.WorkloadUnit(assignee_id="annotator2@dataloop.ai", load=50)]))<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>> RedistributeAssignmentAsync(
            string id,

            global::Dataloop.RedistributeAssignmentPayload request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRedistributeAssignmentArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RedistributeAssignmentSecurityRequirements,
                operationName: "RedistributeAssignmentAsync");

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/assignments/{id}/redistribute",
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
            PrepareRedistributeAssignmentRequest(
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
            ProcessRedistributeAssignmentResponse(
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
                ProcessRedistributeAssignmentResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Redistribute Assignment to annotators
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workload"></param>
        /// <param name="selectNotAnnotatedOnly"></param>
        /// <param name="asynced"></param>
        /// <param name="isSudoCtx"></param>
        /// <param name="allowToSkipAssignments"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>> RedistributeAssignmentAsync(
            string id,
            global::System.Collections.Generic.IList<global::Dataloop.AssignmentWorkload> workload,
            bool? selectNotAnnotatedOnly = default,
            bool? asynced = default,
            bool? isSudoCtx = default,
            bool? allowToSkipAssignments = default,
            string? query = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.RedistributeAssignmentPayload
            {
                Workload = workload,
                SelectNotAnnotatedOnly = selectNotAnnotatedOnly,
                Asynced = asynced,
                IsSudoCtx = isSudoCtx,
                AllowToSkipAssignments = allowToSkipAssignments,
                Query = query,
            };

            return await RedistributeAssignmentAsync(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}