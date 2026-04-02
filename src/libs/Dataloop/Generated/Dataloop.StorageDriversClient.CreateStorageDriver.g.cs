
#nullable enable

namespace Dataloop
{
    public partial class StorageDriversClient
    {
        partial void PrepareCreateStorageDriverArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Dataloop.DriverPayload request);
        partial void PrepareCreateStorageDriverRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Dataloop.DriverPayload request);
        partial void ProcessCreateStorageDriverResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateStorageDriverResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a new storage driver
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create a driver on the platform using the provided payload.<br/>
        /// # <br/>
        /// # :param dict payload: The driver creation payload<br/>
        /// # :return: The created driver object<br/>
        /// # :rtype: dtlpy.entities.driver.Driver<br/>
        /// # :raises PlatformException: If the driver creation fails<br/>
        /// # 
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APIDriverConfiguration> CreateStorageDriverAsync(

            global::Dataloop.DriverPayload request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateStorageDriverArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Dataloop.PathBuilder(
                path: "/drivers",
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
            PrepareCreateStorageDriverRequest(
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
            ProcessCreateStorageDriverResponse(
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
                ProcessCreateStorageDriverResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dataloop.APIDriverConfiguration.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Dataloop.APIDriverConfiguration.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create a new storage driver
        /// </summary>
        /// <param name="type"></param>
        /// <param name="creator"></param>
        /// <param name="integrationId"></param>
        /// <param name="integrationConfig"></param>
        /// <param name="metadata"></param>
        /// <param name="name"></param>
        /// <param name="payload"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dataloop.APIDriverConfiguration> CreateStorageDriverAsync(
            global::Dataloop.DriverType type,
            string creator,
            global::Dataloop.DriverMetadata metadata,
            string name,
            global::Dataloop.AnyOf<global::Dataloop.S3DriverPayload, global::Dataloop.GcsDriverPayload, global::Dataloop.AzureBlobDriverPayload, global::Dataloop.PickFilesystemDriverConfigurationMountPath> payload,
            string? integrationId = default,
            global::Dataloop.AnyOf<global::Dataloop.S3IntegrationConfig, global::Dataloop.GcsIntegrationConfig, global::Dataloop.AzureBlobIntegrationConfig, global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath>? integrationConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dataloop.DriverPayload
            {
                Type = type,
                Creator = creator,
                IntegrationId = integrationId,
                IntegrationConfig = integrationConfig,
                Metadata = metadata,
                Name = name,
                Payload = payload,
            };

            return await CreateStorageDriverAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}