
#nullable enable

namespace Dataloop
{
    public partial class OrganizationsClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_AddOrgMembersSecurityRequirement0 =
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
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_AddOrgMembersSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_AddOrgMembersSecurityRequirement0,
            };
        partial void PrepareAddOrgMembersArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string orgId,
            global::Dataloop.AddOrgMembersRequest request);
        partial void PrepareAddOrgMembersRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string orgId,
            global::Dataloop.AddOrgMembersRequest request);
        partial void ProcessAddOrgMembersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAddOrgMembersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add a new member to an organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Add members to your organization. Read about members and groups `here &lt;https://dataloop.ai/docs/org-members-groups&gt;`_.<br/>
        /// # <br/>
        /// # **Prerequisities**: To add members to an organization, you must be an *owner* in that organization.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: organization, organization_name, or organization_id.<br/>
        /// # <br/>
        /// # :param str email: the member's email<br/>
        /// # :param str role: MemberOrgRole.ADMIN, MemberOrgRole.OWNER, MemberOrgRole.MEMBER, MemberOrgRole.WORKER<br/>
        /// # :param str organization_id: Organization id<br/>
        /// # :param str organization_name: Organization name<br/>
        /// # :param entities.Organization organization: Organization object<br/>
        /// # :return: True if successful or error if unsuccessful<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # success = dl.organizations.add_member(email='user@domain.com',<br/>
        /// # organization_id='organization_id',<br/>
        /// # role=dl.MemberOrgRole.MEMBER)<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIOrgUser>> AddOrgMembersAsync(
            string orgId,

            global::Dataloop.AddOrgMembersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAddOrgMembersArguments(
                httpClient: HttpClient,
                orgId: ref orgId,
                request: request);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AddOrgMembersSecurityRequirements,
                operationName: "AddOrgMembersAsync");

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: $"/orgs/{orgId}/members",
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
            PrepareAddOrgMembersRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                orgId: orgId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAddOrgMembersResponse(
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
                ProcessAddOrgMembersResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        (global::System.Collections.Generic.IList<global::Dataloop.APIOrgUser>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Dataloop.APIOrgUser>), JsonSerializerContext) ??
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
                        (global::System.Collections.Generic.IList<global::Dataloop.APIOrgUser>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::Dataloop.APIOrgUser>), JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Add a new member to an organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="role"></param>
        /// <param name="emails"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIOrgUser>> AddOrgMembersAsync(
            string orgId,
            global::Dataloop.OrgRole role,
            global::System.Collections.Generic.IList<string> emails,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.AddOrgMembersRequest
            {
                Role = role,
                Emails = emails,
            };

            return await AddOrgMembersAsync(
                orgId: orgId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}