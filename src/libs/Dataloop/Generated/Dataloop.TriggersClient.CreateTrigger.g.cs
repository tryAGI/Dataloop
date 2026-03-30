
#nullable enable

namespace Dataloop
{
    public partial class TriggersClient
    {
        partial void PrepareCreateTriggerArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Dataloop.CreateTriggerRequest request);
        partial void PrepareCreateTriggerRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Dataloop.CreateTriggerRequest request);
        partial void ProcessCreateTriggerResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTriggerResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a Trigger. Can create two types: a cron trigger or an event trigger.<br/>
        /// Inputs are different for each type
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create a Trigger. Can create two types: a cron trigger or an event trigger.<br/>
        /// # Inputs are different for each type<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a service.<br/>
        /// # <br/>
        /// # Inputs for all types:<br/>
        /// # <br/>
        /// # :param str service_id: Id of services to be triggered<br/>
        /// # :param str trigger_type: can be cron or event. use enum dl.TriggerType for the full list<br/>
        /// # :param str name: name of the trigger<br/>
        /// # :param str webhook_id: id for webhook to be called<br/>
        /// # :param str  function_name: the function name to be called when triggered (must be defined in the package)<br/>
        /// # :param str  project_id: project id where trigger will work<br/>
        /// # :param bool active: optional - True/False, default = True, if true trigger is active<br/>
        /// # <br/>
        /// # Inputs for event trigger:<br/>
        /// # :param dtlpy.entities.filters.Filters filters: optional - Item/Annotation metadata filters, default = none<br/>
        /// # :param str resource: optional - Dataset/Item/Annotation/ItemStatus, default = Item<br/>
        /// # :param str actions: optional - Created/Updated/Deleted, default = create<br/>
        /// # :param str execution_mode: how many times trigger should be activated; default is "Once". enum dl.TriggerExecutionMode<br/>
        /// # <br/>
        /// # Inputs for cron trigger:<br/>
        /// # :param start_at: iso format date string to start activating the cron trigger<br/>
        /// # :param end_at: iso format date string to end the cron activation<br/>
        /// # :param inputs: dictionary "name":"val" of inputs to the function<br/>
        /// # :param str cron: cron spec specifying when it should run. more information: https://en.wikipedia.org/wiki/Cron<br/>
        /// # :param str pipeline_id: Id of pipeline to be triggered<br/>
        /// # :param pipeline: pipeline entity to be triggered<br/>
        /// # :param str pipeline_node_id: Id of pipeline root node to be triggered<br/>
        /// # :param root_node_namespace: namespace of pipeline root node to be triggered<br/>
        /// # <br/>
        /// # :return: Trigger entity<br/>
        /// # :rtype: dtlpy.entities.trigger.Trigger<br/>
        /// # <br/>
        /// # <br/>
        /// # service.triggers.create(name='triggername',<br/>
        /// # execution_mode=dl.TriggerExecutionMode.ONCE,<br/>
        /// # resource='Item',<br/>
        /// # actions='Created',<br/>
        /// # function_name='run',<br/>
        /// # filters={'$and': [{'hidden': False},<br/>
        /// # {'type': 'file'}]}<br/>
        /// # )<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APITrigger> CreateTriggerAsync(

            global::Dataloop.CreateTriggerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTriggerArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: "/triggers",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateTriggerRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateTriggerResponse(
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
                ProcessCreateTriggerResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.APITrigger.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dataloop.APITrigger.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create a Trigger. Can create two types: a cron trigger or an event trigger.<br/>
        /// Inputs are different for each type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="active"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APITrigger> CreateTriggerAsync(
            global::Dataloop.TriggerType type,
            string name,
            string projectId,
            bool active,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.CreateTriggerRequest
            {
                Type = type,
                Name = name,
                ProjectId = projectId,
                Active = active,
            };

            return await CreateTriggerAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}