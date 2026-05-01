#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesTemplatesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> CreateAsync(

            global::Dataloop.APIPipelineTemplate2 request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <param name="creator"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="projectId"></param>
        /// <param name="orgId"></param>
        /// <param name="compositionId"></param>
        /// <param name="nodes"></param>
        /// <param name="connections"></param>
        /// <param name="description"></param>
        /// <param name="preview"></param>
        /// <param name="startNodes"></param>
        /// <param name="status"></param>
        /// <param name="settings"></param>
        /// <param name="variables"></param>
        /// <param name="resetTimestamp"></param>
        /// <param name="template"></param>
        /// <param name="templateKind"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> CreateAsync(
            string id,
            string url,
            string name,
            string creator,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string projectId,
            string orgId,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor> nodes,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection> connections,
            string description,
            string preview,
            global::Dataloop.CompositionStatus status,
            string? updatedBy = default,
            string? compositionId = default,
            global::System.Collections.Generic.IList<global::Dataloop.IStartNode>? startNodes = default,
            global::Dataloop.IPipelineSettings? settings = default,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>? variables = default,
            global::System.DateTime? resetTimestamp = default,
            global::Dataloop.APIPipelineTemplateTemplate? template = default,
            global::Dataloop.TemplateKind? templateKind = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}