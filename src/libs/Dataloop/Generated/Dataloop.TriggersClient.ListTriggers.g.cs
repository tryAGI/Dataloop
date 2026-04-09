
#nullable enable

namespace Dataloop
{
    public partial class TriggersClient
    {


        private static readonly global::Dataloop.EndPointSecurityRequirement s_ListTriggersSecurityRequirement0 =
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
        private static readonly global::Dataloop.EndPointSecurityRequirement[] s_ListTriggersSecurityRequirements =
            new global::Dataloop.EndPointSecurityRequirement[]
            {                s_ListTriggersSecurityRequirement0,
            };
        partial void PrepareListTriggersArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Dataloop.TriggerType? type,
            ref string? name,
            ref string? projectsQuery,
            ref string? resource,
            ref bool? active,
            ref string? executionMode,
            ref string? serviceId,
            ref string? webhookId,
            ref string? operationType,
            ref string? entity,
            ref string? action,
            ref double? pageOffset,
            ref double? pageSize);
        partial void PrepareListTriggersRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Dataloop.TriggerType? type,
            string? name,
            string? projectsQuery,
            string? resource,
            bool? active,
            string? executionMode,
            string? serviceId,
            string? webhookId,
            string? operationType,
            string? entity,
            string? action,
            double? pageOffset,
            double? pageSize);
        partial void ProcessListTriggersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListTriggersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieves services.<br/>
        /// Supply query parameters to filter the list.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="projectsQuery"></param>
        /// <param name="resource"></param>
        /// <param name="active"></param>
        /// <param name="executionMode"></param>
        /// <param name="serviceId"></param>
        /// <param name="webhookId"></param>
        /// <param name="operationType"></param>
        /// <param name="entity"></param>
        /// <param name="action"></param>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.TriggersPage> ListTriggersAsync(
            global::Dataloop.TriggerType? type = default,
            string? name = default,
            string? projectsQuery = default,
            string? resource = default,
            bool? active = default,
            string? executionMode = default,
            string? serviceId = default,
            string? webhookId = default,
            string? operationType = default,
            string? entity = default,
            string? action = default,
            double? pageOffset = default,
            double? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListTriggersArguments(
                httpClient: HttpClient,
                type: ref type,
                name: ref name,
                projectsQuery: ref projectsQuery,
                resource: ref resource,
                active: ref active,
                executionMode: ref executionMode,
                serviceId: ref serviceId,
                webhookId: ref webhookId,
                operationType: ref operationType,
                entity: ref entity,
                action: ref action,
                pageOffset: ref pageOffset,
                pageSize: ref pageSize);


            var __authorizations = global::Dataloop.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListTriggersSecurityRequirements,
                operationName: "ListTriggersAsync");

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: "/triggers",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("type", type?.ToValueString())
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("projectsQuery", projectsQuery)
                .AddOptionalParameter("resource", resource)
                .AddOptionalParameter("active", active?.ToString().ToLowerInvariant())
                .AddOptionalParameter("executionMode", executionMode)
                .AddOptionalParameter("serviceId", serviceId)
                .AddOptionalParameter("webhookId", webhookId)
                .AddOptionalParameter("operationType", operationType)
                .AddOptionalParameter("entity", entity)
                .AddOptionalParameter("action", action)
                .AddOptionalParameter("pageOffset", pageOffset?.ToString())
                .AddOptionalParameter("pageSize", pageSize?.ToString()) 
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
            PrepareListTriggersRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                type: type,
                name: name,
                projectsQuery: projectsQuery,
                resource: resource,
                active: active,
                executionMode: executionMode,
                serviceId: serviceId,
                webhookId: webhookId,
                operationType: operationType,
                entity: entity,
                action: action,
                pageOffset: pageOffset,
                pageSize: pageSize);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListTriggersResponse(
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
                ProcessListTriggersResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.TriggersPage.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dataloop.TriggersPage.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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