
#nullable enable

namespace Dataloop
{
    public partial class AuditClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_GetAuditLogsCsvSecurityRequirement0 =
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
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_GetAuditLogsCsvSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_GetAuditLogsCsvSecurityRequirement0,
            };
        partial void PrepareGetAuditLogsCsvArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string orgId,
            ref global::System.DateTime fromDate,
            ref global::System.DateTime toDate,
            ref string? id,
            ref string? entityType,
            ref string? entityName,
            ref string? entityId,
            ref string? action,
            ref string? user,
            ref string? sortBy,
            ref string? descending);
        partial void PrepareGetAuditLogsCsvRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string orgId,
            global::System.DateTime fromDate,
            global::System.DateTime toDate,
            string? id,
            string? entityType,
            string? entityName,
            string? entityId,
            string? action,
            string? user,
            string? sortBy,
            string? descending);
        partial void ProcessGetAuditLogsCsvResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="id"></param>
        /// <param name="entityType"></param>
        /// <param name="entityName"></param>
        /// <param name="entityId"></param>
        /// <param name="action"></param>
        /// <param name="user"></param>
        /// <param name="sortBy"></param>
        /// <param name="descending"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        public async global::System.Threading.Tasks.Task GetAuditLogsCsvAsync(
            string orgId,
            global::System.DateTime fromDate,
            global::System.DateTime toDate,
            string? id = default,
            string? entityType = default,
            string? entityName = default,
            string? entityId = default,
            string? action = default,
            string? user = default,
            string? sortBy = default,
            string? descending = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAuditLogsCsvArguments(
                httpClient: HttpClient,
                orgId: ref orgId,
                fromDate: ref fromDate,
                toDate: ref toDate,
                id: ref id,
                entityType: ref entityType,
                entityName: ref entityName,
                entityId: ref entityId,
                action: ref action,
                user: ref user,
                sortBy: ref sortBy,
                descending: ref descending);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetAuditLogsCsvSecurityRequirements,
                operationName: "GetAuditLogsCsvAsync");

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: "/audit/logs/csv",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("orgId", orgId)
                .AddRequiredParameter("fromDate", fromDate.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddRequiredParameter("toDate", toDate.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("id", id)
                .AddOptionalParameter("entityType", entityType)
                .AddOptionalParameter("entityName", entityName)
                .AddOptionalParameter("entityId", entityId)
                .AddOptionalParameter("action", action)
                .AddOptionalParameter("user", user)
                .AddOptionalParameter("sortBy", sortBy)
                .AddOptionalParameter("descending", descending) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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
            PrepareGetAuditLogsCsvRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                orgId: orgId,
                fromDate: fromDate,
                toDate: toDate,
                id: id,
                entityType: entityType,
                entityName: entityName,
                entityId: entityId,
                action: action,
                user: user,
                sortBy: sortBy,
                descending: descending);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetAuditLogsCsvResponse(
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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