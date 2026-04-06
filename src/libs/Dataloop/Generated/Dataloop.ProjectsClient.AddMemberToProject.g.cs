
#nullable enable

namespace Dataloop
{
    public partial class ProjectsClient
    {
        partial void PrepareAddMemberToProjectArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string userId,
            ref bool? allowUpdate,
            global::Dataloop.AddMemberPayload request);
        partial void PrepareAddMemberToProjectRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string userId,
            bool? allowUpdate,
            global::Dataloop.AddMemberPayload request);
        partial void ProcessAddMemberToProjectResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAddMemberToProjectResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add a single member to a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="allowUpdate"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Add a member to the project.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* to add a member to a project.<br/>
        /// # <br/>
        /// # :param str email: member email<br/>
        /// # :param str project_id: The Id of the project<br/>
        /// # :param role: The required role for the user. Use the enum dl.MemberRole<br/>
        /// # :return: dict that represent the user<br/>
        /// # :rtype: dict<br/>
        /// # <br/>
        /// # <br/>
        /// # user_json = dl.projects.add_member(project_id='project_id', email='user@dataloop.ai', role=dl.MemberRole.DEVELOPER)<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>> AddMemberToProjectAsync(
            string projectId,
            string userId,

            global::Dataloop.AddMemberPayload request,
            bool? allowUpdate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAddMemberToProjectArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                userId: ref userId,
                allowUpdate: ref allowUpdate,
                request: request);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/projects/{projectId}/members/{userId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("allowUpdate", allowUpdate?.ToString().ToLowerInvariant()) 
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAddMemberToProjectRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                userId: userId,
                allowUpdate: allowUpdate,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAddMemberToProjectResponse(
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
                ProcessAddMemberToProjectResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Add a single member to a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="allowUpdate"></param>
        /// <param name="via"></param>
        /// <param name="denyMembersManagement"></param>
        /// <param name="canAddGroups"></param>
        /// <param name="skipWelcomeEmail"></param>
        /// <param name="skipResponse"></param>
        /// <param name="role"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>> AddMemberToProjectAsync(
            string projectId,
            string userId,
            global::Dataloop.Role role,
            bool? allowUpdate = default,
            string? via = default,
            bool? denyMembersManagement = default,
            bool? canAddGroups = default,
            bool? skipWelcomeEmail = default,
            bool? skipResponse = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.AddMemberPayload
            {
                Via = via,
                DenyMembersManagement = denyMembersManagement,
                CanAddGroups = canAddGroups,
                SkipWelcomeEmail = skipWelcomeEmail,
                SkipResponse = skipResponse,
                Role = role,
            };

            return await AddMemberToProjectAsync(
                projectId: projectId,
                userId: userId,
                allowUpdate: allowUpdate,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}