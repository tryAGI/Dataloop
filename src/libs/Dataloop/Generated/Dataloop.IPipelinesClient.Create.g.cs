#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Create a pipeline.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// pipeline = project.pipelines.create(name='pipeline_name')<br/>
        /// # <br/>
        /// # Create a new pipeline.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param str name: pipeline name<br/>
        /// # :param str project_id: project id<br/>
        /// # :param dict pipeline_json: json containing the pipeline fields<br/>
        /// # :return: Pipeline object<br/>
        /// # :rtype: dtlpy.entities.pipeline.Pipeline<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> CreateAsync(

            global::Dataloop.IPostPipeline request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a pipeline.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="startNodes"></param>
        /// <param name="spec"></param>
        /// <param name="compositionId"></param>
        /// <param name="description"></param>
        /// <param name="preview"></param>
        /// <param name="nodes"></param>
        /// <param name="connections"></param>
        /// <param name="secrets">
        /// Array of integrations ids - each one will be added to the service deployment as an environment variable
        /// </param>
        /// <param name="variables"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> CreateAsync(
            string name,
            string projectId,
            string description,
            string preview,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor> nodes,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection> connections,
            global::System.Collections.Generic.IList<string> secrets,
            global::System.Collections.Generic.IList<global::Dataloop.IStartNode>? startNodes = default,
            object? spec = default,
            string? compositionId = default,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>? variables = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}